using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolio1.Models;

namespace AcunMedyaPortfolio1.Controllers
{
    public class DefaultController : Controller
    {
        DbDominicPortfolyoEntities2 db = new DbDominicPortfolyoEntities2();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavBarPartial()
        {
            return PartialView();         //static olduğu için values yapmadık
        }
        public PartialViewResult FeaturePartial()
        { 
            var values = db.TblFeature.ToList();
            return PartialView(values); // burası dinamik sql den veri çekicek bu yüzden listeleme vs yapmalısın
        }
        public PartialViewResult AboutPartial() //okey
        {
            var values = db.TblAbout.ToList();
            return PartialView(values); 
        }
        public PartialViewResult ServicesPartial() // okey
        {
            var values = db.TblServices.ToList();
            return PartialView(values);
        }
        public PartialViewResult TestimonialPartial() // okey
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult ProjectPartial() // tamamlandı
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult ContactPartial() // yarım kaldı
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }
        public PartialViewResult FooterPartial()  // footer da basıldığında yeni sayfa açılıyo sayfa içinde hareket etmiyor...
        {
            return PartialView();
        }
        public PartialViewResult JsPartial() // tamamlandı
        {
            return PartialView();
        }
    }
}