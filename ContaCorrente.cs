using System;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace csharp
{
   public class ContaCorrente : IEquatable<ContaCorrente>
   {
      /*  Atributos Privados */
      private string? _correntista;
      private int _chave_pix;
      private double _saldo;
      private double _taxa;

      /*  Propriedades autoimplementadas */
      public string? Conta { get; set; }
      public string? Agencia { get; set; }
      public double ValorSaq { get; set; }
      public double ValorDep { get; set; }
      private static double _total_aplicacao { get; set; }

      /*  Construtores */
      public ContaCorrente(string correntista, int chavepix)
      {
         ChavePix = chavepix;
         Correntista = correntista;
      }
      public ContaCorrente(double taxa, string correntista, string agencia, string conta)
      {
         Taxa = taxa;
         Correntista = correntista;
         Agencia = agencia;
         Conta = conta;
      }
      public ContaCorrente()
      {
         Agencia = "9999";
         Conta = "9999-X";
         Correntista = "XYZ";
      }
      public ContaCorrente(double vlr_de_dep, double vlr_de_saq)
      {
         Depositar(vlr_de_dep);
         Sacar(vlr_de_saq);
      }
      public ContaCorrente(double vlr_de_dep, double vlr_de_saq, string correntista, string agencia, string conta) : this(vlr_de_dep, vlr_de_saq)
      {
         Correntista = correntista;
         Agencia = agencia;
         Conta = conta;
      }

      /*  Propriedades customizadas */
      public int ChavePix
      {
         get { return _chave_pix; }
         set
         {
            if (value > 0)
            {
               _chave_pix = value;
            }
         }
      }
      public string? Correntista
      {
         get { return _correntista; }
         set
         {
            if (value != null)
            {
               _correntista = value;
            }
         }
      }
      public double Taxa
      {
         get { return _taxa; }
         set
         {
            if (value > 0)
            {
               _taxa = value;
            }
         }
      }
      public double Saldo
      {
         get { return _saldo + ValorDep - ValorSaq; }
         set
         {
            if (value > 0)
            {
               _saldo = value;
            }
         }
      }

      /*  Outros métodos da Classe */
      public void Depositar(double vlr_de_dep)
      {
         if (vlr_de_dep > 0)
         {
            ValorDep = ValorDep + vlr_de_dep;
         }
      }
      public void Sacar(double vlr_de_saq)
      {
         if (vlr_de_saq <= Saldo && vlr_de_saq > 0)
         {
            ValorSaq = ValorSaq + vlr_de_saq;
         }
      }

      public override bool Equals(object? obj)
      {
         if (obj == null) return false;
         ContaCorrente? objAsConta = obj as ContaCorrente;
         if (objAsConta == null) return false;
         else return Equals(objAsConta);
      }

      public override int GetHashCode()
      {
         return ChavePix;
      }

      public bool Equals(ContaCorrente? other)
      {
         if (other == null) return false;
         return (ChavePix.Equals(other.ChavePix));
      }

      public override string ToString()
      {
         return "Olá " + Correntista + "X" + ChavePix
         + ", Agência " + Agencia
         + ", Conta " + Conta
         + ", Saldo R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture)
         + ", Vlr de Taxa " + Taxa.ToString("F2", CultureInfo.InvariantCulture) + "%"
         + ", Vlr de Saque R$" + ValorSaq.ToString("F2", CultureInfo.InvariantCulture)
         + ", Vlr de Depósito R$" + ValorDep.ToString("F2", CultureInfo.InvariantCulture);
      }

      // Função que irá receber uma quantidade variável de valores para soma
      // Usando vetor na passagem de parametro e iterando sobre esse mesmo vetor aplicando a soma da variável _total_aplicacao + numbers(na posição atual do vetor)
      public static double Sum(params double[] numbers)
      {
         for (int i = 0; i < numbers.Length; i++)
         {
            _total_aplicacao = _total_aplicacao + numbers[i];
         }
         return _total_aplicacao;
      }
      // Uso de Modificadores de parâmetros ref e out
      public static void Sum2(ref double x)
      {
         x = x + 1.20;
      }
      public static void Mult(double origin, out double result)
      {
         result = origin * 1.20;
      }
   }
}