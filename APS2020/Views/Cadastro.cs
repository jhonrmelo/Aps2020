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
        private readonly UsuarioService service;

        public Cadastro()
        {
            InitializeComponent();
            this.service = new UsuarioService(new Repository.UsuarioRepository());
        }

        private async void btnCadastrar_Click(object sender, System.EventArgs e)
        {
            UsuarioModel model = new UsuarioModel();
            try
            {
                model.Nome = txtNome.Text;
                model.Usuario = txtUsuario.Text;
                model.Senha = txtSenha.Text;
                model.ConfirmarSenha = txtConfirmarSenha.Text;
                model.Email = txtEmail.Text;
                model.Idade = int.Parse(txtIdade.Text);
                model.Telefone = txtTelefone.Text;
                model.IdNivelPermissao = (NivelPermissaoEnum)Convert.ToInt32(comboNivelPermissao.SelectedValue);

                await Task.Run(() => { this.service.CriarUsuario(model); });

            }
            catch (ArgumentException arg)
            {
                //throw arg.Message;
            }
        }

    }
}
