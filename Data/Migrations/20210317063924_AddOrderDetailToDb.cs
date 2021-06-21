using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QadduraResturant.Data.Migrations
{
    public partial class AddOrderDetailToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCard_MenuItem_MenuItemid",
                table: "ShoppingCard");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCard_MenuItemid",
                table: "ShoppingCard");

            migrationBuilder.RenameColumn(
                name: "MenuItemid",
                table: "ShoppingCard",
                newName: "MenuItemId");

            migrationBuilder.AlterColumn<int>(
                name: "MenuItemId",
                table: "ShoppingCard",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "OrderHeaders",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<string>(nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    OrderTotal = table.Column<double>(nullable: false),
                    OrderAfterDiscount = table.Column<double>(nullable: false),
                    PickUpTime = table.Column<DateTime>(nullable: false),
                    CouponCode = table.Column<string>(nullable: true),
                    CouponCodeDiscount = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    PickUpName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    TransactionId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderHeaders", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderHeaders_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    itemId = table.Column<int>(nullable: false),
                    count = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderHeaders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OrderHeaders",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_MenuItem_itemId",
                        column: x => x.itemId,
                        principalTable: "MenuItem",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_itemId",
                table: "OrderDetails",
                column: "itemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeaders_userId",
                table: "OrderHeaders",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderHeaders");

            migrationBuilder.RenameColumn(
                name: "MenuItemId",
                table: "ShoppingCard",
                newName: "MenuItemid");

            migrationBuilder.AlterColumn<int>(
                name: "MenuItemid",
                table: "ShoppingCard",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCard_MenuItemid",
                table: "ShoppingCard",
                column: "MenuItemid");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCard_MenuItem_MenuItemid",
                table: "ShoppingCard",
                column: "MenuItemid",
                principalTable: "MenuItem",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
