using ImportacaoDeContratos.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportacaoDeContratos
{
    public partial class frmPesquisaContratos : Form
    {
        #region CONSTRUTOR
        public frmPesquisaContratos()
        {
            InitializeComponent();
            Personaliza();
        }

        #endregion

        #region METODOS

        private void Personaliza()
        {
            //personalizar a tela
            //metodo nao implementado

        }
        private void PesquisaDados()
        {
            if (radTodos.Checked == true)
            {
                this.PopulaGrid("");
            }
            else if (radData.Checked == true)
            {
                //this.PopulaGrid(txtData.Text.ToString());
                MessageBox.Show("Rotina não implementada!");
            }
            else
            {
                MessageBox.Show("Selecionar um tipo de pesquisa!");
            }
        }


        private void PopulaGrid(string strData)
        {
            ContratosRepositorio contratosRepositorio = new ContratosRepositorio();

            var contratos = contratosRepositorio.BuscarTodosContratos();

            grdContratos.DataSource = contratos.ToList();
        }

        private void LimparDados()
        {
            grdContratos.DataSource = null;
            grdContratos.Rows.Clear();
            radTodos.Checked = false;
            radData.Checked = false;
            txtVecto.Text = string.Empty;
        }

        #endregion

        #region EVENTOS

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisaDados();
        }

        #endregion
    }
}
