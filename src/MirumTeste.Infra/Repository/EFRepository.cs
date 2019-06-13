using Microsoft.EntityFrameworkCore;
using MirumTeste.ApplicationCore.Interface.Repository;
using MirumTeste.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MirumTeste.Infra.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        protected readonly PessoaContext _dbContext;
        public EFRepository(PessoaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public TEntity Adicionar(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Atualizar(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _dbContext.Set<TEntity>().AsEnumerable();
        }

        public TEntity ObterUnico(int Id)
        {
            return _dbContext.Set<TEntity>().Find(Id);
        }

        public void Remover(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
