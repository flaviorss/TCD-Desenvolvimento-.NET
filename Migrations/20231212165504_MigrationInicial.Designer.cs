﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TCD.Data;

#nullable disable

namespace TCD.Migrations
{
    [DbContext(typeof(PerguntaDbContext))]
    [Migration("20231212165504_MigrationInicial")]
    partial class MigrationInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Pergunta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Avaliacao")
                        .HasColumnType("REAL");

                    b.Property<int>("NumAvaliacoes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Selecionado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Texto")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pergunta");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avaliacao = 0.0,
                            NumAvaliacoes = 0,
                            Selecionado = 0,
                            Texto = "Como você avaliaria a competência e o comprometimento dos professores?"
                        },
                        new
                        {
                            Id = 2,
                            Avaliacao = 0.0,
                            NumAvaliacoes = 0,
                            Selecionado = 0,
                            Texto = "As atividades práticas e teóricas das disciplinas do curso são equilibradas de maneira eficaz?"
                        },
                        new
                        {
                            Id = 3,
                            Avaliacao = 0.0,
                            NumAvaliacoes = 0,
                            Selecionado = 0,
                            Texto = "A instituição oferece recursos tecnológicos adequados para apoiar o aprendizado?"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
