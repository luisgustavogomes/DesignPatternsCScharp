using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500 || TemItemMaiorQue100Reias(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento) 
        {
            return orcamento.Valor * 0.10;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool TemItemMaiorQue100Reias(Orcamento orcamento)
        {
            return orcamento.Itens.ToList().Any(o => o.Valor > 100);
        }
    }
}
