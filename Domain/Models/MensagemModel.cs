using Domain.Enum;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Models
{
    public class MensagemModel
    {
        public MensagemModel() { }

        public MensagemModel(AcaoMensagemEnum pAcao, string pText)
        {
            Acao = pAcao;
            Text = pText;
            TextSize = Text.Count();
        }
        public MensagemModel(byte[] bufferMensagem)
        {
            Acao = (AcaoMensagemEnum)BitConverter.ToInt32(bufferMensagem, 0);
            TextSize = BitConverter.ToInt32(bufferMensagem, 4);
            Text = Encoding.ASCII.GetString(bufferMensagem, 8, TextSize);
        }
        public AcaoMensagemEnum Acao { get; set; }
        public string Text { get; set; }
        public int TextSize { get; set; }

        public byte[] ToByteArray()
        {
            List<byte> byteList = new List<byte>();
            byteList.AddRange(BitConverter.GetBytes((int)Acao));
            byteList.AddRange(BitConverter.GetBytes(TextSize));
            byteList.AddRange(Encoding.ASCII.GetBytes(Text));

            return byteList.ToArray();
        }
    }
}
