using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using AlphaMobileShop.Models;

namespace AlphaMobileShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public ActionResult Product()
        {

            return View(db.Products.ToList());
        }

        public ActionResult Faq()
        {

            return View();
        }
    }
}