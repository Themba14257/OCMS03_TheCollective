using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
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

namespace OCMS03.Controllers
{
    public class HospitalController : BaseController
    {
        private readonly OCMS03_TheCollectiveContext context;
        public HospitalController(OCMS03_TheCollectiveContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult SearchHospital()
        {
            return View(context.tblHospital
                  .Include(c => c.City)
                  .Include(c => c.Province)
                  .AsNoTracking());
        }
        [HttpGet]
        public IActionResult FindHospital()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(context.tblHospital
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
                return View(new Hospital());
            }
            else
            {
                PopulateProvinceDropDownList();
                PopulateCityDropDownList();
                var hospital = await context.tblHospital.FindAsync(id);
                if (hospital == null)
                {
                    return NotFound();
                }
                return View(hospital);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(string id, string HospitalName, [Bind("HospitalId,HospitalName,AddressLine1,AddressLine2,ProvinceId,CityId,PostalCode,Telephone,FaxNumber")] Hospital hospital)
        {
            if (ModelState.IsValid)
            {

                if (id == null)
                {
                    try
                    {
                        var item = context.tblHospital.Where(p => p.HospitalName.Equals(HospitalName)).FirstOrDefault();
                        if (item == null)
                        {
                            context.Add(hospital);
                            await context.SaveChangesAsync();
                            Notify(hospital.HospitalName + " hospital was added successfully");
                        }
                        else
                        {
                            Notify(item.HospitalName + " already existing in the database", notificationType: NotificationType.error);
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
                        PopulateProvinceDropDownList(hospital.ProvinceId);
                        PopulateCityDropDownList(hospital.CityId);
                        context.Update(hospital);
                        await context.SaveChangesAsync();
                        Notify(hospital.HospitalName + " hospital was updated successfully");
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ModelExists(hospital.HospitalId))
                        { return NotFound(); }
                        else
                        { throw; }
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hospital);
        }
        
        public async Task<IActionResult> Delete(string id)
        {
            var hospital = await context.tblHospital.FindAsync(id);
            try
            {
                if (id != null)
                {
                    PopulateProvinceDropDownList(hospital.ProvinceId);
                    PopulateCityDropDownList(hospital.CityId);
                    context.tblHospital.Remove(hospital);
                    await context.SaveChangesAsync();
                    Notify(hospital.HospitalName + " hospital was deleted permanently");
                }
            }
            catch (Exception)
            {
                Notify(hospital.HospitalName + " is in use could not be deleted!", notificationType: NotificationType.error);
            }
            return RedirectToAction(nameof(Index));
        }
        private bool ModelExists(string id)
        {
            return context.tblHospital.Any(e => e.HospitalId == id);
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

        ///-----------------Creating PDF for Hospital Table----------------------
        ///
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
            PdfPTable tableLayout = new PdfPTable(6);
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


            float[] headers = { 50, 50, 45, 45, 50, 50 };  //Header Widths
            tableLayout.SetWidths(headers);        //Set the pdf headers
            tableLayout.WidthPercentage = 100;       //Set the PDF File witdh percentage
            tableLayout.HeaderRows = 1;
            //Add Title to the PDF file at the top

            List<Hospital> appointments = context.tblHospital.Include(p => p.Province)
                .Include(p => p.City).ToList<Hospital>();



            tableLayout.AddCell(new PdfPCell(new Phrase("The Collective\nGomery 767 Rd\nSummerStrand\nPort Elizabeth\nEastern Cape\n\nTell: 0839133030\nEmail: OCM03@Collective.com", new Font(Font.HELVETICA, 12, 1, new iTextSharp.text.BaseColor(0, 0, 0)))) { Colspan = 12, Border = 0, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_LEFT });
            tableLayout.AddCell(new PdfPCell(new Phrase("Date: " + printedDate, new Font(Font.HELVETICA, 12, 1, new iTextSharp.text.BaseColor(0, 0, 0)))) { Colspan = 12, Border = 0, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_RIGHT });
            tableLayout.AddCell(new PdfPCell(new Phrase("Hospital Report", new Font(Font.HELVETICA, 16, 1, new iTextSharp.text.BaseColor(0, 0, 0)))) { Colspan = 12, Border = 0, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_CENTER });




            ////Add header

            AddCellToHeader(tableLayout, "Hospital Name");
            AddCellToHeader(tableLayout, "Adress Line 1");
            AddCellToHeader(tableLayout, "Province");
            AddCellToHeader(tableLayout, "City");
            AddCellToHeader(tableLayout, "Telephone");
            AddCellToHeader(tableLayout, "Fax Number");



            ////Add body

            foreach (var emp in appointments)
            {
                AddCellToBody(tableLayout, emp.HospitalName + "\n\n");
                AddCellToBody(tableLayout, emp.AddressLine1 + "\n\n");
                AddCellToBody(tableLayout, emp.Province.ProvinceName + "\n");
                AddCellToBody(tableLayout, emp.City.CityName + "\n\n");
                AddCellToBody(tableLayout, emp.Telephone + "\n\n");
                AddCellToBody(tableLayout, emp.FaxNumber + "\n\n");


            }

            return tableLayout;
        }

        // Method to add single cell to the Header
        private static void AddCellToHeader(PdfPTable tableLayout, string cellText)
        {

            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.HELVETICA, 12, 1, iTextSharp.text.BaseColor.Black))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 1, BackgroundColor = new iTextSharp.text.BaseColor(204, 204, 255) });
        }

        // Method to add single cell to the body
        private static void AddCellToBody(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, new Font(Font.HELVETICA, 12, 1, iTextSharp.text.BaseColor.Black))) { HorizontalAlignment = Element.ALIGN_LEFT, Padding = 1, BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255) });
        }

        ///------------------------Creating PDF ENDS HERE--------------------///
        ///

    }
}
