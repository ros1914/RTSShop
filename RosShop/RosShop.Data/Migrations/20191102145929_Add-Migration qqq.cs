﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace RosShop.Data.Migrations
{
    public partial class AddMigrationqqq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCards_Shippers_ShippersId",
                table: "ShopingCards");

            migrationBuilder.DropIndex(
                name: "IX_ShopingCards_ShippersId",
                table: "ShopingCards");

            migrationBuilder.DropColumn(
                name: "ShippersId",
                table: "ShopingCards");

            migrationBuilder.AddColumn<int>(
                name: "ShopingId",
                table: "Shippers",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.DropColumn(
                name: "ShopingId",
                table: "Shippers");

            migrationBuilder.AddColumn<int>(
                name: "ShippersId",
                table: "ShopingCards",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ShopingCards_ShippersId",
                table: "ShopingCards",
                column: "ShippersId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopingCards_Shippers_ShippersId",
                table: "ShopingCards",
                column: "ShippersId",
                principalTable: "Shippers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
