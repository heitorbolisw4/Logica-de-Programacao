using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT___Atividade_2.Class
{
    internal class Luminaria : Dispositivo
    {
        //private int id;
        private int intensidadeLuz;
        public int IntensidadeLuz { get => intensidadeLuz; set => intensidadeLuz = value; }
        //public int Id { get => id; set => id = value; }

        public Luminaria(string nome, int intensidade) : base(nome)
        {
            this.Nome = nome;
            this.IntensidadeLuz = intensidade;
            
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
