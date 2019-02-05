﻿using CursoDesignPatterns2.Cap1;
using CursoDesignPatterns2.Cap2;
using CursoDesignPatterns2.Cap3;
using CursoDesignPatterns2.Cap4;
using CursoDesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Visitor1();
        }

        private static void Visitor1()
        {
            var esquerda = new Soma(new Numero(5), new Numero(10));
            var direita = new Subtracao(new Numero(20), new Numero(10));
            var resultado = new Multiplicacao(esquerda, direita);

            var impressora = new ImpressoraVisitor();
            resultado.Aceita(impressora);
            Console.WriteLine("\n"+ resultado.Avalia());
        }

        private static void Interpreter3()
        {
            var esquerda = new Multiplicacao(new Numero(2), new Numero(10));
            var direita = new Divisao(new Numero(20), new Numero(10));
            var resultado = new Multiplicacao(esquerda, direita);

            Console.WriteLine(resultado.Avalia());

            var resultadoRaiz = new Raiz(resultado);
            Console.WriteLine(resultadoRaiz.Avalia());
        }

        private static void Interpreter2()
        {
            var soma = Expression.Add(Expression.Constant(200), Expression.Constant(350));
            Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
            Console.WriteLine(funcao());
        }

        private static void Interpreter1()
        {
            var esquerda = new Soma(new Numero(1), new Numero(10));
            var direita = new Subtracao(new Numero(20), new Numero(10));
            var resultado = new Soma(esquerda, direita);

            Console.WriteLine(resultado.Avalia());
        }

        private static void Memento1()
        {
            try
            {
                var contrato = new Contrato(DateTime.Now, "luis");
                Console.WriteLine(contrato);
                contrato.Avanca();
                Console.WriteLine(contrato);
                contrato.Avanca();
                Console.WriteLine(contrato);
                contrato.Avanca();
                Console.WriteLine(contrato);

                Console.WriteLine("\n================================");
                foreach (var item in contrato.Historico.Contratos)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static void Flyweight1()
        {
            var notasMusicais = new NotasMusicais();
            var musica = new List<INota>()
            {
                notasMusicais.Get("do"),
                notasMusicais.Get("re"),
                notasMusicais.Get("mi"),
                notasMusicais.Get("fa"),
                notasMusicais.Get("fa"),
                notasMusicais.Get("fa"),
                
                notasMusicais.Get("do"),
                notasMusicais.Get("re"),
                notasMusicais.Get("do"),
                notasMusicais.Get("re"),
                notasMusicais.Get("re"),
                notasMusicais.Get("re"),
                
                notasMusicais.Get("do"),
                notasMusicais.Get("sol"),
                notasMusicais.Get("fa"),
                notasMusicais.Get("mi"),
                notasMusicais.Get("mi"),
                notasMusicais.Get("mi"),
                
                notasMusicais.Get("do"),
                notasMusicais.Get("re"),
                notasMusicais.Get("mi"),
                notasMusicais.Get("fa"),
                notasMusicais.Get("fa"),
                notasMusicais.Get("fa")
            };

            var piano = new Piano();
            piano.Toca(musica);
        }

        private static void Factory1()
        {
            using (var conexao = new ConnectionFactory().GetConnection())
            {
                var comando = conexao.CreateCommand();
                comando.CommandText = "select * from pessoa";
                comando.ExecuteNonQuery();
            }

            Console.ReadLine();
        }
    }
}
