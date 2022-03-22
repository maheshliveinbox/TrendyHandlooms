using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO Products(Name) VALUES('Product 01')");
            migrationBuilder.Sql($"INSERT INTO Products(Name) VALUES('Product 02')");
            migrationBuilder.Sql($"INSERT INTO Products(Name) VALUES('Product 02')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
