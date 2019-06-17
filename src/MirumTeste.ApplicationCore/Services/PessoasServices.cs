using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using MirumTeste.ApplicationCore.Entity;
using MirumTeste.ApplicationCore.Interface;
using MirumTeste.ApplicationCore.Interface.Repository;
using MirumTeste.ApplicationCore.Interface.Services;
using MirumTeste.ApplicationCore.Services;

namespace MirumTeste.ApplicationCore.Services
{
    public class PessoasServices : IPessoaServices
    {
        private readonly IPessoaRepository _repository;
        public PessoasServices(IPessoaRepository repository)
        {
            _repository = repository;
        }
        public Pessoa Adicionar(Pessoa entity)
        {
            return _repository.Adicionar(entity);
        }

        public void Atualizar(Pessoa entity)
        {
            _repository.Atualizar(entity);
        }

        public IEnumerable<Pessoa> Find(Expression<Func<Pessoa, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pessoa> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public Pessoa ObterUnico(int? Id)
        {
            return _repository.ObterUnico(Id);
        }

        public void Remover(Pessoa entity)
        {
            _repository.Remover(entity);
        }
    }
}
