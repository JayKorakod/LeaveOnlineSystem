using LeaveSystemOnline.CustomModel;
using LeaveSystemOnline.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemOnline.Services
{
    public class LeaveTypeServices
    {
        private LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();
        private LeaveTypeRepo repo = new LeaveTypeRepo();

        public void Insert(LEAVETYPE obj)
        {
            repo.Insert(obj);
        }
        public void Update(LEAVETYPE obj)
        {
            repo.Update(obj);
        }
    }
}