using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentISAAPI.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HotelDetails",
                columns: table => new
                {
                    HotelCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalRate = table.Column<double>(type: "float", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StarLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hotelMainImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    policiesAndDisclaimer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelDescriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Currency = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelDetails", x => x.HotelCode);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelDetails");
        }
    }
}
