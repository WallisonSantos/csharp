using System;
using System.Globalization;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {

            double? X = -10;
            double? Y = 22.88;
            double? Z = null;

            if (X.HasValue == true && X.Value > 0)
            {
                System.Console.WriteLine($"O valor de X é de R$ {X.Value}");
            }
            else if (X.HasValue == false)
            {
                System.Console.WriteLine($"O valor de x esta vazio{X.Value}");
            }
            else if (Y.HasValue == true && Y.Value > 0)
            {
                System.Console.WriteLine($"O valor de Y é de R$ {Y.Value}");
            }
            else if (Z.HasValue == false)
            {
                System.Console.WriteLine($"O valor de Z esta vazio{Z.Value}");
            }
            {
                System.Console.WriteLine("Error !");
            }





        }
    }
}