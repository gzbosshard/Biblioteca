namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input de Informações para Empréstimo do Livro

            Console.WriteLine($"\u001b[36m----- EMPRÉSTIMO DE LIVRO -----\u001b[0m{Environment.NewLine}");

            Console.Write("Livro emprestado para: ");
            Pessoa pessoa1 = new(Console.ReadLine());

            Console.Write("Título do livro: ");
            Livro livro1 = new(Console.ReadLine());

            Emprestimo emprestimo = new();

            Console.Write("Data Empréstimo: ");
            DateTime dataEmprestimo = DateTime.Now;


            // Função Emprestar

            emprestimo.Emprestar(pessoa1, livro1, dataEmprestimo);


            // Informações do empréstimo

            Console.Clear();

            Console.WriteLine($"\u001b[36m----- INFORMAÇÕES DO EMPRÉSTIMO: -----\u001b[0m{Environment.NewLine}");

            Console.WriteLine($"Livro emprestado para: {pessoa1.Nome}");
            Console.WriteLine($"Título do Livro: {livro1.TituloLivro}");
            Console.WriteLine($"Data do empréstimo: {emprestimo.DataEmprestimo.ToShortDateString()}.");
            Console.WriteLine($"Data de Devolução Prevista: {emprestimo.DataEstimadaDevolucao.ToShortDateString()}{Environment.NewLine}");


            // Input de Próxima ação - devolução

            Console.WriteLine("\u001b[36mDeseja devolver o livro agora? Responda 's' para sim ou 'n' para não\u001b[0m");

            Console.Write($"Resposta: ");
            string resposta = Console.ReadLine();

            Console.Clear();

            // Devolução ou Encerramento do Sistema

            if (resposta == "s" || resposta == "S")
            {
                Console.WriteLine($"\u001b[36m----- DEVOLUÇÃO DO LIVRO -----\u001b[0m{Environment.NewLine}");

                bool validacao = false;

                do
                {
                    try
                    {

                        Console.Write("Data de devolução: ");
                        DateTime dataDevolucao = DateTime.Parse(Console.ReadLine());

                        emprestimo.Devolver(pessoa1, livro1, dataDevolucao);
                        validacao = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\u001b[31mErro na inserção dos dados. Tente Novamente!\u001b[0m{Environment.NewLine}");
                    }
                } while (!validacao);
            }
            else
            {            

                Console.WriteLine("Obrigada pela visita! Volte sempre!");

            }

            Console.ReadKey();
        }
    }
}