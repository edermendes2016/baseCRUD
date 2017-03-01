using System;
using System.Collections.Generic;
using System.Linq;
using appCRUD.Dominio.Interfaces.InterfaceRepositorio;
using appCRUD.Dominio.Modelos;

namespace app.Data.Repositorio
{
    public class UsuarioRepositorio : Repositorio<Usuario>, IUsuarioRepositorio
    {
        public IEnumerable<Usuario> ObterAtivos()
        {
            return Buscar(c => c.Ativo && !c.Excluido);
        }

        public Usuario ObterPorCpf(string cpf)
        {
            return Buscar(c => c.CPF == cpf).FirstOrDefault();
        }

        public Usuario ObterPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }

        public override void Remover(Guid id)
        {
            var usuario = ObterPorId(id);
            usuario.Excluido = true;
            Atualizar(usuario);
            
        }
    }
}