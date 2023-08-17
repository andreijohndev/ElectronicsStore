using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElectronicsStore.Migrations
{
    /// <inheritdoc />
    public partial class AddProductForeignKeyToInventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductInventory",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductInventory_ProductId",
                table: "ProductInventory",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductInventory_Product_ProductId",
                table: "ProductInventory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductInventory_Product_ProductId",
                table: "ProductInventory");

            migrationBuilder.DropIndex(
                name: "IX_ProductInventory_ProductId",
                table: "ProductInventory");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductInventory");
        }
    }
}
