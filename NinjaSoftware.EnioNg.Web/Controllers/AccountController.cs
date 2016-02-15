using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.EnioNg.Web.Helpers;
using NinjaSoftware.EnioNg.Web.Models.Account;

namespace NinjaSoftware.EnioNg.Web.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                MembershipProvider membershipProvider = new MembershipProvider();
                if (membershipProvider.ValidateUser(model.UserName, model.Password))
                {
                    System.Web.Security.FormsAuthentication.RedirectFromLoginPage(model.UserName, false);
                    if (string.IsNullOrWhiteSpace(returnUrl))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        return Redirect(returnUrl);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Neispravno korisničko ime ili lozinka.");
                }
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult LogOff()
        {
            System.Web.Security.FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Account");
        }
    }
}
