using Dapper;
using Dapper.Contrib.Extensions;
using Domain;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class UsuarioRepository : DbConn
    {
        public int CriarUsuario(UsuarioModel usuario)
        {
            string sqlQuery = @"INSERT INTO usuario 
                                VALUES(0, @Nome, @Sobrenome, @Login, @Senha, @Email, @Telefone, @Idade); 
                                SELECT LAST_INSERT_ID();";

            return conn.Query<int>(sqlQuery, usuario).Single();
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

        public void InsertPermissoesXUsuario(List<UsuarioXPermissaoModel> lstPermissoes)
        {
            conn.Insert(lstPermissoes);
        }

    }
}
