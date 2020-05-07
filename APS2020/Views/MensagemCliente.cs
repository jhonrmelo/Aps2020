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
            Hide();
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
    }
}
