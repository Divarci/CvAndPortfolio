﻿using CvAndPortfolio.Models.Entity;
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
        PortfolioAndCvEntities2 db = new PortfolioAndCvEntities2();
        public PartialViewResult TopMessages()
        {
            var values = repoMessages.Take(5).ToList();

            return PartialView(values);
        }

        GenericReporitory<TBLADMIN> repoAdmin = new GenericReporitory<TBLADMIN>();


        public ActionResult UserSettings()
        {
            var values = repoAdmin.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult UserEdit(byte id)
        {
            var values = repoAdmin.Find(x => x.ID == id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UserEdit(TBLADMIN p)
        {
            var values = repoAdmin.Find(x => x.ID == 1);
            values.USERNAME = p.USERNAME;
            values.PASSWORD = p.PASSWORD;
            repoAdmin.Update(values);
            return RedirectToAction("Index", "Admin");
        }

        GenericReporitory<TBLSOCIALMEDIA> repoSocialMedia = new GenericReporitory<TBLSOCIALMEDIA>();

        public PartialViewResult SocialMedia()
        {
            var values = repoSocialMedia.List();
            return PartialView(values);
        }
        [HttpGet]
        public ActionResult SocialMediaAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SocialMediaAdd(TBLSOCIALMEDIA p)
        {
            repoSocialMedia.Add(p);
            return RedirectToAction("UserSettings");
        }

        [HttpGet]
        public ActionResult SocialMediaUpdate(byte id)
        {
            var values = repoSocialMedia.Find(x=> x.ID == id);  
            return View(values);
        }
        [HttpPost]
        public ActionResult SocialMediaUpdate(TBLSOCIALMEDIA p)
        {
            var values = repoSocialMedia.Find(x => x.ID == p.ID);
            values.TITLE = p.TITLE;
            values.URL = p.URL;
            values.ACLASS = p.ACLASS;
            values.ICLASS = p.ICLASS;
            repoSocialMedia.Update(p);
            return RedirectToAction("UserSettings");
        }
        public ActionResult SocialMediaDelete(TBLSOCIALMEDIA p)
        {
            var values = repoSocialMedia.Find(x => x.ID == p.ID);
            repoSocialMedia.Delete(values);
            return RedirectToAction("UserSettings");
        }
    }
}