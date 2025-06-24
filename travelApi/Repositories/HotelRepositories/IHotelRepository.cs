using travelApi.Dtos.HotelDtos;

namespace travelApi.Repositories.HotelRepositories;

public interface IHotelRepository
{
    Task<List<GetHotelListDto>> GetHotelListAsync(string? rating, string? priceMin, string? priceMax);
}
