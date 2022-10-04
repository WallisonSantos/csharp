using System;
using System.Globalization;
using System.Collections.Generic;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List< ContaCorrente > Contas = new List< ContaCorrente >();
            Contas.Add( new ContaCorrente() { Correntista = "WALLISON", ChavePix = 129 });
            Contas.Add( new ContaCorrente() { Correntista = "KAREEN", ChavePix = 130 });

        }
    }
}