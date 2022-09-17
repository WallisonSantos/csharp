using System;
using System.Globalization;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            double? X = null;
            double?  Y = 10.00;


            double a = X ?? 5.00;
            double b = Y ?? 5.00;


            System.Console.WriteLine(a);
            System.Console.WriteLine(b);

        }
    }
}