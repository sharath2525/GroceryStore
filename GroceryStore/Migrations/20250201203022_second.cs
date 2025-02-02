using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroceryStore.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShoppingCartCartId",
                table: "ShoppingCarts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCarts_ShoppingCartCartId",
                table: "ShoppingCarts",
                column: "ShoppingCartCartId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_ShoppingCarts_ShoppingCartCartId",
                table: "ShoppingCarts",
                column: "ShoppingCartCartId",
                principalTable: "ShoppingCarts",
                principalColumn: "CartId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_ShoppingCarts_ShoppingCartCartId",
                table: "ShoppingCarts");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCarts_ShoppingCartCartId",
                table: "ShoppingCarts");

            migrationBuilder.DropColumn(
                name: "ShoppingCartCartId",
                table: "ShoppingCarts");
        }
    }
}
