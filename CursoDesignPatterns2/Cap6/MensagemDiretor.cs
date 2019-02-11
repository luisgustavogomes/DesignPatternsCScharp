using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap6
{
    class MensagemDiretor : IMensagem
    {
        public IEnviador Enviador { get; set; }
        public string Nome { get; private set; }

        public MensagemDiretor(string nome)
        {
            Nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Mensagem para o diretor {0}", Nome);
        }
    }
}
