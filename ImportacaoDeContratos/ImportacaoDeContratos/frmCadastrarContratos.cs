using ImportacaoDeContratos.Classes;
using ImportacaoDeContratos.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace ImportacaoDeContratos
{
    public partial class frmCadastrarContratos : Form
    {
        #region CONSTRUTOR
        public frmCadastrarContratos()
        {
            InitializeComponent();
            Personaliza();
        }

        #endregion


        #region METODOS

        private void Personaliza()
        {
            //personalizaTela
            //implementar
        }

        private void SelecionaArquivo()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Selecione um arquivo";

                dialog.Filter = "Arquivos de Texto|*.csv|Todos os Arquivos|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    string caminhoDoArquivoSelecionado = dialog.FileName;

                    txtArquivo.Text = caminhoDoArquivoSelecionado;

                }
            }
        }

        private void SalvarArquivo()
        {
            var arquivo = new Arquivos(0, txtArquivo.Text, DateTime.Now.ToString(), "padrao");

            var arquivosRepositorio = new ArquivosRepositorio();
            arquivosRepositorio.Inserir(arquivo);

        }
        private void SalvarContratos()
        {
            string caminhoDoArquivo = txtArquivo.Text;

            if (File.Exists(caminhoDoArquivo))
            {
                LerArquivoCsv(caminhoDoArquivo);
                MessageBox.Show("Contratos Salvo com Sucesso!");
                txtArquivo.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Caminho não encontrado!");
            }
        }

        private void LerArquivoCsv(string caminhoDoArquivoCsv)
        {
            using (TextFieldParser parser = new TextFieldParser(caminhoDoArquivoCsv))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");

                bool primeiraLinha = true;

                // Lê as linhas do arquivo
                while (!parser.EndOfData)
                {
                    // Obtém os campos da linha atual
                    string[] campos = parser.ReadFields();

                    if (primeiraLinha)
                    {
                        primeiraLinha = false;
                        continue;
                    }

                    string strNome = campos[0];
                    string strCPF = campos[1];
                    string strContrato = campos[2];
                    string strProduto = campos[3];
                    string strVencimento = campos[4];
                    string strValor = campos[5];

                    var contrato = new Contratos(0,strNome,strCPF,strContrato,strProduto,strVencimento, strValor);

                    var contratoRepositorio = new ContratosRepositorio();
                    contratoRepositorio.Inserir(contrato);

                }
            }
        }

        #endregion

        #region EVENTOS
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPesquisaArquivos frmPesquisaArquivos = new frmPesquisaArquivos();

            frmPesquisaArquivos.Show();
        }

        private void btnPesqContratos_Click(object sender, EventArgs e)
        {

            frmPesquisaContratos frmPesquisaContratos = new frmPesquisaContratos();

            frmPesquisaContratos.Show();

        }

        private void btnPesqContratosCliente_Click(object sender, EventArgs e)
        {

            frmPesquisaContratosCliente frmPesquisaContratosCliente = new frmPesquisaContratosCliente();

            frmPesquisaContratosCliente.Show();
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            SelecionaArquivo();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            SalvarArquivo();
            SalvarContratos();         
        }

        #endregion
    }
}
