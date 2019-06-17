using MirumTeste.ApplicationCore.Entity;
using MirumTeste.ApplicationCore.Interface.Repository;
using MirumTeste.ApplicationCore.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MirumTeste.ApplicationCore.Services
{
    public class CargosPessoasServices : ICargoPessoaServices
    {
        private readonly ICargoPessoaRepository _repository;

        public CargosPessoasServices(ICargoPessoaRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<CargoPessoa> ObterTodosComCargos()
        {
            return _repository.ObterTodosComCargo ();
        }

        public IEnumerable<CargoPessoa> ObterTodosComCargoParametro(int Id)
        {
            return _repository.ObterTodosComCargoParametro( Id);
        }

    }
}
