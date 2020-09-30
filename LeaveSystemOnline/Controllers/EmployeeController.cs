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
        LEAVE_STSTEM_ONLINEEntities2 context = new LEAVE_STSTEM_ONLINEEntities2();
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
            var iden = context.EMPLOYEE.Where(x => x.identificationNo == model.identificationNo).ToString();
            if(iden != model.identificationNo) 
            {
                services.CreateEmployee(model);
            }
            return View(model);
        }

        public ActionResult ListEmployee()
        {
            var listEmployee = services.GetAllEmployee();
            return View(listEmployee);
        }

        public ActionResult EditAuthorEmployee(int id)
        {
            EMPLOYEE detail = repo.Detail(id);
            return View(detail);
        }

        [HttpPost]
        public ActionResult EditAuthorEmployee(EMPLOYEE model)
        {
            services.EditAuthor(model);
            return View(model);
        }
        public List<Provinces> GetProvinces()
        {
            List<Provinces> provinces = context.Provinces.ToList();
            return provinces;
        }

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