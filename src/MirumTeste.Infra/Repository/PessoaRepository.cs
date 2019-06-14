using MirumTeste.ApplicationCore.Entity;
using MirumTeste.ApplicationCore.Interface.Repository;
using MirumTeste.Infra.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MirumTeste.Infra.Repository
{
    public class PessoaRepository : EFRepository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(PessoaContext context) : base(context)
        { }

        public PessoaContext InfraContext
        {
            get { return _dbContext as PessoaContext; }
        }
    }
}
