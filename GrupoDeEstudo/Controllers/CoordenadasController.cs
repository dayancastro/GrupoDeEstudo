using GrupoDeEstudo.Models;
using System.Web.Mvc;

namespace GrupoDeEstudo.Controllers
{
    public class CoordenadasController : Controller
    {
        // GET: Coordenadas
        public ActionResult Index()
        {
            CoordenadasCliente coord = new CoordenadasCliente()
            {
                Latitude = 13,
                Longitude = 22,
            };
            
            return View(coord);
        }
    }
}