/* using System;
using System.Globalization;
using System.Collections.Generic;
namespace csharp
{
    class Notes
    {
        static void Main(string[] args)
        {
            // ------------------------------------------------------------------------------

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



            // Criando a lista de parts.
            Console.WriteLine();
            List<ContaCorrente> Conta = new List<ContaCorrente>();


            Conta.Add(new ContaCorrente() { Correntista = "WTA", ChavePix = 00009 });
            Conta.Add(new ContaCorrente() { Correntista = "KAS", ChavePix = 00010 });
            Conta.Add(new ContaCorrente() { Correntista = "MA", ChavePix = 00011 });
            Conta.Add(new ContaCorrente() { Correntista = "AS", ChavePix = 00012 });


            Conta.Insert(0, new ContaCorrente() { Correntista = "SF", ChavePix = 00013 });
            Conta.Insert(1, new ContaCorrente() { Correntista = "AG", ChavePix = 00014 });


            foreach (ContaCorrente contas in Conta)
            {
                Console.WriteLine($"Contas: {contas}");
            }
            Console.WriteLine();


            for (int i = 0; i < Conta.Count; i++)
            {
                Console.WriteLine($"Conta Corrente: {Conta[i]}");
            }
            Console.WriteLine("\nNúmero de contas: {0}\n", Conta.Count);


            Console.WriteLine("\nCONTAINS Chave Pix: {0}",
            Conta.Contains(new ContaCorrente { Correntista = "WTA", ChavePix = 00009 }));

            Console.WriteLine("\nEXISTS chave pix with 00013: {0} \n",
            Conta.Exists(cc => cc.ChavePix == 00013));

            Console.WriteLine("\nFIND Correntista where correntista contains \"A\": {0}",
            Conta.Find(cc => cc.Correntista.Contains("A")));

            Console.WriteLine("\nFIND LAST Correntista where correntista contais \"A\": {0}",
            Conta.FindLast(cc => cc.Correntista.Contains("A")));

            Console.WriteLine("\nFIND INDEX Correntista where correntista contais \"A\": {0}",
            Conta.FindIndex(cc => cc.Correntista.Contains("A")));

            Console.WriteLine("\nFIND LAST INDEX Correntista where correntista contais \"A\": {0}",
            Conta.FindLastIndex(cc => cc.Correntista.Contains("A")));
            Console.WriteLine();

            Console.WriteLine("\nREMOVE contas com 2 LETRAS, {0} contas removidas\n",
            Conta.RemoveAll(cc => cc.Correntista.Length == 2));

            List<ContaCorrente> ContaFilter = Conta.FindAll(conta => conta.Correntista.Length == 3);
            List<ContaCorrente> ContaFilterDois = Conta.FindAll(conta => conta.Correntista.Length == 2);


            foreach (ContaCorrente contas in Conta)
            {
                Console.WriteLine("TODAS as contas {0}", contas);
            }
            Console.WriteLine();


            if (ContaFilterDois.Count() > 0)
            {
                foreach (ContaCorrente filterdois in ContaFilterDois)
                {
                    Console.WriteLine("FILTRO CONTAS COM 2 LETRAS {0}", filterdois);
                }
                Console.WriteLine();
            }
            else if (ContaFilter.Count() > 0)
            {
                foreach (ContaCorrente filter in ContaFilter)
                {
                    Console.WriteLine("FILTRO CONTAS COM 3 LETRAS {0}", filter);
                }
                Console.WriteLine();
            }


            // ------------------------------------------------------------------------------


            List<ContaCorrente> Contas = new List<ContaCorrente>();

            Contas.Add(new ContaCorrente() { ChavePix = 00001, Correntista = "WALLISON" });
            Contas.Add(new ContaCorrente() { ChavePix = 00002, Correntista = "KAREEN" });
            Contas.Add(new ContaCorrente() { ChavePix = 00011, Correntista = "MARIA" });
            Contas.Add(new ContaCorrente() { ChavePix = 00022, Correntista = "JOAO" });
            Contas.Add(new ContaCorrente() { ChavePix = 00111, Correntista = "JOSÉ" });
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


            // Remove
            Console.WriteLine("\nREMOVE contas com 8 letras: ({0}) conta(s) removida(s) \n",
            Contas.RemoveAll(cc => cc.Correntista.Length == 8)
            );


            List<ContaCorrente> FilterLitas1 = Contas.FindAll(cc => cc.Correntista.Length == 2);
            List<ContaCorrente> FilterLitas2 = Contas.FindAll(cc => cc.Correntista.Length == 8);


            if (FilterLitas2.Count > 0)
            {
                foreach (ContaCorrente filter in FilterLitas2)
                {
                    Console.WriteLine("\nFiltro contas com 8 letras {0} ", filter);
                }
                Console.WriteLine("---------------------------------------------------------");
            }
            else if (FilterLitas1.Count > 0)
            {
                foreach (ContaCorrente filter in FilterLitas1)
                {
                    Console.WriteLine("\nFiltro contas com 2 letras {0} ", filter);
                }
                Console.WriteLine("---------------------------------------------------------");
            }
        }
    }
} */