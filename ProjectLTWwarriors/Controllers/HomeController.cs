using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectLTWwarriors.Data;

namespace ProjectLTWwarriors.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LandingPage()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult SignUp()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignIn()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ProductDetail(int id)
        {
            var product = ProductData.GetAllProducts().FirstOrDefault(p => p.Id == id);
            if (product == null)
                return HttpNotFound();

            return View(product);

            
        }
    }
}   