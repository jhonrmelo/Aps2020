using Dapper.Contrib.Extensions;

namespace Domain
{
    [Table("usuarioxpermissoes")]
    public class UsuarioXPermissaoModel
    {
        public UsuarioXPermissaoModel(int pUsuarioID , int pPermissaoID)
        {
            UsuarioId = pUsuarioID;
            PermissaoId = pPermissaoID;
        }

        [ExplicitKey]
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PermissaoId { get; set; }
    }
}
