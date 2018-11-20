using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrupoDeEstudo.Models
{
    public class FranciscoRepository : Francisco
    {
        Francisco francisco = null;

        public void LoadFrancisco()
        {
            this.francisco = new Francisco();
            this.francisco.Nome = "Francisco Queiroz";
            this.francisco.Nascimento = new DateTime(1989,9,21);

            int idade = DateTime.Today.Year - this.francisco.Nascimento.Year;
            if (this.francisco.Nascimento > DateTime.Today.AddYears(-idade))
            {
                idade--;
            }
            this.francisco.Idade = idade;

            this.francisco.Email = "franciscooq@yahoo.com.br";
            this.francisco.Frase = "Desenvolvedor de Software";
            this.francisco.PaginaPessoal = "www.franciscooq.com.br";

            this.francisco.Sobre = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";


        }

        public Francisco GetFrancisco()
        {
            return francisco;
        }
    }
}