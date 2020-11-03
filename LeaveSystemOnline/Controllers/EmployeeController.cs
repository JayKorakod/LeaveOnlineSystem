using LeaveSystemOnline.Repositories;
using LeaveSystemOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeaveSystemOnline.Models;

namespace LeaveSystemOnline.Controllers
{
    public class EmployeeController : Controller
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();
        LeaveServices services = new LeaveServices();
        LeaveRepo repo = new LeaveRepo();

        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateEmployee()
        {
            ViewBag.ProvinceList = new SelectList(GetProvinces(), "Id", "NameInThai");
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(EMPLOYEE model)
        {
            
                services.CreateEmployee(model);
                ViewBag.showAlert = true;
                ViewBag.alertMessage = "บันทึกข้อมูลสำเร็จ";
            return RedirectToAction("ListEmployee");
        }

        public ActionResult ListEmployee(string search)
        {
            //var listEmployee = services.GetAllEmployee();
            var searchEmployee = context.EMPLOYEE.Where(x => x.firstName.StartsWith(search) || search == null);
            return View(searchEmployee);
        }

        public ActionResult AddAuthorForEmployee(string search)
        {
            var searchEmployee = context.EMPLOYEE.Where(x => x.firstName.StartsWith(search) || search == null);
            return View(searchEmployee);
        }

        public ActionResult EditAuthorEmployee(int id)
        {
            ViewBag.AuthorList = new SelectList(GetAuthor(), "id", "tier");
            EMPLOYEE detail = repo.Detail(id);
            return View(detail);
        }

        [HttpPost]
        public ActionResult EditAuthorEmployee(EMPLOYEE model)
        {
            services.EditAuthor(model);
            return RedirectToAction("AddAuthorForEmployee");
        }

        public List<AUTHOR> GetAuthor()
        {
            List<AUTHOR> authors = context.AUTHOR.ToList();
            return authors;
        }

        public List<Provinces> GetProvinces()
        {
            List<Provinces> provinces = context.Provinces.ToList();
            return provinces;
        }

        [HttpGet]
        public ActionResult GetDistrictList(int provinceID)
        {
            List<Districts> selectList = context.Districts.Where(x => x.ProvinceId == provinceID).ToList();
            ViewBag.District = new SelectList(selectList, "Id", "NameInThai");
            return PartialView("DisplayDistrict");
        }

        public ActionResult GetSubDistrictList(int districtID)
        {
            List<Subdistricts> selectList = context.Subdistricts.Where(x => x.DistrictId == districtID).ToList();
            ViewBag.SubDistrict = new SelectList(selectList, "Id", "NameInThai");
            return PartialView("DisplaySubDistrict");
        }
    }
}