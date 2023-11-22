using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace bacit_dotnet.MVC.Migrations
{
    /// <inheritdoc />
    public partial class AddCommentToServiceOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "ServiceOrders",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "ServiceOrders");
        }
    }
}
