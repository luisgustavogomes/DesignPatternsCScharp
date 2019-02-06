using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns2.Cap5;

namespace CursoDesignPatterns2.Cap4
{
    public class Soma : ExpressaoAbstract
    {
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public override void Aceita(IVisitorImpressora impressora)
        {
            impressora.ImprimeSoma(this);
        }

        public override int Avalia()
        {
            return Esquerda.Avalia() + Direita.Avalia();
        }
    }
}
