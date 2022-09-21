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
            List<Part> parts = new List<Part>();

            // Adicionando parts para a lista.
            parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
            parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
            parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
            parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
            parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
            parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

            // Escreva as partes na lista. Isso chamará o método ToString substituído
            // na classe Parte.
            Console.WriteLine();
            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            // Verifique a lista para a peça #1734. Isso chama o método IEquatable.Equals
            // da classe Part, que verifica o PartId para igualdade.
            Console.WriteLine("\nContains(\"1734\"): {0}", parts.Contains(new Part { PartId = 1734, PartName = "" }));

            // Insira um novo item na posição 2.
            Console.WriteLine("\nInsert(2, \"1834\")");
            parts.Insert(2, new Part() { PartName = "brake lever", PartId = 1834 });

            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            Console.WriteLine($"\nParts[2]: {parts[2]}");
            Console.WriteLine("\nRemove(\"1534\")");

            // Isso removerá a parte 1534 mesmo que o PartName seja diferente,
            // porque o método Equals verifica apenas PartId para igualdade.
            parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });

            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }

            // This will remove the part at index 3.
            Console.WriteLine("\nRemoveAt(3)");
            parts.RemoveAt(3);

            foreach (Part aPart in parts)
            {
                Console.WriteLine(aPart);
            }
        }
    }
}