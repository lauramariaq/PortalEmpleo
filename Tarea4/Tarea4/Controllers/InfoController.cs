using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea4.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info
        public ActionResult About()
        {
            return View();
        }
    }
}