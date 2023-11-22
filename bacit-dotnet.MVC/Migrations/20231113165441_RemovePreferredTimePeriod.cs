using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bacit_dotnet.MVC.Migrations
{
    /// <inheritdoc />
    public partial class RemovePreferredTimePeriod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mechanic",
                table: "ServiceOrders");

            migrationBuilder.DropColumn(
                name: "PreferredTimePeriod",
                table: "ServiceOrders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Mechanic",
                table: "ServiceOrders",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "PreferredTimePeriod",
                table: "ServiceOrders",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
