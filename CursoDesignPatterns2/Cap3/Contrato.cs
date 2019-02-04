using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap3
{
    public class Contrato
    {
        public DateTime Data { get; private set; }
        public string Cliente { get; private set; }
        public ITipoContrato Tipo { get; set; }
        public ContratoHistorico Historico { get; set; }
        private bool controlador;

        
        public Contrato(DateTime data, string cliente)
        {
            Data = data;
            Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
            Tipo = new StatusContratoNovo();
            Historico = new ContratoHistorico();
            controlador = true;
        }

        private Contrato(DateTime data, string cliente, ITipoContrato tipo) : this(data, cliente)
        {
            Tipo = tipo;
        }

        public void Avanca()
        {
                Historico.Adiciona(SalvaHistoricoContrato());   
                Tipo.Avanca(this);
        }

        private Contrato SalvaHistoricoContrato()
        {
            return new Contrato(this.Data, this.Cliente, this.Tipo);
        }


        public override string ToString()
        {
            return $"Data: {Data}; Cliente: {Cliente}; Tipo: {Tipo}";
        }
    }
}
