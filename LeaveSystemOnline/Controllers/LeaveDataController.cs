using LeaveSystemOnline.CustomModel;
using LeaveSystemOnline.Repositories;
using LeaveSystemOnline.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace LeaveSystemOnline.Controllers
{
    public class LeaveDataController : Controller
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();
        LeaveDataService services = new LeaveDataService();
        LeaveDataRepo repo = new LeaveDataRepo();
        LeaveTypeServices serType = new LeaveTypeServices();
        LeaveTypeRepo _repo = new LeaveTypeRepo();
        // GET: LeaveData
        public ActionResult Index()
        {
            ViewBag.data = new SelectList(context.LEAVETYPE, "id", "type");
            return View();
        }

        [HttpPost]
        public ActionResult CreateLeaveData(LEAVEDATA model, HttpPostedFileBase file)
        {
            if(file != null && file.ContentLength > 0)
            {
                string fileName = Path.GetFileName(file.FileName);
                string path = Path.Combine(Server.MapPath("~/UploadFile"), fileName);
                file.SaveAs(path);
                model.fileDocument = file.FileName;
                services.CreateLeaveData(model);
            }
            else
            {
                services.CreateLeaveData(model);
            }
            return Json(new
            {
                msg = "Successfully added "
            });
        }
    }
}