using travelApi.DbModel;

namespace travelApi.MockData;

public static class HotelData
{
    public static List<Hotel> Hotels { get; set; } = new List<Hotel>
    {
        new Hotel
        {
            HotelId = 1,
            Name = "Swissôtel The Bosphorus Istanbul",
            Description = "Luxury 5-star hotel offering panoramic views of the Bosphorus.",
            Location = "Istanbul",
            Address = "Visnezade Mah. Acisu Sok. NO:19, Macka, Besiktas, Istanbul",
            Rating = 3,
            PricePerNight = 7500,
        },
        new Hotel
        {
            HotelId = 2,
            Name = "The Marmara Taksim",
            Description = "Modern hotel located in Taksim Square with city and Bosphorus views.",
            Location = "Istanbul",
            Address = "Taksim Meydani, Beyoglu, Istanbul",
            Rating = 4,
            PricePerNight = 4200
        },
        new Hotel
        {
            HotelId = 3,
            Name = "Rixos Premium Belek",
            Description = "All-inclusive resort in Antalya with private beach and aquapark.",
            Location = "Antalya",
            Address = "Belek Mah. Kongre Cad. No:18/A, Serik, Antalya",
            Rating = 5,
            PricePerNight = 10500
        },
    };
}