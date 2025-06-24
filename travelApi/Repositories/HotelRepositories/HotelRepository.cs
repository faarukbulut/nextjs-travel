
using travelApi.Dtos.HotelDtos;
using travelApi.MockData;

namespace travelApi.Repositories.HotelRepositories;

public class HotelRepository : IHotelRepository
{
    public async Task<List<GetHotelListDto>> GetHotelListAsync()
    {
        var hotelList = HotelData.Hotels
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
