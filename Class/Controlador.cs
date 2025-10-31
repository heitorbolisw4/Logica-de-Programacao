using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VT___Atividade_2.Class
{
    internal class Controlador
    {
        private List<Dispositivo> dispositivosDaCasa;

        public Controlador()
        {
            this.dispositivosDaCasa = new List<Dispositivo>();
        }

        // metodos para o menu

        // opcao1 adicionar dispositivo
        public void AdicionarDispositivo(Dispositivo novoDispositivo)
        {
            this.dispositivosDaCasa.Add(novoDispositivo);
            Console.WriteLine($"O dispositivo {novoDispositivo.Nome} foi adicionado");
        }
        public void LigarTodosOsDispositivo()
        {
            Console.WriteLine("----- Ligando Todos os Dispositivos da Casa");

            // verifique se há algum dispositivo cadastrado

            if(dispositivosDaCasa.Count == 0)
            {
                Console.WriteLine("Nenhum dispositivo encontrado..");
                return;
            }

            // faça uma estrutura de repeticao em todos os dispositivos encontrados
            foreach(Dispositivo item in dispositivosDaCasa)
            {
                item.Ligar();
            }
        }
        public void LigarDispositivo(string nome)
        {
            // procurar um dispositivo na lista usando LINQ
            // .FirstOrDefault() procura o primeiro  item que bate com a condicao
            Dispositivo dispositivoEncontrado = this.dispositivosDaCasa.FirstOrDefault(d => d.Nome == nome);

            if(dispositivoEncontrado != null)
            {
                dispositivoEncontrado.Ligar();
            }
            else
            {
                Console.WriteLine("Dispositivo não encontrado");
            }
        }
        public void DesligarDispositivo(string nome)
        {
            // mesma lógica usando o LINQ
            Dispositivo dispositivoEncontrado = this.dispositivosDaCasa.FirstOrDefault(d => d.Nome == nome);
            
            if( dispositivoEncontrado != null)
            {
                dispositivoEncontrado.Desligar();
                //Console.WriteLine($"O Dispositivo {dispositivoEncontrado} foi desligado");
                
            }
            else
            {
                Console.WriteLine("Dispositivo não encontrado");
            }

        }

        public void DesligarTodosOsDispositivos()
        {
            if(dispositivosDaCasa.Count == 0)
            {
                Console.WriteLine("Nenhum dispositivo encontrado");
                return;
            }

            foreach (Dispositivo item in dispositivosDaCasa)
            {
                item.Desligar();
            }
        }
        public void AjustarTemperaturaArCondicionado(string nome, int temperatura)
        {
            Dispositivo dispositivoEncontrado = this.dispositivosDaCasa.FirstOrDefault(d => d.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            
            if(dispositivoEncontrado == null)
            {
                Console.WriteLine($"Dispositivo com nome {nome} não foi encontrado");
                return;
            }
            if(dispositivoEncontrado is ArCondicionado ar)
            {
                ar.Temperatura = temperatura;
                //Console.WriteLine($"Temperatura de '{ar.Nome}' foi ajustada para {ar.Temperatura}");
            }
            else
            {
                Console.WriteLine($"Dispositivo {dispositivoEncontrado.Nome} foi encontrado mas NAO é um Ar Condicionado");
            }

        }
        public void AjustarIntensidadeLuminaria(string nome, int intensidade)
        {
            Dispositivo dispositivoEncontrado = this.dispositivosDaCasa.FirstOrDefault(d => d.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if(dispositivoEncontrado == null)
            {
                Console.WriteLine($"Dispositivo com nome {nome} não foi encontrado");
                return;
            }
            if(dispositivoEncontrado is Luminaria lum)
            {
                lum.IntensidadeLuz = intensidade;
            }
            else
            {
                Console.WriteLine($"Dispositivo {dispositivoEncontrado.Nome} foi encontrado mas NAO é uma Luminaria");
            }
        }
        public void ListarDispositivos()
        {
            if(dispositivosDaCasa.Count == 0)
            {
                Console.WriteLine("Nenhum dispositivo encontrado");
                return;
            }

            foreach (Dispositivo item in dispositivosDaCasa)
            {
                Console.WriteLine(item.Nome);
            }
        }
        public bool ListarArCondicionado()
        {
            var _arCondicionado = this.dispositivosDaCasa.OfType<ArCondicionado>();

            if (!_arCondicionado.Any())
            {
                Console.WriteLine("Nenhum Ar Condicionado esta cadastrado");
                return false;
            }
            else
            {
                foreach (ArCondicionado ar in _arCondicionado)
                {
                    Console.WriteLine($" - Nome: {ar.Nome}");
                }
                return true;

            }
        }
        public bool ListarLuminarias()
        {
            var _luminarias = this.dispositivosDaCasa.OfType<Luminaria>();

            if (!_luminarias.Any())
            {
                Console.WriteLine("Nenhuma Luminaria encontrada");
                return false;
            }
            else
            {
                foreach (Luminaria lum in _luminarias)
                {
                    Console.WriteLine($" - Nome: {lum.Nome}");
                }
                return true;

            }
        }
    }
}
