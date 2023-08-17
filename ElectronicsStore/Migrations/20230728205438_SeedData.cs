using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ElectronicsStore.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mouse" },
                    { 2, "Keyboard" },
                    { 3, "Controller" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "InventoryId", "Name", "Price", "ThumbnailUri" },
                values: new object[,]
                {
                    { 1, 1, "Ultra-Lightweight Gaming Mouse with Razer™ Chroma RGB", 1, "Razer Viper Mini", 1500m, "images/razer_viper_mini.png" },
                    { 2, 1, "Ambidextrous Esports Gaming Mouse with 8000Hz Polling Rate", 2, "Razer Viper 8KHz", 2250m, "images/razer_viper.png" },
                    { 3, 1, "LIGHTSPEED Wireless Gaming Mouse", 3, "Logitech G305", 2200m, "images/logitech_g305.png" },
                    { 4, 1, "HERO Gaming Mouse", 4, "Logitech G403", 2600m, "images/logitech_g403.png" },
                    { 5, 1, "SUPERLIGHT", 5, "Logitech G PRO X", 8000m, "images/logitech_g_pro_x.png" },
                    { 6, 1, "Wired Gaming Mouse with Best-in-class Ergonomics", 6, "Razer DeathAdder V2", 2500m, "images/razer_deathadder_v2.png" },
                    { 7, 1, "MMO Wireless Gaming Mouse with HyperScroll Pro Wheel", 7, "Razer Naga V2 Pro", 7000m, "images/razer_naga_v2_pro.png" },
                    { 8, 2, "Compact Mechanical keyboard with Razer Chroma RGB", 8, "Razer BlackWidow V3 Pro Tenkeyless", 7690m, "images/razer_blackwidow_v3_pro_tkl.png" },
                    { 9, 2, "60% Gaming Keyboard with Razer™ Optical Switch", 9, "Razer Huntsman Mini", 6500m, "images/razer_huntsman_mini.png" },
                    { 10, 2, "KEYBOARD", 10, "Logitech G PRO", 5500m, "images/logitech_g_pro.png" },
                    { 11, 3, "", 11, "8BitDo SN30 Pro", 1500m, "images/8bitdo_sn30_pro.png" },
                    { 12, 3, "", 12, "8BitDo Pro 2", 2000m, "images/8bitdo_pro_2.png" }
                });

            migrationBuilder.InsertData(
                table: "ProductInventory",
                columns: new[] { "Id", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 34 },
                    { 2, 2, 36 },
                    { 3, 3, 25 },
                    { 4, 4, 35 },
                    { 5, 5, 22 },
                    { 6, 6, 18 },
                    { 7, 7, 25 },
                    { 8, 8, 15 },
                    { 9, 9, 21 },
                    { 10, 10, 23 },
                    { 11, 11, 46 },
                    { 12, 12, 34 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductInventory",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
