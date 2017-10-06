using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicios_Propuestos_2.Models;

namespace Ejercicios_Propuestos_2.Controllers
{
    public class FechaController : Controller
    {
        // GET: Fecha
        public ActionResult FechaIndex()
        {
            return View();
        }
        public ActionResult FechaCalcular()
        {
            Clsfecha objfecha = new Clsfecha();

            string ini = Request.Form["ini"];
            string fin = Request.Form["fin"];
            string tipo = Request.Form["tipo"];

            objfecha.ini = Convert.ToInt32(ini);
            objfecha.fin = Convert.ToInt32(fin);
            objfecha.tipo = tipo;
           

            return View("FechaCalcular",objfecha);
        }
    }
}