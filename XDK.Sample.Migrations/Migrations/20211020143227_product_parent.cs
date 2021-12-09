using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XDK.Sample.Migrations.Migrations
{
    public partial class product_parent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ParentProductId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ParentProductId",
                table: "Product",
                column: "ParentProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Product_ParentProductId",
                table: "Product",
                column: "ParentProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Product_ParentProductId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ParentProductId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ParentProductId",
                table: "Product");
        }
    }
}
