using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlinePremio.Mvc.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            //migrationBuilder.CreateTable(
            //    name: "Cliente",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        DataCadastro = table.Column<DateTime>(nullable: true),
            //        DataAtualizacao = table.Column<DateTime>(nullable: true),
            //        UserUpdate = table.Column<Guid>(nullable: true),
            //        Nome = table.Column<string>(nullable: true),
            //        Documento = table.Column<string>(nullable: true),
            //        TipoPessoa = table.Column<int>(nullable: false),
            //        Email = table.Column<string>(nullable: true),
            //        StatusCliente = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Cliente", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Sorteio",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        DataCadastro = table.Column<DateTime>(nullable: true),
            //        DataAtualizacao = table.Column<DateTime>(nullable: true),
            //        UserUpdate = table.Column<Guid>(nullable: true),
            //        Numero = table.Column<int>(nullable: false),
            //        DataInicial = table.Column<DateTime>(nullable: false),
            //        DataSorteio = table.Column<DateTime>(nullable: false),
            //        QtdeCotas = table.Column<int>(nullable: false),
            //        ValorCotas = table.Column<decimal>(nullable: false),
            //        StatusSorteio = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Sorteio", x => x.Id);
            //    });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "Compra",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        DataCadastro = table.Column<DateTime>(nullable: true),
            //        DataAtualizacao = table.Column<DateTime>(nullable: true),
            //        UserUpdate = table.Column<Guid>(nullable: true),
            //        DataCompra = table.Column<DateTime>(nullable: false),
            //        QtdeCotas = table.Column<int>(nullable: false),
            //        StatusCompra = table.Column<int>(nullable: false),
            //        ClienteId = table.Column<Guid>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Compra", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Compra_Cliente_ClienteId",
            //            column: x => x.ClienteId,
            //            principalTable: "Cliente",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Galeria",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        DataCadastro = table.Column<DateTime>(nullable: true),
            //        DataAtualizacao = table.Column<DateTime>(nullable: true),
            //        UserUpdate = table.Column<Guid>(nullable: true),
            //        SorteioId = table.Column<Guid>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Galeria", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Galeria_Sorteio_SorteioId",
            //            column: x => x.SorteioId,
            //            principalTable: "Sorteio",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Cota",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        DataCadastro = table.Column<DateTime>(nullable: true),
            //        DataAtualizacao = table.Column<DateTime>(nullable: true),
            //        UserUpdate = table.Column<Guid>(nullable: true),
            //        Numero = table.Column<int>(nullable: false),
            //        Valor = table.Column<decimal>(nullable: false),
            //        StatusCota = table.Column<int>(nullable: false),
            //        CompraId = table.Column<Guid>(nullable: false),
            //        SorteioId = table.Column<Guid>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Cota", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Cota_Compra_CompraId",
            //            column: x => x.CompraId,
            //            principalTable: "Compra",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Cota_Sorteio_SorteioId",
            //            column: x => x.SorteioId,
            //            principalTable: "Sorteio",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Produto",
            //    columns: table => new
            //    {
            //        Id = table.Column<Guid>(nullable: false),
            //        DataCadastro = table.Column<DateTime>(nullable: true),
            //        DataAtualizacao = table.Column<DateTime>(nullable: true),
            //        UserUpdate = table.Column<Guid>(nullable: true),
            //        Nome = table.Column<string>(nullable: true),
            //        Descricao = table.Column<string>(nullable: true),
            //        ImgURL = table.Column<string>(nullable: true),
            //        GaleriaId = table.Column<Guid>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Produto", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Produto_Galeria_GaleriaId",
            //            column: x => x.GaleriaId,
            //            principalTable: "Galeria",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Compra_ClienteId",
            //    table: "Compra",
            //    column: "ClienteId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cota_CompraId",
            //    table: "Cota",
            //    column: "CompraId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cota_SorteioId",
            //    table: "Cota",
            //    column: "SorteioId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Galeria_SorteioId",
            //    table: "Galeria",
            //    column: "SorteioId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Produto_GaleriaId",
            //    table: "Produto",
            //    column: "GaleriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Cota");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

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
