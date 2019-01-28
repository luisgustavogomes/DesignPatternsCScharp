using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ItemDaNotaBuilder
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota Controi()
        {
            return new ItemDaNota(Nome, Valor);
        }

        public ItemDaNotaBuilder ComNome(string nome)
        {
            Nome = nome; return this;
        }

        public ItemDaNotaBuilder ComValor(double valor)
        {
            Valor = valor; return this;
        }

    }
}
