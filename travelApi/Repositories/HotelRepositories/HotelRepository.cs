
using travelApi.Dtos.HotelDtos;
using travelApi.MockData;

namespace travelApi.Repositories.HotelRepositories;

public class HotelRepository : IHotelRepository
{
    public async Task<List<GetHotelListDto>> GetHotelListAsync(string? rating, string? priceMin, string priceMax)
    {
        var hotels = HotelData.Hotels.AsQueryable();

        if (!string.IsNullOrEmpty(rating) && double.TryParse(rating, out var parsedRating))
        {
            hotels = hotels.Where(h => h.Rating == parsedRating);
        }

        if (!string.IsNullOrEmpty(priceMin) && decimal.TryParse(priceMin, out var minPrice))
        {
            hotels = hotels.Where(h => h.PricePerNight >= minPrice);
        }

        if (!string.IsNullOrEmpty(priceMax) && decimal.TryParse(priceMax, out var maxPrice))
        {
            hotels = hotels.Where(h => h.PricePerNight <= maxPrice);
        }

        var hotelList = hotels
            .Select(u => new GetHotelListDto
            {
                HotelId = u.HotelId,
                Name = u.Name,
                Description = u.Description,
                Location = u.Location,
                Address = u.Address,
                Rating = u.Rating,
                PricePerNight = u.PricePerNight,
                Photos = HotelPhotoData.HotelPhotos
                    .Where(p => p.HotelId == u.HotelId)
                    .Select(p => p.Photo)
                    .ToList()
            })
            .ToList();

        return await Task.FromResult(hotelList);
    }
}
