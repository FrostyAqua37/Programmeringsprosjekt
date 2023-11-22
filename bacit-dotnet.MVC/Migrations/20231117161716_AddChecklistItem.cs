using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bacit_dotnet.MVC.Migrations
{
    /// <inheritdoc />
    public partial class AddChecklistItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChecklistItems",
                columns: table => new
                {
                    ChecklistItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    Kategori = table.Column<string>(nullable: true),
                    Sjekkpunkt = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    // Add other columns as necessary
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChecklistItems", x => x.ChecklistItemId);
                    table.ForeignKey(
                        name: "FK_ChecklistItems_ServiceOrders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "ServiceOrders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChecklistItems");
        }
    }

}

