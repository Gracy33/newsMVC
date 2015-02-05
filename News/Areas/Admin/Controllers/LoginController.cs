using News.DAL;
using News.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Admin/Login/
        [HttpGet]
        public ActionResult LoginForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginForm(string txtLogin, string txtPassword)
        {
            Utilisateur u = Utilisateur.AuthentifieMoi(txtLogin, txtPassword);
            if (u == null)
            {
                ViewBag.ErrorLogin = "Erreur Login/Password";
                return View();
            }
            else
            {
                SessionTools.Login = u.LoginUser;
                SessionTools.User = u;
                return RedirectToRoute(new { area="", controller = "Home", action = "Index" });                
            }
        }

        public RedirectToRouteResult LogOut()
        {
            SessionTools.Login = null;
            Session.Abandon();

            return RedirectToRoute(new { area = "", controller = "Home", action = "Index" });
        }
	}
}