using System;
using System.Collections.Generic;
using app.Aplicacao.Interfaces;
using app.Aplicacao.ViewModels;
using app.Data.Repositorio;
using appCRUD.Dominio.Interfaces.InterfaceRepositorio;
using appCRUD.Dominio.Modelos;
using AutoMapper;

namespace app.Aplicacao.Serviços
{
    public class UsuarioAppServico : IUsuarioAppServico // Conhecer Dominio e Infra
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioAppServico()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }


        public UsuarioEnderecoVM Adicionar(UsuarioEnderecoVM usuarioEnderecoVM)
        {
            // trocar usuarioVM em usuario
            var usuario = Mapper.Map<Usuario>(usuarioEnderecoVM.UsuarioVW);
            var endereco = Mapper.Map<Endereco>(usuarioEnderecoVM.EnderecoVM);
            usuario.Enderecos.Add(endereco);
            usuario.Ativo = true;

            _usuarioRepositorio.Adicionar(usuario);

            return usuarioEnderecoVM;

        }

        public UsuarioVW Atualizar(UsuarioVW usuarioVM)
        {
            var usuario = Mapper.Map<Usuario>(usuarioVM);
            _usuarioRepositorio.Atualizar(usuario);
            return usuarioVM;
        }

        public void Dispose()
        {
            _usuarioRepositorio.Dispose();
        }

        public IEnumerable<UsuarioVW> ObterAtivos()
        {
            return Mapper.Map<IEnumerable<UsuarioVW>>(_usuarioRepositorio.ObterAtivos());
        }

        public UsuarioVW ObterPorCpf(string cpf)
        {
            return Mapper.Map<UsuarioVW>(_usuarioRepositorio.ObterPorCpf(cpf));
        }

        public UsuarioVW ObterPorEmail(string email)
        {
            return Mapper.Map<UsuarioVW>(_usuarioRepositorio.ObterPorEmail(email));

        }

        public UsuarioVW ObterPorId(Guid id)
        {
            return Mapper.Map<UsuarioVW>(_usuarioRepositorio.ObterPorId(id));
        }

        public IEnumerable<UsuarioVW> ObterTodos()
        {
            return Mapper.Map<IEnumerable<UsuarioVW>>(_usuarioRepositorio.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _usuarioRepositorio.Remover(id);
        }
    }
}