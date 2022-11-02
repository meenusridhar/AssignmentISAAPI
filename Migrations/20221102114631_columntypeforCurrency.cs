using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentISAAPI.Migrations
{
    public partial class columntypeforCurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Currency",
                table: "HotelDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.InsertData(
                table: "HotelDetails",
                columns: new[] { "HotelCode", "Address", "Currency", "HotelDescriptions", "HotelName", "Latitude", "Longitude", "StarLevel", "TotalRate", "hotelMainImage", "policiesAndDisclaimer" },
                values: new object[] { 23, "Al Fosool Street,Tecom - Dubai", "AED", "The 4 Star modern hotel is designed in a way that reflects a cozy ambience with subtle decorations making you feel like home & offers guests coming to Dubai for Business or leisure the convenience of travel to tourist attractions, business districts & commercial areas such as Media City, Knowledge Village, Business Bay, Dubai Downtown and the Jebel Ali Industrial Free zone.<br/><br/>Auris Inn AlMuhanna is Located 5 minutes away from Dubai Internet City Metro station allowing you easy access to Dubai Marina, Jumeirah Beach, Palm Jumeirah, Mall of the Emirates, Dubai Mall, Ibn Battuta Mall, The Walk JBR & Emirates Golf Club & providing accessibility to taxi picks ups & drop offs on the spot. <br/><br/>The hotel features 145 rooms & suites with an option of smoking & nonsmoking rooms. There are also the treatment rooms offering you the ultimate wellness & health to help you relax with a selection of massages, facials, skin & full body treatments to help your body & mind to rejuvenate. Not only that but a fully equipped GYM for the fit ones & who would like to stay in shape is right across a view to the swimming pool on the 1st Floor.<br/><br/>We have also designed services & key amenities to make your stay your way starting with keeping you connected with the world to show off your stay & Vacay through Free Wi-Fi in all areas of the hotel including the rooms & suites. In addition to Free valet car parking for those who came from across the GCC.<br/><br/>Auris Inn Al Muhanna Hotel offers an all-round dining service with all-day dining at Didon restaurant serving an exquisite open buffet & Ucci Sushi restaurant which serves the most delicious and tasteful Japanese food.<br/><br/>You will also have access to lounge café for a chill out with your family & friends, The terrace for relaxing & enjoying a shisha or hookah & in room dining service with a selection of Arabic & international dishes from ala carte menu served in the comfort of your room 24 hours a day.", "AURIS INN AL MUHANNA HOTEL", 55.177206300000002, 25.094456999999998, "4S", 150.0, "", "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dirham to be paid by guest directly to the hotel per room per night#&#" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelDetails",
                keyColumn: "HotelCode",
                keyValue: 23);

            migrationBuilder.AlterColumn<double>(
                name: "Currency",
                table: "HotelDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
