using APS2020.ViewsController;
using APS2020.ViewsUitl;

using Domain.Enum;

using System;
using System.Windows.Forms;

using Util;

namespace APS2020.Views
{
    public partial class MensagemCliente : Form
    {
        ClienteMensagemController _clienteMensagemController;
        public MensagemCliente()
        {
            InitializeComponent();
            _clienteMensagemController = new ClienteMensagemController(this);
        }

        private void lklVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _clienteMensagemController.SendDesconectRequest();
            _getBackMenu();
        }

        private void _getBackMenu()
        {
            InvokeUtil.SafeInvoke(this, delegate
            {
                Hide();
            }, true);

            new MainMenu(NivelPermissaoEnum.Cliente).ShowDialog();
        }
        public void ShowMessageByTcp(string text)
        {
            InvokeUtil.SafeInvoke(txtRecebido, delegate
            {
                txtRecebido.Text += MensagensHelper.FormataMensagemServidor(text);
            }, true);

        }
        public void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string textToSend = txtEnviado.Text;
            txtEnviado.Clear();
            _clienteMensagemController.SendToServer(textToSend);

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            Desconectar();
        }

        public void Desconectar()
        {
            _clienteMensagemController.SendDesconectRequest();
            MessageBox.Show("Desconectado do servidor, voltando para o menu!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            _getBackMenu();
        }
    }
}
