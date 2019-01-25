using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto outroImposto) : base(outroImposto) { }
        public ICCC() : base() { }


        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
            {
                return 0.05 * orcamento.Valor + CalculoDoOutroImposto(orcamento);
            }
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
            {
                return 0.07 * orcamento.Valor + CalculoDoOutroImposto(orcamento);
            }
            else
            {
                return 0.08 * orcamento.Valor + 30.0 + CalculoDoOutroImposto(orcamento);
            }
        }
    }
}
