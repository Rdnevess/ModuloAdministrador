using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuloAdministrador.Infra.Data.Migrations
{
    public partial class RetornaSistLegado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdSistemaLegado",
                table: "Entidade",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdSistemaLegado",
                table: "Entidade");
        }
    }
}
