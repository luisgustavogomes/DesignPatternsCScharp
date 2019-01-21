using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns
{
    public abstract class TemplateRelatorioBancario
    {
        public void Imprimir(IList<Conta> contas)
        {
            CabecalhoRelatorio();
            CorpoRelatorio(contas);
            Rodape();
        }

        internal abstract void Rodape();
        internal abstract void CorpoRelatorio(IList<Conta> contas);
        internal abstract void CabecalhoRelatorio();
    }

}