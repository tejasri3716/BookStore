using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class tr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CustId",
                table: "Customers",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "CustId");
        }
    }
}
