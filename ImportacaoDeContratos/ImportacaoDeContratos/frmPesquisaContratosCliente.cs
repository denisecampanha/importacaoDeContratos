using ImportacaoDeContratos.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ImportacaoDeContratos
{
    public partial class frmPesquisaContratosCliente : Form
    {
        #region  CONSTRUTOR
        public frmPesquisaContratosCliente()
        {
            InitializeComponent();
            Personaliza();
        }

        #endregion

        #region  METODOS

        private void Personaliza()
        {
            //personalizar a tela
            //metodo nao implementado
        }

        private void PopulaGrid()
        {
            ContratosRepositorio contratosRepositorio = new ContratosRepositorio();

            if (txtNome.Text.ToString() != string.Empty)
            {
                var contratosCliente = contratosRepositorio.BuscarContratoPeloNome(txtNome.Text.ToString());

                grdContratosCliente.DataSource = contratosCliente;

                CalculaValor();

                CalculaMaiorAtraso();
            }
            else 
            {
                MessageBox.Show("Filtro da Pesquisa não informado!");
            }
        }

        private void CalculaValor()
        {
            decimal somaDaColunaValor = 0;

            foreach (DataGridViewRow linha in grdContratosCliente.Rows)
            {
                if (linha.Cells.Count > 5 && linha.Cells[5].Value != null)
                {
                    decimal valorDaCelula;
                    if (decimal.TryParse(linha.Cells[5].Value.ToString(), out valorDaCelula))
                    {
                        somaDaColunaValor += valorDaCelula;
                    }
                }
            }

            txtValorTotal.Text = somaDaColunaValor.ToString();

        }

        private void CalculaMaiorAtraso()
        {
            decimal maiorAtrasoDias = 0;

            foreach (DataGridViewRow linha in grdContratosCliente.Rows)
            {
                if (linha.Cells.Count > 4 && linha.Cells[4].Value != null)
                {
                    if (DateTime.TryParse(linha.Cells[4].Value.ToString(), out DateTime dataNoVencimento))
                    {
                        decimal atrasoDias = (decimal)(DateTime.Now - dataNoVencimento).TotalDays;

                        if (atrasoDias > maiorAtrasoDias)
                        {
                            maiorAtrasoDias = atrasoDias;
                        }
                    }
                }
            }

            txtMaiorAtraso.Text = maiorAtrasoDias.ToString();
        }

        private void LimparCampos()
        {
            grdContratosCliente.DataSource = null;
            grdContratosCliente.Rows.Clear();
            txtNome.Text = string.Empty;
            txtValorTotal.Text = string.Empty;
            txtMaiorAtraso.Text = string.Empty;
        }

        #endregion

        #region EVENTOS

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PopulaGrid();
        }

        #endregion 
    }
}
