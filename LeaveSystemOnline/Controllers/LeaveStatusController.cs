using LeaveSystemOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace LeaveSystemOnline.Controllers
{
    public class LeaveStatusController : Controller
    {
        LEAVE_STSTEM_ONLINEEntities2 context = new LEAVE_STSTEM_ONLINEEntities2();
        LeaveStatusServices service = new LeaveStatusServices();
        // GET: LeaveStatus
        public ActionResult checkStatus(int? search)
        {
            var searchStatus = context.LEAVEDATA.Where(x => x.id.ToString().Contains(search.ToString())).ToList();
            return View(searchStatus);
        } 
    }
}