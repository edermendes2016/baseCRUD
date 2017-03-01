using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using appCRUD.Dominio.Modelos;

namespace appCRUD.Dominio.Interfaces.InterfaceRepositorio
{
    public interface IRepositorio<TEntidade> : IDisposable where TEntidade : Entidade
    {
        TEntidade Adicionar(TEntidade obj);
        TEntidade ObterPorId(Guid id);
        IEnumerable<TEntidade> ObterTodos();
        TEntidade Atualizar(TEntidade obj);
        void Remover(Guid id);
        IEnumerable<TEntidade> Buscar(Expression<Func<TEntidade, bool>> predicate);
        int SaveChanges();
    }
}