using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class StatusOrcamentoEmAndamento : IStatusOrcamento
    {
        private bool DescontoAplicado { get; set; }

        public StatusOrcamentoEmAndamento()
        {
            DescontoAplicado = false;
        }

        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if (!DescontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                DescontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado!");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.Status = new StatusOrcamentoAprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em aprovação não pode ir para finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.Status = new StatusOrcamentoReprovado();
        }

        public override string ToString()
        {
            return "Em andamento";
        }
    }
}
