using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT___Atividade_2.Class
{
    internal class Televisao : Dispositivo
    {
        //private int id;

        //public int Id { get => id; set => id = value; }
        public Televisao(string nome) : base(nome)
        {
            //this.id = id;
            this.Nome = nome;
        }

        public override void Ligar()
        {
            Console.WriteLine($"A {this.Nome} foi ligada");
            
        }

        public override void Desligar()
        {
            Console.WriteLine($"A {this.Nome} foi desligada");
            
        }

    }
}
