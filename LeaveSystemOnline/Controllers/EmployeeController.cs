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
        LEAVE_STSTEM_ONLINEEntities context = new LEAVE_STSTEM_ONLINEEntities();
        LeaveServices services = new LeaveServices();

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
            services.CreateEmployee(model);
            return View(model);
        }

        public ActionResult ListEmployee()
        {
            var a = services.GetAllEmployee();
            return View(a);
        }
    }
}