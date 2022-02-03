using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K205Agency.Migrations
{
    public partial class Servicess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Services",
                table: "Services");

            migrationBuilder.RenameTable(
                name: "Services",
                newName: "Servicess");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Servicess",
                table: "Servicess",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Servicess",
                table: "Servicess");

            migrationBuilder.RenameTable(
                name: "Servicess",
                newName: "Services");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Services",
                table: "Services",
                column: "ID");
        }
    }
}
