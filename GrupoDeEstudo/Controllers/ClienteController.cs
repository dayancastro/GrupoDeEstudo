using GrupoDeEstudo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GrupoDeEstudo.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            IList<Cliente> clientes = new List<Cliente>();
            var cliente = new Cliente();
            cliente.Nome = "Daniel Yanagita";

            List<Produto> produtos = new List<Produto>();

            Produto p = new Produto();
            p.Codigo = 1;
            p.Descricao = "Computador";
            produtos.Add(p);

            p = new Produto();
            p.Codigo = 2;
            p.Descricao = "Mouse";
            produtos.Add(p);

            p = new Produto();
            p.Codigo = 3;
            p.Descricao = "Teclado";
            produtos.Add(p);

            cliente.Produtos = produtos;

            clientes.Add(cliente);

            cliente = new Cliente();
            cliente.Nome = "Francisco";

            produtos = new List<Produto>();

            p = new Produto();
            p.Codigo = 1;
            p.Descricao = "Roteador";
            produtos.Add(p);

            p = new Produto();
            p.Codigo = 2;
            p.Descricao = "Cabo";
            produtos.Add(p);

            p = new Produto();
            p.Codigo = 3;
            p.Descricao = "RJ45";
            produtos.Add(p);

            cliente.Produtos = produtos;

            clientes.Add(cliente);

            return View(clientes);
        }

    
    }
}
