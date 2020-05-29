using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Conexao
{
    public class Conexao
    {

        SqlConnection conexaoSql = new SqlConnection();
        public Conexao ()
        {
            conexaoSql.ConnectionString = @"";
        }

        public SqlConnection conectar()
        {
            if(conexaoSql.State == System.Data.ConnectionState.Closed)
            {
                conexaoSql.Open();
            }
            return conexaoSql;
        }

        public void desconectar ()
        {
            if(conexaoSql.State == System.Data.ConnectionState.Open)
            {
                conexaoSql.Close();
            }
        }

    }
}
