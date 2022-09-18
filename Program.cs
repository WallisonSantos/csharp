using System;
using System.Globalization;
namespace csharp {
    class Program {
        static void Main(string[] args) {

            int numElementos = 2;
            double    indice = 0;
            double totalTaxa = 0.00;

            ContaCorrente[] vetor = new ContaCorrente[numElementos];

            for (int i = 0; i < numElementos; i++) {
                indice += 1;

                Console.Write($"\nCorrentista ({indice}): ");
                string? correntista = Console.ReadLine();

                Console.Write($"\nAgencia ({indice}): ");
                string?     agencia = Console.ReadLine();

                Console.Write($"\nConta ({indice}): ");
                string?       conta = Console.ReadLine();

                Console.Write($"\nTaxa ({indice}): ");
                double         taxa = double.Parse(Console.ReadLine());

                Console.Write($"\nValorDep({indice}): ");
                double         dep = double.Parse(Console.ReadLine());

                vetor[i] = new ContaCorrente {
                    Correntista = correntista,
                    Agencia = agencia,
                    Conta = conta,
                    Taxa = taxa,
                    ValorDep = dep,
                };
                Console.WriteLine($"\nVETOR ({indice}) - {vetor[i]}");
            }

            for (int i = 0; i < numElementos; i++) {
                indice += 1;
                totalTaxa = totalTaxa + vetor[i].Taxa;
                Console.WriteLine($"\nTAXA DO VETOR ({indice}) {vetor[i].Taxa}");
            }

            double mediaTaxa = totalTaxa / numElementos;
            Console.WriteLine($"\nAverage rate % {mediaTaxa} \n");
        }
    }
}