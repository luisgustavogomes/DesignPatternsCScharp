using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> Itens { get; set; }
        public string  Observacao { get; set; }

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissoa, double valorBruto, double impostos, IList<ItemDaNota> itens, string observacao)
        {
            RazaoSocial = razaoSocial ?? throw new ArgumentNullException(nameof(razaoSocial));
            Cnpj = cnpj ?? throw new ArgumentNullException(nameof(cnpj));
            DataEmissao = dataDeEmissoa;
            ValorBruto = valorBruto;
            Impostos = impostos;
            Itens = itens ?? throw new ArgumentNullException(nameof(itens));
            Observacao = observacao ?? throw new ArgumentNullException(nameof(observacao));
        }


        public override string ToString()
        {
            return $"Razão social: {RazaoSocial}; Data : {DataEmissao}; Cnpj/Cpf: {Cnpj}; Valor total: {ValorBruto}; Obs.: {Observacao} ";
        }

    }
}
