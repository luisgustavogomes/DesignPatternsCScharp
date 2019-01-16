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
            var ikcv = new IKCV();
            var orcamento = new Orcamento(500.00);

            CalculadorDeImpostos.RealizaCalculo(orcamento, ikcv);


            Console.ReadLine();
        }

        private static void ChainOfResponsibility2()
        {
            var req = new Requisicao(Formato.PORCENTO);
            var conta = new Conta(nome:"luis", saldo: 100.00);

            var chamada = new RealizaChamadaRequisicao();
            chamada.Chamada(req, conta);
        }

        private static void ChainOfResponsibility1()
        {
            var calculador = new CalculadorDeDesconto();
            var orcamento = new Orcamento(500);

            orcamento.AdicionarItem(new Item("Caneta", 250));
            orcamento.AdicionarItem(new Item("Lapis", 250));

            var desconto = calculador.Calcula(orcamento);
            Console.WriteLine($"Desconto calculado: {desconto}");
        }

        private static void TrabalhandoComStrategy2()
        {
            var conta1 = new Conta();
            var conta2 = new Conta();
            var conta3 = new Conta();
            var realizadorDeInvestimento = new RealizadorDeInvestimento();
            conta1.Depositar(1000.00);
            conta2.Depositar(1000.00);
            conta3.Depositar(1000.00);

            var moderado = new Moderado();
            var conservador = new Conservador();
            var arrojado = new Arrojado();

            realizadorDeInvestimento.Realiza(conta1, moderado);
            realizadorDeInvestimento.Realiza(conta2, conservador);
            realizadorDeInvestimento.Realiza(conta3, arrojado);
        }

        private static void TrabalhandoComStrategy1()
        {
            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(120000.00);

            CalculadorDeImpostos.RealizaCalculo(orcamento, iss);
            CalculadorDeImpostos.RealizaCalculo(orcamento, icms);
        }
    }
}
