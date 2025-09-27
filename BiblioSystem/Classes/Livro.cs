using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BiblioSystem.Classes
{
    internal class Livro
    {
        public string Nome;
        public string Autor;
        public int AnoPublicacao;
        public bool Disponivel;


        public void ExibirInfo()
        {
            Console.WriteLine($"Livro {Nome} de {Autor} - Ano de Publicação: {AnoPublicacao}");
        }



    }
}
