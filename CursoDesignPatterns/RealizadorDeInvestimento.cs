using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class RealizadorDeInvestimento
    {
        public void Realiza(Conta conta, IInvestimento investimento)
        {
            double resultado = investimento.Calcular(conta);
            conta.Depositar(resultado * 0.75);
            Console.WriteLine($"Novo saldo: {conta.Saldo}");
        }
    }
}
