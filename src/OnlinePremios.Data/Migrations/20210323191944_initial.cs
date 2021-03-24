using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePremios.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: true),
                    UserUpdate = table.Column<Guid>(nullable: true),
                    Nome = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false),
                    Documento = table.Column<string>(type: "varchar(14)", nullable: false),
                    TipoPessoa = table.Column<int>(nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    StatusCliente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sorteio",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: true),
                    UserUpdate = table.Column<Guid>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    DataInicial = table.Column<DateTime>(nullable: false),
                    DataSorteio = table.Column<DateTime>(nullable: false),
                    QtdeCotas = table.Column<int>(nullable: false),
                    ValorCotas = table.Column<decimal>(nullable: false),
                    StatusSorteio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sorteio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: true),
                    UserUpdate = table.Column<Guid>(nullable: true),
                    DataCompra = table.Column<DateTime>(nullable: false),
                    QtdeCotas = table.Column<int>(nullable: false),
                    StatusCompra = table.Column<int>(nullable: false),
                    ClienteId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Galeria",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: true),
                    UserUpdate = table.Column<Guid>(nullable: true),
                    SorteioId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galeria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Galeria_Sorteio_SorteioId",
                        column: x => x.SorteioId,
                        principalTable: "Sorteio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cota",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: true),
                    UserUpdate = table.Column<Guid>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    StatusCota = table.Column<int>(nullable: false),
                    CompraId = table.Column<Guid>(nullable: false),
                    SorteioId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cota", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cota_Compra_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cota_Sorteio_SorteioId",
                        column: x => x.SorteioId,
                        principalTable: "Sorteio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: true),
                    UserUpdate = table.Column<Guid>(nullable: true),
                    Nome = table.Column<string>(type: "varchar(90)", maxLength: 200, nullable: false),
                    Descricao = table.Column<string>(type: "varchar(90)", maxLength: 200, nullable: false),
                    ImgURL = table.Column<string>(type: "varchar(90)", maxLength: 2000, nullable: false),
                    GaleriaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Galeria_GaleriaId",
                        column: x => x.GaleriaId,
                        principalTable: "Galeria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_ClienteId",
                table: "Compra",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Cota_CompraId",
                table: "Cota",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_Cota_SorteioId",
                table: "Cota",
                column: "SorteioId");

            migrationBuilder.CreateIndex(
                name: "IX_Galeria_SorteioId",
                table: "Galeria",
                column: "SorteioId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_GaleriaId",
                table: "Produto",
                column: "GaleriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cota");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Compra");

            migrationBuilder.DropTable(
                name: "Galeria");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Sorteio");
        }
    }
}
