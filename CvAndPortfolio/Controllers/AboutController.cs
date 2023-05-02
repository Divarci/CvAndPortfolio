using CvAndPortfolio.Models.Entity;
using CvAndPortfolio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvAndPortfolio.Controllers
{
    public class AboutController : Controller
    {
        GenericReporitory<TBLABOUT> repoAbout = new GenericReporitory<TBLABOUT>();

        // GET: About

        public ActionResult AboutMe()
        {
            var values = repoAbout.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult AboutUpdate(byte id)
        {
            var values = repoAbout.Find(x => x.ID == id);
            return View(values);
        }

        [HttpPost]
        public ActionResult AboutUpdate(TBLABOUT tbl)
        {
            var values = repoAbout.Find(x => x.ID == tbl.ID);
            values.NAMESURNAME = tbl.NAMESURNAME;
            values.ADDRESS = tbl.ADDRESS;
            values.TITLE = tbl.TITLE;
            values.SUBTITLE = tbl.SUBTITLE;
            values.DEGREE = tbl.DEGREE;
            values.MOBILE = tbl.MOBILE;
            values.AGE = tbl.AGE;
            values.EMAIL = tbl.EMAIL;
            values.RELOCATION = tbl.RELOCATION;
            values.PICURL = tbl.PICURL;
            values.DESCRIPTION = tbl.DESCRIPTION;
            values.SUBDESCRIPTION = tbl.SUBDESCRIPTION;
            repoAbout.Update(values);
            return RedirectToAction("AboutUpdate");
        }

        GenericReporitory<TBLFACT> repoFact = new GenericReporitory<TBLFACT>();

        public ActionResult Facts()
        {
            var values = repoFact.List();
            return View(values);
        }
        [HttpGet]
        public ActionResult FactAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FactAdd(TBLFACT tbl)
        {
            repoFact.Add(tbl);
            return RedirectToAction("Facts");
        }

        public ActionResult FactDelete(byte id)
        {
            var values = repoFact.Find(x => x.ID == id);
            repoFact.Delete(values);
            return RedirectToAction("Facts");
        }
        [HttpGet]
        public ActionResult FactUpdate(byte id)
        {
            var values = repoFact.Find(x => x.ID == id);
            return View(values);
        }
        [HttpPost]
        public ActionResult FactUpdate(TBLFACT tbl)
        {
            var values = repoFact.Find(x => x.ID == tbl.ID);
            values.TITLE = tbl.TITLE;
            values.VALUE = tbl.VALUE;
            repoFact.Update(values);
            return RedirectToAction("Facts");

        }

        GenericReporitory<TBLSKILL> repoSkill = new GenericReporitory<TBLSKILL>();

        public ActionResult Skills()
        {
            var values = repoSkill.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult SkillAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SkillAdd(TBLSKILL tbl)
        {
            repoSkill.Add(tbl);
            return RedirectToAction("Skills");
        }

        [HttpGet]
        public ActionResult SkillUpdate(byte id)
        {
            var values = repoSkill.Find(x => x.ID == id);
            return View(values);
        }
        [HttpPost]
        public ActionResult SkillUpdate(TBLSKILL tbl)
        {
            var values = repoSkill.Find(x => x.ID == tbl.ID);
            values.TITLE = tbl.TITLE;
            values.VALUE = tbl.VALUE;
            values.LEFTORRIGHT = tbl.LEFTORRIGHT;
            repoSkill.Update(values);
            return RedirectToAction("Skills");
        }
        public ActionResult SkillDelete(byte id)
        {
            var values = repoSkill.Find(x => x.ID == id);
            repoSkill.Delete(values);
            return RedirectToAction("Skills");
        }

    }
}