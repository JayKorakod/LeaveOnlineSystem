using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystemOnline.Repositories
{
    public class LeaveTypeRepo
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();

        public IEnumerable<LEAVETYPE> GetAll()
        {
            var result = context.LEAVETYPE.AsNoTracking();
            return result;
        }
    }
}