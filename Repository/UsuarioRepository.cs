using Dapper;
using Domain.Models;
using System.Linq;

namespace Repository
{
    public class UsuarioRepository : DbConn
    {
        public int CriarUsuario(UsuarioModel model)
        {
            model.IdNivelPermissao = Domain.Enum.NivelPermissaoEnum.Cliente;

            string sqlQuery = "INSERT INTO usuario VALUES(0, @Nome, @Usuario, @Senha, @Email, @Telefone, @Idade, @IdNivelPermissao); SELECT LAST_INSERT_ID();";

            return conn.Query<int>(sqlQuery, model).Single();
        }
    }
}
