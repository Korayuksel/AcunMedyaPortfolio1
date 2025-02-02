﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolio1.Models;

namespace AcunMedyaPortfolio1.Controllers
{
    public class ProjectController : Controller
    {
        DbDominicPortfolyoEntities2 db = new DbDominicPortfolyoEntities2();
        public ActionResult ProjectList()
        {
            var values = db.TblProject.ToList();
            return View(values);
        }
        [HttpGet]
        // altta yazılan list select kısmı httpget kısmının altına yazılmalı
        public ActionResult CreateProject()
        {
            List<SelectListItem> values =(from x in db.TblCategory.ToList()
                                          select new SelectListItem
                                          {
                                              Text=x.CategoryName,
                                              Value=x.Categoryid.ToString()
                                          }).ToList();
            ViewBag.v=values;             
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(TblProject p)
        {
            db.TblProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }
        public ActionResult DeleteProject(int id)
        {
            var values = db.TblProject.Find(id);
            db.TblProject.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ProjectList");

        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            List<SelectListItem> values1 = (from x in db.TblCategory.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.Categoryid.ToString()
                                           }).ToList();
            ViewBag.v = values1;
            var value = db.TblProject.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProject(TblProject p)
        {
            var value = db.TblProject.Find(p.Projectid);
            value.Description = p.Description;
            value.ImageUrl = p.ImageUrl;
            value.Categoryid = p.Categoryid;
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }
    }
}