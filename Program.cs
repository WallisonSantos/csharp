using System;
using System.Globalization;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();

            cc.Depositar(1000);

            System.Console.WriteLine( cc );
        }
    }
}