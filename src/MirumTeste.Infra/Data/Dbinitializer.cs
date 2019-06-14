using Microsoft.EntityFrameworkCore;
using MirumTeste.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MirumTeste.Infra.Data
{
    public static class Dbinitializer
    {
        public static void Initialize(PessoaContext context)
        {
            if (context.Cargos.Any())
            {
                return;
            }
            else
            {
                var cargos = new Cargo[]
                {
                    new Cargo()
                    {
                        Funcao = "Analista de sistemas",
                    }
                };
            }

            if (context.Pessoas.Any())
            {
                return;
            }
            else
            {
                var pessoas = new Pessoa[]
                {
                    new Pessoa()
                    {
                        Nome="Zezinho da esquina",
                    }
                };
            }

        }
    }
}
