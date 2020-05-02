using Domain.Enum;
using System.Net.Sockets;
using System.Windows.Forms;

namespace APS2020.Views
{
    public partial class MensagemCliente : Form
    {
        private TcpClient _tcpClient;
        public MensagemCliente()
        {
            InitializeComponent();
        }

        private void lklVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new MainMenu(NivelPermissaoEnum.Cliente).ShowDialog();
        }
    }
}
