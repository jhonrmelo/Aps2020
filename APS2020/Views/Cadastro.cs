using Domain.Enum;
using Domain.Models;

using Service;

using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS2020.Views
{
    public partial class Cadastro : Form
    {
        private UsuarioService _usuarioService;
        public Cadastro()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();
        }

        private void btnCadastrar_Click(object sender, System.EventArgs e)
        {
            UsuarioModel model = new UsuarioModel();
            try
            {
                model.Nome = txtNome.Text;
                model.Login = txtUsuario.Text;
                model.Senha = txtSenha.Text;
                model.ConfirmarSenha = txtConfirmarSenha.Text;
                model.Email = txtEmail.Text;
                model.Idade = int.Parse(txtIdade.Text);
                model.Telefone = txtTelefone.Text;
                model.IdNivelPermissao = (NivelPermissaoEnum)Convert.ToInt32(comboNivelPermissao.SelectedValue);

                _usuarioService.CriarUsuario(model);

            }
            catch (ArgumentException arg)
            {
                //throw arg.Message;
            }
        }

    }
}
