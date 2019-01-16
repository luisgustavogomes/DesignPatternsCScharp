using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class CalculadorDeDesconto
    {
        public double Calcula(Orcamento orcamento)
        {
            var d1 = new DescontoPorCincoItens();
            var d2 = new DescontoPorVendaCasada();
            var d3 = new DescontoPorMaisDeQuinhentosReais();
            var d4 = new SemDesconto();
            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;
            return d1.Descontar(orcamento);
        }
    }
}
