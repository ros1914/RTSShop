using Microsoft.EntityFrameworkCore.Migrations;

namespace RosShop.Data.Migrations
{
    public partial class CreatDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ShopingCards_ShopingId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ShopingId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ShopingId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ShopingCards",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopingCards_UserId",
                table: "ShopingCards",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopingCards_AspNetUsers_UserId",
                table: "ShopingCards",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCards_AspNetUsers_UserId",
                table: "ShopingCards");

            migrationBuilder.DropIndex(
                name: "IX_ShopingCards_UserId",
                table: "ShopingCards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ShopingCards");

            migrationBuilder.AddColumn<int>(
                name: "ShopingId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ShopingId",
                table: "AspNetUsers",
                column: "ShopingId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ShopingCards_ShopingId",
                table: "AspNetUsers",
                column: "ShopingId",
                principalTable: "ShopingCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
