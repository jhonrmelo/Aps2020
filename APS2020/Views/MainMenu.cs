using Domain.Enum;

using System;
using System.Windows.Forms;

namespace APS2020.Views
{
    public partial class MainMenu : Form
    {
        private NivelPermissaoEnum _permissao;

        public MainMenu(NivelPermissaoEnum permisao)
        {
            _permissao = permisao;
            InitializeComponent();
            _setEvents();
        }

        private void _setEvents()
        {
            menuItemUsuarioCadatro.Click += new System.EventHandler(_openCadastro);
            menuItemMensagem.Click += new System.EventHandler(_openMensagens);
        }

        private void _openCadastro(object sender, System.EventArgs e)
        {
            Hide();
            new Cadastro().ShowDialog();
        }
        private void _openMensagens(object sender, System.EventArgs e)
        {
            Hide();
            if (_permissao == NivelPermissaoEnum.Cliente)
                new MensagemCliente().ShowDialog();
            else
                new MensagemServidor().ShowDialog();


        }


    }
}
