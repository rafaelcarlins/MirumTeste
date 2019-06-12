using Microsoft.EntityFrameworkCore.Migrations;

namespace MirumTeste.Infra.Migrations
{
    public partial class AlteradoTiposTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoa",
                type: "varchar(80)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Pessoa",
                type: "varchar(80)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Funcao",
                table: "Cargo",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pessoa",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Pessoa",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Funcao",
                table: "Cargo",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true);
        }
    }
}
