using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Pessoa
    {

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        


        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }
}
