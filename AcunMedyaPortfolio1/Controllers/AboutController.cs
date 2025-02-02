using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolio1.Models;

namespace AcunMedyaPortfolio1.Controllers
{
    public class AboutController : Controller
    {
        DbDominicPortfolyoEntities2 db = new DbDominicPortfolyoEntities2();
        public ActionResult AboutList()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbout(TblAbout p)
        {
            db.TblAbout.Add(p);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public ActionResult DeleteAbout(int id)
        {
            var values = db.TblAbout.Find(id);
            db.TblAbout.Remove(values);
            db.SaveChanges();
            return RedirectToAction("AboutList");
            //silme işleminde yine bir sıkıntı gözükmüyor
        }
    }
}