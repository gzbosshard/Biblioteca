using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Emprestimo
    {
        public DateTime DataEmprestimo { get; set; } = new DateTime();
        public DateTime DataDevolucao { get; set; } = new DateTime();
        public DateTime DataEstimadaDevolucao { get; set; }
        private List<Livro> Livros { get; set; } = new();
        private List<Pessoa> Pessoas { get; set; } = new();

        

        
        public Emprestimo()
        {

        }

        public void Emprestar(Pessoa pessoa, Livro livro, DateTime dataEmprestimo)
        {
            Pessoas.Add(pessoa);
            Livros.Add(livro);
            DataEmprestimo = dataEmprestimo;
            DataEstimadaDevolucao = DataEmprestimo.AddDays(10);


        }

        public void Devolver(Pessoa pessoa, Livro livro, DateTime dataDevolucao)
        {
            if (dataDevolucao >= DataEstimadaDevolucao)
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine($"\u001b[31mDevolução feita com atraso.\u001b[0m");
                Console.WriteLine("---------------------------------------------------");
            }
            else
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("\u001b[32mParabéns! Você entregou dentro do prazo!\u001b[0m");
                Console.WriteLine("---------------------------------------------------");
            }
            
        }
    }
}
