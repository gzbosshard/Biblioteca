using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Livro
    {

        public string TituloLivro { get; private set; }
        public string Editora { get; private set; }
        public int QuantiadadeEmprestimos { get; private set; }
        public DateTime AnoPublicacao { get; private set; }


        public Livro(string tituloLivro)
        {
            TituloLivro = tituloLivro;
        }


    }

    
}
