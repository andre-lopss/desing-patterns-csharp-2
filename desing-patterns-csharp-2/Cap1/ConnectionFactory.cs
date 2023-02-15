using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desing_patterns_csharp_2.Cap1
{
    class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root; Password=;Server=(localdb)\\mssqllocaldb;Database=MeuBanco";
            conexao.Open();
            return conexao;
        }
    }
}
