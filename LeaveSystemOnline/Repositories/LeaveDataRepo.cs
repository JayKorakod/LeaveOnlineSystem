using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemOnline.Repositories
{
    public class LeaveDataRepo
    {
        LEAVE_STSTEM_ONLINEEntities2 context = new LEAVE_STSTEM_ONLINEEntities2();

        public void Create(LEAVEDATA model)
        {
            context.LEAVEDATA.Add(model);
            context.SaveChanges();
        }
    }
}