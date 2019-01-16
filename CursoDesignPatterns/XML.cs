using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class XML : IResposta
    {
        public IResposta OutraResposta { get; set; }


        public XML(IResposta outraResposta)
        {
            OutraResposta = outraResposta ?? throw new ArgumentNullException(nameof(outraResposta));
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.XML)
            {
                Console.WriteLine($"<conta><titular>{conta.Nome}</titular><saldo>{conta.Saldo}</saldo></conta>");
            }
            else
            {
                OutraResposta.Responde(requisicao, conta);
            }
        }
    }
}
