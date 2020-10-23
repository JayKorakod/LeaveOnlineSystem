using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemOnline.Repositories
{
    public class LeaveDataRepo
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();

        public void Create(LEAVEDATA model)
        {
            model.leaveStatus_id = 3;

            context.LEAVEDATA.Add(model);
            context.SaveChanges();
        }
        public List<LEAVEDATA> List()
        {
            return context.LEAVEDATA.ToList();
        }
        public List<LEAVEDATA> GetDepart(string depart)
        {
            return context.LEAVEDATA.Where(x => x.EMPLOYEE.department == depart).ToList();
        }
        public List<LEAVEDATA> GetId(int id)
        {
            return context.LEAVEDATA.Where(x => x.EMPLOYEE.id == id).ToList();
        }
    }
}