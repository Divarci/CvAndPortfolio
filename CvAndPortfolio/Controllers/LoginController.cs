using CvAndPortfolio.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CvAndPortfolio.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(TBLADMIN p)
        {
            PortfolioAndCvEntities2 db = new PortfolioAndCvEntities2();
            var userinfo = db.TBLADMINs.FirstOrDefault(x => x.USERNAME == p.USERNAME && x.PASSWORD == p.PASSWORD);
            if (userinfo != null)
            {
                FormsAuthentication.SetAuthCookie(userinfo.USERNAME, false);
                Session["USERNAME"] = userinfo.USERNAME.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}