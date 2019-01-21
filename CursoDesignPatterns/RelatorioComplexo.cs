using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns
{
    public class RelatorioComplexo : TemplateRelatorioBancario
    {
        internal override void CabecalhoRelatorio()
        {
            Console.WriteLine("Banco XYZ" +
                "\nAvenida Paulista, 1234" +
                "\nFone:(11) 1234-5678");
        }

        internal override void CorpoRelatorio(IList<Conta> contas)
        {
            contas.ToList().ForEach(c => Console.WriteLine(c));
        }

        internal override void Rodape()
        {
            Console.WriteLine("Direitos reservados \nEmail: luisgustavogomes@outlook.com \n" + DateTime.Now);
        }
    }
}