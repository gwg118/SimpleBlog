using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Account
{
    public class Login
    {
        public ActionResult Index()
        {
            //return View();
            return Content("ADMIN POSTS!");
        }

        private ActionResult Content(string v)
        {
            throw new NotImplementedException();
        }
    }
}