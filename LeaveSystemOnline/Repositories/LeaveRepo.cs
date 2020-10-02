using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LeaveSystemOnline.Repositories
{
    public class LeaveRepo
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();

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

        public EMPLOYEE Detail(int id)
        {
            return context.EMPLOYEE.Find(id);
        }

        public void Edit(EMPLOYEE model)
        {
            context.Entry(model).State = EntityState.Modified;
        }
    }
}