using System;
using System.Globalization;
using System.Collections.Generic;
namespace csharp
{
   class Program
   {
      static void Main(string[] args)
      {
         // Criando a lista de parts.
         List<ContaCorrente> Conta = new List<ContaCorrente>();

         Conta.Add(new ContaCorrente() { Correntista = "WTA", ChavePix = 00009 });
         Conta.Add(new ContaCorrente() { Correntista = "KAS", ChavePix = 00010 });
         Conta.Add(new ContaCorrente() { Correntista = "MA", ChavePix = 00011 });
         Conta.Add(new ContaCorrente() { Correntista = "AS", ChavePix = 00012 });

         Conta.Insert(2, new ContaCorrente() { Correntista = "JGF", ChavePix = 00013 });

         foreach ( ContaCorrente contas in Conta )
         {
            Console.WriteLine($"Contas: {contas}");
         }
         Console.WriteLine();


         for ( int i = 0; i < Conta.Count; i++ )
         {
            Console.WriteLine($"Conta Corrente: {Conta[i]}");
         }
         Console.WriteLine("\nNúmero de contas: {0}\n", Conta.Count);


         Console.WriteLine("\nCONTAINS Chave Pix: {0}",
            Conta.Contains(new ContaCorrente { Correntista = "WTA", ChavePix = 00009 }));

         Console.WriteLine("\nFIND Correntista where correntista contains \"WTA\":  {0}",
            Conta.Find(cc => cc.Correntista.Contains("WTA")));

         Console.WriteLine("\nEXISTS chave pix with 00013: {0} \n",
            Conta.Exists(cc => cc.ChavePix == 00013));

         Console.WriteLine("\nFIND LAST Correntsta where correntista contais \"A\": {0}",
            Conta.FindLast(cc => cc.Correntista.Contains("A")));

         Console.WriteLine("\nFIND INDEX Correntsta where correntista contais \"A\": {0}",
            Conta.FindIndex(cc => cc.Correntista.Contains("A")));

         Console.WriteLine("\nFIND LAST INDEX Correntsta where correntista contais \"A\": {0}",
            Conta.FindLastIndex(cc => cc.Correntista.Contains("A")));
            Console.WriteLine();

         List<ContaCorrente> ContaFilter = Conta.FindAll(conta => conta.Correntista.Length == 3);

         foreach( ContaCorrente filter in ContaFilter ) {
            Console.WriteLine("FILTRO contas com 3 letras {0}", filter);
         }

         Conta.RemoveAll(conta => conta.Correntista.Length == 3);

         foreach( ContaCorrente contas in Conta ) {
            Console.WriteLine("Todas as Contas {0}", contas);
         }
      }
   }
}