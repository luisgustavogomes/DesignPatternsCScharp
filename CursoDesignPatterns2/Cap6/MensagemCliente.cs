using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap6
{
    public class MensagemCliente : IMensagem
    {
        public string Nome { get; private set; }
        public IEnviador Enviador { get; set; }

        public MensagemCliente(string nome)
        {
            Nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Mensagem para o cliente {0}", Nome);
        }
    }
}
