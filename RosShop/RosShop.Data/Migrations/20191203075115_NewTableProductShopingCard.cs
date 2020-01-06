using Microsoft.EntityFrameworkCore.Migrations;

namespace RosShop.Data.Migrations
{
    public partial class NewTableProductShopingCard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCards_Products_ProductId",
                table: "ShopingCards");

            migrationBuilder.DropIndex(
                name: "IX_ShopingCards_ProductId",
                table: "ShopingCards");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ShopingCards");

            migrationBuilder.CreateTable(
                name: "ProductShopingCard",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    ShopingCardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductShopingCard", x => new { x.ProductId, x.ShopingCardId });
                    table.ForeignKey(
                        name: "FK_ProductShopingCard_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductShopingCard_ShopingCards_ShopingCardId",
                        column: x => x.ShopingCardId,
                        principalTable: "ShopingCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductShopingCard_ShopingCardId",
                table: "ProductShopingCard",
                column: "ShopingCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductShopingCard");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ShopingCards",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopingCards_ProductId",
                table: "ShopingCards",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopingCards_Products_ProductId",
                table: "ShopingCards",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
