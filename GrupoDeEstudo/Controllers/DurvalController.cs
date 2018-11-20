using GrupoDeEstudo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace GrupoDeEstudo.Controllers
{
    public class DurvalController : Controller
    {     
      

        // GET: Durval
        public ActionResult Index()
        {
            DurvalInicial init = new DurvalInicial()
            {
                Nome = "Durval Ferreira Pinto Marques",
                Cidade = "Itaúna",
                Estado = "MG",
                Telefone = int.Parse("99591849"),
        };

            return View(init);

        }
    }
}