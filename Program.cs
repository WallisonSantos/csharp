using System;
using System.Globalization;
namespace csharp {
    class Program {
        static void Main(string[] args) {

            int a = 10;
            ContaCorrente.Triple(ref a);
            Console.WriteLine(a);

            double b = 5;
            ContaCorrente.Aplicacao(ref b   );
            Console.WriteLine(b);

        }
    }
}