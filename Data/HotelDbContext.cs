using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentISAAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AssignmentISAAPI.Data
{
    public class HotelDbContext :DbContext
    {
        public HotelDbContext(DbContextOptions options ) : base(options)
        {

        }
        public DbSet<HotelDetail> HotelDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelDetail>().HasData(
                new HotelDetail
                {
                    HotelCode= 23,
                    HotelName= "AURIS INN AL MUHANNA HOTEL",
                    TotalRate= 150.0000,
                    Address= "Al Fosool Street,Tecom - Dubai",
                    StarLevel= "4S",
                    hotelMainImage= "",
                    policiesAndDisclaimer= "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dirham to be paid by guest directly to the hotel per room per night#&#",
                    HotelDescriptions= "The 4 Star modern hotel is designed in a way that reflects a cozy ambience with subtle decorations making you feel like home & offers guests coming to Dubai for Business or leisure the convenience of travel to tourist attractions, business districts & commercial areas such as Media City, Knowledge Village, Business Bay, Dubai Downtown and the Jebel Ali Industrial Free zone.<br/><br/>Auris Inn AlMuhanna is Located 5 minutes away from Dubai Internet City Metro station allowing you easy access to Dubai Marina, Jumeirah Beach, Palm Jumeirah, Mall of the Emirates, Dubai Mall, Ibn Battuta Mall, The Walk JBR & Emirates Golf Club & providing accessibility to taxi picks ups & drop offs on the spot. <br/><br/>The hotel features 145 rooms & suites with an option of smoking & nonsmoking rooms. There are also the treatment rooms offering you the ultimate wellness & health to help you relax with a selection of massages, facials, skin & full body treatments to help your body & mind to rejuvenate. Not only that but a fully equipped GYM for the fit ones & who would like to stay in shape is right across a view to the swimming pool on the 1st Floor.<br/><br/>We have also designed services & key amenities to make your stay your way starting with keeping you connected with the world to show off your stay & Vacay through Free Wi-Fi in all areas of the hotel including the rooms & suites. In addition to Free valet car parking for those who came from across the GCC.<br/><br/>Auris Inn Al Muhanna Hotel offers an all-round dining service with all-day dining at Didon restaurant serving an exquisite open buffet & Ucci Sushi restaurant which serves the most delicious and tasteful Japanese food.<br/><br/>You will also have access to lounge café for a chill out with your family & friends, The terrace for relaxing & enjoying a shisha or hookah & in room dining service with a selection of Arabic & international dishes from ala carte menu served in the comfort of your room 24 hours a day.",
                    Longitude= 25.094457,
                    Latitude= 55.1772063,
                    Currency= "AED"
                },new HotelDetail
                  {
                HotelCode = 40,
                HotelName= "DUBAI INTERNATIONAL AIRPORT TERMINAL HOTEL",
                TotalRate = 633.0000,
                Address= "Dubai International Airport",
                StarLevel= "4S",
                hotelMainImage= "",
                policiesAndDisclaimer= "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dirham to be paid by guest directly to the hotel per room per night#&#",
                HotelDescriptions= "Featuring direct access to Terminal 3 of Dubai International Airport.<br/>Polished rooms offer WiFi access, flat-screens and safes, plus minibars, and tea and coffee making facilities. Upgraded rooms add living and dining areas. The 1-bedroom suites feature kitchenettes, and separate living and dining rooms.<br/><br/>There's an airy buffet restaurant, an Irish pub, an East Asian bar/restaurant and a tapas bar, as well as 2 lounges, a business center, and meeting and event space. Other amenities include an indoor pool, hot tubs, saunas and steam rooms.",
                Longitude= 25.249102,
                Latitude= 55.360878,
                Currency= "AED"
      }, new HotelDetail
      {
        HotelCode= 42,
        HotelName= "MILLENNIUM AIRPORT HOTEL DUBAI",
        TotalRate= 175.0000,
        Address= "Airport Road - Casablanca St - Dubai",
        StarLevel= "4S",
        hotelMainImage= "",
        policiesAndDisclaimer= "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dirham to be paid by guest directly to the hotel per room per night#&#",
        HotelDescriptions= "The award-winning Millennium Airport Hotel Dubai is a contemporary lifestyle destination for those who desire to be at the centre of Dubai's pulsating business and cultural scene. For the eight time since 2008, it was recognized as the Middle East's Leading Airport Hotel at the World Travel Awards (WTA) 2019. The hotel proudly provides guests with a “More Than Meets the Eye” touch that reflects the mindset of highly personalised and engaging services by each member of the hotel team.<br/><br/>This exceptional hotel is perfectly located just a few steps away from the GGICO Metro Station with easy access to all other public transportation. Only 5 to 10 minutes from Dubai International Airport, the hotel offers complimentary shuttle service to Terminals 1 & 3 every 45 minutes. The business districts of Deira, Dubai Airport Freezone and local attractions including Deira City Centre, Dubai Creek Golf & Yacht Club and Dubai Festival City are all less than 15 minutes away. The World Trade Centre, Dubai International Financial Centre, BurjKhalifa, Dubai Mall, Dubai Tennis Stadium, Irish Village, Gold and Spice Souk and Business Bay are all also conveniently close by, making Millennium Airport Hotel Dubai a preferred choice of stay for couples, families and corporate guests.<br/><br/>Conveniently close to DXB, Millennium Airport Hotel Dubai caters to discerning global business and leisure travellers and is known for its engaging service and convenient free valet parking. Our 4 star hotel near DXB Airport features 341 spacious accommodations including Superior, Deluxe, and Family Rooms, as well as Club and Executive Deluxe Suites – all equipped with outstanding amenities including complimentary Wi-Fi. Onsite, we offer a distinctive choice of six restaurants and bars providing exciting nightlife, and a range of leisure options including a superb, large outdoor swimming pool with pool bar, expansive garden area, kids playground and a fully equipped fitness centre.",
        Longitude= 25.248448,
        Latitude= 55.343872,
        Currency= "AED"
      }, new HotelDetail
      {
        HotelCode= 112,
        HotelName= "DUBAI PALM HOTEL",
        TotalRate= 60.0000,
        Address= "Al Mateena St - Deira - Dubai",
        StarLevel= "3S",
        hotelMainImage= "",
        policiesAndDisclaimer= "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dirham to be paid by guest directly to the hotel per room per night#&#",
        HotelDescriptions= "The Dubai Palm Hotel is a 3-star hotel located in the commercial district of Dubai, offering modern residential comfort. This hotel combines efficient architecture and interior design. Each of the rooms feature casual decor that allows its guests to receive excellent value for their money. Guests on a budget do not have to go outside of the premises for a night out on the town as there are many restaurant and night clubs on the premises. The restaurants are the Lounge Bar, Kalpakavadi, and Goa to Kerala. The night clubs, spread over the lobby level and mezzanine, focus on different national themes.",
        Longitude= 25.273223,
        Latitude= 55.319722,
        Currency= "AED"
      }, new HotelDetail
      {
        HotelCode= 113,
        HotelName= "ABJAD GRAND HOTEL",
        TotalRate= 70.0000,
        Address= "Quds Street, Hor Al Anz, Near Abu Hail Metro Station, Deira - Dubai",
        StarLevel= "4S",
        hotelMainImage= "",
        policiesAndDisclaimer= "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dirham to be paid by guest directly to the hotel per room per night#&#",
        HotelDescriptions= "A 6-minute walk from Abu Hail metro station, this refined hotel with a contemporary glass facade is 6 km from Deira Clocktower and 10 km from bustling Dubai Gold Souk.<br/><br/>Elegant rooms offer free Wi-Fi, flat-screen TVs and minifridges, plus tea and coffeemaking facilities. Upgraded rooms add sitting areas, while suites include separate living areas. Room service is available 24/7.<br/><br/>Parking is complimentary. Other amenities include a nightclub, 2 restaurants (1 buffet-style) and an Indian eatery. There's also a gym and a rooftop outdoor pool, as well as a a sauna, a steam room and meeting space. A breakfast buffet is available.",
        Longitude= 25.277184,
        Latitude= 55.347529,
        Currency= "AED"
      }, new HotelDetail
      {
        HotelCode= 224,
        HotelName= "GRAND MILLENNIUM HOTEL BUSINESS BAY",
        TotalRate= 280.0000,
        Address= "Marasi Dr - Business Bay - Dubai",
        StarLevel= "5S",
        hotelMainImage= "",
        policiesAndDisclaimer= "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dhirham to be paid by guest directly to the hotel per room per night#&#",
        HotelDescriptions= "This upscale hotel set alongside the Dubai Water Canal is 5 km from the Burj Khalifa skyscraper, 9 km from the Dubai Mall and 19 km from Dubai International Airport.<br/><br/>The polished rooms and suites come with flat-screen TVs, safes and minibars, in addition to marble bathrooms, tea and coffeemaking facilities, and free Wi-Fi. Upgraded rooms offer canal views.<br/><br/>A breakfast buffet is complimentary. Other amenities include 4 restaurants, 4 bars and a gym, as well as a spa.",
        Longitude= 25.18288,
        Latitude= 55.274173,
        Currency= "AED"
      }, new HotelDetail
      {
        HotelCode= 265,
        HotelName= "SOFITEL DUBAI THE OBELISK",
        TotalRate= 375.0000,
        Address= "Wafi - Sheikh Rashid Rd - Umm Hurair 2 - Dubai",
        StarLevel= "5S",
        hotelMainImage= "",
        policiesAndDisclaimer= "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dhirham to be paid by guest directly to the hotel per room per night#&#",
        HotelDescriptions= "",
        Longitude= 25.23113,
        Latitude= 55.318623,
        Currency= "AED"
      }, new HotelDetail
      {
        HotelCode= 292,
        HotelName= "REFLECTIONS HOTEL",
        TotalRate= 70.0000,
        Address= "Al Jadaf 1, Bur Dubai,Near Al Jadaf Metro Station - Dubai",
        StarLevel= "4S",
        hotelMainImage= "",
        policiesAndDisclaimer= "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dhirham to be paid by guest directly to the hotel per room per night#&#",
        HotelDescriptions= "This polished hotel is a 14-minute walk from the nearest metro stop and 8 km from the landmark Burj Khalifa skyscraper.<br/><br/>Featuring decor inspired by famous cities, the colorful rooms offer free Wi-Fi, flat-screens, tea and coffeemakers, and minibars; some have 4-poster beds and/or balconies. Suites add living rooms. Kids age 12 and under stay at no charge with a parent. Room service is available 24/7.<br/><br/>Valet parking is complimentary. Breakfast is available for a fee, and there are also 5 restaurants and bars, including a Japanese eatery. Other amenities consist of a gym, a hot tub, a sauna and a steam room, along with a rooftop pool.",
        Longitude= 25.219834536964662,
        Latitude= 55.323552084327694,
        Currency= "AED"
      }, new HotelDetail
      {
        HotelCode= 307,
        HotelName= "Market test Hotel",
        TotalRate= 15.0000,
        Address= "",
        StarLevel= "1S",
        hotelMainImage= "",
        policiesAndDisclaimer= "",
        HotelDescriptions= "",
        Longitude= 25.2074,
        Latitude= 55.2754,
        Currency= "AED"
      }, new HotelDetail
      {
        HotelCode= 308,
        HotelName= "HOLIDAY INN DUBAI - AL BARSHA",
        TotalRate= 100.0000,
        Address= "Al Barsha 1 Sheikh Zayed Road, Next To Mall of the, Emirates Mashreq metro Station 1 - Dubai",
        StarLevel= "4S",
        hotelMainImage= "",
        policiesAndDisclaimer= "No Show, Early checkout are will be charge entire stay.#&#Compulsory Tourism Dhiram to be paid by guest directly to the hotel per room per night#&#",
        HotelDescriptions= "In a glass-fronted tower on a bustling thoroughfare, this chic hotel with a grand atrium is a 5-minute walk from the Mall of the Emirates and 1 km from year-round indoor skiing at Ski Dubai.<br/><br/>Warm rooms have sitting areas, free Wi-Fi and flat-screens, plus tea and coffeemakers. Upgraded rooms add Nespresso machines; some provide sofabeds and iPod docks. Club rooms include access to a lounge serving free breakfast and afternoon tea. Suites add separate living rooms.<br/><br/>Parking is free. There are 5 bars and restaurants, including a chic Thai eatery, as well as a coffee shop. Additional amenities include a gym, an outdoor pool and a rooftop terrace.",
        Longitude= 25.116410851419239,
        Latitude= 55.193700692545455,
        Currency= "AED"
      }
                
                );

            
        }
    }
}
