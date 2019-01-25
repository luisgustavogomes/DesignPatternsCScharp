using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class Filtro
    {
        private readonly Filtro OutroFiltro;

        protected Filtro(Filtro outroFiltro)
        {
            OutroFiltro = outroFiltro ?? throw new ArgumentNullException(nameof(outroFiltro));
        }

        protected Filtro()
        {
            OutroFiltro = null;
        }

        public abstract IList<Conta> Filtra(IList<Conta> contas);

        protected IList<Conta> Proximo(IList<Conta> contas)
        {
            if (contas == null)
            {
                return new List<Conta>();
            }
            return OutroFiltro.Filtra(contas);
        }
    }
}
