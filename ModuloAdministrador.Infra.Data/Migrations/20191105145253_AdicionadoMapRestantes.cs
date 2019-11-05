using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloAdministrador.Infra.Data.Migrations
{
    public partial class AdicionadoMapRestantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entidade_Estado_EstadoId",
                table: "Entidade");

            migrationBuilder.DropForeignKey(
                name: "FK_Entidade_Municipio_MunicipioId",
                table: "Entidade");

            migrationBuilder.DropForeignKey(
                name: "FK_Municipio_Estado_EstadoId",
                table: "Municipio");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioEntidadePerfil_Usuarios_UsuarioId1",
                table: "UsuarioEntidadePerfil");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioEntidadePerfil_UsuarioId1",
                table: "UsuarioEntidadePerfil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Municipio",
                table: "Municipio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estado",
                table: "Estado");

            migrationBuilder.DropColumn(
                name: "CallbackUrl",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "UsuarioEntidadePerfil");

            migrationBuilder.DropColumn(
                name: "IdSistemaLegado",
                table: "Entidade");

            migrationBuilder.RenameTable(
                name: "Municipio",
                newName: "Municipios");

            migrationBuilder.RenameTable(
                name: "Estado",
                newName: "Estados");

            migrationBuilder.RenameIndex(
                name: "IX_Municipio_EstadoId",
                table: "Municipios",
                newName: "IX_Municipios_EstadoId");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "UsuarioEntidadePerfil",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Municipios",
                table: "Municipios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estados",
                table: "Estados",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEntidadePerfil_UsuarioId",
                table: "UsuarioEntidadePerfil",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entidade_Estados_EstadoId",
                table: "Entidade",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entidade_Municipios_MunicipioId",
                table: "Entidade",
                column: "MunicipioId",
                principalTable: "Municipios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Municipios_Estados_EstadoId",
                table: "Municipios",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioEntidadePerfil_Usuarios_UsuarioId",
                table: "UsuarioEntidadePerfil",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entidade_Estados_EstadoId",
                table: "Entidade");

            migrationBuilder.DropForeignKey(
                name: "FK_Entidade_Municipios_MunicipioId",
                table: "Entidade");

            migrationBuilder.DropForeignKey(
                name: "FK_Municipios_Estados_EstadoId",
                table: "Municipios");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioEntidadePerfil_Usuarios_UsuarioId",
                table: "UsuarioEntidadePerfil");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioEntidadePerfil_UsuarioId",
                table: "UsuarioEntidadePerfil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Municipios",
                table: "Municipios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estados",
                table: "Estados");

            migrationBuilder.RenameTable(
                name: "Municipios",
                newName: "Municipio");

            migrationBuilder.RenameTable(
                name: "Estados",
                newName: "Estado");

            migrationBuilder.RenameIndex(
                name: "IX_Municipios_EstadoId",
                table: "Municipio",
                newName: "IX_Municipio_EstadoId");

            migrationBuilder.AddColumn<string>(
                name: "CallbackUrl",
                table: "Usuarios",
                maxLength: 400,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<Guid>(
                name: "UsuarioId",
                table: "UsuarioEntidadePerfil",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId1",
                table: "UsuarioEntidadePerfil",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdSistemaLegado",
                table: "Entidade",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Municipio",
                table: "Municipio",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estado",
                table: "Estado",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEntidadePerfil_UsuarioId1",
                table: "UsuarioEntidadePerfil",
                column: "UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Entidade_Estado_EstadoId",
                table: "Entidade",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entidade_Municipio_MunicipioId",
                table: "Entidade",
                column: "MunicipioId",
                principalTable: "Municipio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Municipio_Estado_EstadoId",
                table: "Municipio",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioEntidadePerfil_Usuarios_UsuarioId1",
                table: "UsuarioEntidadePerfil",
                column: "UsuarioId1",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
