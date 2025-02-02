using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolio1.Models;

namespace AcunMedyaPortfolio1.Controllers
{
    public class FeatureController : Controller
    {
        DbDominicPortfolyoEntities2 db = new DbDominicPortfolyoEntities2();
        public ActionResult FeatureList()
        {
            var values = db.TblFeature.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateFeature(TblFeature p)
        {
            db.TblFeature.Add(p);
            db.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        public ActionResult DeleteFeature(int id)
        {
            var values = db.TblFeature.Find(id);
            db.TblFeature.Remove(values);
            db.SaveChanges();
            return RedirectToAction("FeatureList");
            //koda baktığımız da diğerleriyle aynı gözüküyoyor.

        }
    }
}