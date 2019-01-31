using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap3
{
    public class ContratoHistorico
    {
        public IList<Contrato> Contratos { get; private set; }

        public ContratoHistorico()
        {
            Contratos = new List<Contrato>();
        }

        public void Adiciona(Contrato contrato)
        {
            Contratos.Add(contrato);
        }

        public Contrato GetContratoHistorico(int index)
        {
            return Contratos[index];
        }
    }
}
