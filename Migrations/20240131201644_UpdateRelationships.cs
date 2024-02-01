using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOTNET_PIZZA_APP.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkSizeDrinkType_DrinkSizes_DrinkSizesDrinkSizeId",
                table: "DrinkSizeDrinkType");

            migrationBuilder.DropForeignKey(
                name: "FK_DrinkSizeDrinkType_DrinkTypes_DrinkTypesDrinkTypeId",
                table: "DrinkSizeDrinkType");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaToppingsPizzaType_PizzaTypes_PizzaTypesPizzaTypeId",
                table: "PizzaToppingsPizzaType");

            migrationBuilder.RenameColumn(
                name: "PizzaTypeId",
                table: "PizzaTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PizzaTypesPizzaTypeId",
                table: "PizzaToppingsPizzaType",
                newName: "PizzaTypesId");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaToppingsPizzaType_PizzaTypesPizzaTypeId",
                table: "PizzaToppingsPizzaType",
                newName: "IX_PizzaToppingsPizzaType_PizzaTypesId");

            migrationBuilder.RenameColumn(
                name: "PizzaSizeId",
                table: "PizzaSizes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PizzaPriceId",
                table: "PizzaPrices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OrderItemId",
                table: "OrderItems",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DrinkTypeId",
                table: "DrinkTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DrinkSizeId",
                table: "DrinkSizes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DrinkTypesDrinkTypeId",
                table: "DrinkSizeDrinkType",
                newName: "DrinkTypesId");

            migrationBuilder.RenameColumn(
                name: "DrinkSizesDrinkSizeId",
                table: "DrinkSizeDrinkType",
                newName: "DrinkSizesId");

            migrationBuilder.RenameIndex(
                name: "IX_DrinkSizeDrinkType_DrinkTypesDrinkTypeId",
                table: "DrinkSizeDrinkType",
                newName: "IX_DrinkSizeDrinkType_DrinkTypesId");

            migrationBuilder.AddColumn<int>(
                name: "OrderPrice",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PizzaSizePizzaType",
                columns: table => new
                {
                    PizzaSizesId = table.Column<string>(type: "text", nullable: false),
                    PizzaTypesId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaSizePizzaType", x => new { x.PizzaSizesId, x.PizzaTypesId });
                    table.ForeignKey(
                        name: "FK_PizzaSizePizzaType_PizzaSizes_PizzaSizesId",
                        column: x => x.PizzaSizesId,
                        principalTable: "PizzaSizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PizzaSizePizzaType_PizzaTypes_PizzaTypesId",
                        column: x => x.PizzaTypesId,
                        principalTable: "PizzaTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PizzaSizePizzaType_PizzaTypesId",
                table: "PizzaSizePizzaType",
                column: "PizzaTypesId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkSizeDrinkType_DrinkSizes_DrinkSizesId",
                table: "DrinkSizeDrinkType",
                column: "DrinkSizesId",
                principalTable: "DrinkSizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkSizeDrinkType_DrinkTypes_DrinkTypesId",
                table: "DrinkSizeDrinkType",
                column: "DrinkTypesId",
                principalTable: "DrinkTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaToppingsPizzaType_PizzaTypes_PizzaTypesId",
                table: "PizzaToppingsPizzaType",
                column: "PizzaTypesId",
                principalTable: "PizzaTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrinkSizeDrinkType_DrinkSizes_DrinkSizesId",
                table: "DrinkSizeDrinkType");

            migrationBuilder.DropForeignKey(
                name: "FK_DrinkSizeDrinkType_DrinkTypes_DrinkTypesId",
                table: "DrinkSizeDrinkType");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaToppingsPizzaType_PizzaTypes_PizzaTypesId",
                table: "PizzaToppingsPizzaType");

            migrationBuilder.DropTable(
                name: "PizzaSizePizzaType");

            migrationBuilder.DropColumn(
                name: "OrderPrice",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PizzaTypes",
                newName: "PizzaTypeId");

            migrationBuilder.RenameColumn(
                name: "PizzaTypesId",
                table: "PizzaToppingsPizzaType",
                newName: "PizzaTypesPizzaTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaToppingsPizzaType_PizzaTypesId",
                table: "PizzaToppingsPizzaType",
                newName: "IX_PizzaToppingsPizzaType_PizzaTypesPizzaTypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PizzaSizes",
                newName: "PizzaSizeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PizzaPrices",
                newName: "PizzaPriceId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OrderItems",
                newName: "OrderItemId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DrinkTypes",
                newName: "DrinkTypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DrinkSizes",
                newName: "DrinkSizeId");

            migrationBuilder.RenameColumn(
                name: "DrinkTypesId",
                table: "DrinkSizeDrinkType",
                newName: "DrinkTypesDrinkTypeId");

            migrationBuilder.RenameColumn(
                name: "DrinkSizesId",
                table: "DrinkSizeDrinkType",
                newName: "DrinkSizesDrinkSizeId");

            migrationBuilder.RenameIndex(
                name: "IX_DrinkSizeDrinkType_DrinkTypesId",
                table: "DrinkSizeDrinkType",
                newName: "IX_DrinkSizeDrinkType_DrinkTypesDrinkTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkSizeDrinkType_DrinkSizes_DrinkSizesDrinkSizeId",
                table: "DrinkSizeDrinkType",
                column: "DrinkSizesDrinkSizeId",
                principalTable: "DrinkSizes",
                principalColumn: "DrinkSizeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DrinkSizeDrinkType_DrinkTypes_DrinkTypesDrinkTypeId",
                table: "DrinkSizeDrinkType",
                column: "DrinkTypesDrinkTypeId",
                principalTable: "DrinkTypes",
                principalColumn: "DrinkTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaToppingsPizzaType_PizzaTypes_PizzaTypesPizzaTypeId",
                table: "PizzaToppingsPizzaType",
                column: "PizzaTypesPizzaTypeId",
                principalTable: "PizzaTypes",
                principalColumn: "PizzaTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
