using LeaveSystemOnline.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveSystemOnline.Services
{
    public class AuthorServices
    {
        AuthorRepo repo = new AuthorRepo();
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();

        public List<AUTHOR> GetAuthor()
        {
            repo.GetAuthor();
            return context.AUTHOR.ToList();
        }
    }
}