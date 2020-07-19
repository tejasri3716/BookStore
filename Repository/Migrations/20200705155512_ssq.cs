using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class ssq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Name = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<long>(nullable: false),
                    Pincode = table.Column<int>(nullable: false),
                    Locality = table.Column<string>(nullable: false),
                    Landmark = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    TypeOfLocation = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    CustId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Email);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
