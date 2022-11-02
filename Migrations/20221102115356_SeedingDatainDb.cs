using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentISAAPI.Migrations
{
    public partial class SeedingDatainDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HotelDetails",
                columns: new[] { "HotelCode", "Address", "Currency", "HotelDescriptions", "HotelName", "Latitude", "Longitude", "StarLevel", "TotalRate", "hotelMainImage", "policiesAndDisclaimer" },
                values: new object[,]
                {
                    { 40, "Dubai International Airport", "AED", "Featuring direct access to Terminal 3 of Dubai International Airport.<br/>Polished rooms offer WiFi access, flat-screens and safes, plus minibars, and tea and coffee making facilities. Upgraded rooms add living and dining areas. The 1-bedroom suites feature kitchenettes, and separate living and dining rooms.<br/><br/>There's an airy buffet restaurant, an Irish pub, an East Asian bar/restaurant and a tapas bar, as well as 2 lounges, a business center, and meeting and event space. Other amenities include an indoor pool, hot tubs, saunas and steam rooms.", "DUBAI INTERNATIONAL AIRPORT TERMINAL HOTEL", 55.360878, 25.249102000000001, "4S", 633.0, "", "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dirham to be paid by guest directly to the hotel per room per night#&#" },
                    { 42, "Airport Road - Casablanca St - Dubai", "AED", "The award-winning Millennium Airport Hotel Dubai is a contemporary lifestyle destination for those who desire to be at the centre of Dubai's pulsating business and cultural scene. For the eight time since 2008, it was recognized as the Middle East's Leading Airport Hotel at the World Travel Awards (WTA) 2019. The hotel proudly provides guests with a “More Than Meets the Eye” touch that reflects the mindset of highly personalised and engaging services by each member of the hotel team.<br/><br/>This exceptional hotel is perfectly located just a few steps away from the GGICO Metro Station with easy access to all other public transportation. Only 5 to 10 minutes from Dubai International Airport, the hotel offers complimentary shuttle service to Terminals 1 & 3 every 45 minutes. The business districts of Deira, Dubai Airport Freezone and local attractions including Deira City Centre, Dubai Creek Golf & Yacht Club and Dubai Festival City are all less than 15 minutes away. The World Trade Centre, Dubai International Financial Centre, BurjKhalifa, Dubai Mall, Dubai Tennis Stadium, Irish Village, Gold and Spice Souk and Business Bay are all also conveniently close by, making Millennium Airport Hotel Dubai a preferred choice of stay for couples, families and corporate guests.<br/><br/>Conveniently close to DXB, Millennium Airport Hotel Dubai caters to discerning global business and leisure travellers and is known for its engaging service and convenient free valet parking. Our 4 star hotel near DXB Airport features 341 spacious accommodations including Superior, Deluxe, and Family Rooms, as well as Club and Executive Deluxe Suites – all equipped with outstanding amenities including complimentary Wi-Fi. Onsite, we offer a distinctive choice of six restaurants and bars providing exciting nightlife, and a range of leisure options including a superb, large outdoor swimming pool with pool bar, expansive garden area, kids playground and a fully equipped fitness centre.", "MILLENNIUM AIRPORT HOTEL DUBAI", 55.343871999999998, 25.248448, "4S", 175.0, "", "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dirham to be paid by guest directly to the hotel per room per night#&#" },
                    { 112, "Al Mateena St - Deira - Dubai", "AED", "The Dubai Palm Hotel is a 3-star hotel located in the commercial district of Dubai, offering modern residential comfort. This hotel combines efficient architecture and interior design. Each of the rooms feature casual decor that allows its guests to receive excellent value for their money. Guests on a budget do not have to go outside of the premises for a night out on the town as there are many restaurant and night clubs on the premises. The restaurants are the Lounge Bar, Kalpakavadi, and Goa to Kerala. The night clubs, spread over the lobby level and mezzanine, focus on different national themes.", "DUBAI PALM HOTEL", 55.319721999999999, 25.273223000000002, "3S", 60.0, "", "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dirham to be paid by guest directly to the hotel per room per night#&#" },
                    { 113, "Quds Street, Hor Al Anz, Near Abu Hail Metro Station, Deira - Dubai", "AED", "A 6-minute walk from Abu Hail metro station, this refined hotel with a contemporary glass facade is 6 km from Deira Clocktower and 10 km from bustling Dubai Gold Souk.<br/><br/>Elegant rooms offer free Wi-Fi, flat-screen TVs and minifridges, plus tea and coffeemaking facilities. Upgraded rooms add sitting areas, while suites include separate living areas. Room service is available 24/7.<br/><br/>Parking is complimentary. Other amenities include a nightclub, 2 restaurants (1 buffet-style) and an Indian eatery. There's also a gym and a rooftop outdoor pool, as well as a a sauna, a steam room and meeting space. A breakfast buffet is available.", "ABJAD GRAND HOTEL", 55.347529000000002, 25.277183999999998, "4S", 70.0, "", "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dirham to be paid by guest directly to the hotel per room per night#&#" },
                    { 224, "Marasi Dr - Business Bay - Dubai", "AED", "This upscale hotel set alongside the Dubai Water Canal is 5 km from the Burj Khalifa skyscraper, 9 km from the Dubai Mall and 19 km from Dubai International Airport.<br/><br/>The polished rooms and suites come with flat-screen TVs, safes and minibars, in addition to marble bathrooms, tea and coffeemaking facilities, and free Wi-Fi. Upgraded rooms offer canal views.<br/><br/>A breakfast buffet is complimentary. Other amenities include 4 restaurants, 4 bars and a gym, as well as a spa.", "GRAND MILLENNIUM HOTEL BUSINESS BAY", 55.274172999999998, 25.182880000000001, "5S", 280.0, "", "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dhirham to be paid by guest directly to the hotel per room per night#&#" },
                    { 265, "Wafi - Sheikh Rashid Rd - Umm Hurair 2 - Dubai", "AED", "", "SOFITEL DUBAI THE OBELISK", 55.318623000000002, 25.23113, "5S", 375.0, "", "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dhirham to be paid by guest directly to the hotel per room per night#&#" },
                    { 292, "Al Jadaf 1, Bur Dubai,Near Al Jadaf Metro Station - Dubai", "AED", "This polished hotel is a 14-minute walk from the nearest metro stop and 8 km from the landmark Burj Khalifa skyscraper.<br/><br/>Featuring decor inspired by famous cities, the colorful rooms offer free Wi-Fi, flat-screens, tea and coffeemakers, and minibars; some have 4-poster beds and/or balconies. Suites add living rooms. Kids age 12 and under stay at no charge with a parent. Room service is available 24/7.<br/><br/>Valet parking is complimentary. Breakfast is available for a fee, and there are also 5 restaurants and bars, including a Japanese eatery. Other amenities consist of a gym, a hot tub, a sauna and a steam room, along with a rooftop pool.", "REFLECTIONS HOTEL", 55.323552084327694, 25.219834536964662, "4S", 70.0, "", "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dhirham to be paid by guest directly to the hotel per room per night#&#" },
                    { 307, "", "AED", "", "Market test Hotel", 55.275399999999998, 25.2074, "1S", 15.0, "", "" },
                    { 308, "Al Barsha 1 Sheikh Zayed Road, Next To Mall of the, Emirates Mashreq metro Station 1 - Dubai", "AED", "In a glass-fronted tower on a bustling thoroughfare, this chic hotel with a grand atrium is a 5-minute walk from the Mall of the Emirates and 1 km from year-round indoor skiing at Ski Dubai.<br/><br/>Warm rooms have sitting areas, free Wi-Fi and flat-screens, plus tea and coffeemakers. Upgraded rooms add Nespresso machines; some provide sofabeds and iPod docks. Club rooms include access to a lounge serving free breakfast and afternoon tea. Suites add separate living rooms.<br/><br/>Parking is free. There are 5 bars and restaurants, including a chic Thai eatery, as well as a coffee shop. Additional amenities include a gym, an outdoor pool and a rooftop terrace.", "HOLIDAY INN DUBAI - AL BARSHA", 55.193700692545455, 25.116410851419239, "4S", 100.0, "", "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dhiram to be paid by guest directly to the hotel per room per night#&#" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelDetails",
                keyColumn: "HotelCode",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "HotelDetails",
                keyColumn: "HotelCode",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "HotelDetails",
                keyColumn: "HotelCode",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "HotelDetails",
                keyColumn: "HotelCode",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "HotelDetails",
                keyColumn: "HotelCode",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "HotelDetails",
                keyColumn: "HotelCode",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "HotelDetails",
                keyColumn: "HotelCode",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "HotelDetails",
                keyColumn: "HotelCode",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "HotelDetails",
                keyColumn: "HotelCode",
                keyValue: 308);
        }
    }
}
