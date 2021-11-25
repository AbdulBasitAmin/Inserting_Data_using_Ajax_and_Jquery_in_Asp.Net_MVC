using Inserting_Data_using_Ajax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inserting_Data_using_Ajax.Controllers
{
    public class HomeController : Controller
    {
        ajax_testingEntities db = new ajax_testingEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(tbl_questions q)
        {
            db.tbl_questions.Add(q);
            db.SaveChanges();




            return View(q);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}