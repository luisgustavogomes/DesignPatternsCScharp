using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class DescontoPorVendaCasada : TemplateDeDesconto
    {

        public DescontoPorVendaCasada(IDesconto desconto)
        {
            Proximo = desconto ?? throw new ArgumentNullException(nameof(desconto));
        }

        public override double Desconto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }

        public override bool DeveAplicarDesconto(Orcamento orcamento)
        {
            return AconteceuVendaCasadaEm(orcamento);
        }

        private bool AconteceuVendaCasadaEm(Orcamento orcamento)
        {
            return Existe("Lapis", orcamento) && Existe("Caneta", orcamento);
        }

        private bool Existe(String nomeDoItem, Orcamento orcamento) => orcamento.Itens.ToList().Any(o => o.Nome.Equals(nomeDoItem));


        //public IDesconto Proximo { get; set; }

        //public double Descontar(Orcamento orcamento)
        //{
        //    return AconteceuVendaCasadaEm(orcamento) ? orcamento.Valor * 0.05 : Proximo.Descontar(orcamento);
        //}
    }
}
