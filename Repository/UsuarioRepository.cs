using Dapper;

using Domain.Models;

using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class UsuarioRepository : DbConn
    {
        public int CriarUsuario(UsuarioModel model)
        {
            model.IdNivelPermissao = Domain.Enum.NivelPermissaoEnum.Cliente;

            string sqlQuery = @"INSERT INTO usuario 
                                VALUES(0, @Nome, @Login, @Senha, @Email, @Telefone, @Idade, @IdNivelPermissao); 
                                SELECT LAST_INSERT_ID();";

            return conn.Query<int>(sqlQuery, model).Single();
        }

        public List<NivelPermissaoModel> GetNivelPermissao()
        {
            string sqlQuery = @"SELECT Id, NomePermissao 
                                FROM NivelPermissao";

            return conn.Query<NivelPermissaoModel>(sqlQuery).ToList();
        }

        public UsuarioModel GetUsuarioByLogin(string login, string senha)
        {
            string sqlQuery = @"SELECT * FROM Usuario where Login = @login and Senha = @senha";

            return conn.Query<UsuarioModel>(sqlQuery, new { login, senha }).FirstOrDefault(); ;
        }

        public List<NivelPermissaoModel> GetNiveisPermissaoByUsuarioId(int usuarioId)
        {
            string sqlQuery = @"SELECT np.Id, NomePermissao 
                                FROM NivelPermissao np
                                JOIN UsuarioXPermissoes up 
                                     ON up.PermissaoId = np.Id
                                WHERE up.UsuarioId = @usuarioId";

            return conn.Query<NivelPermissaoModel>(sqlQuery, new { usuarioId }).ToList();
        }
    }
}
