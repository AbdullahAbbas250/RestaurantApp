using Microsoft.EntityFrameworkCore.Migrations;

namespace QadduraResturant.Data.Migrations
{
    public partial class AddCoponToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Coupon",
                table: "Coupon");

            migrationBuilder.RenameTable(
                name: "Coupon",
                newName: "Copon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Copon",
                table: "Copon",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Copon",
                table: "Copon");

            migrationBuilder.RenameTable(
                name: "Copon",
                newName: "Coupon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coupon",
                table: "Coupon",
                column: "id");
        }
    }
}
