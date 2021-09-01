using Calc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calc2.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new nums());
        }
        [HttpPost]
        public ActionResult Index(nums c, string calculate)
        {
            if (calculate == "add")
            {
                c.result = c.a + c.b;
            }
           else if (calculate == "min")
            {
                c.result = c.a - c.b;
            }
           else if (calculate == "sub")
            {
                c.result = c.a * c.b;
            }
           else if (calculate == "divv")
            {
                c.result = c.a / c.b;
            }
            else
            {
                c.result = 0.0;
            }
            return View(c);
        }
    }
}