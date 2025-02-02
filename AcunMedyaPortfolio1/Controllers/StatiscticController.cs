using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolio1.Models;

public class StatiscticController : Controller
{
    DbDominicPortfolyoEntities2 db = new DbDominicPortfolyoEntities2();
    public ActionResult Index()
    {
        ViewBag.categorysayisi = db.TblCategory.Count();
        ViewBag.projesayisi = db.TblProject.Count();
        return View();
    }
}