using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreciendoJuntos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Centro Creciendo Juntos";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contacto";

            return View();
        }

        public ActionResult Personal()
        {
            ViewBag.Message = "Personal";

            return View();
        }

        public ActionResult Mision()
        {
            ViewBag.Message = "Misión, Visión y Valores";

            return View();
        }

        public ActionResult Servicios()
        {
            ViewBag.Message = "Servicios";

            return View();
        }

        public ActionResult Instalaciones()
        {
            ViewBag.Message = "Instalaciones";

            return View();
        }

        public ActionResult Matricula()
        {
            ViewBag.Message = "Matrícula";

            return View();
        }
    }
}