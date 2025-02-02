using AcunMedyaPortfolio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaPortfolio1.Controllers
{
    public class ServicesController : Controller
    {
        DbDominicPortfolyoEntities2 db = new DbDominicPortfolyoEntities2();
        public ActionResult ServicesList()
        {
            var values = db.TblServices.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateServices()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateServices(TblServices p)
        {
            db.TblServices.Add(p);
            db.SaveChanges();
            return RedirectToAction("ServicesList");
        }
        public ActionResult DeleteServices(int id)
        {
            var values = db.TblServices.Find(id);
            db.TblServices.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ServicesList");
            //burada yine gözükmüyor bir hata
        }
    }
}