using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap3
{
    public class StatusContratoEmAndamento : ITipoContrato
    {
        public void Avanca(Contrato contrato)
        {
            contrato.Tipo = new StatusContratoAcertado();
        }

        public override string ToString()
        {
            return "EmAndamento";
        }
    }
}
