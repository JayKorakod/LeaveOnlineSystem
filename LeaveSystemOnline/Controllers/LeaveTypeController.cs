using LeaveSystemOnline.Repositories;
using LeaveSystemOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystemOnline.Controllers
{
    public class LeaveTypeController : Controller
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();
        LeaveTypeRepo repo = new LeaveTypeRepo();
        LeaveTypeServices service = new LeaveTypeServices();
        // GET: LeaveType
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            List<LEAVETYPE> list = new List<LEAVETYPE>();
            list = repo.List();
            return View(list);
        }
        [HttpPost]
        public ActionResult Insert(LEAVETYPE obj)
        {
            try
            {
                if(obj == null)
                {
                    ViewBag.showAlert = true;
                    ViewBag.alertMessage = "ไม่มีข้อมูล";
                }
                if(context.LEAVETYPE.ToList().Exists(x => x.type == obj.type))
                {
                    ViewBag.showAlert = true;
                    ViewBag.alertMessage = "มีข้อมูลอยู่แล้ว";
                }
                service.Insert(obj);
            }
            catch (Exception)
            {

                throw;
            }
            return View(obj);
        }
        [HttpPost]
        public ActionResult Update(LEAVETYPE obj)
        {
            service.Update(obj);
            return View(obj);
        }
    }
}