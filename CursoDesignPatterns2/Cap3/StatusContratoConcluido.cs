using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap3
{
    public class StatusContratoConcluido : ITipoContrato
    {
        public void Avanca(Contrato contrato)
        {
            throw new Exception("Contratos concluidos não podem ser avançados");
        }

        public override string ToString()
        {
            return "Concluido";
        }
    }
}
