using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePremios.Data.Migrations
{
    public partial class UpdateCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cpf",
                table: "Cliente");

            migrationBuilder.AddColumn<string>(
                name: "Documento",
                table: "Cliente",
                type: "varchar(14)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TipoPessoa",
                table: "Cliente",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Documento",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "TipoPessoa",
                table: "Cliente");

            migrationBuilder.AddColumn<string>(
                name: "Cpf",
                table: "Cliente",
                type: "varchar(11)",
                fixedLength: true,
                maxLength: 11,
                nullable: false,
                defaultValue: "");
        }
    }
}
