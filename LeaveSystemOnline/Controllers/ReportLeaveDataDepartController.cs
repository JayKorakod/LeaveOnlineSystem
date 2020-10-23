using LeaveSystemOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystemOnline.Controllers
{
    public class ReportLeaveDataDepartController : Controller
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();
        LeaveDataService service = new LeaveDataService();
        public ActionResult Index(string search)
        {
            List<LEAVEDATA> list = new List<LEAVEDATA>();
            if (search == null)
            {
                var depart = Session["depart"].ToString();
                list = service.GetDepart(depart);
            }
            else if(search =="")
            {
                var depart = Session["depart"].ToString();
                list = service.GetDepart(depart);
            }
            else
            {
                var depart = Session["depart"].ToString();
                list = context.LEAVEDATA.Where(x => x.EMPLOYEE.department.StartsWith(depart) && x.EMPLOYEE.firstName.StartsWith(search)).ToList();
            }
            return View(list);
        }
        public ActionResult History(string search)
        {
            if (search == null)
            {
                var id = int.Parse(Session["id"].ToString());
                var list = service.GetId(id);

                return View(list);
            }
            else if(search == "")
            {
                var id = int.Parse(Session["id"].ToString());
                var list = service.GetId(id);

                return View(list);
            }
            else
            {
                var idemp = int.Parse(Session["id"].ToString());
                var list = context.LEAVEDATA.Where(x => x.id.ToString() == search && x.EMPLOYEE.id == idemp || search == null).ToList();

                return View(list);
            }
        }
    }
}