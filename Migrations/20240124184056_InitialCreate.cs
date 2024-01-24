using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DOTNET_PIZZA_APP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrinkSizes",
                columns: table => new
                {
                    DrinkSizeId = table.Column<string>(type: "text", nullable: false),
                    DrinkSizeName = table.Column<string>(type: "text", nullable: false),
                    DrinkSizePrice = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkSizes", x => x.DrinkSizeId);
                });

            migrationBuilder.CreateTable(
                name: "DrinkTypes",
                columns: table => new
                {
                    DrinkTypeId = table.Column<string>(type: "text", nullable: false),
                    DrinkTypeName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkTypes", x => x.DrinkTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "PizzaSizes",
                columns: table => new
                {
                    PizzaSizeId = table.Column<string>(type: "text", nullable: false),
                    PizzaSizeName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaSizes", x => x.PizzaSizeId);
                });

            migrationBuilder.CreateTable(
                name: "PizzaToppings",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ToppingName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaToppings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PizzaTypes",
                columns: table => new
                {
                    PizzaTypeId = table.Column<string>(type: "text", nullable: false),
                    PizzaName = table.Column<string>(type: "text", nullable: false),
                    PizzaDescription = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaTypes", x => x.PizzaTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DrinkSizeDrinkType",
                columns: table => new
                {
                    DrinkSizesDrinkSizeId = table.Column<string>(type: "text", nullable: false),
                    DrinkTypesDrinkTypeId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrinkSizeDrinkType", x => new { x.DrinkSizesDrinkSizeId, x.DrinkTypesDrinkTypeId });
                    table.ForeignKey(
                        name: "FK_DrinkSizeDrinkType_DrinkSizes_DrinkSizesDrinkSizeId",
                        column: x => x.DrinkSizesDrinkSizeId,
                        principalTable: "DrinkSizes",
                        principalColumn: "DrinkSizeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrinkSizeDrinkType_DrinkTypes_DrinkTypesDrinkTypeId",
                        column: x => x.DrinkTypesDrinkTypeId,
                        principalTable: "DrinkTypes",
                        principalColumn: "DrinkTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<string>(type: "text", nullable: false),
                    DrinkTypeId = table.Column<string>(type: "text", nullable: false),
                    DrinkSizeId = table.Column<string>(type: "text", nullable: false),
                    PizzaTypeId = table.Column<string>(type: "text", nullable: true),
                    PizzaSizeId = table.Column<string>(type: "text", nullable: true),
                    OrderId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItems_DrinkSizes_DrinkSizeId",
                        column: x => x.DrinkSizeId,
                        principalTable: "DrinkSizes",
                        principalColumn: "DrinkSizeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_DrinkTypes_DrinkTypeId",
                        column: x => x.DrinkTypeId,
                        principalTable: "DrinkTypes",
                        principalColumn: "DrinkTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                    table.ForeignKey(
                        name: "FK_OrderItems_PizzaSizes_PizzaSizeId",
                        column: x => x.PizzaSizeId,
                        principalTable: "PizzaSizes",
                        principalColumn: "PizzaSizeId");
                    table.ForeignKey(
                        name: "FK_OrderItems_PizzaTypes_PizzaTypeId",
                        column: x => x.PizzaTypeId,
                        principalTable: "PizzaTypes",
                        principalColumn: "PizzaTypeId");
                });

            migrationBuilder.CreateTable(
                name: "PizzaPrices",
                columns: table => new
                {
                    PizzaPriceId = table.Column<string>(type: "text", nullable: false),
                    PizzaTypeId = table.Column<string>(type: "text", nullable: true),
                    PizzaSizeId = table.Column<string>(type: "text", nullable: true),
                    PizzaPriceAmount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaPrices", x => x.PizzaPriceId);
                    table.ForeignKey(
                        name: "FK_PizzaPrices_PizzaSizes_PizzaSizeId",
                        column: x => x.PizzaSizeId,
                        principalTable: "PizzaSizes",
                        principalColumn: "PizzaSizeId");
                    table.ForeignKey(
                        name: "FK_PizzaPrices_PizzaTypes_PizzaTypeId",
                        column: x => x.PizzaTypeId,
                        principalTable: "PizzaTypes",
                        principalColumn: "PizzaTypeId");
                });

            migrationBuilder.CreateTable(
                name: "PizzaToppingsPizzaType",
                columns: table => new
                {
                    PizzaToppingsId = table.Column<string>(type: "text", nullable: false),
                    PizzaTypesPizzaTypeId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaToppingsPizzaType", x => new { x.PizzaToppingsId, x.PizzaTypesPizzaTypeId });
                    table.ForeignKey(
                        name: "FK_PizzaToppingsPizzaType_PizzaToppings_PizzaToppingsId",
                        column: x => x.PizzaToppingsId,
                        principalTable: "PizzaToppings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PizzaToppingsPizzaType_PizzaTypes_PizzaTypesPizzaTypeId",
                        column: x => x.PizzaTypesPizzaTypeId,
                        principalTable: "PizzaTypes",
                        principalColumn: "PizzaTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrinkSizeDrinkType_DrinkTypesDrinkTypeId",
                table: "DrinkSizeDrinkType",
                column: "DrinkTypesDrinkTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DrinkSizeId",
                table: "OrderItems",
                column: "DrinkSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DrinkTypeId",
                table: "OrderItems",
                column: "DrinkTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_PizzaSizeId",
                table: "OrderItems",
                column: "PizzaSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_PizzaTypeId",
                table: "OrderItems",
                column: "PizzaTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaPrices_PizzaSizeId",
                table: "PizzaPrices",
                column: "PizzaSizeId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaPrices_PizzaTypeId",
                table: "PizzaPrices",
                column: "PizzaTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaToppingsPizzaType_PizzaTypesPizzaTypeId",
                table: "PizzaToppingsPizzaType",
                column: "PizzaTypesPizzaTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrinkSizeDrinkType");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "PizzaPrices");

            migrationBuilder.DropTable(
                name: "PizzaToppingsPizzaType");

            migrationBuilder.DropTable(
                name: "DrinkSizes");

            migrationBuilder.DropTable(
                name: "DrinkTypes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PizzaSizes");

            migrationBuilder.DropTable(
                name: "PizzaToppings");

            migrationBuilder.DropTable(
                name: "PizzaTypes");
        }
    }
}
