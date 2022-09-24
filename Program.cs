using System;
using System.Globalization;
using System.Collections.Generic;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de Contas Correntes
            List<ContaCorrente> Contas = new List<ContaCorrente>();

            Contas.Add(new ContaCorrente() { ChavePix = 00001, Correntista = "WALLISON" });
            Contas.Add(new ContaCorrente() { ChavePix = 00002, Correntista = "KAREEN" });
            Contas.Add(new ContaCorrente() { ChavePix = 00011, Correntista = "MARIA" });
            Contas.Add(new ContaCorrente() { ChavePix = 00022, Correntista = "JOAO" });

            foreach ( ContaCorrente contas in Contas )
            {
                Console.WriteLine($" Contas: {contas} ");
            }
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine( "\nContais chave pix: {0} ",
                Contas.Contains( new ContaCorrente { Correntista = "0000" } )
            );
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine( "\nTotal de contas: {0} ",
                Contas.Count()
            );
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine( "\nFirst \"WALL\": {0} ",
                Contas.Find ( cc => cc.Correntista.Contains("WALL") )
            );
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine();
        }
    }
}