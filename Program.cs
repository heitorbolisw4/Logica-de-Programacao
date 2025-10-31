using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VT___Atividade_2.Class;

namespace VT___Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controlador controlador = new Controlador();

            

            // faça um loop onde o usuario poderá voltar ao menu principal sempre que quiser
            // sem precisar sair da aplicacao

            bool executar = true;
            
            while(executar == true)
            {
                MostrarMenu();
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        TratarAddDispositivo(controlador);
                        break;
                    case "2":
                        TratarLigarDispositivo(controlador);
                        break;
                    case "3":
                        TratarDesligarDispositivo(controlador);
                        break;
                    case "4":
                        TratarLigarTodosOsDispositivo(controlador);
                        break;
                    case "5":
                        TratarDesligarTodosOsDispositivos(controlador);
                        break;
                    case "6":
                        TratarListarDispositivo(controlador);
                        break;
                    case "7":
                        TratarAjustarTemperaturaArCondicionado(controlador);
                        break;
                    case "8":
                        TratarAjustarIntenseLuminaria(controlador);
                        break;
                    case "9":
                        Console.WriteLine("Saindo da aplicacao");
                        executar = false;
                        break;
                    default:
                        Console.WriteLine("Dispositivo não encontrado");
                        break;
                     
                }
                if (executar)
                {
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadKey();
                }
                

            }
            

        }
        #region Menu
        private static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao SmartHomeController\n" +
                "Seu assistente inteligente pique Einstein");

            Console.WriteLine("=================== - MENU - ==================");
            Console.WriteLine("1 - Adicionar dispositivo");
            Console.WriteLine("2 - Ligar dispositivo");
            Console.WriteLine("3 - Desligar dispositivo");
            Console.WriteLine("4 - Ligar todos os dispositivos");
            Console.WriteLine("5 - Desligar todos os dispositivos");
            Console.WriteLine("6 - Listar todos os dispositivos");
            Console.WriteLine("7 - Ajustar Temperatura do Ar Condicionado");
            Console.WriteLine("8 - Ajustar Intensidade das Luminarias");
            Console.WriteLine("9 - Sair do SmartController");
        }
        #endregion

        #region Funcionalidades
        private static void TratarAddDispositivo(Controlador controlador)
        {
            Console.WriteLine("\n ------- Adicionar novo dispositivo ------");
            Console.WriteLine("Qua é o tipo do dispositivo?");
            Console.WriteLine("1 - Computador");
            Console.WriteLine("2 - TV");
            Console.WriteLine("3 - Luminaria");
            Console.WriteLine("4 - Ar Condicionado");
            Console.Write("Selecione o dispositivo: ");
            string tipo = Console.ReadLine();

            Console.WriteLine("Digite o nome do dispositivo. Ex: tv da sala ...");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("O nome não pode estar vazio");
                return;
            }
            try
            {
                if (tipo == "1")
                {
                    
                    string nomePC = nome;
                    Computador computador = new Computador(nomePC);
                    controlador.AdicionarDispositivo(computador);
                    
                }
                else if (tipo == "2")
                {
                    
                    string nomeTV = nome;
                    Televisao tv = new Televisao(nomeTV);
                    controlador.AdicionarDispositivo(tv);
                }
                else if (tipo == "3")
                {
                    
                    string nomeLuminaria = nome;
                    int intensidade = 1;
                    Luminaria luminaria = new Luminaria(nomeLuminaria, intensidade);
                    controlador.AdicionarDispositivo(luminaria);
                }
                else if (tipo == "4")
                {
                    string nomeAR = nome;
                    int temperatura = 0;
                    ArCondicionado arCondicionado = new ArCondicionado(nomeAR, temperatura);
                    controlador.AdicionarDispositivo(arCondicionado);
                }
                else
                {
                    Console.WriteLine("Tipo Inválido");
                }
            }


            catch (FormatException)
            {
                Console.WriteLine("Erro: Dispositivo inválido");
            }
        }
        private static void TratarLigarDispositivo(Controlador controlador)
        {
            Console.WriteLine("\n ------- Ligar dispositivo ------");
            Console.WriteLine("1 - Computador");
            Console.WriteLine("2 - TV");
            Console.WriteLine("3 - Luminaria");
            Console.WriteLine("4 - Ar Condicionado");
            Console.WriteLine("Selecione o dispositivo que deseja ligar: ");
            string option = Console.ReadLine();

            if (option == "")
            {
                Console.WriteLine("Você deve selecionar uma opcao");
                return;
            }
            try
            {
                if(option == "1")
                {
                    Console.WriteLine("Digite o nome do computador que deseja ligar");
                    string nomePC = Console.ReadLine();
                    controlador.LigarDispositivo(nomePC);

                }
                else if (option == "2")
                {
                    Console.WriteLine("Digite o nome da TV que deseja ligar");
                    string nomeTV = Console.ReadLine();
                    controlador.LigarDispositivo(nomeTV);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Digite o nome da Luminaria que deseja ligar");
                    string nomeLum = Console.ReadLine();
                    controlador.LigarDispositivo(nomeLum);
                }
                else if (option == "4")
                {
                    Console.WriteLine("Digite o nome do Ar Condicionado que deseja ligar");
                    string nomeAr = Console.ReadLine();
                    controlador.LigarDispositivo(nomeAr);
                }
                else
                {
                    Console.WriteLine("Tipo invalido");
                }
            
            }
            catch
            {
                throw new Exception("Erro, dispositivo não encontrado");
            }


        }
        private static void TratarDesligarDispositivo(Controlador controlador)
        {
            Console.WriteLine("\n ------- Desligar Dispositivo ------");
            Console.WriteLine("1 - Computador");
            Console.WriteLine("2 - TV");
            Console.WriteLine("3 - Luminaria");
            Console.WriteLine("4 - Ar Condicionado");
            Console.WriteLine("Selecione o dispositivo que deseja desligar:   ");
            string option = Console.ReadLine();
            
            if(option == "")
            {
                throw new Exception("selecione um dispositivo");
            }
            try
            {
                if(option == "1")
                {
                    Console.WriteLine("Digite o nome do computador");
                    string nomePC = Console.ReadLine();
                    controlador.DesligarDispositivo(nomePC);
                }
                else if(option == "2")
                {
                    Console.WriteLine("Digite o nome da TV");
                    string nomeTV = Console.ReadLine();
                    controlador.DesligarDispositivo(nomeTV);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Digite o nome da Luminaria");
                    string nomeLum = Console.ReadLine();
                    controlador.DesligarDispositivo(nomeLum);
                }
                else if (option == "4")
                {
                    Console.WriteLine("Digite o nome da Luminaria");
                    string nomeAr = Console.ReadLine();
                    controlador.DesligarDispositivo(nomeAr);
                }
                else
                {
                    Console.WriteLine("Dispositivo não encontrado");
                }
            }
            catch
            {
                throw new Exception("Opcao invalida");
            }
        }
        private static void TratarDesligarTodosOsDispositivos(Controlador controlador)
        {
            controlador.DesligarTodosOsDispositivos();
        }
        private static void TratarLigarTodosOsDispositivo(Controlador controlador)
        {
            controlador.LigarTodosOsDispositivo();
        }
        private static void TratarListarDispositivo(Controlador controlador)
        {
            controlador.ListarDispositivos();
        }
        private static void TratarAjustarTemperaturaArCondicionado(Controlador controlador)
        {
            Console.WriteLine("========== Ajustar Temperatura do Ar Condicionado ==========");
            bool ArCadastrado = controlador.ListarArCondicionado();


            if (!ArCadastrado)
            {
                Console.WriteLine("Não há nenhum dispositivo cadastrado");
                return;
            }

            Console.WriteLine("Digite o nome do ar que deseja alterar a temperatura");
            string nomeAR = Console.ReadLine();
            
            if (string.IsNullOrWhiteSpace(nomeAR))
            {
                Console.WriteLine("Nome invalido");
                return;
            }
            try
            {
                Console.WriteLine("Digite a temperatura desejada");
                Console.WriteLine("Min 1  - Max 30");
                int temperatura = Convert.ToInt32(Console.ReadLine());
                if(temperatura <= 0 ||  temperatura > 30)
                {
                    Console.WriteLine("Valor invalido meu xapa");
                    return;
                }
                else if (temperatura >= 1 && temperatura <= 10)
                {
                    Console.WriteLine("Cê curte um frio hein...");
                }
                else if (temperatura > 10 && temperatura <= 20)
                {
                    Console.WriteLine("Éeee mais ou menos, mais ou menos");
                }
                else
                {
                    Console.WriteLine("Sem condição mano, abaixo isso ai");
                }
                controlador.AjustarTemperaturaArCondicionado(nomeAR, temperatura);
                Console.WriteLine($"Temperatura do {nomeAR} foi ajustada em {temperatura}%");
            }
            catch(FormatException)
            {
                Console.WriteLine("Informe uma temperatura valida");
            }
        }
        private static void TratarAjustarIntenseLuminaria(Controlador controlador)
        {
            Console.WriteLine("========== Ajustar Intensidade da Luz ==========");
            bool lumCadastrada = controlador.ListarLuminarias();

            if (!lumCadastrada)
            {
                Console.WriteLine("Não ha nenhuma luminaria cadastrada");
                return;
            }
            Console.WriteLine("Digite o nome do ar que deseja alterar a temperatura");
            string nomeLum = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(nomeLum))
            {
                Console.WriteLine("O nome nao pode ficar vazio");
                return;
            }
            try
            {
                Console.WriteLine("Digite a intensidade da Luminaria");
                Console.WriteLine("Min 1 max 10");
                int intensidadeLum = Convert.ToInt32(Console.ReadLine());

                if(intensidadeLum <= 0 || intensidadeLum > 10)
                {
                    Console.WriteLine("Insira um valor valido");
                    return;
                }else if (intensidadeLum >= 1 && intensidadeLum <= 5)
                {
                    Console.WriteLine("Legal, ta bacana");
                }else if (intensidadeLum <= 8)
                {
                    Console.WriteLine("Pra que essa intensidade toda cara");

                }else if(intensidadeLum <= 10)
                {
                    Console.WriteLine("Cuidade com os óleos cara!");
                }
                else
                {
                    Console.WriteLine("Insira um valor valido ai cara");
                }
                controlador.AjustarIntensidadeLuminaria(nomeLum, intensidadeLum);
                Console.WriteLine($"A intensidade da {nomeLum} foi alterada para {intensidadeLum}%");

            }
            catch (FormatException)
            {
                Console.WriteLine("Informe uma intensidade valida");
            }
        }
        #endregion
    }
}

