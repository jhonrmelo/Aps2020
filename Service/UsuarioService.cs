using Domain;
using Domain.Enum;
using Domain.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service
{
    public class UsuarioService
    {
        private  UsuarioRepository _usuarioRepository;

        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public void CriarUsuario(UsuarioModel usuario)
        {

            if (usuario.Senha != usuario.ConfirmarSenha)
                throw new ArgumentException("As senhas não correspondem");

            usuario.Id = _usuarioRepository.CriarUsuario(usuario);

            _insertPermissoes(usuario);
        }

        public List<NivelPermissaoModel> GetNivelPermissao()
        {
            return _usuarioRepository.GetNivelPermissao();
        }

        public void VerifyUserLogin(string login, string senha, NivelPermissaoEnum permissaoSelecionada)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
                throw new ArgumentException("Login ou Senha não preenchidos, Tente novamente!");

            UsuarioModel usuario = GetUsuario(login, senha);

            if (usuario == null)
                throw new ArgumentException("Login ou senha incorretos!");

            if (!VerifyPermissaoSelecionada(usuario.Permissoes, permissaoSelecionada))
                throw new ArgumentException("O nivel de permissão do usuário não contém a permissão selecionada");
        }

        public UsuarioModel GetUsuario(string login, string senha)
        {
            UsuarioModel usuario = _usuarioRepository.GetUsuarioByLogin(login, senha);
            
            if (usuario != null)
                usuario.Permissoes = _usuarioRepository.GetNiveisPermissaoByUsuarioId(usuario.Id);

            return usuario;
        }

        public bool VerifyPermissaoSelecionada(List<NivelPermissaoModel> lstPermissao, NivelPermissaoEnum permissaoSelecionada)
        {
            if (lstPermissao.Select(permissao => permissao.Id).ToList().Contains((int)permissaoSelecionada))
                return true;

            return false;
        }

        private void _insertPermissoes(UsuarioModel usuario)
        {
            List<UsuarioXPermissaoModel> lstUsuarioPermissoes = new List<UsuarioXPermissaoModel>();

            foreach (var permissao in usuario.Permissoes)
            {
                lstUsuarioPermissoes.Add(new UsuarioXPermissaoModel(permissao.Id, usuario.Id));
            }

            _usuarioRepository.InsertPermissoesXUsuario(lstUsuarioPermissoes);

        }
    }
}
