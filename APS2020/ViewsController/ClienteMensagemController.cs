using APS2020.Views;

using Domain.Enum;
using Domain.Models;

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

using Util;

namespace APS2020.ViewsController
{
    public class ClienteMensagemController
    {
        MensagemCliente _mensagemClienteView;
        private Socket clientSocket;
        private byte[] buffer;
        public ClienteMensagemController(MensagemCliente mensagemClienteView)
        {
            _mensagemClienteView = mensagemClienteView;
            _connectClient();
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
                _callError(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                _callError(ex.Message);
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

                MensagemModel mensagem = new MensagemModel(recBuf);

                _verifyAcaoMensagem(mensagem);

                clientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ReceiveCallback, null);
            }

            catch (SocketException ex)
            {
                _callError(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                _callError(ex.Message);
            }
        }

        private void _callError(string message)
        {
            _mensagemClienteView.ShowErrorDialog(message);
        }

        public void SendToServer(string text)
        {
            MensagemModel message = new MensagemModel(AcaoMensagemEnum.EnviarTexto, text);
            byte[] buffer = message.ToByteArray();
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
                _callError(ex.Message);
            }
            catch (ObjectDisposedException ex)
            {
                _callError(ex.Message);
            }
        }


        public void SendDesconectRequest()
        {
            MensagemModel message = new MensagemModel(AcaoMensagemEnum.Desconectar, string.Empty);
            byte[] buffer = message.ToByteArray();
            clientSocket.BeginSend(buffer, 0, buffer.Length, SocketFlags.None, SendCallback, null);
        }

        private void _verifyAcaoMensagem(MensagemModel message)
        {
            if (message.Acao == AcaoMensagemEnum.EnviarTexto)
            {
                _mensagemClienteView.ShowMessageByTcp(message.Text);
            }
            else if (message.Acao == AcaoMensagemEnum.TerminarTransmissao)
            {
                _mensagemClienteView.Desconectar();
            }
        }
    }
}
