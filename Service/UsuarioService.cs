using Domain.Models;
using Repository;
using System;

namespace Service
{
    public class UsuarioService
    {
        private readonly UsuarioRepository _usuarioRepositorio;
            
        public UsuarioService(UsuarioRepository usuarioRepository)
        {
            _usuarioRepositorio = usuarioRepository;
        }
 
        public void CriarUsuario(UsuarioModel model)
        {           

            if (model.Senha != model.ConfirmarSenha)
                throw new ArgumentException("As senhas não correspondem");

            model.UsuarioId = _usuarioRepositorio.CriarUsuario(model);

        }
    }
}
