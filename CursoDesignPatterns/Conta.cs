using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public IStatusConta StatusConta { get; set; }
        public double Saldo { get; set; }
        public string Nome { get; private set; }
        public DateTime DataAbertura { get; private set; }

        public Conta()
        {
            StatusConta = new StatusContaPositivo();
            Saldo = 10;
        }

        public Conta(double saldo, string nome)
        {
            Saldo = saldo;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        }

        public void Depositar(double valor)
        {
            StatusConta.Depositar(this, valor);
        }

        public void Sacar(double valor)
        {
            StatusConta.Sacar(this, valor);
        }

        public override string ToString()
        {
            return $"Saldo: {Saldo} | Status: {StatusConta}";
        }
    }
}
