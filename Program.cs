using System;
using System.Globalization;
namespace csharp {
    class Program {
        static void Main(string[] args) {

            int result = ContaCorrente.Sum(new int[] { 10, 20, 30 });
            int result2 = ContaCorrente.Sum(new int[] { 10, 20, 30 });

            System.Console.WriteLine(result2);


        }
    }
}