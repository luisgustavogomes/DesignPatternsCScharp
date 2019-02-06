using CursoDesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap4
{
    public abstract class ExpressaoAbstract : IExpressao
    {
        public IExpressao Esquerda { get; protected set; }
        public IExpressao Direita { get; protected set; }
        public abstract int Avalia();
        public abstract void Aceita(IVisitorImpressora impressora);
    }
}
