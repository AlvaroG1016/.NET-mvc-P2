using Microsoft.AspNetCore.Mvc;
using Punto2Quiz.Models;

namespace Punto2Quiz.Controllers
{
    public class VentasController : Controller
    {
        public IActionResult Resultados()
        {
            Persona p1 = new Persona();
            Calculo dsa = new Calculo();
            p1.ventas = Convert.ToInt32(Request.Form["ventas"]);
            p1.ubi = Request.Form["Ubicacion"].ToString();
            dsa.Data(p1);

            return View(p1);
        }
    }
}
