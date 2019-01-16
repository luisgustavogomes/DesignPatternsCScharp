using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string Nome { get; private set; }

        public Conta()
        {
        }

        public Conta(double saldo, string nome)
        {
            Saldo = saldo;
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Campo: " + nameof(valor) + " não pode ser menor ou igual a zero!");
            }
#pragma warning disable CS0472 // O resultado da expressão é sempre o mesmo, pois um valor deste tipo nunca é 'null' 
            if (valor == null)
#pragma warning restore CS0472 // O resultado da expressão é sempre o mesmo, pois um valor deste tipo nunca é 'null' 
            {
                throw new ArgumentNullException("Campo " + nameof(valor) + " não pode ser nulo!");
            }

            Saldo += valor;
        }

    }
}
