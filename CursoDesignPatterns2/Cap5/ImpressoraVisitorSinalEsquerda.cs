﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns2.Cap4;

namespace CursoDesignPatterns2.Cap5
{
    public class ImpressoraVisitorSinalEsquerda : IVisitorImpressora
    {
        public void ImprimeDivisao(Divisao divisao)
        {
            Console.Write("(");
            Console.Write("/");
            divisao.Esquerda.Aceita(this);
            Console.Write(" ");
            divisao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("(");
            Console.Write("*");
            multiplicacao.Esquerda.Aceita(this);
            Console.Write(" ");
            multiplicacao.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }

        public void ImprimeRaiz(Raiz raiz)
        {
            Console.Write("Raiz");
            raiz.Esquerda.Aceita(this);
        }

        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            Console.Write("+");
            soma.Esquerda.Aceita(this);
            Console.Write(" ");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            Console.Write("-");
            subtracao.Esquerda.Aceita(this);
            Console.Write(" ");
            subtracao.Direita.Aceita(this);
            Console.Write(")");
        }
    }
}
