using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using travelApi.Repositories.HotelRepositories;

namespace travelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelRepository _hotelRepository;

        public HotelController(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetHotelList(string? rating, string? priceMin, string? priceMax)
        {
            var values = await _hotelRepository.GetHotelListAsync(rating, priceMin, priceMax);
            return Ok(values);
        }
    }
}
