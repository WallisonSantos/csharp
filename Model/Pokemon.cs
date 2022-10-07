using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.Model
{
    public class Pokemon
    {
        public List<Abilities> abilities { get; set; }
        public double height { get; set; }
        public double weight { get; set; }
        public string? name { get; set; }
        public int Alimentacao { get; set; }
        public int Humor { get; set; }
        public DateTime DataNascimento { get; set; }

        public Pokemon()
        {
            Random ValorRandomico = new();
            Alimentacao = ValorRandomico.Next(2, 100);
            Humor = ValorRandomico.Next(2, 10);
            DataNascimento = DateTime.Now;
        }

        public bool VerificarFome()
        {
            return this.Alimentacao < 5;
        }

        public void AlimentarMascote()
        {
            this.Alimentacao++;
        }

        public void BrincarMacote()
        {
            this.Humor++;
            this.Alimentacao--;
        }
    }
}