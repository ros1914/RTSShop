using Microsoft.EntityFrameworkCore.Migrations;

namespace RosShop.Data.Migrations
{
    public partial class AddRelationShipeShippers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shippers_ShopingCards_ShopingCardId",
                table: "Shippers");

            migrationBuilder.DropIndex(
                name: "IX_Shippers_ShopingCardId",
                table: "Shippers");

            migrationBuilder.DropColumn(
                name: "ShopingCardId",
                table: "Shippers");

            migrationBuilder.CreateIndex(
                name: "IX_Shippers_ShopingId",
                table: "Shippers",
                column: "ShopingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shippers_ShopingCards_ShopingId",
                table: "Shippers",
                column: "ShopingId",
                principalTable: "ShopingCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shippers_ShopingCards_ShopingId",
                table: "Shippers");

            migrationBuilder.DropIndex(
                name: "IX_Shippers_ShopingId",
                table: "Shippers");

            migrationBuilder.AddColumn<int>(
                name: "ShopingCardId",
                table: "Shippers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shippers_ShopingCardId",
                table: "Shippers",
                column: "ShopingCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shippers_ShopingCards_ShopingCardId",
                table: "Shippers",
                column: "ShopingCardId",
                principalTable: "ShopingCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
