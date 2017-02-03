//Move data from a form to a controller

using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        //Get request go in to this method.
        public ActionResult Login()
        {
            return View(new AuthLogin
            { });
        }


        //Post request go into this method. 
        [HttpPost] //httpPost - attribute to go in to the Post method. 
        public ActionResult Login(AuthLogin form)
        {

            if (!ModelState.IsValid)
                return View(form);

            if (form.Username != "rainbow dash")
            {
                ModelState.AddModelError("Username", "Username or password isn't 20% cooler.");
                return View(form);
            }

            return Content("The form is valid!");
        }

    }
}