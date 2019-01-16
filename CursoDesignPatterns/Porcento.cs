using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Porcento : IResposta
    {
        public IResposta OutraResposta { get; set ; }

        public Porcento()
        {
        }

        public Porcento(IResposta outraResposta)
        {
            OutraResposta = outraResposta ?? throw new ArgumentNullException(nameof(outraResposta));
        }

        public void Responde(Requisicao requisicao, Conta conta)
        {
            if (requisicao.Formato == Formato.PORCENTO)
            {
                Console.WriteLine($"{conta.Nome}%{conta.Saldo}");
            }
            else if (OutraResposta == null)
            {
                OutraResposta.Responde(requisicao, conta);
            }
            else
            {
                throw new ArgumentException("Formato de resposta não encontrada");
            }
        }
    }
}
