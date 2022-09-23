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
            Conta.Add(new ContaCorrente() { Correntista = "MAA", ChavePix = 00011 });
            Conta.Add(new ContaCorrente() { Correntista = "AAS", ChavePix = 00012 });

            Conta.Insert(2, new ContaCorrente() { Correntista = "JGF", ChavePix = 00013 });

            foreach (ContaCorrente contas in Conta)
            {
                System.Console.WriteLine($"Contas: {contas}");
            }
            System.Console.WriteLine();


            for (int i = 0; i < Conta.Count; i++)
            {
                System.Console.WriteLine($"Conta Corrente: {Conta[i]}");
            }
            System.Console.WriteLine("\nNúmero de contas: {0}\n", Conta.Count);


            Console.WriteLine("\nCONTAINS Chave Pix: {0}",
            Conta.Contains(new ContaCorrente { Correntista = "WTA", ChavePix = 00009 }));

            Console.WriteLine("\nFIND Correntista where correntista contains \"WTA\":  {0}",
            Conta.Find(cc => cc.Correntista.Contains("WTA")));

            Console.WriteLine("\nEXISTS chave pix with 00013: {0} \n",
            Conta.Exists(cc => cc.ChavePix == 00013));
        }
    }
}