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

        public IEnumerable<CargoPessoa> ObterTodosComCargo()
        {
            var aluno = (from p in _dbContext.Pessoas
                         join c in _dbContext.Cargos on p.CargoId equals c.Id
                         select new CargoPessoa
                         {
                             Nome = p.Nome,
                             Funcao = c.Funcao,
                             SalarioBase = c.SalarioBase,
                         }).ToList();
            return (aluno);
        }

        public IEnumerable<CargoPessoa> ObterTodosComCargoParametro(int Id)
        {
            var aluno = (from p in _dbContext.Pessoas
                         join c in _dbContext.Cargos on p.CargoId equals c.Id
                         where c.Id == Id
                         select new CargoPessoa
                         {
                             Nome = p.Nome,
                             Funcao = c.Funcao,
                             SalarioBase = c.SalarioBase,
                         }).ToList();
            return (aluno);
        }
        //public IEnumerable<CargoPessoa> ObterTodosComCargos()
        //{


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
