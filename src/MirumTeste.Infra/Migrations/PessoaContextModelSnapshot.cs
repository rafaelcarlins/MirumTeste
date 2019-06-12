﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MirumTeste.Infra.Data;

namespace MirumTeste.Infra.Migrations
{
    [DbContext(typeof(PessoaContext))]
    partial class PessoaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("MirumTeste.ApplicationCore.Entity.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MenuId");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("Menu");
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

            modelBuilder.Entity("MirumTeste.ApplicationCore.Entity.Menu", b =>
                {
                    b.HasOne("MirumTeste.ApplicationCore.Entity.Menu")
                        .WithMany("subMenu")
                        .HasForeignKey("MenuId");
                });
#pragma warning restore 612, 618
        }
    }
}
