using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ExtraController : Controller
    {
        // GET: Extra
        public ActionResult Serials()
        {
            var serials = SerialFaсtory.CreateSerials();
            return View(serials);
        }

        public ActionResult Biography()
        {
            return View();
        }
    }
}