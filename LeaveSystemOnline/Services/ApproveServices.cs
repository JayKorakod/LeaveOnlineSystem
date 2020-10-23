using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeaveSystemOnline.Repositories;

namespace LeaveSystemOnline.Services
{
    public class ApproveServices
    {
        private LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();
        private ApproveRepo repo = new ApproveRepo();

        public void ApproveLeave(LEAVEDATA obj)
        {
            repo.Edit(obj);
            repo.Save();
        }
    }
}