using MirumTeste.ApplicationCore.Entity;
using MirumTeste.ApplicationCore.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MirumTeste.ApplicationCore.Services
{
    public class CargosServices : ICargoServices
    {
        public Pessoa Adicionar(Cargo entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Cargo entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cargo> Find(Expression<Func<Cargo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cargo> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Cargo ObterUnico(int Id)
        {
            throw new NotImplementedException();
        }

        public void Remover(Cargo entity)
        {
            throw new NotImplementedException();
        }
    }
}
