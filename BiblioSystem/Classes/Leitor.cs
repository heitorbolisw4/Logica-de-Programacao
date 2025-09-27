using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BiblioSystem.Classes
{
    internal class Leitor
    {
        public string Nome;
        public int Idade;
        public string Endereco;

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome do leitor: {Nome}, Idade: {Idade}, Endereço: {Endereco}");
        }
        public void CadastroLeitor(string nome, int idade, string endereco)
        {
            Console.WriteLine("Qual é o seu nome?");
            Nome = Console.ReadLine();
            nome = Nome;
            Thread.Sleep(500);
            Console.WriteLine("Informe sua idade");
            Idade = Convert.ToInt32(Console.ReadLine());
            idade = Idade;
            Thread.Sleep(500);
            Console.WriteLine("E qual é o seu endereço? Só será utilizado caso você não devolva o livro no dia");
            Endereco = Console.ReadLine();
            endereco = Endereco;
            Thread.Sleep(1000);
            
        }
    }
}
