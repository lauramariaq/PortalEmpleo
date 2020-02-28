using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tarea4.Models;

namespace Tarea4.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Formulario()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Resultados(Datos datos, HttpPostedFileBase pic, HttpPostedFileBase curriculum)
        {

            if (ModelState.IsValid)
            {
                string nombreFoto = pic.FileName;
                pic.SaveAs(Server.MapPath("/image/ " + nombreFoto));
                ViewBag.picture = nombreFoto;

                string nombreCurriculum = curriculum.FileName;
                curriculum.SaveAs(Server.MapPath("/pdf/" + nombreCurriculum));
                ViewBag.curriculum = nombreCurriculum;
                return View(datos);

            }


            else
            {
                return View("Formulario");
            }
        }
    }
}