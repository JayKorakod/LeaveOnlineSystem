using LeaveSystemOnline.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemOnline.Services
{
    public class LeaveDataService
    {
        private LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();
        private LeaveDataRepo repo = new LeaveDataRepo();

        public void CreateLeaveData(LEAVEDATA model)
        {
            repo.Create(model);
        }
    }
}