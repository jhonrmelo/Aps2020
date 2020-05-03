using Domain.Enum;
using Repository;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

using Util;

namespace APS2020.Views
{
    public partial class MensagemServidor : Form
    {
        private Socket _serverSocket;
        private List<Socket> _lstSocket;
        private byte[] buffer;
        public MensagemServidor()
        {
            InitializeComponent();
            _startServer();
        }

        private void lklVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new MainMenu(NivelPermissaoEnum.Servidor).ShowDialog();
        }

        private void ShowErrorDialog(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void _startServer()
        {
            try
            {
                _lstSocket = new List<Socket>();
                _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _serverSocket.Bind(new IPEndPoint(IPAddress.Any, Config.MessagePort));
                _serverSocket.Listen(10);
                _serverSocket.BeginAccept(AcceptCallback, null);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }
        private void AcceptCallback(IAsyncResult AR)
        {
            try
            {
                Socket current = _serverSocket.EndAccept(AR);

                _lstSocket.Add(current);

                buffer = new byte[current.ReceiveBufferSize];

                var sendData = Encoding.ASCII.GetBytes("Servidor Conectado");

                current.BeginSend(sendData, 0, sendData.Length, SocketFlags.None, SendCallback, current);

                current.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, current);

                _serverSocket.BeginAccept(AcceptCallback, null);
            }
            catch (SocketException ex)
            {
                ShowErrorDialog(ex.Message);
            }
        }

        private void SendCallback(IAsyncResult AR)
        {
            try
            {
                Socket current = (Socket)AR.AsyncState;

                current.EndSend(AR);
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
                Socket current = (Socket)AR.AsyncState;

                int received = current.EndReceive(AR);

                if (received == 0)
                {
                    return;
                }

                byte[] recBuf = new byte[received];
                Array.Copy(buffer, recBuf, received);
                string message = Encoding.ASCII.GetString(recBuf);

                //Para não termos problemas de thread
                Invoke((Action)delegate
                {
                    txtRecebido.Text += MensagensHelper.FormataMensagemCliente(message);
                });


                current.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, current);
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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string textToSend = txtEnviado.Text;
            byte[] buffer = Encoding.ASCII.GetBytes(textToSend);
            txtEnviado.Clear();
            foreach (var socket in _lstSocket)
            {
                socket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, SendCallback, socket);
            }
        }
    }
}
