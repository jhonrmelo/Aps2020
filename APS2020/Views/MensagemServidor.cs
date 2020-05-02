using Domain.Enum;
using System.Net.Sockets;
using System.Windows.Forms;

namespace APS2020.Views
{
    public partial class MensagemServidor : Form
    {
        private Socket _serverSocket;
        public MensagemServidor()
        {
            InitializeComponent();
        }

        private void lklVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new MainMenu(NivelPermissaoEnum.Servidor).ShowDialog();
        }
    }
}
