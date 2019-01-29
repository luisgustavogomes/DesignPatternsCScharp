using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        private double valotTotal;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas = new List<IAcaoAposGerarNota>();

        public NotaFiscalBuilder(IList<IAcaoAposGerarNota> lista)
        {
            Data = DateTime.Now;
            todasAcoesASeremExecutadas = lista;
        }
        public NotaFiscalBuilder()
        {
            Data = DateTime.Now;
        }

        public NotaFiscal Constroi()
        {
            var nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valotTotal, impostos, todosItens, Observacoes);
            todasAcoesASeremExecutadas.ToList().ForEach(a => a.Executa(nf));
            return nf;
        }

        public void AdicionaAcao(IAcaoAposGerarNota novaAcao)
        {
            todasAcoesASeremExecutadas.Add(novaAcao);
        }

        public NotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota itemDaNota)
        {
            todosItens.Add(itemDaNota);
            valotTotal += itemDaNota.Valor;
            impostos += itemDaNota.Valor * 0.05;
            return this;
        }


        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime dateTime)
        {
            Data = dateTime;
            return this;
        }

    }
}
