using GrupoDeEstudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrupoDeEstudo.Controllers
{
    public class FranciscoController : Controller
    {
        FranciscoRepository repository = null;

        // GET: Francsisco
        public ActionResult Index()
        {
            repository = new FranciscoRepository();
            repository.LoadFrancisco();
            
            return View(repository.GetFrancisco());
        }
    }
}