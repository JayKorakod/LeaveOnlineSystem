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
        LEAVESYSTEM_DBEntities context = new LEAVESYSTEM_DBEntities();
        LeaveServices services = new LeaveServices();

        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
    }
}