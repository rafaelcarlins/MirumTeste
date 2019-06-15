using Microsoft.EntityFrameworkCore;
using MirumTeste.ApplicationCore.Entity;
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



        //public IEnumerable<Cargo> ObterTodosComCargos()
        //{
        //    IEnumerable<Cargo> query = from p in _dbContext.Pessoas
        //                               join c in _dbContext.Cargos on p.Id equals c.IdPessoa
        //                               select (c);

            //    return query;
        //}
        public TEntity ObterUnico(int? Id)
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
