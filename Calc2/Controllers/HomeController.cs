using Calc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calc2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calcu(nums c, string Text)
        { 
            string[] items = Text.Split(' ');
            c.a = Convert.ToDouble(items[0]);
            c.b = Convert.ToDouble(items[2]);
            switch (items[1])
            {
                case "+":
                    c.result = c.a + c.b;
                    break;
                case "-":
                    c.result = c.a - c.b;
                    break;
                case "×":
                    c.result = c.a * c.b;
                    break;
                case "/":
                    c.result = c.a / c.b;
                    break;
                default:
                    c.result = 0;
                    break;
            }
            return View(c.result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Calcu(nums c)
        {
           
           
            return View(c);

        }
    }
}