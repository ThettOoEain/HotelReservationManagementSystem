using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelReservationManagementSystem.Data.Migrations
{
    public partial class CategoryToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "Category",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Category",
                newName: "name");
        }
    }
}
