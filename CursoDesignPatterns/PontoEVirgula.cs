using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class PontoEVirgula : IResposta
    {
        public IResposta OutraResposta { get; set ; }

       

        public PontoEVirgula(IResposta outraResposta)
        {
            OutraResposta = outraResposta ?? throw new ArgumentNullException(nameof(outraResposta));
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.CSV)
            {
                Console.WriteLine($"{conta.Nome};{conta.Saldo}");
            }
            else
            {
                OutraResposta.Responde(requisicao, conta);
            }
        }
    }
}
