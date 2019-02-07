using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap7
{
    public class FilaDeTrabalho
    {
        private IList<IComando> ComandosPedidos { get; }

        public FilaDeTrabalho()
        {
            ComandosPedidos = new List<IComando>();
        }

        public void Adiciona(IComando comando)
        {
            ComandosPedidos.Add(comando);
        }

        public void Processa() => ComandosPedidos.ToList().ForEach(c => c.Executa());
    }
}
