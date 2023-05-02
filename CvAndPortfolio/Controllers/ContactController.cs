using CvAndPortfolio.Models.Entity;
using CvAndPortfolio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CvAndPortfolio.Controllers
{
    public class ContactController : Controller
    {
        GenericReporitory<TBLCONTACT> repoContact = new GenericReporitory<TBLCONTACT>();
        // GET: Contact
        [HttpGet]
        public ActionResult ContactUpdate()
        {
            var values = repoContact.List();
            return View(values);
        }

        [HttpPost]
        public ActionResult ContactUpdate(TBLCONTACT tbl)
        {
            var values = repoContact.Find(x => x.ID == 1);
            values.MAPCOOR = tbl.MAPCOOR;
            values.DESCRIPTION = tbl.DESCRIPTION;
            repoContact.Update(values);
            return RedirectToAction("ContactUpdate");
        }

        GenericReporitory<TBLMESSAGE> repoMessage = new GenericReporitory<TBLMESSAGE>();

        public ActionResult Messages()
        {
            var values = repoMessage.List();
            return View(values);
        }

        [HttpGet]
        public ActionResult MessageUpdate(int id)
        {
            var values = repoMessage.Find(x => x.ID == id);
            return View(values);
        }

        [HttpPost]
        public ActionResult MessageUpdate(TBLMESSAGE tbl)
        {
            var values = repoMessage.Find(x=>x.ID == tbl.ID);
            values.NAME = tbl.NAME;
            values.SUBJECT = tbl.SUBJECT;
            values.EMAIL = tbl.EMAIL;   
            values.MESSAGE = tbl.MESSAGE;
            repoMessage.Update(values);
            return RedirectToAction("Messages");
        }

        public ActionResult MessageDelete(int id)
        {
            var values = repoMessage.Find(x => x.ID == id);
            repoMessage.Delete(values);
            return RedirectToAction("Messages");
        }
    }
}