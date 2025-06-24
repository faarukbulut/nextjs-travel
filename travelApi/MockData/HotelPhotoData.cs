using travelApi.DbModel;

namespace travelApi.MockData;

public static class HotelPhotoData
{
    public static List<HotelPhoto> HotelPhotos { get; set; } = new List<HotelPhoto>
    {
        new HotelPhoto
        {
            HotelPhotoId = 1,
            HotelId = 1,
            Photo = "/hotel1/1.jpg",
        },
        new HotelPhoto
        {
            HotelPhotoId = 2,
            HotelId = 1,
            Photo = "/hotel1/2.jpg",
        },
        new HotelPhoto
        {
            HotelPhotoId = 3,
            HotelId = 1,
            Photo = "/hotel1/3.jpg",
        },
        new HotelPhoto
        {
            HotelPhotoId = 4,
            HotelId = 1,
            Photo = "/hotel1/4.jpg",
        },
        new HotelPhoto
        {
            HotelPhotoId = 5,
            HotelId = 2,
            Photo = "/hotel2/1.jpg",
        },
        new HotelPhoto
        {
            HotelPhotoId = 6,
            HotelId = 2,
            Photo = "/hotel2/2.jpg",
        },
        new HotelPhoto
        {
            HotelPhotoId = 7,
            HotelId = 2,
            Photo = "/hotel2/3.jpg",
        },
        new HotelPhoto
        {
            HotelPhotoId = 8,
            HotelId = 2,
            Photo = "/hotel2/4.jpg",
        },
        new HotelPhoto
        {
            HotelPhotoId = 9,
            HotelId = 3,
            Photo = "/hotel3/1.jpg",
        },
        new HotelPhoto
        {
            HotelPhotoId = 10,
            HotelId = 3,
            Photo = "/hotel3/2.jpg",
        },
        new HotelPhoto
        {
            HotelPhotoId = 11,
            HotelId = 3,
            Photo = "/hotel3/3.jpg",
        },
        new HotelPhoto
        {
            HotelPhotoId = 12,
            HotelId = 3,
            Photo = "/hotel3/4.jpg",
        },
    };
}
