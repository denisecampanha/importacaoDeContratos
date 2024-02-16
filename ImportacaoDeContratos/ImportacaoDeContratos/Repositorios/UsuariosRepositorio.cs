using ImportacaoDeContratos.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Collections;

namespace ImportacaoDeContratos.Repositorios
{
    public class UsuariosRepositorio
    {
        public IEnumerable<Usuarios> BuscarUsuarioPorLogin(string login, string senha)
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();

            return conexao.Query<Usuarios>(@"SELECT * FROM USUARIOS WHERE LOGIN = @login AND SENHA = @senha",
                new { 
                    login,
                    senha
                });

        }
    }
}
