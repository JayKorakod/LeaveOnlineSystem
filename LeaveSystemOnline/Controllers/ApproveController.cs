using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LeaveSystemOnline.Repositories;
using LeaveSystemOnline.Services;

namespace LeaveSystemOnline.Controllers
{
    public class ApproveController : Controller
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();
        ApproveRepo repo = new ApproveRepo();
        ApproveServices service = new ApproveServices();
        // GET: Approve
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult List()
        {
            List<LEAVEDATA> list = new List<LEAVEDATA>();
            list = repo.List();
            return View(list);
        }

        public ActionResult ApproveLeave(int id)
        {
            LEAVEDATA detail = repo.Detail(id);
            return View(detail);
        }

        [HttpPost]
        public ActionResult ApproveLeave(LEAVEDATA obj)
        {
            service.ApproveLeave(obj);
            return RedirectToAction("List");
        }
    }
}