using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Conexao
{
    class LoginConexaoComandos
    {
        public bool Tem = false;
        public String mensagem = ""; // Estando tudo certo msg ficara fazia.
        SqlCommand comandoVerificar = new SqlCommand();
        Conexao conexaoSql = new Conexao();
        SqlDataReader DataReader;

        public bool verificarLogin (String login, String senha)
        {
            //Comando varificar no banco de dados
            comandoVerificar.CommandText = "select * from nomeDaTabela where email = @login and senha = @senha";
            comandoVerificar.Parameters.AddWithValue("@login", login);
            comandoVerificar.Parameters.AddWithValue("@senha", senha);

            try
            {
                comandoVerificar.Connection = conexaoSql.conectar();
                DataReader = comandoVerificar.ExecuteReader();
                if(DataReader.HasRows) // Verifica se encontrou alguma info do BD.
                {
                    Tem = true;
                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro na conexão com banco de dados!";
            }
            return Tem;
        }








        public String cadastrar (String email, String senha, String confirmarSenha) 
        {
            //Comando para inserir no banco
            return mensagem; 
        }
    
    }
}
