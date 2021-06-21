using Microsoft.EntityFrameworkCore.Migrations;

namespace QadduraResturant.Data.Migrations
{
    public partial class AddItemsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    image = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    spicyness = table.Column<string>(nullable: true),
                    subCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.id);
                    table.ForeignKey(
                        name: "FK_items_subCategory_subCategoryId",
                        column: x => x.subCategoryId,
                        principalTable: "subCategory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_items_subCategoryId",
                table: "items",
                column: "subCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "items");
        }
    }
}
