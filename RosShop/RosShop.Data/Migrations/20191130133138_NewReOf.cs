using Microsoft.EntityFrameworkCore.Migrations;

namespace RosShop.Data.Migrations
{
    public partial class NewReOf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ShopingCards_ShopingId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ShopingId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ShopingId",
                table: "Products");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ShopingId",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShopingId",
                table: "Products",
                column: "ShopingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ShopingCards_ShopingId",
                table: "Products",
                column: "ShopingId",
                principalTable: "ShopingCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
