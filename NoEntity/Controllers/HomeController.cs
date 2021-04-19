using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NoEntity.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;

namespace PsycologSite.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        
        public HomeController(ApplicationContext appContext)
        {
            db = appContext;
    
        }

        public IActionResult Main1()
        {
            return View();
        }

        public IActionResult Main2()
        {
            return View();
        }
        public IActionResult Main3()
        {
            return View();
        }
        public IActionResult Main4()
        {
            return View();
        }
        public IActionResult Main5()
        {
            return View();
        }
        public IActionResult Main6()
        {
            return View();
        }
        public IActionResult Main7()
        {
            return View();
        }
        public IActionResult Main8()
        {
            return View();
        }
        public IActionResult Main9()
        {
            return View();
        }
        public IActionResult Main10()
        {
            return View();
        }
        public IActionResult Main11()
        {
            return View();
        }
        public IActionResult Main12()
        {
            return View();
        }
        public IActionResult Main13()
        {
            /*  if (db != null)
            {
                foreach (Review item in db.Reviews)
                {
                    db.Reviews.Remove(item);                 
                }
                db.SaveChanges();
            }*/
            ViewBag.Reviews = db.Reviews;
            return View();
        }
        [HttpPost]
        public IActionResult Main13(Review review)
        {
            db.Reviews.Add(review);
            db.SaveChanges();
            return RedirectToAction("Main13");
        }
 


   
    }
}
