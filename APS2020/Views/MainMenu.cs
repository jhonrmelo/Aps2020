using Domain.Enum;
using System;
using System.Windows.Forms;

namespace APS2020.Views
{
    public partial class MainMenu : Form
    {
        public MainMenu(NivelPermissaoEnum permisao)
        {
            InitializeComponent();
            _loadMenuByPermissao(permisao);   
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void _loadMenuByPermissao(NivelPermissaoEnum permissao)
        {
            if (permissao == NivelPermissaoEnum.Servidor)
                menuItemMensagemCliente.Visible = false;
            else
                menuItemMensagemServidor.Visible = false;
        }

    }
}
