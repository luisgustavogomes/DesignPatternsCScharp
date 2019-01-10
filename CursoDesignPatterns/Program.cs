using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(120000.00);

            CalculadorDeImpostos.RealizaCalculo(orcamento, iss);
            CalculadorDeImpostos.RealizaCalculo(orcamento, icms);


            Console.ReadLine();
        }
    }
}
