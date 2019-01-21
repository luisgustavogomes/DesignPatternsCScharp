using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns
{
    public class RelatorioSimples : TemplateRelatorioBancario
    {
        internal override void CabecalhoRelatorio()
        {
            Console.WriteLine("Banco x");
        }

        internal override void CorpoRelatorio(IList<Conta> contas)
        {
            contas.ToList().ForEach(c => Console.WriteLine(c.Nome + "-" + c.Saldo));
        }

        internal override void Rodape()
        {
            Console.WriteLine("Direitos reservados");
        }
    }
}