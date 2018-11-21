using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GrupoDeEstudo.Models;

namespace GrupoDeEstudo.Controllers
{
    public class BrenoController : Controller
    {
        public Breno breno = new Breno();

        // GET: Breno
        public ActionResult Index()
        {
            breno.nome = "Breno Lorran Nicacio";
            breno.email = "breno@hotmail.com";

            //return View(breno.getbreno());
            return View(breno);
        }
    }
}