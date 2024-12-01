using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veripark.Data.Migrations
{
    public partial class Sikayet_Tablosuna_CepTelefonu_Alani_Eklenmesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CepTelefonu",
                table: "Sikayetler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CepTelefonu",
                table: "Sikayetler");
        }
    }
}
