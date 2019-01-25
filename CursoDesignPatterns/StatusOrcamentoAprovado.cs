using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class StatusOrcamentoAprovado : IStatusOrcamento
    {
        private bool DescontoAplicado { get; set; }

        public StatusOrcamentoAprovado()
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
            throw new Exception("Orcamento já está aprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.Status = new StatusOrcamentoFinalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento está aprovado, não pode ser reprovado agora!");
        }

        public override string ToString()
        {
            return "Aprovado";
        }
    }
}
