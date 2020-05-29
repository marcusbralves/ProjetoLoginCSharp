using ProjetoLogin.Conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLogin.Modelo
{
    public class Controle
    {
        public bool Tem;
        public String mensagem = "";

        public bool acessar(String login, String senha)
        {
            LoginConexaoComandos loginConexao = new LoginConexaoComandos();
            Tem = loginConexao.verificarLogin(login, senha);

            if(!loginConexao.mensagem.Equals(""))
            {
                this.mensagem = loginConexao.mensagem;

            }
            return Tem;
        }

    public String cadastrar(String email, String senha, String confirmarSenha)
        {
            return mensagem;
        }
    }
}
