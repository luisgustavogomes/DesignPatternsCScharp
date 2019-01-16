using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            return AconteceuVendaCasadaEm(orcamento) ? orcamento.Valor * 0.05 : Proximo.Descontar(orcamento);
        }

        private bool AconteceuVendaCasadaEm(Orcamento orcamento)
        {
            return Existe("Lapis", orcamento) && Existe("Caneta", orcamento);
        }


        /// <summary>
        /// teste de visualização de médoto utilizando lambda
        /// </summary>
        /// <param name="nomeDoItem"></param>
        /// <param name="orcamento"></param>
        /// <returns></returns>
        private bool Existe(String nomeDoItem, Orcamento orcamento) 
            => orcamento.Itens.ToList().Any(o => o.Nome.Equals(nomeDoItem));
    }
}
