using System.Collections;
using System.Collections.Generic;
using appCRUD.Dominio.Modelos;

namespace appCRUD.Dominio.Interfaces.InterfaceRepositorio
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario>
    {
        Usuario ObterPorCpf(string cpf);
        Usuario ObterPorEmail(string email);
        IEnumerable<Usuario> ObterAtivos();
    }
}