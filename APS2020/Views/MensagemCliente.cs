using APS2020.ViewsUitl;

using Domain.Enum;

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

using Util;

namespace APS2020.Views
{
    public partial class MensagemCliente : Form
    {
        private Socket clientSocket;
        private byte[] buffer;
        public MensagemCliente()
        {
            InitializeComponent();
            _connectClient();
        }

        private void lklVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new MainMenu(NivelPermissaoEnum.Cliente).ShowDialog();
        }

        private void _connectClient()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            var endPoint = new IPEndPoint(IPAddress.Parse(Config.LocalIp), 3333);
            clientSocket.BeginConnect(endPoint, ConnectCallback, null);
        }

        private void ConnectCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndConnect(AR);
                buffer = new byte[clientSocket.ReceiveBufferSize];
                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void ReceiveCallback(IAsyncResult AR)
        {
            try
            {
                int received = clientSocket.EndReceive(AR);

                if (received == 0)
                {
                    return;
                }

                byte[] recBuf = new byte[received];
                Array.Copy(buffer, recBuf, received);
                string message = Encoding.ASCII.GetString(recBuf);

                InvokeUtil.SafeInvoke(txtRecebido, delegate
                 {
                     txtRecebido.Text += MensagensHelper.FormataMensagemServidor(message);
                 }, true);

                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
            }

            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string textToSend = txtEnviado.Text;
            txtEnviado.Clear();
            byte[] buffer = Encoding.ASCII.GetBytes(textToSend);
            clientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, SendCallback, null);
        }

        private void SendCallback(IAsyncResult AR)
        {
            try
            {
                clientSocket.EndSend(AR);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }
    }
}
