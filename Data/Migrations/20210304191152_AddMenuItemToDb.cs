using Microsoft.EntityFrameworkCore.Migrations;

namespace QadduraResturant.Data.Migrations
{
    public partial class AddMenuItemToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.CreateTable(
                name: "MenuItem",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    price = table.Column<double>(nullable: false),
                    image = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    spicyness = table.Column<string>(nullable: true),
                    subCategoryId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_MenuItem_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MenuItem_subCategory_subCategoryId",
                        column: x => x.subCategoryId,
                        principalTable: "subCategory",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_CategoryId",
                table: "MenuItem",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuItem_subCategoryId",
                table: "MenuItem",
                column: "subCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItem");

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    spicyness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    subCategoryId = table.Column<int>(type: "int", nullable: false)
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
    }
}
