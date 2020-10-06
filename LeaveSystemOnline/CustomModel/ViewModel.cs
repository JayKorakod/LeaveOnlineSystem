using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveSystemOnline.CustomModel
{
    public class ViewModel
    {
        public List<LEAVETYPE> Types { get; set; }
    }
}