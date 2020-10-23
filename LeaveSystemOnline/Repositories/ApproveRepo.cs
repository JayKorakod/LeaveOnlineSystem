using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LeaveSystemOnline.Repositories
{
    public class ApproveRepo
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();

        public IEnumerable<LEAVEDATA> GetAll()
        {
            var result = context.LEAVEDATA.AsNoTracking();
            return result;
        }

        public List<LEAVEDATA> List()
        {
            List<LEAVEDATA> data = new List<LEAVEDATA>();
            try
            {
                data = context.LEAVEDATA.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return data;
        }

        public LEAVEDATA Detail(int id)
        {
            return context.LEAVEDATA.Find(id);
        }

        public void Edit(LEAVEDATA model)
        {
            context.Entry(model).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}