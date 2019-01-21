using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class DescontoPorMaisDeQuinhentosReais : TemplateDeDesconto
    {
        public DescontoPorMaisDeQuinhentosReais(IDesconto desconto)
        {
            Proximo = desconto ?? throw new ArgumentNullException(nameof(desconto));
        }

        public override double Desconto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override bool DeveAplicarDesconto(Orcamento orcamento)
        {
            return orcamento.Valor > 500.00;
        }
        
        //public IDesconto Proximo { get; set; }

        //public double Descontar(Orcamento orcamento) 
        //{
        //    return orcamento.Valor > 500.00 ? orcamento.Valor * 0.07 : Proximo.Descontar(orcamento);
        //}
    }
}
