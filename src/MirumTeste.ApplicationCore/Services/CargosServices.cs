using MirumTeste.ApplicationCore.Entity;
using MirumTeste.ApplicationCore.Interface.Repository;
using MirumTeste.ApplicationCore.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MirumTeste.ApplicationCore.Services
{
    public class CargosServices : ICargoServices
    {
        private readonly ICargoRepository _repository;
        public CargosServices(ICargoRepository repository)
        {
            _repository = repository;
        }
        public Cargo Adicionar(Cargo entity)
        {
            return _repository.Adicionar(entity);
        }

        public void Atualizar(Cargo entity)
        {
            _repository.Atualizar(entity);
        }

        public IEnumerable<Cargo> Find(Expression<Func<Cargo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cargo> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public Cargo ObterUnico(int? Id)
        {
            return _repository.ObterUnico(Id);
        }

        public void Remover(Cargo entity)
        {
            _repository.Remover(entity);
        }
    }
}
