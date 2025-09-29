using System;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira o token de acesso
        Console.WriteLine("Digite sua credencial abaixo");
        string? token = Console.ReadLine();

        if (token?.Length != 10 || token?[0] != 'A' || !token.Any(char.IsDigit))
        {
            Console.WriteLine("Acesso Negado");
        }
        else
        {
            Console.WriteLine("Acesso permitido");            
        }

    }
}
