using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT___Atividade_2.Class
{
    public class Dispositivo
    {
        //private int id;
        private string nome;

        public string Nome { get => nome; set => nome = value; }
        //public int Id { get => id; set => id = value; }

        public Dispositivo(string nome /*int id*/)
        {
            this.Nome = nome;
            //this.Id = id;
        }


        public virtual void Ligar()
        {
            Console.WriteLine($"O dispositivo {this.Nome} está ligado");
        }
        public virtual void Desligar()
        {
            Console.WriteLine($"O Dispositivo {this.Nome} esta desligado");
        }
    }
}
