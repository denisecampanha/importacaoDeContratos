using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ImportacaoDeContratos.Repositorios
{
    public class DbConexao : IDisposable
    {
        private readonly IDbConnection connection;

        public DbConexao()
        {
            string connectionString = "Server=192.168.100.118; Port=1433; Database=projeto_teste; User ID=root;Password=1234;";

            connection = new SqlConnection(connectionString);
        }

        public IDbConnection GetConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }


        public void Dispose()
        {
            connection?.Dispose();
        }
    }
}
