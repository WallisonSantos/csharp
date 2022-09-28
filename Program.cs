using System;
using System.Globalization;
using System.Collections.Generic;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ContaCorrente> ContaPessoaFisica = new List<ContaCorrente>();

            ContaPessoaFisica.Add(new ContaCorrente() { Correntista = "SILVA", ChavePix = 001 });
            ContaPessoaFisica.Add(new ContaCorrente() { Correntista = "SANTOS", ChavePix = 002 });
            ContaPessoaFisica.Insert(0, new ContaCorrente() { Correntista = "ASSIS", ChavePix = 003 });

            foreach (ContaCorrente depositar in ContaPessoaFisica)
            {
                depositar.Depositar(1000);
                System.Console.WriteLine(depositar);
            }

            List<ContaCorrente> Filter = ContaPessoaFisica.FindAll(conta => conta.Correntista.Contains("ASSIS"));

            foreach (ContaCorrente filter in Filter)
            {
                if (filter.Correntista.Contains("ASSIS") && filter.Correntista.Contains("SÁ"))
                    Console.WriteLine("\nCONTAINS ASSIS and SÁ {0}", filter);

                else if (filter.Correntista.Contains("ASSIS"))
                    System.Console.WriteLine("\nCONTAINS only ASSIS {0}", filter);

                else if (filter.Correntista.Contains("SÁ"))
                    System.Console.WriteLine("\nCONTAINS only SÁ {0}", filter);

                else
                    System.Console.WriteLine("\nNOT CONTAINS nothing {0}", filter);
            }


        }
    }
}