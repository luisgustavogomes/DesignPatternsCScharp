using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ItemDaNota
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota(string nome, double valor)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Valor = valor;
        }
    }
}
