using Microsoft.EntityFrameworkCore.Migrations;

namespace MirumTeste.Infra.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCargo",
                table: "Pessoa",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCargo",
                table: "Pessoa");
        }
    }
}
