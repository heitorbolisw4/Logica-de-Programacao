using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT___Atividade_2.Class
{
    internal class ArCondicionado : Dispositivo
    {
        //private int id;
        private int temperatura;
        public int Temperatura { get => temperatura; set => temperatura = value; }
        //public int Id { get => id; set => id = value; }

        public ArCondicionado(string nome, int temperatura) : base(nome)
        {
            this.Nome = nome;
            this.Temperatura = temperatura;
        }

        public override void Ligar()
        {
            Console.WriteLine($"O Ar {this.Nome} está ligado");
            
        }
        public override void Desligar()
        {
            Console.WriteLine($"O {this.Nome} foi desligado");
            
        }

    }
}
