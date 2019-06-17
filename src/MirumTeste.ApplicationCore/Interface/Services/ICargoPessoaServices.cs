using MirumTeste.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MirumTeste.ApplicationCore.Interface.Services
{
    public interface ICargoPessoaServices
    {
       
        IEnumerable<CargoPessoa> ObterTodosComCargos();
        IEnumerable<CargoPessoa> ObterTodosComCargoParametro(int Id);

    }
}
