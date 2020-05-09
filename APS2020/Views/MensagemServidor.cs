using APS2020.ViewsController;
using APS2020.ViewsUitl;

using Domain.Enum;
using System;
using System.Windows.Forms;
using Util;

namespace APS2020.Views
{
    public partial class MensagemServidor : Form
    {
        ClienteServidorController _clienteServidorController;

        public MensagemServidor()
        {
            _clienteServidorController = new ClienteServidorController(this);
            InitializeComponent();
        }

        private void lklVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new MainMenu(NivelPermissaoEnum.Servidor).ShowDialog();
        }

        public void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowMessageByTcp(string text)
        {
            InvokeUtil.SafeInvoke(txtRecebido, delegate
            {
                txtRecebido.Text += MensagensHelper.FormataMensagemCliente(text);
            }, true);

        }

        public void ShowStandardMessage(string text)
        {
            InvokeUtil.SafeInvoke(txtRecebido, delegate
            {
                txtRecebido.Text += MensagensHelper.AddMessage(text);
            }, true);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string textToSend = txtEnviado.Text;
            txtEnviado.Clear();
            _clienteServidorController.SendToClients(textToSend);
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            _clienteServidorController.DesconectAllClients();
        }
    }
}
