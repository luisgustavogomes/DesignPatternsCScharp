using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class StatusOrcamentoFinalizado : IStatusOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizados!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizados!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizados!");
        }

        public override string ToString()
        {
            return "Finalizado";
        }
    }
}
