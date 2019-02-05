using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns2.Cap5;

namespace CursoDesignPatterns2.Cap4
{
    public class Divisao : ExpressaoAbstract
    {
        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }

        public override void Aceita(ImpressoraVisitor impressora)
        {
            impressora.ImprimeDivisao(this);
        }

        public override int Avalia()
        {
            return Esquerda.Avalia() / Direita.Avalia();
        }
    }
}
