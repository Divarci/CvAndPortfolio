using CvAndPortfolio.Models.Entity;
using CvAndPortfolio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvAndPortfolio.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        GenericReporitory<TBLSKILL> repoSkill = new GenericReporitory<TBLSKILL>();

        public PartialViewResult Progress()
        {
            var values = repoSkill.List();
            return PartialView(values);
        }

        GenericReporitory<TBLMESSAGE> repoMessages = new GenericReporitory<TBLMESSAGE>();

        public PartialViewResult TopMessages()
        {
            var values = repoMessages.List();
            return PartialView(values);
        }

    }
}