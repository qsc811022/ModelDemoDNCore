using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelDemoDNCore.Migrations
{
    public partial class addLenderAitemNameColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lender",
                table: "Item",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Lender",
                table: "Item");
        }
    }
}
