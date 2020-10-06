using LeaveSystemOnline.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystemOnline.Controllers
{
    public class AuthorController : Controller
    {
        AuthorServices services = new AuthorServices();
        LEAVE_STSTEM_ONLINEEntities1 context = new LEAVE_STSTEM_ONLINEEntities1();
        // GET: Author
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListAuthor()
        {
            var listAuthor = services.GetAuthor();
            return View(listAuthor);
        }
    }
}