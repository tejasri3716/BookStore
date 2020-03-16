using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class notes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddImg",
                table: "Notes",
                newName: "AddImage");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AddImage",
                table: "Notes",
                newName: "AddImg");
        }
    }
}
