using System;
using System.Collections.Generic;
using System.Text;
using MirumTeste.ApplicationCore.Entity;
using MirumTeste.ApplicationCore.Interface.Repository;

namespace MirumTeste.ApplicationCore.Services
{
    public class PessoasServices : IPessoaServices
    {
        private readonly IRepository<Pessoa> _repository;
        public PessoasServices(IRepository<Pessoa> repository)
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

        public IEnumerable<Pessoa> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public Pessoa ObterUnico(int Id)
        {
            return _repository.ObterUnico(Id);
        }

        public void Remover(Pessoa entity)
        {
            _repository.Remover(entity);
        }
    }
}
