using Domain.Enum;

using System.Collections.Generic;

namespace Domain.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string ConfirmarSenha { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public int Idade { get; set; }

        public List<NivelPermissaoModel> Permissoes { get; set; }

        public NivelPermissaoEnum IdNivelPermissao { get; set; }
    }
}
