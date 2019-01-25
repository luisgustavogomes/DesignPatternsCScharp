using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Orcamento 
    {
        public IStatusOrcamento Status { get; set; }
        public double Valor { get; set; }
        public IList<Item> Itens { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            Status = new StatusOrcamentoEmAndamento();
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            Status.AplicarDescontoExtra(this);
        }

        public void Aprova()
        {
            Status.Aprova(this);
        }

        public void Reprova()
        {
            Status.Reprova(this);

        }

        public void Finaliza()
        {
            Status.Finaliza(this);
        }

    }
}
