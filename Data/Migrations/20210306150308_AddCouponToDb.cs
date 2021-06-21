using Microsoft.EntityFrameworkCore.Migrations;

namespace QadduraResturant.Data.Migrations
{
    public partial class AddCouponToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Coupons",
                table: "Coupons");

            migrationBuilder.DropColumn(
                name: "picture",
                table: "Coupons");

            migrationBuilder.RenameTable(
                name: "Coupons",
                newName: "Coupon");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coupon",
                table: "Coupon",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Coupon",
                table: "Coupon");

            migrationBuilder.RenameTable(
                name: "Coupon",
                newName: "Coupons");

            migrationBuilder.AddColumn<byte>(
                name: "picture",
                table: "Coupons",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coupons",
                table: "Coupons",
                column: "id");
        }
    }
}
