using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set ; }

        public double Descontar(Orcamento orcamento)
        {
            return orcamento.Itens.Count > 5 ? orcamento.Valor * 0.01 : Proximo.Descontar(orcamento);
        }
    }
}
