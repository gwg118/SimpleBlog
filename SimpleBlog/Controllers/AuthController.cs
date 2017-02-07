//Move data from a form to a controller

using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
        }




        //Get request go in to this method.
        public ActionResult Login()
        {
            return View(new AuthLogin
            { });
        }




        //Post request go into this method. 
        [HttpPost] //httpPost - attribute to go in to the Post method. 
        public ActionResult Login(AuthLogin form, string returnUrl)
        {

            if (!ModelState.IsValid)
                return View(form);

            FormsAuthentication.SetAuthCookie(form.Username, true);


            if (!string.IsNullOrWhiteSpace(returnUrl))
                return Redirect(returnUrl);

            //return Content("This is valid!");

            return RedirectToRoute("home");
        }

    }
}