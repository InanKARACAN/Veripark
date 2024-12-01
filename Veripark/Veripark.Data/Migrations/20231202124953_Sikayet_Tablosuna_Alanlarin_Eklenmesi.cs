using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veripark.Data.Migrations
{
    public partial class Sikayet_Tablosuna_Alanlarin_Eklenmesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Sikayetler");

            migrationBuilder.AddColumn<string>(
                name: "MusteriAdi",
                table: "Sikayetler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "MusteriTipi",
                table: "Sikayetler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "OlayTipi",
                table: "Sikayetler",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "OlayZamani",
                table: "Sikayetler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MusteriAdi",
                table: "Sikayetler");

            migrationBuilder.DropColumn(
                name: "MusteriTipi",
                table: "Sikayetler");

            migrationBuilder.DropColumn(
                name: "OlayTipi",
                table: "Sikayetler");

            migrationBuilder.DropColumn(
                name: "OlayZamani",
                table: "Sikayetler");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Sikayetler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
