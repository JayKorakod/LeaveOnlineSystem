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
        public ActionResult ShowPieChart()
        {
            return View();
        }
        public ActionResult List(string search)
        {
            List<LEAVEDATA> list = new List<LEAVEDATA>();
            list = context.LEAVEDATA.Where(x => x.EMPLOYEE.department.StartsWith(search) || search == null).ToList();
            return View(list);
        }

        public ActionResult PieChart()
        {
            int engineer = context.LEAVEDATA.Where(x => x.EMPLOYEE.department == "วิศวกรรม").Count();
            int it = context.LEAVEDATA.Where(x => x.EMPLOYEE.department == "เทคโนโลยีสารสนเทศ").Count();
            int purchase = context.LEAVEDATA.Where(x => x.EMPLOYEE.department == "จัดซื้อ").Count();
            int warehouse = context.LEAVEDATA.Where(x => x.EMPLOYEE.department == "คลังสินค้า").Count();
            int hr = context.LEAVEDATA.Where(x => x.EMPLOYEE.department == "บุคคล").Count();
            int marketing = context.LEAVEDATA.Where(x => x.EMPLOYEE.department == "การตลาด").Count();
            int security = context.LEAVEDATA.Where(x => x.EMPLOYEE.department == "รักษาความปลอดภัย").Count();
            int production = context.LEAVEDATA.Where(x => x.EMPLOYEE.department == "ฝ่ายผลิต").Count();

            Ratio obj = new Ratio();
            obj.Engineer = engineer;
            obj.IT = it;
            obj.Purchase = purchase;
            obj.Warehouse = warehouse;
            obj.HR = hr;
            obj.Marketing = marketing;
            obj.Security = security;
            obj.Production = production;
            return Json(obj, JsonRequestBehavior.AllowGet);
        }


        public class Ratio
        {
            public int Engineer { get; set; }
            public int IT { get; set; }
            public int Purchase { get; set; }
            public int Warehouse { get; set; }
            public int HR { get; set; }
            public int Marketing { get; set; }
            public int Security { get; set; }
            public int Production { get; set; }
        }

    }
}