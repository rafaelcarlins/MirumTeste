using MirumTeste.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MirumTeste.ApplicationCore.Interface.Services
{
    public interface IPessoaServices
    {
        Pessoa Adicionar(Pessoa entity);
        void Atualizar(Pessoa entity);
        IEnumerable<Pessoa> ObterTodos();
        Pessoa ObterUnico(int? Id);
        void Remover(Pessoa entity);
    }
}
