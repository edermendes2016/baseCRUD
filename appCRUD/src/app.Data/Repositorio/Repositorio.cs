using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using app.Data.Context;
using appCRUD.Dominio.Interfaces.InterfaceRepositorio;
using appCRUD.Dominio.Modelos;

namespace app.Data.Repositorio
{
    public abstract class Repositorio<TEntidade> : IRepositorio<TEntidade> where TEntidade : Entidade, new() // => e uma instancia de um objeto
    {
        protected AppContext Db;
        protected DbSet<TEntidade> DbSet;

        protected Repositorio()
        {
            Db = new AppContext();
            DbSet = Db.Set<TEntidade>();
        }

        public virtual TEntidade Adicionar(TEntidade obj)
        {
            var objAdd = DbSet.Add(obj);
            SaveChanges();
            return objAdd;

        }

        public virtual TEntidade Atualizar(TEntidade obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChanges();
            return obj;
        }

        public virtual  IEnumerable<TEntidade> Buscar(Expression<Func<TEntidade, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual TEntidade ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntidade> ObterTodos()
        {
            return DbSet.ToList(); // Colocar Paginação
        }

        public virtual void Remover(Guid id)
        {
            var obj = new TEntidade() {Id = id};
            DbSet.Remove(obj);
            SaveChanges();
        }

        public int SaveChanges()
        {
            //Try //Log
           return Db.SaveChanges();
        }
    }
}