﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace drakaysa.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CEP = table.Column<string>(type: "nvarchar", maxLength: 8, nullable: false),
                    Rua = table.Column<string>(type: "nvarchar", maxLength: 100, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar", maxLength: 100, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    TipoDePlano = table.Column<int>(type: "INT", nullable: false),
                    Descricao = table.Column<string>(type: "varchar", maxLength: 300, nullable: true),
                    Coberturas = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    DataInicial = table.Column<DateTime>(type: "DATETIME", nullable: false, defaultValue: new DateTime(2025, 1, 31, 19, 42, 22, 815, DateTimeKind.Local).AddTicks(5474)),
                    DataFinal = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Procedimentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    TipoDeProcedimento = table.Column<int>(type: "INT", nullable: false),
                    Descricao = table.Column<string>(type: "varchar", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TituloTopico = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosDoSistema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoDeUsuario = table.Column<int>(type: "INT", nullable: true),
                    AcessoDeUsuario = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: false),
                    NomeCompleto = table.Column<string>(type: "nvarchar", maxLength: 200, nullable: true),
                    TipoDeSexo = table.Column<int>(type: "INT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosDoSistema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dentistas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "nvarchar", maxLength: 200, nullable: false),
                    SobreNome = table.Column<string>(type: "nvarchar", maxLength: 200, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar", maxLength: 11, nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "Date", nullable: true),
                    Idade = table.Column<int>(type: "INT", nullable: true),
                    Email = table.Column<string>(type: "nvarchar", maxLength: 50, nullable: false),
                    NumeroDeTelefone = table.Column<string>(type: "nvarchar", maxLength: 15, nullable: false),
                    NumeroDeRegistro = table.Column<string>(type: "nvarchar", maxLength: 9, nullable: false),
                    Especialização = table.Column<string>(type: "TEXT", nullable: false),
                    IdEndereco = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dentistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dentistas_Enderecos_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Texto = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    TopicoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_Topicos_TopicoId",
                        column: x => x.TopicoId,
                        principalTable: "Topicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "varchar", maxLength: 200, nullable: true),
                    Sexo = table.Column<int>(type: "int", nullable: true),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar", maxLength: 11, nullable: true, defaultValue: "00000000000"),
                    RG = table.Column<string>(type: "nvarchar", maxLength: 20, nullable: true),
                    NumeroDeTelefone = table.Column<string>(type: "nvarchar", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar", maxLength: 100, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar", maxLength: 15, nullable: true),
                    Whatsapp = table.Column<string>(type: "nvarchar", maxLength: 15, nullable: true),
                    IdDentista = table.Column<int>(type: "INT", nullable: false),
                    IdEndereco = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pacientes_Dentistas_IdDentista",
                        column: x => x.IdDentista,
                        principalTable: "Dentistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pacientes_Enderecos_IdEndereco",
                        column: x => x.IdEndereco,
                        principalTable: "Enderecos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PacientePlanos",
                columns: table => new
                {
                    IdPaciente = table.Column<int>(type: "INTEGER", nullable: false),
                    IdPlano = table.Column<int>(type: "INTEGER", nullable: false),
                    PlanoAtivo = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacientePlanos", x => new { x.IdPlano, x.IdPaciente });
                    table.ForeignKey(
                        name: "FK_PacientePlanos_Pacientes_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PacientePlanos_Planos_IdPlano",
                        column: x => x.IdPlano,
                        principalTable: "Planos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PacienteProcedimentos",
                columns: table => new
                {
                    IdPaciente = table.Column<int>(type: "INTEGER", nullable: false),
                    IdProcedimento = table.Column<int>(type: "INTEGER", nullable: false),
                    DataProcedimento = table.Column<DateTime>(type: "SMALLDATETIME", nullable: false),
                    ProcedimentoRealizado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacienteProcedimentos", x => new { x.IdPaciente, x.IdProcedimento });
                    table.ForeignKey(
                        name: "FK_PacienteProcedimentos_Pacientes_IdPaciente",
                        column: x => x.IdPaciente,
                        principalTable: "Pacientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PacienteProcedimentos_Procedimentos_IdProcedimento",
                        column: x => x.IdProcedimento,
                        principalTable: "Procedimentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_TopicoId",
                table: "Cards",
                column: "TopicoId");

            migrationBuilder.CreateIndex(
                name: "IX_dentista_CPF",
                table: "Dentistas",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dentista_Nome",
                table: "Dentistas",
                column: "Nome");

            migrationBuilder.CreateIndex(
                name: "IX_Dentistas_IdEndereco",
                table: "Dentistas",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_CEP",
                table: "Enderecos",
                column: "CEP");

            migrationBuilder.CreateIndex(
                name: "IX_PacientePlanos_IdPaciente",
                table: "PacientePlanos",
                column: "IdPaciente");

            migrationBuilder.CreateIndex(
                name: "IX_PacienteProcedimento_ProcedimentoRealizado",
                table: "PacienteProcedimentos",
                column: "ProcedimentoRealizado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PacienteProcedimentos_IdProcedimento",
                table: "PacienteProcedimentos",
                column: "IdProcedimento");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_IdDentista",
                table: "Pacientes",
                column: "IdDentista");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_IdEndereco",
                table: "Pacientes",
                column: "IdEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioDoSistema_AcessoDeUsuario",
                table: "UsuariosDoSistema",
                column: "AcessoDeUsuario",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "PacientePlanos");

            migrationBuilder.DropTable(
                name: "PacienteProcedimentos");

            migrationBuilder.DropTable(
                name: "UsuariosDoSistema");

            migrationBuilder.DropTable(
                name: "Topicos");

            migrationBuilder.DropTable(
                name: "Planos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Procedimentos");

            migrationBuilder.DropTable(
                name: "Dentistas");

            migrationBuilder.DropTable(
                name: "Enderecos");
        }
    }
}
