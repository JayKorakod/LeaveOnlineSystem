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
            List<LEAVETYPE> list = new List<LEAVETYPE>();
            list = repo.List();
            return View(list);
        }
        [HttpGet]
        public ActionResult List()
        {
            List<LEAVETYPE> list = new List<LEAVETYPE>();
            list = repo.List();
            return View(list);
        }
        [HttpPost]
        public ActionResult Insert(LEAVETYPE model)
        {
            try
            {
                if (model == null)
                {
                    ViewBag.showAlert = true;
                    ViewBag.alertMessage = "ไม่มีข้อมูล";
                }
                if (context.LEAVETYPE.ToList().Exists(x => x.type == model.type))
                {
                    ViewBag.showAlert = true;
                    ViewBag.alertMessage = "มีข้อมูลอยู่แล้ว";
                }
                service.Insert(model);
            }
            catch (Exception)
            {

                throw;
            }
            return Json(new
            {
                msg = "Successfully added " + model.type
            });
        }
        [HttpPost]
        public ActionResult Update(LEAVETYPE obj)
        {
            service.Update(obj);
            return Json(new
            {
                msg = "Successfully update " + obj.type
            });
        }

    }
}