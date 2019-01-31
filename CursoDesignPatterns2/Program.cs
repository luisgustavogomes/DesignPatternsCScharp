using CursoDesignPatterns2.Cap1;
using CursoDesignPatterns2.Cap2;
using CursoDesignPatterns2.Cap3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var contrato = new Contrato(DateTime.Now, "luis");
            Console.WriteLine(contrato);
            contrato.Avanca();
            Console.WriteLine(contrato);
            contrato.Avanca();
            Console.WriteLine(contrato);
            contrato.Avanca();
            Console.WriteLine(contrato);

            Console.WriteLine("\n================================");
            foreach (var item in contrato.Historico.Contratos)
            {
                Console.WriteLine(item);
            }

        }

        private static void Flyweight1()
        {
            var notasMusicais = new NotasMusicais();
            var musica = new List<INota>()
            {
                notasMusicais.Get("do"),
                notasMusicais.Get("re"),
                notasMusicais.Get("mi"),
                notasMusicais.Get("fa"),
                notasMusicais.Get("fa"),
                notasMusicais.Get("fa"),
                
                notasMusicais.Get("do"),
                notasMusicais.Get("re"),
                notasMusicais.Get("do"),
                notasMusicais.Get("re"),
                notasMusicais.Get("re"),
                notasMusicais.Get("re"),
                
                notasMusicais.Get("do"),
                notasMusicais.Get("sol"),
                notasMusicais.Get("fa"),
                notasMusicais.Get("mi"),
                notasMusicais.Get("mi"),
                notasMusicais.Get("mi"),
                
                notasMusicais.Get("do"),
                notasMusicais.Get("re"),
                notasMusicais.Get("mi"),
                notasMusicais.Get("fa"),
                notasMusicais.Get("fa"),
                notasMusicais.Get("fa")
            };

            var piano = new Piano();
            piano.Toca(musica);
        }

        private static void Factory1()
        {
            using (var conexao = new ConnectionFactory().GetConnection())
            {
                var comando = conexao.CreateCommand();
                comando.CommandText = "select * from pessoa";
                comando.ExecuteNonQuery();
            }

            Console.ReadLine();
        }
    }
}
