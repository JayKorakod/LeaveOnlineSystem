using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemOnline.Repositories
{
    public class LeaveStatusRepo
    {
        LEAVE_STSTEM_ONLINEEntities2 context = new LEAVE_STSTEM_ONLINEEntities2();

        public IQueryable<LEAVEDATA> GetLeaveData()
        {
            return context.LEAVEDATA;
        }
    }
}