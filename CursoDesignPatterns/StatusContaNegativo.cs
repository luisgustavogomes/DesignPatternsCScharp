using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class StatusContaNegativo : IStatusConta
    {
        public void Depositar(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) conta.StatusConta = new StatusContaPositivo();
        }

        public void Sacar(Conta conta, double valor)
        {
            throw new Exception("Não é possível efetuar sacar valores, saldo negativo");
        }

        public override string ToString()
        {
            return "Negativo";
        }
    }
}
