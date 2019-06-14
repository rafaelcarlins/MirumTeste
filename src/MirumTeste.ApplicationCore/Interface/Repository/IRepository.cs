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
        TEntity ObterUnico(int? Id);
        void Remover(TEntity entity);
    }
}
