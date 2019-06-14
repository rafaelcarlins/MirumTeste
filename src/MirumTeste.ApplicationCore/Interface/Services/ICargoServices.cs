using MirumTeste.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MirumTeste.ApplicationCore.Interface.Services
{
    public interface ICargoServices
    {
        Cargo Adicionar(Cargo entity);
        void Atualizar(Cargo entity);
        IEnumerable<Cargo> ObterTodos();
        IEnumerable<Cargo> Find(Expression<Func<Cargo, bool>> predicate);
        Cargo ObterUnico(int? Id);
        void Remover(Cargo entity);
    }
}
