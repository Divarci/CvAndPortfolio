using CvAndPortfolio.Models.Entity;
using CvAndPortfolio.Repositories;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvAndPortfolio.Controllers
{
    public class ResumeController : Controller
    {
        GenericReporitory<TBLRESUME> repoResume = new GenericReporitory<TBLRESUME>();
       
        // GET: Resume
        [HttpGet]
        public ActionResult ResumeUpdate()
        {
            var values = repoResume.List();
            return View(values);
        }
        [HttpPost]
        public ActionResult ResumeUpdate(TBLRESUME tbl)
        {
            var values = repoResume.Find(x => x.ID == 1);
            values.DESCRIPTION = tbl.DESCRIPTION;
            repoResume.Update(values);
            return RedirectToAction("ResumeUpdate");
        }
               
        GenericReporitory<TBLEXPERIENCE> repoExp = new GenericReporitory<TBLEXPERIENCE>();

        public ActionResult Experiences()
        {
            var values = repoExp.List();
            return View(values);
        }
        [HttpGet]
        public ActionResult ExperienceAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ExperienceAdd(TBLEXPERIENCE tbl)
        {
            repoExp.Add(tbl);
            return RedirectToAction("Experiences");
        }

        [HttpGet]
        public ActionResult ExperienceUpdate(int id)
        {
            var values = repoExp.Find(x => x.ID == id);
            return View(values);
        }
        [HttpPost]
        public ActionResult ExperienceUpdate(TBLEXPERIENCE tbl)
        {
            var values = repoExp.Find(x => x.ID == tbl.ID);
            values.TITLE = tbl.TITLE;
            values.DATE = tbl.DATE;
            values.LOCATION = tbl.LOCATION;
            values.DESCRIPTION1 = tbl.DESCRIPTION1;
            values.DESCRIPTION2 = tbl.DESCRIPTION2;
            values.DESCRIPTION3 = tbl.DESCRIPTION3;
            values.DESCRIPTION4 = tbl.DESCRIPTION4;
            repoExp.Update(values);
            return RedirectToAction("Experiences");
        }

        public ActionResult ExperienceDelete(int id)
        {
            var values = repoExp.Find(x => x.ID == id);
            repoExp.Delete(values);
            return RedirectToAction("Experiences");
        }

        GenericReporitory<TBLEDUCATION> repoEdu = new GenericReporitory<TBLEDUCATION>();

        public ActionResult Educations()
        {
            var values = repoEdu.List();
            return View(values);
        }
        [HttpGet]
        public ActionResult EducationAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EducationAdd(TBLEDUCATION tbl)
        {
            repoEdu.Add(tbl);
            return RedirectToAction("Educations");
        }

        [HttpGet]
        public ActionResult EducationUpdate(int id)
        {
            var values = repoEdu.Find(x => x.ID == id);
            return View(values);
        }
        [HttpPost]
        public ActionResult EducationUpdate(TBLEDUCATION tbl)
        {
            var values = repoEdu.Find(x => x.ID == tbl.ID);
            values.TITLE = tbl.TITLE;
            values.DATE = tbl.DATE;
            values.SCHOOL = tbl.SCHOOL;
            values.DESCRIPTION = tbl.DESCRIPTION;
            repoEdu.Update(values);
            return RedirectToAction("Educations");
        }

        public ActionResult EducationDelete(int id)
        {
            var values = repoEdu.Find(x => x.ID == id);
            repoEdu.Delete(values);
            return RedirectToAction("Educations");
        }
        GenericReporitory<TBLCERTIFICATE> repoCer = new GenericReporitory<TBLCERTIFICATE>();

        public ActionResult Certificates()
        {
            var values = repoCer.List();
            return View(values);
        }
        [HttpGet]
        public ActionResult CertificateAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CertificateAdd(TBLCERTIFICATE tbl)
        {
            repoCer.Add(tbl);
            return RedirectToAction("Certificates");
        }

        [HttpGet]
        public ActionResult CertificateUpdate(int id)
        {
            var values = repoCer.Find(x => x.ID == id);
            return View(values);
        }
        [HttpPost]
        public ActionResult CertificatEUpdate(TBLCERTIFICATE tbl)
        {
            var values = repoCer.Find(x => x.ID == tbl.ID);
            values.TITLE = tbl.TITLE;
            values.DATE = tbl.DATE;
            values.LOCATION = tbl.LOCATION;
            values.DESCRIPTION = tbl.DESCRIPTION;
            repoCer.Update(values);
            return RedirectToAction("Certificates");
        }

        public ActionResult CertificateDelete(int id)
        {
            var values = repoCer.Find(x => x.ID == id);
            repoCer.Delete(values);
            return RedirectToAction("Certificates");
        }
    }
}