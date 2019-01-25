using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class StatusContaPositivo : IStatusConta
    {
        public void Depositar(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Sacar(Conta conta, double valor)
        {
            conta.Saldo -= valor;
            if (conta.Saldo < 0) conta.StatusConta = new StatusContaNegativo();
        }

        public override string ToString()
        {
            return "Positivo";
        }
    }
}
