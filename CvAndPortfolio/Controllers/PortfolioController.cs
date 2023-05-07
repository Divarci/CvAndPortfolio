using CvAndPortfolio.Models.Entity;
using CvAndPortfolio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows;

namespace CvAndPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        GenericReporitory<TBLPORTFOLIO> repoPort = new GenericReporitory<TBLPORTFOLIO>();

        [HttpGet]
        public ActionResult PortfolioUpdate()
        {
            var values = repoPort.List();
            return View(values);
        }
        [HttpPost]
        public ActionResult PortfolioUpdate(TBLPORTFOLIO tbl)
        {
            var values = repoPort.Find(x => x.ID == 1);
            values.DESCRIPTION = tbl.DESCRIPTION;
            repoPort.Update(values);
            return RedirectToAction("PortfolioUpdate");
        }

        GenericReporitory<TBLCATEGORY> repoCategory = new GenericReporitory<TBLCATEGORY>();

        public ActionResult Categories()
        {
            var values = repoCategory.List();
            return View(values);
        }
        [HttpGet]
        public ActionResult CategoryAdd()
        {
            return View();

        }
        [HttpPost]
        public ActionResult CategoryAdd(TBLCATEGORY tbl)
        {
            repoCategory.Add(tbl);
            return RedirectToAction("Categories");
        }
        [HttpGet]
        public ActionResult CategoryUpdate(byte id)
        {
            var values = repoCategory.Find(x => x.ID == id);
            return View(values);
        }
        [HttpPost]
        public ActionResult CategoryUpdate(TBLCATEGORY tbl)
        {
            var values = repoCategory.Find(x => x.ID == tbl.ID);
            values.CATEGORY = tbl.CATEGORY;
            values.TITLE = tbl.TITLE;
            repoCategory.Update(values);
            return RedirectToAction("Categories");

        }
        public ActionResult CategoryDelete(byte id)
        {
            var values = repoCategory.Find(x => x.ID == id);
            repoCategory.Delete(values);
            return RedirectToAction("categories");
        }



        GenericReporitory<TBLSTUDY> repoStudy = new GenericReporitory<TBLSTUDY>();

        public ActionResult Studies()
        {
            var values = repoStudy.List();
            return View(values);
        }
        [HttpGet]
        public ActionResult StudyAdd()
        {
            var values = repoCategory.List();
            return View(values);

        }
        [HttpPost]
        public ActionResult StudyAdd(TBLSTUDY tbl)
        {
            repoStudy.Add(tbl);
            return RedirectToAction("Studies");
        }
        [HttpGet]
        public ActionResult StudyUpdate(int id)
        {
            var values = repoStudy.Find(x => x.ID == id);
            return View(values);
        }
        [HttpPost]
        public ActionResult StudyUpdate(TBLSTUDY tbl)
        {
            var values = repoStudy.Find(x => x.ID == tbl.ID);
            values.CATEGORY = tbl.CATEGORY;
            values.TITLE = tbl.TITLE;
            values.DESCRIPTION = tbl.DESCRIPTION;
            values.PICTURL = tbl.PICTURL;
            repoStudy.Update(values);
            return RedirectToAction("Studies");

        }
        public ActionResult StudyDelete(int id)
        {
            var values = repoStudy.Find(x => x.ID == id);
            var valuespic = repoStudyPic.Find(x => x.STUDYID == id);
            if (valuespic == null)
            {
                repoStudy.Delete(values);
            }
                        
            return RedirectToAction("Studies");
        }

        public PartialViewResult CategoryDropDownDefault()
        {
            var values = repoCategory.List();
            return PartialView(values);
        }
        PortfolioAndCvEntities2 db2 = new PortfolioAndCvEntities2();
        GenericReporitory<TBLSTUDYPIC> repoStudyPic = new GenericReporitory<TBLSTUDYPIC>();
        public ActionResult StudyPictures(int id)
        {
            var values = db2.TBLSTUDYPICs.Where(x => x.STUDYID == id).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult StudyPicUpdate(byte id)
        {
            var values = repoStudyPic.Find(x => x.ID == id);
            return View(values);
        }
        [HttpPost]
        public ActionResult StudyPicUpdate(TBLSTUDYPIC tbl)
        {
            var values = repoStudyPic.Find(x => x.ID == tbl.ID);
            values.PICURL = tbl.PICURL;
            values.TITLE = tbl.TITLE;
            repoStudyPic.Update(values);
            return RedirectToAction("Studies");

        }


        [HttpGet]
        public ActionResult StudyPicAdd()
        {
            var values = repoStudy.List();
            return View(values);
        }
        [HttpPost]
        public ActionResult StudyPicAdd(TBLSTUDYPIC tbl)
        {
            repoStudyPic.Add(tbl);
            return RedirectToAction("Studies");
        }

        public ActionResult StudyPicDelete(int id)
        {
            var values = repoStudyPic.Find(x => x.ID == id);
            repoStudyPic.Delete(values);
            return RedirectToAction("Studies");
        }

    }

}