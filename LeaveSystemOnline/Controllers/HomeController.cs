using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeaveSystemOnline.Services;

namespace LeaveSystemOnline.Controllers
{
    public class HomeController : Controller
    {
        LEAVE_STSTEM_ONLINEEntities context = new LEAVE_STSTEM_ONLINEEntities();
        LeaveServices services = new LeaveServices();
        public ActionResult Index()
        {
            if (Session["name"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login Form";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(EMPLOYEE model)
        {
            if (ModelState.IsValid)
            {
                var employee = context.EMPLOYEE.Where(x => x.id.Equals(model.id) && x.password.Equals(model.password)).FirstOrDefault();
                if(employee  != null)
                {
                    Session["name"] = employee.firstName + " " + employee.lastName;
                    return RedirectToAction("Index");
                }
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            Session["name"] = null;
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}