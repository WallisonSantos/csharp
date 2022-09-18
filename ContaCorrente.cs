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
        private string? _correntista;
        private double  _saldo;

        /*  Propriedades autoimplementadas */
        public string? Agencia { get; set; }
        public string? Conta { get; set; }
        public double  ValorSaq { get; set; }
        public double  ValorDep { get; set; }

        /*  Construtores */
        public ContaCorrente()
        {
            Agencia = "9999";
            Conta = "9999-X";
            Correntista = "XYZ";
        }
        public ContaCorrente(double saldo) : this()
        {
            _saldo = saldo;
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
        public double Saldo() {
            return _saldo + ValorDep - ValorSaq;
        }
        public void Depositar(double vlr_de_dep)
        {
            if (vlr_de_dep > 0)
            {
                ValorDep = ValorDep + vlr_de_dep;
            }
        }
        public void Sacar(double vlr_de_saq)
        {
            if (vlr_de_saq <= _saldo && vlr_de_saq > 0)
            {
                ValorSaq = ValorSaq + vlr_de_saq;
            }
        }
        public override string ToString()
        {
            return "\n Olá " + Correntista
            + ", Agência " + Agencia
            + ", Conta " + Conta
            + ", Saldo R$ " + Saldo().ToString("F2", CultureInfo.InvariantCulture)
            + ", Vlr de Saque R$" + ValorSaq.ToString("F2", CultureInfo.InvariantCulture)
            + ", Vlr de Depósito R$" + ValorDep.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}