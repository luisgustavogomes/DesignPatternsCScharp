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
            var d1 = new DescontoPorCincoItens(new DescontoPorVendaCasada(new DescontoPorMaisDeQuinhentosReais(new SemDesconto())));
            return d1.Descontar(orcamento);
        }
    }
}
