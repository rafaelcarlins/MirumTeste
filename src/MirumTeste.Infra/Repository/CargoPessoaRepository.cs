using MirumTeste.ApplicationCore.Entity;
using MirumTeste.ApplicationCore.Interface.Repository;
using MirumTeste.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MirumTeste.Infra.Repository
{
    public class CargoPessoaRepository : EFRepository<Cargo>, ICargoPessoaRepository
    {
        public CargoPessoaRepository(PessoaContext context) : base(context)
        { }

        public PessoaContext InfraContext
        {
            get { return _dbContext as PessoaContext; }
        }

        public CargoPessoa Adicionar(CargoPessoa entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(CargoPessoa entity)
        {
            throw new NotImplementedException();
        }

        public void Remover(CargoPessoa entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<CargoPessoa> IRepository<CargoPessoa>.ObterTodos()
        {
            throw new NotImplementedException();
        }

        CargoPessoa IRepository<CargoPessoa>.ObterUnico(int? Id)
        {
            throw new NotImplementedException();
        }
    }
}
