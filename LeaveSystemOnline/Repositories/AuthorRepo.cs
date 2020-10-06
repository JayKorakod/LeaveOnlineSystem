using LeaveSystemOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemOnline.Repositories
{
    public class AuthorRepo
    {
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();

        public IQueryable<AUTHOR> GetAuthor ()
        {
            return context.AUTHOR;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public AUTHOR Detail(int id)
        {
            return context.AUTHOR.Find(id);
        }

    }
}