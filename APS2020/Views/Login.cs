using Domain.Enum;

using Service;

using System;
using System.Windows.Forms;

namespace APS2020.Views
{
    public partial class Login : Form
    {
        private UsuarioService _usuarioService;
        public Login()
        {
            _usuarioService = new UsuarioService();
            InitializeComponent();
            _loadComboPermissao();
        }

        private void _loadComboPermissao()
        {
            cbbNivelPermissao.DataSource = _usuarioService.GetNivelPermissao();
            cbbNivelPermissao.ValueMember = "Id";
            cbbNivelPermissao.DisplayMember = "NomePermissao";

        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                var permissao = (NivelPermissaoEnum)cbbNivelPermissao.SelectedValue;
                _usuarioService.VerifyUserLogin(txtLogin.Text, txtSenha.Text, permissao);
                Hide();
                new MainMenu(permissao).ShowDialog();
            }
            catch (ArgumentException arg)
            {
                MessageBox.Show(arg.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
