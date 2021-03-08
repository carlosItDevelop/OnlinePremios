using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePremios.Data.Migrations
{
    public partial class UpdateProdutoNomeImgUrlEDescricao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Produto");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Produto",
                type: "varchar(90)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Produto",
                type: "varchar(90)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Produto");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Produto",
                type: "varchar(90)",
                maxLength: 400,
                nullable: false,
                defaultValue: "");
        }
    }
}
