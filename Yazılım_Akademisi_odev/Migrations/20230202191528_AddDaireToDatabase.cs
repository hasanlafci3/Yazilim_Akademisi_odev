using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Yazılım_Akademisi_odev.Migrations
{
    public partial class AddDaireToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Daire_no",
                table: "Daireler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Daire_no",
                table: "Daireler");
        }
    }
}
