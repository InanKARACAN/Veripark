using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veripark.Data.Migrations
{
    public partial class Sikayet_Tablosun_MaxVerilenSure_Eklenmesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxVerilenSure",
                table: "Sikayetler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxVerilenSure",
                table: "Sikayetler");
        }
    }
}
