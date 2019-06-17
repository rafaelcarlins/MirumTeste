using MirumTeste.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MirumTeste.ApplicationCore.Interface.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        IEnumerable<TEntity>ObterTodos();
        IEnumerable<CargoPessoa> ObterTodosComCargo();
        IEnumerable<CargoPessoa> ObterTodosComCargoParametro(int Id);
        TEntity ObterUnico(int? Id);
        void Remover(TEntity entity);
    }
}
