using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolio1.Models;

namespace AcunMedyaPortfolio1.Controllers
{
    public class CategoryController : Controller
    {
        DbDominicPortfolyoEntities2 db =new DbDominicPortfolyoEntities2();
        // sınfıtan nesne türetmek lazım , bu nesne db adında bir nesne türetiyor , bu nesnenin özelliklerine ulaşmak laızm  bu özellikte tablo.

        public ActionResult CategoryList()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            
            return View();
        }
        [HttpPost]

        public ActionResult CreateCategory(TblCategory p)
        {
            db.TblCategory.Add(p);
            db.SaveChanges();
            return RedirectToAction("CategoryList");   
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = db.TblCategory.Find(id);
            db.TblCategory.Remove(values);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
       public ActionResult UpdateCategory(int id) // buradaki id RouteConfig den gelen id değiştirmek isteniliyosa route config e gidilip id kısmının ismini x vs yapmalısın
        {
            var value = db.TblCategory.Find(id);
            return View(value);

        }
        [HttpPost]  
        public ActionResult UpdateCategory(TblCategory p)  // güncellenmesi gerkeen kaç alan varsa yazılmalı
        {
            var value = db.TblCategory.Find(p.Categoryid);
            value.CategoryName = p.CategoryName; // kaç sütun varsa onalr yazılmalı bu tabloda sadece name var (id harici)
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}



//public string birlestir()
//{
//    string cumle1 = "selam";
//    string cumle2 = "ase";
//    string cumle3 = cumle1 + cumle2;
//    return cumle3;
//}

//[HttpGet] Sayfayı ilk açtığımızda listelemek için kullanılan metod
//[HttpPost] 
//[HttpDelete]
//[HttpPut]
//using AcunMedyaPortfolio1.Models; projelere başlarken using kısmına eklemeyi unutma



                          // CREATE İŞLEMİ YAPILABİLMESİ İÇİN AŞAĞIDAKİ TÜM KOMUTLARIN YAZILMASI LAZIM

//[HttpPost]

//public ActionResult CreateCategory(TblCategory p)
//{
//    db.TblCategory.Add(p);
//    db.SaveChanges();
//    return RedirectToAction("CategoryList");
//}