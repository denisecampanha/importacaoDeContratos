using ImportacaoDeContratos.Classes;
using ImportacaoDeContratos.Repositorios;
using Microsoft.VisualBasic.Logging;

namespace ImportacaoDeContratos
{
    public partial class frmLogin : Form
    {

        #region CONSTRUTOR
        public frmLogin()
        {
            InitializeComponent();
            Personaliza();
        }

        #endregion

        #region METODOS

        private void Personaliza()
        {
            //personaliza Tela, implementar.
        }

        private bool ValidaLogin()
        {

            UsuariosRepositorio usuariosRepositorio = new UsuariosRepositorio();

            bool boOk = false;
            string usuarioLogin = string.Empty;
            string usuarioSenha = string.Empty;

            if (txtLogin.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                IEnumerable<Usuarios> ListUsuarios = usuariosRepositorio.BuscarUsuarioPorLogin(txtLogin.Text, txtSenha.Text);

                usuarioSenha = string.Join(",", ListUsuarios.Select(u => u.Login));
                usuarioLogin = string.Join(",", ListUsuarios.Select(u => u.Senha));

                if (txtLogin.Text.Trim() == usuarioLogin && txtSenha.Text.ToString() == usuarioSenha)
                {
                    boOk = true;
                }

                else
                {
                    MessageBox.Show("Login ou Senha inválido!");
                    boOk = false;
                }
            }

            else
            {
                MessageBox.Show("Campo Login ou Senha vazio!");
                boOk = false;
            }

            return boOk;

        }

        #endregion

        #region EVENTOS

        #endregion
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
           if (this.ValidaLogin())
           {
                frmCadastrarContratos frmCadastrarContratos = new frmCadastrarContratos();
                frmCadastrarContratos.Show();

           }

        }
    }
}
