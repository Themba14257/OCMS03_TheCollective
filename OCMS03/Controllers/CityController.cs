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
using static OCMS03.Infrastructure.Helper;

namespace OCMS03.Controllers
{
    public class CityController : BaseController
    {
        private readonly OCMS03_TheCollectiveContext context;

        public CityController(OCMS03_TheCollectiveContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.tblCity
                .Include(c => c.District)
                .AsNoTracking());
        }
        [NoDirectAccess]
        [HttpGet]
        public async Task<IActionResult> AddOrEdit(string id = null)
        {
            if (id == null)
            {
                PopulateDistrctDropDownList();
                return View(new City());
            }
            else
            {
                PopulateDistrctDropDownList();
                var cities = await context.tblCity.FindAsync(id);
                if (cities == null)
                {
                    return NotFound();
                }
                return View(cities);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(string id, string CityName, [Bind("CityId,CityName,DistrictId")] City cities)
        {
            if (ModelState.IsValid)
            {

                if (id == null)
                {
                    try
                    {
                        var item = context.tblCity.Where(p => p.CityName.Equals(CityName)).FirstOrDefault();
                        if (item == null)
                        {
                            context.Add(cities);
                            await context.SaveChangesAsync();
                            Notify(cities.CityName + " city was added successfully");
                        }
                        else
                        {
                            Notify(item.CityName + " already existing in the database", notificationType: NotificationType.error);
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
                        PopulateDistrctDropDownList(cities.DistrictId);
                        context.Update(cities);
                        await context.SaveChangesAsync();
                        Notify(cities.CityName + " city was updated successfully");
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ModelExists(cities.CityId))
                        {
                            return NotFound();
                        }
                        else
                        { throw; }
                    }
                }
                return RedirectToAction(nameof(Index), cities);
            }
            return View(cities);
        }
      
        public async Task<IActionResult> Delete(string id)
        {
            var cities = await context.tblCity.FindAsync(id);
            try
            {
                if (id != null)
                {
                    PopulateDistrctDropDownList(cities.DistrictId);
                    context.tblCity.Remove(cities);
                    Notify(cities.CityName + " city was deleted permanently");
                }
            }
            catch (Exception)
            {
                Notify(cities.CityName + " is in use could not be deleted!", notificationType: NotificationType.error);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ModelExists(string id)
        {
            return context.tblCity.Any(e => e.CityId == id);
        }

        private void PopulateDistrctDropDownList(object selectedDistrictId = null)
        {
            var CityQuery = from d in context.tblDistrict.Distinct().AsNoTracking()
                            orderby d.DistrictName
                            select d;
            ViewBag.DistrictId = new SelectList(CityQuery.AsNoTracking(), "DistrictId", "DistrictName",
            selectedDistrictId);
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