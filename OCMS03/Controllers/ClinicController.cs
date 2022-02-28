using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OCMS03.Data;
using OCMS03.Infrastructure;
using OCMS03.Models;
using OCMS03.Models.Content;
using OCMS03.Models.ViewModels.ClinicViewModel;

namespace OCMS03.Controllers
{
    public class ClinicController : BaseController
    {
        private readonly OCMS03_TheCollectiveContext context;
        public ClinicController(OCMS03_TheCollectiveContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult SearchClinic()
        {
            return View(context.tblClinic
                .Include(c => c.City)
                .Include(c => c.Province)
                .AsNoTracking());
        }
        [HttpGet]
        public IActionResult FindClinic()
            => View(context.tblClinic
            .Include(c => c.Province)
            .Include(c => c.City));
        
            
       
        public IActionResult Index()
        {
            return View(context.tblClinic
                .Include(c => c.City)
                .Include(c => c.Province)
                .AsNoTracking());
        }
        [HttpGet]
        public async Task<IActionResult> AddOrEdit(string id = null)
        {
            if (id == null)
            {
                PopulateProvinceDropDownList();
                PopulateCityDropDownList();
                return View(new Clinic());
            }
            else
            {
                PopulateProvinceDropDownList();
                PopulateCityDropDownList();
                var clinic = await context.tblClinic.FindAsync(id);
                if (clinic == null)
                {
                    return NotFound();
                }
                return View(clinic);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(string id, string ClinicName, [Bind("ClinicId,ClinicName,AddressLine1,AddressLine2,ProvinceId,CityId,PostalCode,Telephone,FaxNumber")] Clinic clinic)
        {
            if (ModelState.IsValid)
            {

                if (id == null)
                {
                    try
                    {
                        var item = context.tblClinic.Where(p => p.ClinicName.Equals(ClinicName)).FirstOrDefault();
                        if (item == null)
                        {
                            context.Add(clinic);
                            await context.SaveChangesAsync();
                            Notify(clinic.ClinicName + " clinic was added successfully");
                        }
                        else
                        {
                            Notify(item.ClinicName + " already existing in the database", notificationType: NotificationType.error);
                            return View(item);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
                else
                {
                    try
                    {
                        PopulateProvinceDropDownList(clinic.ProvinceId);
                        PopulateCityDropDownList(clinic.CityId);
                        context.Update(clinic);
                        await context.SaveChangesAsync();
                        Notify(clinic.ClinicName + " clinic was updated successfully");
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ModelExists(clinic.ClinicId))
                        { return NotFound(); }
                        else
                        { throw; }
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(clinic);
        }
      
        public async Task<IActionResult> Delete(string id)
        {
            var clinic = await context.tblClinic.FindAsync(id);
            try
            {
                if (id != null)
                {
                    PopulateProvinceDropDownList(clinic.ProvinceId);
                    PopulateCityDropDownList(clinic.CityId);
                    context.tblClinic.Remove(clinic);
                    await context.SaveChangesAsync();
                    Notify(clinic.ClinicName + " clinic was deleted permanently");
                }
            }
            catch (Exception)
            {
                Notify(clinic.ClinicName + " is in use could not be deleted!", notificationType: NotificationType.error);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ModelExists(string id)
        {
            return context.tblClinic.Any(e => e.ClinicId == id);
        }

        private void PopulateProvinceDropDownList(object selectedProvince = null)
        {
            var provinceQuery = from d in context.tblProvince
                                orderby d.ProvinceName
                                select d;
            ViewBag.ProvinceId = new SelectList(provinceQuery.AsNoTracking(), "ProvinceId", "ProvinceName",
            selectedProvince);
        }
        private void PopulateCityDropDownList(object selectedCity = null)
        {
            var CityQuery = from d in context.tblCity
                            orderby d.CityName
                            select d;
            ViewBag.CityId = new SelectList(CityQuery.AsNoTracking(), "CityId", "CityName",
            selectedCity);
        }

        //----------------------Print PDF District--------------------------
        public FileResult CreatePdf()
        {
            MemoryStream workStream = new MemoryStream();
            StringBuilder status = new StringBuilder("");
            DateTime dTime = DateTime.Now;
            //file name to be created 
            string strPDFFileName = string.Format("SamplePdf" + dTime.ToString("yyyyMMdd") + "-" + ".pdf");
            Document doc = new Document();
            doc.SetMargins(0f, 0f, 0f, 0f);
            //Create PDF Table with 5 columns
            PdfPTable tableLayout = new PdfPTable(2);
            doc.SetMargins(0f, 0f, 0f, 0f);
            //Create PDF Table

            //file will created in this path
            //string strAttachment = Report.Load(HttpContext.Current.Server.MapPath("GraduationCertificate.rpt"));


            PdfWriter.GetInstance(doc, workStream).CloseStream = false;
            doc.Open();

            //Add Content to PDF 
            doc.Add(Add_Content_To_PDF(tableLayout));

            // Closing the document
            doc.Close();

            byte[] byteInfo = workStream.ToArray();
            workStream.Write(byteInfo, 0, byteInfo.Length);
            workStream.Position = 0;


            return File(workStream, "application/pdf", strPDFFileName);

        }
        protected PdfPTable Add_Content_To_PDF(PdfPTable tableLayout)
        {
            TimeSpan duration = new TimeSpan(30, 0, 0, 0);
            DateTime printedDate = DateTime.Now.Add(duration);

            float[] headers = { 35, 24 };  //Header Widths
            tableLayout.SetWidths(headers);        //Set the pdf headers
            tableLayout.WidthPercentage = 100;       //Set the PDF File witdh percentage
            tableLayout.HeaderRows = 1;
            //Add Title to the PDF file at the top

            List<City> appointments = context.tblCity.Include(p => p.District).ToList<City>();


            tableLayout.AddCell(new PdfPCell(new Phrase("The Collective\nGomery 767 Rd\nSummerStrand\nPort Elizabeth\nEastern Cape\n\nTell: 0839133030\nEmail: OCM03@Collective.com", new Font(Font.HELVETICA, 12, 1, new iTextSharp.text.BaseColor(0, 0, 0)))) { Colspan = 12, Border = 0, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_LEFT });
            tableLayout.AddCell(new PdfPCell(new Phrase("Date: " + printedDate, new Font(Font.HELVETICA, 12, 1, new iTextSharp.text.BaseColor(0, 0, 0)))) { Colspan = 12, Border = 0, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_RIGHT });
            tableLayout.AddCell(new PdfPCell(new Phrase("City Report", new Font(Font.HELVETICA, 16, 1, new iTextSharp.text.BaseColor(0, 0, 0)))) { Colspan = 12, Border = 0, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_CENTER });


            ////Add header

            AddCellToHeader(tableLayout, "District");
            AddCellToHeader(tableLayout, "Province");



            ////Add body

            foreach (var emp in appointments)
            {

                AddCellToBody(tableLayout, emp.CityName + "\n\n");
                AddCellToBody(tableLayout, emp.District.DistrictName + "\n\n");


            }

            return tableLayout;
        }

        // Method to add single cell to the Header
        private static void AddCellToHeader(PdfPTable tableLayout, string cellText)
        {

            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.HELVETICA, 12, 1, iTextSharp.text.BaseColor.Black))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new iTextSharp.text.BaseColor(204, 204, 255) });
        }

        // Method to add single cell to the body
        private static void AddCellToBody(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.HELVETICA, 12, 1, iTextSharp.text.BaseColor.Black))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 5, BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255) });
        }




    }
}
