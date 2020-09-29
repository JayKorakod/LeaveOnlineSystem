using LeaveSystemOnline.Repositories;
using LeaveSystemOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(EMPLOYEE model)
        {
            ViewBag.ProvinceList = new SelectList(GetProvincesList(), "id", "NameInThai");
            services.CreateEmployee(model);
            return View(model);
        }

        public ActionResult ListEmployee()
        {
            var a = services.GetAllEmployee();
            return View(a);
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

        public List<Provinces> GetProvincesList()
        {
            List<Provinces> provinces = context.Provinces.ToList();
            return provinces;
        }

    }
}