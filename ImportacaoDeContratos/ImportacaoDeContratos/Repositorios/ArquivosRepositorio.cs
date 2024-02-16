using ImportacaoDeContratos.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ImportacaoDeContratos.Repositorios
{
    public class ArquivosRepositorio
    {

        public IEnumerable<Arquivos> BuscarArquivos()
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();

            return conexao.Query<Arquivos>(@"SELECT * FROM ARQUIVOS");

        }

        public void Inserir(Arquivos arquivo)
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();

            conexao.Execute("INSERT INTO ARQUIVOS (ID, NOME_ARQUIVO, DATA, USUARIO) VALUES (@id,@nome,@data,@usuario);",
                new
                {
                    id = arquivo.Id,
                    nome = arquivo.Nome,
                    data = arquivo.Data,
                    usuario = arquivo.UsuarioImportacao
                });
        }
    }
}
