using System;
using travelApi.DbModel;

namespace travelApi.MockData;

public static class HotelRoomData
{
    public static List<HotelRoom> HotelRooms { get; set; } = new List<HotelRoom>
    {
        new HotelRoom
        {
            HotelRoomId = 1,
            HotelId = 1,
            Type = "Deluxe Bosphorus View",
            Price = 8500,
            Amenties = "King Bed, Free Wi-Fi, Balcony, Bathtub, Breakfast Included",
            IsAvailable = true
        },
        new HotelRoom
        {
            HotelRoomId = 2,
            HotelId = 1,
            Type = "Executive Suite",
            Price = 12000,
            Amenties = "King Bed, Living Area, Free Wi-Fi, Jacuzzi, Sea View, Breakfast Included",
            IsAvailable = true
        },
        new HotelRoom
        {
            HotelRoomId = 3,
            HotelId = 1,
            Type = "Standard Room",
            Price = 7500,
            Amenties = "Queen Bed, Free Wi-Fi, City View, Breakfast Included",
            IsAvailable = true
        },
        new HotelRoom
        {
            HotelRoomId = 4,
            HotelId = 2,
            Type = "Superior City View",
            Price = 4500,
            Amenties = "King Bed, Free Wi-Fi, City View, Breakfast Included",
            IsAvailable = true
        },
        new HotelRoom
        {
            HotelRoomId = 5,
            HotelId = 2,
            Type = "Bosphorus View Room",
            Price = 5200,
            Amenties = "King Bed, Free Wi-Fi, Balcony, Sea View, Breakfast Included",
            IsAvailable = true
        },
        new HotelRoom
        {
            HotelRoomId = 6,
            HotelId = 2,
            Type = "Standard Room",
            Price = 4000,
            Amenties = "Queen Bed, Free Wi-Fi, City View",
            IsAvailable = true
        },
        new HotelRoom
        {
            HotelRoomId = 7,
            HotelId = 3,
            Type = "Superior Double Room",
            Price = 11000,
            Amenties = "King Bed, Pool View, All Inclusive, Balcony, Free Wi-Fi",
            IsAvailable = true
        },
        new HotelRoom
        {
            HotelRoomId = 8,
            HotelId = 3,
            Type = "Family Suite",
            Price = 13500,
            Amenties = "2 Bedrooms, Living Room, Private Pool Access, All Inclusive",
            IsAvailable = true
        },
        new HotelRoom
        {
            HotelRoomId = 9,
            HotelId = 3,
            Type = "Deluxe Sea View Room",
            Price = 10500,
            Amenties = "King Bed, Sea View, All Inclusive, Balcony, Free Wi-Fi",
            IsAvailable = true
        },
    };
}
