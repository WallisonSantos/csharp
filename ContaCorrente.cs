using System;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace csharp
{
    public class ContaCorrente
    {
        /*  Atributos Privados */
        public string? _correntista;

        /*  Propriedades autoimplementadas */
        public string? Agencia { get; private set; }
        public string? Conta { get; private set; }
        public double  ValorSaq { get; private set; }
        public double  ValorDep { get; private set; }
        public double  Saldo { get; private set; }

        /*  Construtores */
        public ContaCorrente()
        {
            Agencia = "9999";
            Conta = "9999-X";
            Correntista = "XYZ";
        }
        public ContaCorrente(double saldo) : this()
        {
            Saldo = saldo;
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

        /*  Outros métodos da Classe */
        public void Depositar(double vlr_de_dep)
        {
            if (vlr_de_dep > 0)
            {
                ValorDep = ValorDep + vlr_de_dep;
                Saldo = Saldo + vlr_de_dep;
            }
        }
        public void Sacar(double vlr_de_saq)
        {
            if (vlr_de_saq <= Saldo && vlr_de_saq > 0)
            {
                ValorSaq = ValorSaq + vlr_de_saq;
                Saldo = Saldo - vlr_de_saq;
            }
        }
        public override string ToString()
        {
            return "\n Olá " + Correntista
            + ", Agência " + Agencia
            + ", Conta " + Conta
            + ", Saldo R$ " + Saldo
            + ", Vlr de Saque " + ValorSaq
            + ", Vlr de Depósito " + ValorDep;
        }
    }
    struct Point
    {
        public double X, Y;

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}