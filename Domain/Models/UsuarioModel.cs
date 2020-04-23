using Domain.Enum;

namespace Domain.Models
{
    public class UsuarioModel
    {
        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public string Usuario { get; set; }

        public string Senha { get; set; }

        public string ConfirmarSenha { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public int Idade { get; set; }

        public NivelPermissaoEnum IdNivelPermissao { get; set; }
    }
}
