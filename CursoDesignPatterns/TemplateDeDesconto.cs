using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns
{
    public abstract class TemplateDeDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Descontar(Orcamento orcamento)
        {
            return DeveAplicarDesconto(orcamento) ? Desconto(orcamento) : Proximo.Descontar(orcamento);
        }

        public abstract bool DeveAplicarDesconto(Orcamento orcamento);
        public abstract double Desconto(Orcamento orcamento);
    }
}