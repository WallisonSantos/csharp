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
            Contas.Add(new ContaCorrente() { ChavePix = 00022, Correntista = "ZÉ" });

            foreach (ContaCorrente contas in Contas)
            {
                Console.WriteLine($"\nContas: {contas} ");
            }
            Console.WriteLine("---------------------------------------------------------");


            Console.WriteLine("\nTOTAL de contas: {0} ",
                Contas.Count()
            );
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\nCONTAINS chave pix: {0} ",
                Contas.Contains(new ContaCorrente { Correntista = "0000" })
            );
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\nEXISTS correntista pix with 00013: {0} ",
                Contas.Exists(cc => cc.ChavePix == 00011)
            );
            Console.WriteLine("---------------------------------------------------------");


            // Find
            Console.WriteLine("\nFIRST \"WALL\": {0} ",
                Contas.Find(cc => cc.Correntista.Contains("WALL"))
            );
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\nLAST \"WALL\": {0} ",
                Contas.FindLast(cc => cc.Correntista.Contains("WALL"))
            );
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\n FILTRO com mais de 5 letras: {0} ",
                Contas.FindAll( cc => cc.Correntista.Length > 5 )
            );
            Console.WriteLine("---------------------------------------------------------");


            // Index
            Console.WriteLine("\nFIND INDEX \"WALL\" {0} ",
                Contas.FindIndex(cc => cc.Correntista.Contains("WALL"))
            );
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\nFIND LAST INDEX Correntista where correntista contains \"K\": {0}",
                Contas.FindLastIndex(cc => cc.Correntista.Contains("K"))
            );
            Console.WriteLine("---------------------------------------------------------");


            foreach (ContaCorrente contas in Contas)
            {
                Console.WriteLine("\n Contas ", contas);
            }
            Console.WriteLine("---------------------------------------------------------");

            if ( Contas.FindAll( cc => cc.Correntista.Length == 3) )



        }
    }
}