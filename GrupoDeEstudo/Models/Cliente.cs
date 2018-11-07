using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrupoDeEstudo.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}