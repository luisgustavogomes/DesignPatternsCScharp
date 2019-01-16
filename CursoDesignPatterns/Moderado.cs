using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Moderado : IInvestimento
    {
        private Random Random;

        public Moderado()
        {
            Random = new Random();
        }

        public double Calcular(Conta conta)
        {
            return Random.Next(2) == 0 ? conta.Saldo * 0.025 : conta.Saldo * 0.007;
        }
    }
}
