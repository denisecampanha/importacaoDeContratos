using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImportacaoDeContratos.Classes;
using System.Diagnostics.Contracts;
using System.Drawing;

namespace ImportacaoDeContratos.Repositorios
{
    public class ContratosRepositorio
    {
        public void Inserir(Contratos contrato)
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();

            conexao.Execute("INSERT INTO CONTRATOS (NOME, CPF, CONTRATO, PRODUTO, VENCIMENTO, VALOR) VALUES (@nome,@cpf,@contrato,@produto,@vencimento,@valor);",
                new 
                { 
                    nome = contrato.Nome,
                    cpf = contrato.CPF,
                    contrato = contrato.Contrato,
                    produto = contrato.Produto,
                    vencimento = contrato.Vencimento,
                    valor = contrato.Valor
                });    
        }

        public void Atualizar(Contratos contrato)
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();

            conexao.Execute("UPDATE CONTRATOS SET NOME = @nome, CPF = @cpf, CONTRATO = @contrato, PRODUTO = @produto, VENCIMENTO = @vencimento, VALOR = @valor WHERE ID = @id;",
                new
                {
                    nome = contrato.Nome,
                    cpf = contrato.CPF,
                    contrato = contrato.Contrato,
                    produto = contrato.Produto,
                    vencimento = contrato.Vencimento,
                    valor = contrato.Valor,
                    id = contrato.Id
                });
        }

        public void Deletar(int id)
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();

            conexao.Execute("DELETE FROM CONTRATOS WHERE ID = @id;",
                new
                {
                    id
                });
        }

        public Contratos BuscarContratoPeloId(int id)
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();

            return conexao.QueryFirstOrDefault<Contratos>(@"SELECT * FROM CONTRATOS WHERE ID = @id",
                new { id });

        }

        public Contratos BuscarContratoPeloNome(string nome)
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();

            return conexao.QueryFirstOrDefault<Contratos>(@"SELECT * FROM CONTRATOS WHERE NOME LIKE %@nome%",
                new { nome });

        }

        public IEnumerable<Contratos> BuscarTodosContratos()
        {
            using SqlConnection conexao = (SqlConnection)new DbConexao().GetConnection();

            return conexao.Query<Contratos>(@"SELECT * FROM CONTRATOS");

        }

    }
}
