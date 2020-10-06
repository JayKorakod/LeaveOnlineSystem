using LeaveSystemOnline.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemOnline.Services
{
    public class LeaveStatusServices
    {
        LeaveStatusRepo repo = new LeaveStatusRepo();
        LEAVE_STSTEM_ONLINEEntities2 context = new LEAVE_STSTEM_ONLINEEntities2();

        public List<LEAVEDATA> checkStatus()
        {
            repo.GetLeaveData();
            return context.LEAVEDATA.ToList();
        }
    }
}