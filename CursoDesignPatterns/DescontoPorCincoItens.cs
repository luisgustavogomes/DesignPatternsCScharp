using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class DescontoPorCincoItens : TemplateDeDesconto
    {

        public DescontoPorCincoItens(IDesconto desconto)
        {
            Proximo = desconto ?? throw new ArgumentNullException(nameof(desconto));
        }
        
        public override double Desconto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01;
        }

        public override bool DeveAplicarDesconto(Orcamento orcamento)
        {
            return orcamento.Itens.Count > 5;
        }

        //public IDesconto Proximo { get; set ; }

        //public double Descontar(Orcamento orcamento)
        //{
        //    return orcamento.Itens.Count > 5 ? orcamento.Valor * 0.01 : Proximo.Descontar(orcamento);
        //}
    }
}
