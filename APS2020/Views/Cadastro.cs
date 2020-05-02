using Domain.Enum;
using Domain.Models;

using Service;

using System;
using System.Net.Sockets;
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
            try
            {
                var usuario = _fillUsuario();
                _fillPermissoes(usuario);
                _usuarioService.CriarUsuario(usuario);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void _fillPermissoes(UsuarioModel usuario)
        {
            if (checkBoxCliente.Checked)
                usuario.Permissoes.Add(new NivelPermissaoModel((int)NivelPermissaoEnum.Cliente));

            if (checkBoxCliente.Checked)
                usuario.Permissoes.Add(new NivelPermissaoModel((int)NivelPermissaoEnum.Servidor));
        }

        private UsuarioModel _fillUsuario()
        {
            UsuarioModel usuario = new UsuarioModel();

            usuario.Nome = txtNome.Text;
            usuario.Sobrenome = txtNome.Text;
            usuario.Login = txtUsuario.Text;
            usuario.Senha = txtSenha.Text;
            usuario.ConfirmarSenha = txtConfirmarSenha.Text;
            usuario.Email = txtEmail.Text;
            usuario.Idade = int.Parse(txtIdade.Text);
            usuario.Telefone = txtTelefone.Text;

            return usuario;
        }

        private void lblNivelPermissao_Click(object sender, EventArgs e)
        {

        }

        private void lblVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            //Somente servidores podem entrar na tela de cadastro, logo devolvemos como servidor
            new MainMenu(NivelPermissaoEnum.Servidor).ShowDialog();
        }
    }
}
