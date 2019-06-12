using Microsoft.EntityFrameworkCore;
using MirumTeste.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MirumTeste.Infra.Data
{
    public class PessoaContext: DbContext
    {
        public PessoaContext(DbContextOptions<PessoaContext>options): base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
        }
    }
}
