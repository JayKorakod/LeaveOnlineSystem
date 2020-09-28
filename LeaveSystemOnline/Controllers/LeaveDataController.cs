using LeaveSystemOnline.Repositories;
using LeaveSystemOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystemOnline.Controllers
{
    public class LeaveDataController : Controller
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();
        LeaveDataService services = new LeaveDataService();
        LeaveDataRepo repo = new LeaveDataRepo();
        // GET: LeaveData
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateLeaveData(LEAVEDATA model)
        {
            services.CreateLeaveData(model);
            return View(model);
        }
    }
}