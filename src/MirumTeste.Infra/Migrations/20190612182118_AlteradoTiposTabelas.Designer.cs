﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MirumTeste.Infra.Data;

namespace MirumTeste.Infra.Migrations
{
    [DbContext(typeof(PessoaContext))]
    [Migration("20190612182118_AlteradoTiposTabelas")]
    partial class AlteradoTiposTabelas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MirumTeste.ApplicationCore.Entity.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Funcao")
                        .HasColumnType("varchar(30)");

                    b.Property<int>("IdPessoa");

                    b.Property<int?>("PessoaId");

                    b.Property<decimal>("SalarioBase");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("MirumTeste.ApplicationCore.Entity.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Nome")
                        .HasColumnType("varchar(80)");

                    b.Property<int>("Rg");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("MirumTeste.ApplicationCore.Entity.Cargo", b =>
                {
                    b.HasOne("MirumTeste.ApplicationCore.Entity.Pessoa", "Pessoa")
                        .WithMany("Cargos")
                        .HasForeignKey("PessoaId");
                });
#pragma warning restore 612, 618
        }
    }
}
