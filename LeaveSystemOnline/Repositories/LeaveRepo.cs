using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemOnline.Repositories
{
    public class LeaveRepo
    {
        LEAVESYSTEM_DBEntities context = new LEAVESYSTEM_DBEntities();

        public void Save()
        {
            context.SaveChanges();
        }
        public IQueryable<EMPLOYEE> GetEmployeeAll()
        {
            return context.EMPLOYEE;
        }

        public void Create(EMPLOYEE model)
        {
            context.EMPLOYEE.Add(model);
        }
    }
}