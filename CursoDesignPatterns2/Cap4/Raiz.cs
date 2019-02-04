using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap4
{
    public class Raiz : ExpressaoAbstract
    {
        public Raiz(IExpressao esquerda)
        {
            Esquerda = esquerda;
        }
        public override int Avalia()
        {
            return (int) Math.Sqrt(Esquerda.Avalia());
        }
    }
}
