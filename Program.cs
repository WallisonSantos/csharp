using System;
using System.Globalization;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCC;

            System.Console.Write("Entre com o nro da Conta: ");
            string? conta = Console.ReadLine();

            System.Console.Write("Entre com o Titular da conta: ");
            string? titular = Console.ReadLine();

            System.Console.Write("Abrir conta com Depósito inicial (s/n): ");
            char resp = char.Parse(Console.ReadLine().ToUpper());

            if (resp == 'S')
            {
                System.Console.Write("Entre com o valor para o depósito: ");
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                contaCC = new ContaCorrente(depInicial,0,titular,"",conta);
            }
            else
            {
                contaCC = new ContaCorrente(0,0,titular,"",conta);
            }

            System.Console.WriteLine("\nDados Bancários: \n");
            System.Console.WriteLine(contaCC);
            System.Console.WriteLine("\n");

            contaCC.Sacar(10);

            System.Console.WriteLine("\nDados Bancários: \n");
            System.Console.WriteLine(contaCC);
            System.Console.WriteLine("\n");
        }
    }
}