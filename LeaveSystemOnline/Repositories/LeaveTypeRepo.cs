using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystemOnline.Repositories
{
    public class LeaveTypeRepo
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();

        public IEnumerable<LEAVETYPE> GetAll()
        {
            var result = context.LEAVETYPE.AsNoTracking();
            return result;
        }
        public List<LEAVETYPE> List()
        {
            List<LEAVETYPE> type = new List<LEAVETYPE>();
            try
            {
                type = context.LEAVETYPE.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return type;
        }
        public void Insert(LEAVETYPE obj)
        {
            context.LEAVETYPE.Add(obj);
            context.SaveChanges();
        }
        public void Update(LEAVETYPE obj)
        {
            var objUp = new LEAVETYPE();

            objUp = context.LEAVETYPE.First(x => x.id == obj.id);

            objUp.type = obj.type;
            objUp.numOfLeave = obj.numOfLeave;
            objUp.description = obj.description;

            context.SaveChanges();
        }
    }
}