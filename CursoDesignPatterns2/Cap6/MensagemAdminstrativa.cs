using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap6
{
    public class MensagemAdminstrativa : IMensagem
    {
        public string Nome { get; private set; }
        public IEnviador Enviador { get; set; }


        public MensagemAdminstrativa(string nome)
        {
            Nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Mensagem para o administrador {0}", Nome);
        }
    }
}
