﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModuloAdministrador.Infra.Data.Context;

namespace ModuloAdministrador.Infra.Data.Migrations
{
    [DbContext(typeof(ModuloAdministradorContext))]
    [Migration("20191105152742_RetiradoAutoIncrementMunEstado")]
    partial class RetiradoAutoIncrementMunEstado
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ModuloAdministrador.Domain.Entities.Entidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Cnpj");

                    b.Property<int?>("EntidadeFiscalizadoraId");

                    b.Property<int>("EntidadeTipoId");

                    b.Property<int>("EstadoId");

                    b.Property<int?>("MunicipioId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("EntidadeTipoId");

                    b.HasIndex("EstadoId");

                    b.HasIndex("MunicipioId");

                    b.ToTable("Entidade");
                });

            modelBuilder.Entity("ModuloAdministrador.Domain.Entities.EntidadeTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("EntidadeTipo");
                });

            modelBuilder.Entity("ModuloAdministrador.Domain.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<string>("Nome");

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("ModuloAdministrador.Domain.Entities.Municipio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<int>("EstadoId");

                    b.Property<string>("Latitude");

                    b.Property<string>("Longitude");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId");

                    b.ToTable("Municipios");
                });

            modelBuilder.Entity("ModuloAdministrador.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ModuloAdministrador.Domain.Entities.UsuarioEntidadePerfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Ativo");

                    b.Property<DateTime>("DataCadastro");

                    b.Property<int?>("EntidadeId");

                    b.Property<int>("UsuarioId");

                    b.Property<int>("UsuarioPerfilTipoId");

                    b.HasKey("Id");

                    b.HasIndex("EntidadeId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("UsuarioPerfilTipoId");

                    b.ToTable("UsuarioEntidadePerfil");
                });

            modelBuilder.Entity("ModuloAdministrador.Domain.Entities.UsuarioPerfilTipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("UsuarioPerfilTipo");
                });

            modelBuilder.Entity("ModuloAdministrador.Domain.Entities.Entidade", b =>
                {
                    b.HasOne("ModuloAdministrador.Domain.Entities.EntidadeTipo", "EntidadeTipo")
                        .WithMany("Entidades")
                        .HasForeignKey("EntidadeTipoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ModuloAdministrador.Domain.Entities.Estado", "Estado")
                        .WithMany("Entidades")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ModuloAdministrador.Domain.Entities.Municipio", "Municipio")
                        .WithMany("Entidades")
                        .HasForeignKey("MunicipioId");
                });

            modelBuilder.Entity("ModuloAdministrador.Domain.Entities.Municipio", b =>
                {
                    b.HasOne("ModuloAdministrador.Domain.Entities.Estado", "Estado")
                        .WithMany("Municipios")
                        .HasForeignKey("EstadoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ModuloAdministrador.Domain.Entities.UsuarioEntidadePerfil", b =>
                {
                    b.HasOne("ModuloAdministrador.Domain.Entities.Entidade", "Entidade")
                        .WithMany("UsuarioEntidadePerfis")
                        .HasForeignKey("EntidadeId");

                    b.HasOne("ModuloAdministrador.Domain.Entities.Usuario", "Usuario")
                        .WithMany("UsuarioEntidadePerfis")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ModuloAdministrador.Domain.Entities.UsuarioPerfilTipo", "UsuarioPerfilTipo")
                        .WithMany("UsuarioEntidadePerfis")
                        .HasForeignKey("UsuarioPerfilTipoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
