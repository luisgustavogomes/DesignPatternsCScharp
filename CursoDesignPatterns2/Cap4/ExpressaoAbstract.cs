using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap4
{
    public abstract class ExpressaoAbstract : IExpressao
    {
        protected IExpressao Esquerda;
        protected IExpressao Direita;
        public abstract int Avalia();
    }
}
