using CvAndPortfolio.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvAndPortfolio.Controllers
{
    public class HomeController : Controller
    {
        PortfolioAndCvEntities2 db = new PortfolioAndCvEntities2();
        public ActionResult Index()
        {
            var values = db.TBLABOUTs.ToList();
            return View(values);
        }

        public PartialViewResult Facts()
        {
            var values = db.TBLFACTDESCRIPTIONs.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartTwoFacts()
        {
            var values = db.TBLFACTs.ToList();
            return PartialView(values);
        }
    }
}