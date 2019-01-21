using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class SemDesconto : TemplateDeDesconto
    {

        public SemDesconto()
        {

        }

        public SemDesconto(IDesconto desconto)
        {
            Proximo = desconto ?? throw new ArgumentNullException(nameof(desconto));
        }

        public override double Desconto(Orcamento orcamento)
        {
            return 0;
        }

        public override bool DeveAplicarDesconto(Orcamento orcamento)
        {
            return true;
        }
        
        //public IDesconto Proximo { get ; set ; }
        //
        //public double Descontar(Orcamento orcamento)
        //{
        //    return 0;
        //}
    }
}
