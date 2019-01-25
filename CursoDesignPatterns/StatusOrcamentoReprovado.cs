using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class StatusOrcamentoReprovado : IStatusOrcamento
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já esta reprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Status = new StatusOrcamentoFinalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já esta reprovado!");
        }

        public override string ToString()
        {
            return "Reprovado";
        }
    }
}
