using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap1
{
    public class ConnectionFactory :IDisposable
    {
        private readonly IDbConnection conexao;

        public ConnectionFactory()
        {
            conexao = new SqlConnection
            {
                ConnectionString = "User id=root;Password=;Server=localhost;Database=meubanco"
            };
        }

        public IDbConnection GetConnection()
        {
            conexao.Open();
            return conexao;
        }

        public void Dispose()
        {
            conexao.Close();
        }

    }
}
