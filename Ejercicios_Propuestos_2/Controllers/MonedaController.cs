using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicios_Propuestos_2.Models;

namespace Ejercicios_Propuestos_2.Controllers
{
    public class MonedaController : Controller
    {
        // GET: Moneda
        public ActionResult MonedaIndex()
        {
            return View();
        }
        public ActionResult MonedaCalcular() {

            ClsMoneda objmoneda = new ClsMoneda();
            objmoneda.soles = Convert.ToDouble(Request.Form["soles"]);
            objmoneda.tipo = Request.Form["tipo"];
            if (objmoneda.tipo == "dolar")
            {
                objmoneda.cambio = objmoneda.soles * 0.31;
            }
            else if (objmoneda.tipo == "yen")
            {
                objmoneda.cambio = objmoneda.soles * 34.55;
            }
            else if (objmoneda.tipo == "euro")
            {
                objmoneda.cambio = objmoneda.soles * 0.26;
            }
            else
            {
                objmoneda.cambio = objmoneda.soles * 193.17;
            }
            return View("MonedaCalcular",objmoneda);
        }
    }
}