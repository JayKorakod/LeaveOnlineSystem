using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemOnline.Repositories
{
    public class LeaveDataRepo
    {
        LEAVE_STSTEM_ONLINEEntities context = new LEAVE_STSTEM_ONLINEEntities();

        public void Create(LEAVEDATA model)
        {
            context.LEAVEDATA.Add(model);
        }
    }
}