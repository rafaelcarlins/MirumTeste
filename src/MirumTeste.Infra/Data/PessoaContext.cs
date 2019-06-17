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
        public DbSet<Cargo> Cargos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>().ToTable("Pessoa");
            modelBuilder.Entity<Cargo>().ToTable("Cargo");


            modelBuilder.Entity<Pessoa>().Property(e => e.Nome)
                .HasColumnType("varchar(80)");

            modelBuilder.Entity<Pessoa>().Property(e => e.Email)
                .HasColumnType("varchar(80)");

            modelBuilder.Entity<Cargo>().Property(e => e.Funcao)
                .HasColumnType("varchar(30)");


            //modelBuilder.Entity<Menu>()
            //    .HasMany(c => c.subMenu)
            //    .WithOne();

        }
    }
}
