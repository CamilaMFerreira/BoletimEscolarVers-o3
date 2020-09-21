﻿// <auto-generated />
using System;
using BoletimEscolarVersão3Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoletimEscolarVersão3Modelos.Migrations
{
    [DbContext(typeof(BancoContex))]
    partial class BancoContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BoletimEscolarVersão3Modelos.Modelos.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Função")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("IdCurso")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("IdCurso");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("BoletimEscolarVersão3Modelos.Modelos.AlunoMateriaNotas", b =>
                {
                    b.Property<int>("IdAluno")
                        .HasColumnType("int");

                    b.Property<int>("IdMateria")
                        .HasColumnType("int");

                    b.Property<int?>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int?>("MateriaId")
                        .HasColumnType("int");

                    b.Property<double>("Nota")
                        .HasColumnType("float");

                    b.HasKey("IdAluno", "IdMateria");

                    b.HasIndex("AlunoId");

                    b.HasIndex("MateriaId");

                    b.ToTable("AlunoMateriaNotas");
                });

            modelBuilder.Entity("BoletimEscolarVersão3Modelos.Modelos.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Situação")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("BoletimEscolarVersão3Modelos.Modelos.Materia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descrição")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCurso")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Situação")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IdCurso");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("BoletimEscolarVersão3Modelos.Modelos.Aluno", b =>
                {
                    b.HasOne("BoletimEscolarVersão3Modelos.Modelos.Curso", "Curso")
                        .WithMany("Alunos")
                        .HasForeignKey("IdCurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoletimEscolarVersão3Modelos.Modelos.AlunoMateriaNotas", b =>
                {
                    b.HasOne("BoletimEscolarVersão3Modelos.Modelos.Aluno", "Aluno")
                        .WithMany("MateriasNota")
                        .HasForeignKey("AlunoId");

                    b.HasOne("BoletimEscolarVersão3Modelos.Modelos.Materia", "Materia")
                        .WithMany("AlunoNota")
                        .HasForeignKey("MateriaId");
                });

            modelBuilder.Entity("BoletimEscolarVersão3Modelos.Modelos.Materia", b =>
                {
                    b.HasOne("BoletimEscolarVersão3Modelos.Modelos.Curso", "Curso")
                        .WithMany("Materias")
                        .HasForeignKey("IdCurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
