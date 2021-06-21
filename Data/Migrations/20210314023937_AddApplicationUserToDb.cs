using Microsoft.EntityFrameworkCore.Migrations;

namespace QadduraResturant.Data.Migrations
{
    public partial class AddApplicationUserToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "AspNetUsers");
        }
    }
}
