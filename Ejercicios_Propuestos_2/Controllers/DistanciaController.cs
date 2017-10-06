using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicios_Propuestos_2.Models;

namespace Ejercicios_Propuestos_2.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult DistanciaIndex()
        {
            return View();
        }
        public ActionResult DistanciaCalcular()
            
        {
            Clsdistancia objdis = new Clsdistancia();

            double dis = Convert.ToDouble(Request.Form["dist"]);

            double hora = Convert.ToDouble(Request.Form["hora"]);
            double min = Convert.ToDouble(Request.Form["minuto"]);
            double seg = Convert.ToDouble(Request.Form["segundo"]);

            double tiempo = (hora * 3600) + (min * 60) + seg;
            double mps = dis/  tiempo;
            double kph = (dis / 1000.0f) / (tiempo / 3600.0f);
            double mph = kph / 1.609f;

            objdis.dist = dis;
            objdis.tiemp =   hora + " H  -- " +min +" min  --" +seg +" seg";
            objdis.resultm = mps + " Metros por segundo" ;
            objdis.resultk = kph + " Kilometros por hora ";
            objdis.resultmi =  mph + " Millas por hora  ";

            return View("DistanciaCalcular", objdis);
        }
    }
}