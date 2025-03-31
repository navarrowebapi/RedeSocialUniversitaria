﻿// <auto-generated />
using System;
using DDDCommerceComRepository.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DDDCommerceComRepository.Infra.RedeSocial.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20250331194937_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DDDCommerceComRepository.Domain.RedeSocial.Entidades.Evento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("DDDCommerceComRepository.Domain.RedeSocial.Entidades.Postagem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AutorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.ToTable("Postagens");
                });

            modelBuilder.Entity("DDDCommerceComRepository.Domain.RedeSocial.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Curso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("EventoParticipantes", b =>
                {
                    b.Property<Guid>("EventoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EventoId", "UsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("EventoParticipantes");
                });

            modelBuilder.Entity("PostagemCurtidas", b =>
                {
                    b.Property<Guid>("PostagemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PostagemId", "UsuarioId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("PostagemCurtidas");
                });

            modelBuilder.Entity("UsuarioSeguidores", b =>
                {
                    b.Property<Guid>("SeguidoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SeguidorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SeguidoId", "SeguidorId");

                    b.HasIndex("SeguidorId");

                    b.ToTable("UsuarioSeguidores");
                });

            modelBuilder.Entity("DDDCommerceComRepository.Domain.RedeSocial.Entidades.Postagem", b =>
                {
                    b.HasOne("DDDCommerceComRepository.Domain.RedeSocial.Entidades.Usuario", "Autor")
                        .WithMany()
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");
                });

            modelBuilder.Entity("EventoParticipantes", b =>
                {
                    b.HasOne("DDDCommerceComRepository.Domain.RedeSocial.Entidades.Evento", null)
                        .WithMany()
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DDDCommerceComRepository.Domain.RedeSocial.Entidades.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PostagemCurtidas", b =>
                {
                    b.HasOne("DDDCommerceComRepository.Domain.RedeSocial.Entidades.Postagem", null)
                        .WithMany()
                        .HasForeignKey("PostagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DDDCommerceComRepository.Domain.RedeSocial.Entidades.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("UsuarioSeguidores", b =>
                {
                    b.HasOne("DDDCommerceComRepository.Domain.RedeSocial.Entidades.Usuario", null)
                        .WithMany()
                        .HasForeignKey("SeguidoId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("DDDCommerceComRepository.Domain.RedeSocial.Entidades.Usuario", null)
                        .WithMany()
                        .HasForeignKey("SeguidorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
