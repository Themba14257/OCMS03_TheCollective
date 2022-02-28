using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OCMS03.Data;
using OCMS03.Models;
using OCMS03.Models.Content;
using OCMS03.Models.ViewModels;
using OCMS03.Models.ViewModels.AssignSpecialistViewModel;
using OCMS03.Models.ViewModels.DoctorViewModel;
using System.Threading.Tasks;

namespace OCMS03.Controllers
{
    [Authorize(Roles = "Receptionist, Admin")]
    public class UsersController : BaseController
    {
        private RoleManager<ApplicationRole> roleManager;
        private UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly OCMS03_TheCollectiveContext context;
        private readonly IWebHostEnvironment hostEnvironment;

        public UsersController(RoleManager<ApplicationRole> roleMgr, UserManager<ApplicationUser> userMrg, SignInManager<ApplicationUser> signInManager, OCMS03_TheCollectiveContext context, IWebHostEnvironment hostEnvironment)
        {
            roleManager = roleMgr;
            userManager = userMrg;
            this.signInManager = signInManager;
            this.context = context;
            this.hostEnvironment = hostEnvironment;
        }
        public ViewResult Index()
           => View(userManager.Users);


        public async Task<IActionResult> AllDoctors()
        {
            List<ViewModelUserRole> doctors = new List<ViewModelUserRole>();
            var drs = await userManager.GetUsersInRoleAsync("Doctor");
            foreach (var dr in drs)
            {
                doctors.Add(new ViewModelUserRole
                {
                    Title = dr.Title,
                    FirstName = dr.FirstName,
                    LastName = dr.LastName,
                    Email = dr.Email,
                    PhoneNumber = dr.PhoneNumber,
                    AddressLine1 = dr.AddressLine1,
                    AddressLine2 = dr.AddressLine2,
                    ImagePath = dr.ImagePath
                });
            }
            return View(doctors);
        }
        public async Task<IActionResult> AllNurses()
        {
            List<ViewModelUserRole> nurses = new List<ViewModelUserRole>();
            var nurse = await userManager.GetUsersInRoleAsync("Nurse");
            foreach (var nrs in nurse)
            {
                nurses.Add(new ViewModelUserRole
                {
                    Title = nrs.Title,
                    FirstName = nrs.FirstName,
                    LastName = nrs.LastName,
                    Email = nrs.Email,
                    PhoneNumber = nrs.PhoneNumber,
                    AddressLine1 = nrs.AddressLine1,
                    AddressLine2 = nrs.AddressLine2,
                    ImagePath = nrs.ImagePath
                });
            }
            return View(nurses);
        }
        public async Task<IActionResult> AllPharmacists()
        {
            List<ViewModelUserRole> pharmacists = new List<ViewModelUserRole>();
            var pharmacist = await userManager.GetUsersInRoleAsync("Pharmacist");
            foreach (var phr in pharmacist)
            {
                pharmacists.Add(new ViewModelUserRole
                {
                    Title = phr.Title,
                    FirstName = phr.FirstName,
                    LastName = phr.LastName,
                    Email = phr.Email,
                    PhoneNumber = phr.PhoneNumber,
                    AddressLine1 = phr.AddressLine1,
                    AddressLine2 = phr.AddressLine2,
                    ImagePath = phr.ImagePath
                });
            }
            return View(pharmacists);
        }
        public async Task<IActionResult> AllPatients()
        {
            List<ViewModelUserRole> patients = new List<ViewModelUserRole>();
            var patient = await userManager.GetUsersInRoleAsync("Patient");
            foreach (var dr in patient)
            {
                patients.Add(new ViewModelUserRole
                {
                    Title = dr.Title,
                    FirstName = dr.FirstName,
                    LastName = dr.LastName,
                    Email = dr.Email,
                    PhoneNumber = dr.PhoneNumber,
                    AddressLine1 = dr.AddressLine1,
                    AddressLine2 = dr.AddressLine2,
                    ImagePath = dr.ImagePath
                });
            }
            return View(patients);
        }
     
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                Notify("User can't be deleted most activities depends on", notificationType: NotificationType.error);
                return View(nameof(Index));
            }
            else
            {
                var result = await userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Index));
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("Index");
            }

        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            PopulateCityDropDownList();
            PopulateProvinceDropDownList();
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                Notify("User Not Found", notificationType: NotificationType.error);
                return View("Index");
            }

            // GetClaimsAsync retunrs the list of user Claims
            var userClaims = await userManager.GetClaimsAsync(user);
            // GetRolesAsync returns the list of user Roles
            var userRoles = await userManager.GetRolesAsync(user);

            var model = new EditUserViewModel
            {

                Race = user.Race,
                Dob = user.Dob,
                Email = user.Email,
                Title = user.Title,
                Gender = user.Gender,
                CityId = user.CityId,
                Idnumber = user.Idnumber,
                LastName = user.LastName,
                Username = user.UserName,
                ClinicId = user.ClinicId,
                FirstName = user.FirstName,
                HospitalId = user.HospitalId,
                Occupation = user.Occupation,
                NextOfName = user.NextOfName,
                PostalCode = user.PostalCode,
                ProvinceId = user.ProvinceId,
                PhoneNumber = user.PhoneNumber,
                Nationality = user.Nationality,
                Citizenship = user.Citizenship,
                Relationship = user.Relationship,
                DepartmentId = user.DepartmentId,
                AddressLine1 = user.AddressLine1,
                AddressLine2 = user.AddressLine2,
                Specialization = user.Specialization,
                NextOfKinNumber = user.NextOfKinNumber,
                NextOfKinSurname = user.NextOfKinSurname,
            };

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            string uniqueFileName = UploadedFile(model);
            PopulateCityDropDownList();
            PopulateProvinceDropDownList();
            var user = await userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                user.Dob = model.Dob;
                user.Race = model.Race;
                user.Title = model.Title;
                user.Gender = model.Gender;
                user.CityId = model.CityId;
                user.Idnumber = model.Idnumber;
                user.ClinicId = model.ClinicId;
                user.LastName = model.LastName;
                user.ImagePath = uniqueFileName;
                user.FirstName = model.FirstName;
                user.ProvinceId = model.ProvinceId;
                user.PostalCode = model.PostalCode;
                user.NextOfName = model.NextOfName;
                user.Occupation = model.Occupation;
                user.HospitalId = model.HospitalId;
                user.Nationality = model.Nationality;
                user.Citizenship = model.Citizenship;
                user.AddressLine1 = model.AddressLine1;
                user.AddressLine2 = model.AddressLine2;
                user.Relationship = model.Relationship;
                user.DepartmentId = model.DepartmentId;
                user.Specialization = model.Specialization;
                user.NextOfKinNumber = model.NextOfKinNumber;
                user.NextOfKinSurname = model.NextOfKinSurname;

                PopulateCityDropDownList(model.CityId);
                PopulateProvinceDropDownList(model.ProvinceId);

                await userManager.UpdateAsync(user);

                //await signInManager.RefreshSignInAsync(user);
                Notify("Your profile was updated successfully");
               

                var result = await userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(UsersController.Index), "Users");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }
           
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
        private string UploadedFile(EditUserViewModel model)
        {
            string uniqueFileName = null;

            if (model.ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(hostEnvironment.WebRootPath, "profileImage");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProfileImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
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
            PdfPTable tableLayout = new PdfPTable(4);
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

            float[] headers = { 50, 50, 25, 55 };  //Header Widths
            tableLayout.SetWidths(headers);        //Set the pdf headers
            tableLayout.WidthPercentage = 100;       //Set the PDF File witdh percentage
            tableLayout.HeaderRows = 1;
            //Add Title to the PDF file at the top

            List<ApplicationUser> applicationUsers = context.tblApplicationUser.ToList<ApplicationUser>();


            tableLayout.AddCell(new PdfPCell(new Phrase("The Collective\nGomery 767 Rd\nSummerStrand\nPort Elizabeth\nEastern Cape\n\nTell: 0839133030\nEmail: OCM03@Collective.com", new Font(Font.HELVETICA, 12, 1, new iTextSharp.text.BaseColor(0, 0, 0)))) { Colspan = 12, Border = 0, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_LEFT });
            tableLayout.AddCell(new PdfPCell(new Phrase("Date: " + printedDate, new Font(Font.HELVETICA, 12, 1, new iTextSharp.text.BaseColor(0, 0, 0)))) { Colspan = 12, Border = 0, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_RIGHT });
            tableLayout.AddCell(new PdfPCell(new Phrase("List of Employees Report", new Font(Font.HELVETICA, 16, 1, new iTextSharp.text.BaseColor(0, 0, 0)))) { Colspan = 12, Border = 0, PaddingBottom = 5, HorizontalAlignment = Element.ALIGN_CENTER });


            ////Add header

            AddCellToHeader(tableLayout, "Full Name");
            AddCellToHeader(tableLayout, "Address");
            AddCellToHeader(tableLayout, "Phone");
            AddCellToHeader(tableLayout, "Email");



            ////Add body

            foreach (var emp in applicationUsers)
            {

                AddCellToBody(tableLayout, emp.FullName + "\n\n");
                AddCellToBody(tableLayout, emp.AddressLine1 + "\n\n");
                AddCellToBody(tableLayout, emp.PhoneNumber + "\n\n");
                AddCellToBody(tableLayout, emp.Email + "\n\n");


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
