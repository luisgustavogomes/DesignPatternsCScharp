using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap3
{
    class StatusContratoAcertado : ITipoContrato
    {
        public void Avanca(Contrato contrato)
        {
            contrato.Tipo = new StatusContratoConcluido();
        }

        public override string ToString()
        {
            return "Acertado";
        }
    }
}
