using System;

namespace Util
{
    public static class MensagensHelper
    {
        public static string FormataMensagemCliente(string text)
        {
            return $"{Environment.NewLine} Recebido do cliente: {text} "; 
        }

        public static string FormataMensagemServidor(string text)
        {
            return $"{Environment.NewLine} Recebido do servidor: {text} ";
        }
    }
}
