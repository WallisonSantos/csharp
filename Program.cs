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
            Contas.Add(new ContaCorrente() { ChavePix = 00111, Correntista = "JOSÉ" });
            Contas.Add(new ContaCorrente() { ChavePix = 00111, Correntista = "LUAN" });
            Contas.Add(new ContaCorrente() { ChavePix = 00222, Correntista = "ZÉ" });

            foreach (ContaCorrente contas in Contas)
            {
                Console.WriteLine($"\nContas: {contas} ");
            }
            Console.WriteLine("---------------------------------------------------------");


            Console.WriteLine("\nTOTAL de contas: {0} ",
                Contas.Count()
            );
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine("\nCONTAINS chave pix \"00001\": {0} ",
                Contas.Contains(new ContaCorrente { ChavePix = 00001 })
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
                Console.WriteLine($"\nContas: {contas} ");
            }
            Console.WriteLine("---------------------------------------------------------");


            List< ContaCorrente > FilterLitas2 = Contas.FindAll( cc => cc.Correntista.Length == 8 );
            List< ContaCorrente > FilterLitas1 = Contas.FindAll( cc => cc.Correntista.Length == 2 );


            // Remove
            Console.WriteLine( "\nREMOVE contas com 8 letras: ({0}) conta(s) removida(s) \n",
                Contas.RemoveAll( cc => cc.Correntista.Length == 4 )
            );
            Console.WriteLine("---------------------------------------------------------");
            Contas.RemoveAt(2);
            Contas.RemoveRange(2, 2);


            if ( FilterLitas2.Count > 0 ) {
                foreach ( ContaCorrente filter in FilterLitas2 ) {
                    Console.WriteLine( "\nFiltro contas com 8 letras {0} ", filter );
                }
            Console.WriteLine("---------------------------------------------------------");
            } else if ( FilterLitas1.Count > 0 ) {
                foreach ( ContaCorrente filter in FilterLitas1 ) {
                    Console.WriteLine( "\nFiltro contas com 2 letras {0} ", filter );
                }
            Console.WriteLine("---------------------------------------------------------");
            }
        }
    }
}