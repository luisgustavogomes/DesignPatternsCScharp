using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class FiltraSaldoMaiorQuinhentos : Filtro
    {
        public FiltraSaldoMaiorQuinhentos(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltraSaldoMaiorQuinhentos() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (var c in contas)
            {
                if (c.Saldo > 500) filtrada.Add(c);
            }
            foreach (var c in Proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }

    }
}
