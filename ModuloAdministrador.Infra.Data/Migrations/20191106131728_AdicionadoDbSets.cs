using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloAdministrador.Infra.Data.Migrations
{
    public partial class AdicionadoDbSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entidade_EntidadeTipo_EntidadeTipoId",
                table: "Entidade");

            migrationBuilder.DropForeignKey(
                name: "FK_Entidade_Estados_EstadoId",
                table: "Entidade");

            migrationBuilder.DropForeignKey(
                name: "FK_Entidade_Municipios_MunicipioId",
                table: "Entidade");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioEntidadePerfil_Entidade_EntidadeId",
                table: "UsuarioEntidadePerfil");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioEntidadePerfil_Usuarios_UsuarioId",
                table: "UsuarioEntidadePerfil");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioEntidadePerfil_UsuarioPerfilTipo_UsuarioPerfilTipoId",
                table: "UsuarioEntidadePerfil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioPerfilTipo",
                table: "UsuarioPerfilTipo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioEntidadePerfil",
                table: "UsuarioEntidadePerfil");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntidadeTipo",
                table: "EntidadeTipo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entidade",
                table: "Entidade");

            migrationBuilder.RenameTable(
                name: "UsuarioPerfilTipo",
                newName: "UsuarioPerfilTipos");

            migrationBuilder.RenameTable(
                name: "UsuarioEntidadePerfil",
                newName: "UsuarioEntidadePerfis");

            migrationBuilder.RenameTable(
                name: "EntidadeTipo",
                newName: "EntidadeTipos");

            migrationBuilder.RenameTable(
                name: "Entidade",
                newName: "Entidades");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioEntidadePerfil_UsuarioPerfilTipoId",
                table: "UsuarioEntidadePerfis",
                newName: "IX_UsuarioEntidadePerfis_UsuarioPerfilTipoId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioEntidadePerfil_UsuarioId",
                table: "UsuarioEntidadePerfis",
                newName: "IX_UsuarioEntidadePerfis_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioEntidadePerfil_EntidadeId",
                table: "UsuarioEntidadePerfis",
                newName: "IX_UsuarioEntidadePerfis_EntidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Entidade_MunicipioId",
                table: "Entidades",
                newName: "IX_Entidades_MunicipioId");

            migrationBuilder.RenameIndex(
                name: "IX_Entidade_EstadoId",
                table: "Entidades",
                newName: "IX_Entidades_EstadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Entidade_EntidadeTipoId",
                table: "Entidades",
                newName: "IX_Entidades_EntidadeTipoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioPerfilTipos",
                table: "UsuarioPerfilTipos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioEntidadePerfis",
                table: "UsuarioEntidadePerfis",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntidadeTipos",
                table: "EntidadeTipos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entidades",
                table: "Entidades",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entidades_EntidadeTipos_EntidadeTipoId",
                table: "Entidades",
                column: "EntidadeTipoId",
                principalTable: "EntidadeTipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entidades_Estados_EstadoId",
                table: "Entidades",
                column: "EstadoId",
                principalTable: "Estados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Entidades_Municipios_MunicipioId",
                table: "Entidades",
                column: "MunicipioId",
                principalTable: "Municipios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioEntidadePerfis_Entidades_EntidadeId",
                table: "UsuarioEntidadePerfis",
                column: "EntidadeId",
                principalTable: "Entidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioEntidadePerfis_Usuarios_UsuarioId",
                table: "UsuarioEntidadePerfis",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioEntidadePerfis_UsuarioPerfilTipos_UsuarioPerfilTipoId",
                table: "UsuarioEntidadePerfis",
                column: "UsuarioPerfilTipoId",
                principalTable: "UsuarioPerfilTipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entidades_EntidadeTipos_EntidadeTipoId",
                table: "Entidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Entidades_Estados_EstadoId",
                table: "Entidades");

            migrationBuilder.DropForeignKey(
                name: "FK_Entidades_Municipios_MunicipioId",
                table: "Entidades");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioEntidadePerfis_Entidades_EntidadeId",
                table: "UsuarioEntidadePerfis");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioEntidadePerfis_Usuarios_UsuarioId",
                table: "UsuarioEntidadePerfis");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioEntidadePerfis_UsuarioPerfilTipos_UsuarioPerfilTipoId",
                table: "UsuarioEntidadePerfis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioPerfilTipos",
                table: "UsuarioPerfilTipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioEntidadePerfis",
                table: "UsuarioEntidadePerfis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntidadeTipos",
                table: "EntidadeTipos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Entidades",
                table: "Entidades");

            migrationBuilder.RenameTable(
                name: "UsuarioPerfilTipos",
                newName: "UsuarioPerfilTipo");

            migrationBuilder.RenameTable(
                name: "UsuarioEntidadePerfis",
                newName: "UsuarioEntidadePerfil");

            migrationBuilder.RenameTable(
                name: "EntidadeTipos",
                newName: "EntidadeTipo");

            migrationBuilder.RenameTable(
                name: "Entidades",
                newName: "Entidade");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioEntidadePerfis_UsuarioPerfilTipoId",
                table: "UsuarioEntidadePerfil",
                newName: "IX_UsuarioEntidadePerfil_UsuarioPerfilTipoId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioEntidadePerfis_UsuarioId",
                table: "UsuarioEntidadePerfil",
                newName: "IX_UsuarioEntidadePerfil_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioEntidadePerfis_EntidadeId",
                table: "UsuarioEntidadePerfil",
                newName: "IX_UsuarioEntidadePerfil_EntidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Entidades_MunicipioId",
                table: "Entidade",
                newName: "IX_Entidade_MunicipioId");

            migrationBuilder.RenameIndex(
                name: "IX_Entidades_EstadoId",
                table: "Entidade",
                newName: "IX_Entidade_EstadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Entidades_EntidadeTipoId",
                table: "Entidade",
                newName: "IX_Entidade_EntidadeTipoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioPerfilTipo",
                table: "UsuarioPerfilTipo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioEntidadePerfil",
                table: "UsuarioEntidadePerfil",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntidadeTipo",
                table: "EntidadeTipo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Entidade",
                table: "Entidade",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Entidade_EntidadeTipo_EntidadeTipoId",
                table: "Entidade",
                column: "EntidadeTipoId",
                principalTable: "EntidadeTipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_UsuarioEntidadePerfil_Entidade_EntidadeId",
                table: "UsuarioEntidadePerfil",
                column: "EntidadeId",
                principalTable: "Entidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioEntidadePerfil_Usuarios_UsuarioId",
                table: "UsuarioEntidadePerfil",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioEntidadePerfil_UsuarioPerfilTipo_UsuarioPerfilTipoId",
                table: "UsuarioEntidadePerfil",
                column: "UsuarioPerfilTipoId",
                principalTable: "UsuarioPerfilTipo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
