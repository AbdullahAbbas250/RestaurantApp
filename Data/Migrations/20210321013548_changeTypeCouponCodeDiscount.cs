using Microsoft.EntityFrameworkCore.Migrations;

namespace QadduraResturant.Data.Migrations
{
    public partial class changeTypeCouponCodeDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "CouponCodeDiscount",
                table: "OrderHeaders",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "OrderHeaders",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "OrderHeaders");

            migrationBuilder.AlterColumn<string>(
                name: "CouponCodeDiscount",
                table: "OrderHeaders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "OrderDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double));
        }
    }
}
