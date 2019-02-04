﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap4
{
    public class Divisao : ExpressaoAbstract
    {
        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            Esquerda = esquerda;
            Direita = direita;
        }


        public override int Avalia()
        {
            return Esquerda.Avalia() / Direita.Avalia();
        }
    }
}