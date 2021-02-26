﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.API.Data;

namespace SmartSchool.API.Migrations
{
    [DbContext(typeof(SmartContext))]
    [Migration("20210226120809_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("SmartSchool.API.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Datafim")
                        .HasColumnType("TEXT");

                    b.Property<int>("Matricula")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 26, 9, 8, 8, 910, DateTimeKind.Local).AddTicks(9701),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 1,
                            Nome = "Marta",
                            Sobrenome = "Kent",
                            Telefone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(4054),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 2,
                            Nome = "Paula",
                            Sobrenome = "Isabela",
                            Telefone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(4124),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 3,
                            Nome = "Laura",
                            Sobrenome = "Antonia",
                            Telefone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(4131),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 4,
                            Nome = "Luiza",
                            Sobrenome = "Maria",
                            Telefone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(4138),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 5,
                            Nome = "Lucas",
                            Sobrenome = "Machado",
                            Telefone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(4150),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 6,
                            Nome = "Pedro",
                            Sobrenome = "Alvares",
                            Telefone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(4157),
                            DataNasc = new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Matricula = 7,
                            Nome = "Paulo",
                            Sobrenome = "José",
                            Telefone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoCurso", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateIni")
                        .HasColumnType("TEXT");

                    b.HasKey("AlunoId", "CursoId");

                    b.HasIndex("CursoId");

                    b.ToTable("AlunosCursos");
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoDisciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplinaId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateFim")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateIni")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Nota")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "DisciplinaId");

                    b.HasIndex("DisciplinaId");

                    b.ToTable("AlunosDisciplinas");

                    b.HasData(
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 2,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(6096)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 4,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7581)
                        },
                        new
                        {
                            AlunoId = 1,
                            DisciplinaId = 5,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7624)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 1,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7626)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 2,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7628)
                        },
                        new
                        {
                            AlunoId = 2,
                            DisciplinaId = 5,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7634)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 1,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7636)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 2,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7637)
                        },
                        new
                        {
                            AlunoId = 3,
                            DisciplinaId = 3,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7639)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 1,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7643)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 4,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7644)
                        },
                        new
                        {
                            AlunoId = 4,
                            DisciplinaId = 5,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7646)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 4,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7648)
                        },
                        new
                        {
                            AlunoId = 5,
                            DisciplinaId = 5,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7650)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 1,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7652)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 2,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7654)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 3,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7655)
                        },
                        new
                        {
                            AlunoId = 6,
                            DisciplinaId = 4,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7659)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 1,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7661)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 2,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7662)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 3,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7664)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 4,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7666)
                        },
                        new
                        {
                            AlunoId = 7,
                            DisciplinaId = 5,
                            DateIni = new DateTime(2021, 2, 26, 9, 8, 8, 911, DateTimeKind.Local).AddTicks(7668)
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Tecnologia da Informação"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Sistemas de Informação"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Ciência da Computação"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CargaHoraria")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CursoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PrerequisitoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("PrerequisitoId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Disciplinas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 2,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Matemática",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 3,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Física",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 4,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Português",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 5,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 6,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 7,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Inglês",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 8,
                            CargaHoraria = 0,
                            CursoId = 1,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 9,
                            CargaHoraria = 0,
                            CursoId = 2,
                            Nome = "Programação",
                            ProfessorId = 5
                        },
                        new
                        {
                            Id = 10,
                            CargaHoraria = 0,
                            CursoId = 3,
                            Nome = "Programação",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataIni")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Datafim")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<int>("Registro")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 26, 9, 8, 8, 905, DateTimeKind.Local).AddTicks(836),
                            Nome = "Lauro",
                            Registro = 1,
                            Sobrenome = "Oliveira"
                        },
                        new
                        {
                            Id = 2,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 26, 9, 8, 8, 907, DateTimeKind.Local).AddTicks(4960),
                            Nome = "Roberto",
                            Registro = 2,
                            Sobrenome = "Soares"
                        },
                        new
                        {
                            Id = 3,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 26, 9, 8, 8, 907, DateTimeKind.Local).AddTicks(5033),
                            Nome = "Ronaldo",
                            Registro = 3,
                            Sobrenome = "Marconi"
                        },
                        new
                        {
                            Id = 4,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 26, 9, 8, 8, 907, DateTimeKind.Local).AddTicks(5036),
                            Nome = "Rodrigo",
                            Registro = 4,
                            Sobrenome = "Carvalho"
                        },
                        new
                        {
                            Id = 5,
                            Ativo = true,
                            DataIni = new DateTime(2021, 2, 26, 9, 8, 8, 907, DateTimeKind.Local).AddTicks(5038),
                            Nome = "Alexandre",
                            Registro = 5,
                            Sobrenome = "Montanha"
                        });
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoCurso", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Aluno", "Aluno")
                        .WithMany()
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.API.Models.AlunoDisciplina", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Aluno", "Aluno")
                        .WithMany("AlunoDisciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Disciplina", "Disciplina")
                        .WithMany("AlunoDisciplina")
                        .HasForeignKey("DisciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartSchool.API.Models.Disciplina", b =>
                {
                    b.HasOne("SmartSchool.API.Models.Curso", "Curso")
                        .WithMany("Disciplinas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.API.Models.Disciplina", "Prerequisito")
                        .WithMany()
                        .HasForeignKey("PrerequisitoId");

                    b.HasOne("SmartSchool.API.Models.Professor", "Professor")
                        .WithMany("Disciplina")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}