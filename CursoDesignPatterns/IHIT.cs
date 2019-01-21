using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            IList<string> noOrcamento = new List<string>();

            foreach (var item in orcamento.Itens)
            {
                if (noOrcamento.Contains(item.Nome))
                {
                    return true;
                }
                else
                {
                    noOrcamento.Add(item.Nome);
                }
            }
            return false;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}