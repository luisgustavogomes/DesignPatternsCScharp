using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap3
{
    public class StatusContratoNovo : ITipoContrato
    {
        public void Avanca(Contrato contrato)
        {
            contrato.Tipo = new StatusContratoEmAndamento();
        }

        public override string ToString()
        {
            return "Novo";
        }
    }
}
