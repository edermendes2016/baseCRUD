using System;
using System.Collections;
using System.Collections.Generic;
using app.Aplicacao.ViewModels;

namespace app.Aplicacao.Interfaces
{
    public interface IUsuarioAppServico : IDisposable
    {
        UsuarioEnderecoVM Adicionar(UsuarioEnderecoVM usuarioEnderecoVm);
        UsuarioVW ObterPorId(Guid id);
        UsuarioVW ObterPorCpf(string cpf);
        UsuarioVW ObterPorEmail(string email);
        UsuarioVW Atualizar(UsuarioVW usuarioVM);
        IEnumerable<UsuarioVW> ObterTodos();
        IEnumerable<UsuarioVW> ObterAtivos();
        void Remover(Guid id);

    }
}