using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veripark.Data.Migrations
{
    public partial class IlkMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MusteriTipler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MusteriTipAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusteriTipler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OlayOncelikler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OlayOncelikAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxCozumSuresi = table.Column<int>(type: "int", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlayOncelikler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sikayetler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sikayetler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OlayTipler",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OlayTipAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OlayOncelikId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Silindi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OlayTipler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OlayTipler_OlayOncelikler_OlayOncelikId",
                        column: x => x.OlayOncelikId,
                        principalTable: "OlayOncelikler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OlayTipler_OlayOncelikId",
                table: "OlayTipler",
                column: "OlayOncelikId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MusteriTipler");

            migrationBuilder.DropTable(
                name: "OlayTipler");

            migrationBuilder.DropTable(
                name: "Sikayetler");

            migrationBuilder.DropTable(
                name: "OlayOncelikler");
        }
    }
}
