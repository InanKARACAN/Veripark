using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Veripark.Data.Migrations
{
    public partial class MusteriTip_Tablosuna_MaxCozumSuresi_eklenmesi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxCozumSuresi",
                table: "MusteriTipler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxCozumSuresi",
                table: "MusteriTipler");
        }
    }
}
