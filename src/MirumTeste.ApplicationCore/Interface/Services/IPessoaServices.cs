using MirumTeste.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MirumTeste.ApplicationCore.Interface.Services
{
    public interface IPessoaServices
    {
        Pessoa Adicionar(Pessoa entity);
        void Atualizar(Pessoa entity);
        IEnumerable<Pessoa> ObterTodos();
        IEnumerable<Pessoa> Find(Expression<Func<Pessoa, bool>> predicate);
        Pessoa ObterUnico(int? Id);
        void Remover(Pessoa entity);
    }
}
