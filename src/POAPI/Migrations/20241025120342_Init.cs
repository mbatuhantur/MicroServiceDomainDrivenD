using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace POAPI.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PurchaseQuoteId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseRequestId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseQuote",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Offer_Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    offer_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseRequestId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseQuote", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseRequests",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status_Id = table.Column<int>(type: "int", nullable: false),
                    Budget_Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Budget_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseRequests", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "PurchaseQuote");

            migrationBuilder.DropTable(
                name: "PurchaseRequests");
        }
    }
}
