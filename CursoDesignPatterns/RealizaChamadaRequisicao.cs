using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class RealizaChamadaRequisicao
    {
        public void Chamada(Requisicao requisicao, Conta conta)
        {
            var r1 = new XML(new PontoEVirgula(new Porcento()));
            r1.Responde(requisicao, conta);
        }
    }
}
