using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBackEnd.Entity
{
    public class Pessoa
    {
        //declarar propriedades
        public string Nome { get; set; }

        //construtores
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa() {}



    }
}
