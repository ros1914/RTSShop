using Microsoft.EntityFrameworkCore.Migrations;

namespace RosShop.Data.Migrations
{
    public partial class ShopingIdMakeNullabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ShopingCards_ShopingId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ShopingId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ShopingCards_ShopingId",
                table: "Products",
                column: "ShopingId",
                principalTable: "ShopingCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ShopingCards_ShopingId",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "ShopingId",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ShopingCards_ShopingId",
                table: "Products",
                column: "ShopingId",
                principalTable: "ShopingCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
