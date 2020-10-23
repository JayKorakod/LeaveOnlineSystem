using LeaveSystemOnline.Repositories;
using LeaveSystemOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystemOnline.Controllers
{
    public class ReportLeaveDataController : Controller
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();
        LeaveDataService services = new LeaveDataService();
        LeaveDataRepo repo = new LeaveDataRepo();
        // GET: ReprotLeaveData
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult List(string search)
        {
            List<LEAVEDATA> list = new List<LEAVEDATA>();
            list = context.LEAVEDATA.Where(x => x.EMPLOYEE.department.StartsWith(search) || search == null).ToList();
            return View(list);
        }
    }
}