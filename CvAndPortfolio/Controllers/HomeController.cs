using CvAndPortfolio.Models.Entity;
using CvAndPortfolio.Repositories;
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

        public PartialViewResult Skills()
        {
            var values = db.TBLSKILLs.ToList();
            return PartialView(values);
        }
        public PartialViewResult Resume()
        {
            var values = db.TBLRESUMEs.ToList();
            return PartialView(values);
        }
        public PartialViewResult Certificate()
        {
            var values = db.TBLCERTIFICATEs.ToList();
            return PartialView(values);
        }
        public PartialViewResult Education()
        {
            var values = db.TBLEDUCATIONs.ToList();
            return PartialView(values);
        }
        public PartialViewResult Experience()
        {
            var values = db.TBLEXPERIENCEs.ToList();
            return PartialView(values);
        }
        public PartialViewResult Portfolio()
        {
            var values = db.TBLPORTFOLIOs.ToList();
            return PartialView(values);
        }

        public PartialViewResult PortfolioCategory()
        {
            var values = db.TBLCATEGORies.ToList();
            return PartialView(values);
        }
        public PartialViewResult PortfolioStudy()
        {
            var values = db.TBLSTUDies.ToList();
            return PartialView(values);
        }

        public PartialViewResult StudyPics(TBLSTUDY p)
        {
            var values = db.TBLSTUDYPICs.Where(x => x.STUDYID == p.ID).ToList();
            return PartialView(values);
        }

        public PartialViewResult Contact()
        {
            var values = db.TBLCONTACTs.ToList();
            return PartialView(values);
        }
        
        public PartialViewResult LayoutPartial()
        {
            var values = db.TBLSOCIALMEDIAs.ToList();
            return PartialView(values);
        }
        public PartialViewResult LayoutPartialProfile()
        {
            var values = db.TBLABOUTs.ToList();
            return PartialView(values);
        }

        public ActionResult PortDet(TBLSTUDY p)
        {
            var values = db.TBLSTUDies.Where(x=>x.ID == p.ID).ToList();
            return View(values);
        }
    }
}