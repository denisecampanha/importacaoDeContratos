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
    public partial class frmPesquisaArquivos : Form
    {

        #region CONSTRUTOR
        public frmPesquisaArquivos()
        {
            InitializeComponent();
            Personaliza();
        }

        #endregion

        #region METODOS

        private void Personaliza()
        {
            //personaliza a Tela
            //rotina não implementada.
        }
        private void PopulaGrid(string strData)
        {
            ArquivosRepositorio arquivosRepositorio = new ArquivosRepositorio();

            var arquivos = arquivosRepositorio.BuscarArquivos();

            grdArquivos.DataSource = arquivos.ToList();

        }

        private void LimparDados()
        {
            grdArquivos.DataSource = null;
            grdArquivos.Rows.Clear();
            radTodos.Checked = false;
            radData.Checked = false;
            txtData.Text = string.Empty;
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
