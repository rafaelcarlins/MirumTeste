using Microsoft.EntityFrameworkCore.Migrations;

namespace MirumTeste.Infra.Migrations
{
    public partial class Teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCargo",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "IdPessoa",
                table: "Cargo");

            migrationBuilder.AddColumn<int>(
                name: "CargoId",
                table: "Pessoa",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_CargoId",
                table: "Pessoa",
                column: "CargoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Cargo_CargoId",
                table: "Pessoa",
                column: "CargoId",
                principalTable: "Cargo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Cargo_CargoId",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_CargoId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "CargoId",
                table: "Pessoa");

            migrationBuilder.AddColumn<int>(
                name: "IdCargo",
                table: "Pessoa",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPessoa",
                table: "Cargo",
                nullable: false,
                defaultValue: 0);
        }
    }
}
