using BiblioSystem.Classes;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BiblioSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanciando emprestimo
            Emprestimo emprestimo = new Emprestimo();

            #region Adicionando Livros
            // Adicionando o primeiro livro
            Livro l1 = new Livro();

            l1.Autor = "Andrew S. Tanenbaum";
            l1.Nome = "Sistemas Operacionais Modernos";
            l1.AnoPublicacao = 2003;
            l1.Disponivel = true;
            //l1.ExibirInfo();

            // Adicionando o Segundo Livro
            Livro l2 = new Livro();

            l2.Autor = "Ian Sommerville";
            l2.Nome = "Engenharia de Software";
            l2.AnoPublicacao = 2011;
            l2.Disponivel = true;
            //l2.ExibirInfo();

            // Adicionando o Segundo Livro
            Livro l3 = new Livro();

            l3.Autor = "Andrew Hunt";
            l3.Nome = "O Programador Pragmático";
            l3.AnoPublicacao = 2010;
            l3.Disponivel = true;
            //l3.ExibirInfo();

            // Adicionando o Quarto Livro
            Livro l4 = new Livro();

            l4.Autor = "Andrew S. Tanenbaum";
            l4.Nome = "Redes de computadores";
            l4.AnoPublicacao = 2006;
            l4.Disponivel = true;
            //l4.ExibirInfo();

            // Adicionando o Quinto Livro
            Livro l5 = new Livro();

            l5.Autor = "Elizabeth Castro & Bruce Hyslop";
            l5.Nome = "HTML5 e CSS3";
            l5.AnoPublicacao = 2013;
            l5.Disponivel = true;
            //l5.ExibirInfo();
            #endregion

            // Instanciando Biblioteca
            Biblioteca b1 = new Biblioteca();
            b1.Nome = "Biblioteca UNITRI";
            b1.Livros.Add(l1);
            b1.Livros.Add(l2);
            b1.Livros.Add(l3);
            b1.Livros.Add(l4);
            b1.Livros.Add(l5);
            b1.ListarLivros();
            

                       
            #region interacao com user
            bool select = true;

            Console.WriteLine($"Seja Bem-vindo(a) {b1.Nome}");
            Thread.Sleep(2000);
            while (select == true)
            {
                Console.WriteLine($"Menu: ");
                Console.WriteLine($"1 - Emprestimo de Livros");
                Console.WriteLine($"2 - Cadastrar Leitor");
                Console.WriteLine($"3 - Verificar Livros Disponíveis");
                Console.WriteLine($"4 - Sair da aplicação");
                Console.Write("Selecione a opção desejada: ");
                int option = Convert.ToInt32(Console.ReadLine());
                Thread.Sleep(2000);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Livros disponiveis: ");
                        Console.WriteLine($"1 - {l1.Nome} de {l1.Autor}");
                        Console.WriteLine($"2 - {l2.Nome} de {l2.Autor}");
                        Console.WriteLine($"3 - {l3.Nome} de {l3.Autor}");
                        Console.WriteLine($"4 - {l4.Nome} de {l4.Autor}");
                        Console.WriteLine($"5 - {l5.Nome} de {l5.Autor}");
                        Console.WriteLine("----------");
                        Console.Write("Selecione a opção desejada: ");
                        int bookOption = Convert.ToInt32(Console.ReadLine());
                        Thread.Sleep(700);
                        if (bookOption == 1)
                        {
                            Console.WriteLine("Precisamos fazer seu cadastro sistema");
                            Leitor leitor = new Leitor();
                            leitor.CadastroLeitor(leitor.Nome, leitor.Idade, leitor.Endereco);
                            Console.WriteLine($"O leitor {leitor.Nome} tem {leitor.Idade} anos e pegou emprestado " +
                            $"o livro '{l1.Nome}' de {l1.Autor} na data {emprestimo.ConfigDataSolicitacao()} na {b1.Nome}." +
                            $" Ele precisa devolver o livro até o dia {emprestimo.ConfigDataDevolucao()}");

                            l1.Disponivel = false;
                            Console.WriteLine("Prontinho, Voltando ao Menu...");
                            #region detalhes
                            Thread.Sleep(700);
                            Console.WriteLine("-");
                            Thread.Sleep(700);
                            Console.WriteLine("-");
                            Thread.Sleep(700);
                            Console.WriteLine("-");
                            Thread.Sleep(700);
                            Console.WriteLine("~----------------------------");
                            #endregion
                        }

                        if (bookOption == 2)
                        {
                            Console.WriteLine("Precisamos fazer seu cadastro sistema");
                            Leitor leitor = new Leitor();
                            leitor.CadastroLeitor(leitor.Nome, leitor.Idade, leitor.Endereco);
                            Console.WriteLine($"O leitor {leitor.Nome} tem {leitor.Idade} anos e pegou emprestado " +
                            $"o livro '{l2.Nome}' de {l2.Autor} na data {emprestimo.ConfigDataSolicitacao()} na {b1.Nome}." +
                            $" Ele precisa devolver o livro até o dia {emprestimo.ConfigDataDevolucao()}");

                            l2.Disponivel = false;
                            Console.WriteLine("Prontinho, Voltando ao Menu...");
                            Console.WriteLine("~----------------------------");

                        }

                        if (bookOption == 3)
                        {
                            Console.WriteLine("Precisamos fazer seu cadastro sistema");
                            Leitor leitor = new Leitor();
                            leitor.CadastroLeitor(leitor.Nome, leitor.Idade, leitor.Endereco);
                            Console.WriteLine($"O leitor {leitor.Nome} tem {leitor.Idade} anos e pegou emprestado " +
                            $"o livro '{l3.Nome}' de {l3.Autor} na data {emprestimo.ConfigDataSolicitacao()} na {b1.Nome}." +
                            $" Ele precisa devolver o livro até o dia {emprestimo.ConfigDataDevolucao()}");

                            l3.Disponivel = false;
                            Console.WriteLine("Prontinho, Voltando ao Menu...");
                            Console.WriteLine("~----------------------------");
                        }


                        if (bookOption == 4)
                        {
                            Console.WriteLine("Precisamos fazer seu cadastro sistema");
                            Leitor leitor = new Leitor();
                            leitor.CadastroLeitor(leitor.Nome, leitor.Idade, leitor.Endereco);
                            Console.WriteLine($"O leitor {leitor.Nome} tem {leitor.Idade} anos e pegou emprestado " +
                            $"o livro '{l4.Nome}' de {l4.Autor} na data {emprestimo.ConfigDataSolicitacao()} na {b1.Nome}." +
                            $" Ele precisa devolver o livro até o dia {emprestimo.ConfigDataDevolucao()}");

                            l4.Disponivel = false;
                            Console.WriteLine("Prontinho, Voltando ao Menu...");
                            Console.WriteLine("~----------------------------");
                        }

                        if (bookOption == 5)
                        {
                            Console.WriteLine("Precisamos fazer seu cadastro sistema");
                            Leitor leitor = new Leitor();
                            leitor.CadastroLeitor(leitor.Nome, leitor.Idade, leitor.Endereco);
                            Console.WriteLine($"O leitor {leitor.Nome} tem {leitor.Idade} anos e pegou emprestado " +
                            $"o livro '{l5.Nome}' de {l5.Autor} na data {emprestimo.ConfigDataSolicitacao()} na {b1.Nome}." +
                            $" Ele precisa devolver o livro até o dia {emprestimo.ConfigDataDevolucao()}");

                            l5.Disponivel = false;
                            Console.WriteLine("Prontinho, Voltando ao Menu...");
                            Console.WriteLine("~----------------------------");
                        }

                        break;
                    case 2:
                        Console.WriteLine("Vamos fazer o seu cadastro no sistema");
                        Leitor leitor1 = new Leitor();
                        leitor1.CadastroLeitor(leitor1.Nome, leitor1.Idade, leitor1.Endereco);
                        Thread.Sleep(500);
                        break;
                    case 3:
                        Console.WriteLine("Livros Disponíveis:");
                            foreach(var i in b1.Livros)
                            {
                                if( i.Disponivel == true)
                                {
                                    i.ExibirInfo();
                                }
                            }
                        Thread.Sleep(500);
                        break;
                    case 4:
                        Console.WriteLine("Encerrando aplicação...");
                        select = false;
                        break;
                }

            }
            #endregion
        }
    }
}

