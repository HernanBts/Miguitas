using Microsoft.EntityFrameworkCore.Migrations;

namespace Miguitas.Web.Migrations
{
    public partial class FieldAddressToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Addres",
                table: "AspNetUsers",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Addres",
                table: "AspNetUsers");
        }
    }
}
