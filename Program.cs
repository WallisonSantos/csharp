using System;
using System.Globalization;
namespace csharp {
    class Program {
        static void Main(string[] args) {

            // Variáveis auxiliares globais da Stack
            double vlrSaldo = 0.00;
            int numElements = 2;

            // Variável do tipo vetor de conta corrente, na Stack com a quantidade de Posições conforme variável numElements
            // as Posições serão criadas na memória Heap
            ContaCorrente[] vetor = new ContaCorrente[numElements];

            for (int i = 0; i < numElements; i++) {

                // definindo atributos para o Objeto que será criado na Posição[n]
                System.Console.Write($"Agencia Nro ({i}): ");
                string? agencia = Console.ReadLine();
                System.Console.Write($"Conta Nro ({i}): ");
                string? conta = Console.ReadLine();
                System.Console.Write($"Valor de depósito inicial ({i}): ");
                double valorDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // instanciando o novo Objeto a partir da posição[n] passando os atributos definidos
                vetor[i] = new ContaCorrente {
                    Agencia = agencia,
                    Conta = conta,
                    ValorDep = valorDep
                };
            }

            // Acessando as Posições do vetor, aplicando o método de depositar em cada um dos Objetos da respectiva posição
            for (int i = 0; i < numElements; i++) {
                vetor[i].Depositar(100);
                System.Console.WriteLine(vetor[i]);
            }

            // Somar os saldos disponíveis nas contas, acessando as Posições do vetor invocando o atributo Saldo do Objeto
            for (int i = 0; i < numElements; i++) {
                vlrSaldo += vetor[i].Saldo();
            }
            System.Console.WriteLine($"\nValor total disponível nas contas R$ {vlrSaldo}\n");

        }
    }
}