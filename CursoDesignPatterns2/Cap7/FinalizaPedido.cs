using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap7
{
    public class FinalizaPedido : IComando
    {
        public Pedido Pedido { get; private set; }

        public FinalizaPedido(Pedido pedido)
        {
            Pedido = pedido;
        }

        public void Executa()
        {
            Pedido.Finaliza();
            Console.WriteLine("Finalizando o pedido do cliente {0}", Pedido.Cliente);
        }
    }
}
