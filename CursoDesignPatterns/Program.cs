using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Decorator2();
        }

        private static void Observer1()
        {
            var listaDeAcoes = new List<IAcaoAposGerarNota>() { new EnviadorDeEmail(), new NotaFiscalDao(), new EnviadorPorSMS(), new Multiplicador(10) };
            var criadorDeNotaFiscal = new NotaFiscalBuilder(listaDeAcoes);
            var itens = new ItemDaNotaBuilder();
            criadorDeNotaFiscal
                .ParaEmpresa("LG")
                .ComCnpj("999.999.99-99")
                .ComItem(itens.ComNome("Sapato").ComValor(100).Controi())
                .ComItem(itens.ComNome("Calça").ComValor(500).Controi())
                .NaData(new DateTime(2017, 1, 18))
                .ComObservacoes("Teste obs ");

            var nf = criadorDeNotaFiscal.Constroi();

            Console.WriteLine(nf);
        }

        private static void Builder1()
        {
            var criadorDeNotaFiscal = new NotaFiscalBuilder();
            var itens = new ItemDaNotaBuilder();
            criadorDeNotaFiscal
                .ParaEmpresa("LG")
                .ComCnpj("999.999.99-99")
                .ComItem(itens.ComNome("Sapato").ComValor(100).Controi())
                .ComItem(itens.ComNome("Calça").ComValor(500).Controi())
                .NaData(new DateTime(2017, 1, 18))
                .ComObservacoes("Teste obs ");

            var nf = criadorDeNotaFiscal.Constroi();

            Console.WriteLine(nf);
        }

        private static void State2()
        {
            try
            {
                var conta = new Conta();
                Console.WriteLine(conta);

                conta.Sacar(100);

                Console.WriteLine(conta);

                conta.Sacar(100);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void State1()
        {
            try
            {
                var reforma = new Orcamento(500);


                Console.WriteLine("Status: " + reforma.Status + " | Saldo: " + reforma.Valor);
                reforma.AplicaDescontoExtra();
                Console.WriteLine("Status: " + reforma.Status + " | Saldo: " + reforma.Valor);


                reforma.Aprova();

                Console.WriteLine("\nStatus: " + reforma.Status + " | Saldo: " + reforma.Valor);

                reforma.AplicaDescontoExtra();
                Console.WriteLine("Status: " + reforma.Status + " | Saldo: " + reforma.Valor);

                reforma.Finaliza();
                Console.WriteLine("\nStatus: " + reforma.Status + " | Saldo: " + reforma.Valor);

                reforma.AplicaDescontoExtra();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void Decorator2()
        {
            IList<Conta> contas = new List<Conta>() { new Conta(200, "luis"), new Conta(50, "Gustavo"), new Conta(750, "Bauer") };
            IList<Conta> contasFiltradas = new List<Conta>();

            var filtro = new FiltraSaldoMenorQueCem(new FiltraSaldoMaiorQuinhentos());
            contasFiltradas = filtro.Filtra(contas);
            contasFiltradas.ToList().ForEach(c => Console.WriteLine(c));

            Console.ReadLine();
        }

        private static void Decorator1()
        {
            var iss = new ISS(new ICMS());
            var orcamento = new Orcamento(500);

            var valorImposto = iss.Calcula(orcamento);

            Console.WriteLine(valorImposto);
        }

        private static void ChainOfResponsaibilityComTemplateMethod()
        {
            var calculador = new CalculadorDeDesconto();
            var orcamento = new Orcamento(750);

            orcamento.AdicionarItem(new Item("Caneta", 750));
            //orcamento.AdicionarItem(new Item("Lapis", 250));

            var desconto = calculador.Calcula(orcamento);
            Console.WriteLine($"Desconto calculado: {desconto}");
        }

        private static void TemplateMethod1()
        {
            var ikcv = new IKCV();
            var orcamento = new Orcamento(500.00);

            CalculadorDeImpostos.RealizaCalculo(orcamento, ikcv);
        }

        private static void ChainOfResponsibility2()
        {
            var req = new Requisicao(Formato.PORCENTO);
            var conta = new Conta(nome: "luis", saldo: 100.00);

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

        private static void Strategy2()
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

        private static void Strategy1()
        {
            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(120000.00);

            CalculadorDeImpostos.RealizaCalculo(orcamento, iss);
            CalculadorDeImpostos.RealizaCalculo(orcamento, icms);
        }
    }
}
