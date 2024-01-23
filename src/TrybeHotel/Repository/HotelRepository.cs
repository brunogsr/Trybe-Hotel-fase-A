using TrybeHotel.Models;
using TrybeHotel.Dto;

namespace TrybeHotel.Repository
{
    public class HotelRepository : IHotelRepository
    {
        protected readonly ITrybeHotelContext _context;
        public HotelRepository(ITrybeHotelContext context)
        {
            _context = context;
        }

        // 4. Desenvolva o endpoint GET /hotel
        public IEnumerable<HotelDto> GetHotels()
        {
            var hotels = _context.Hotels;
            var hotelsDto = new List<HotelDto>();
            foreach (var hotel in hotels)
            {
                hotelsDto.Add(new HotelDto
                {
                    HotelId = hotel.HotelId,
                    Name = hotel.Name,
                    CityId = hotel.CityId,
                    CityName = hotel.City.Name
                });
            }
            return hotelsDto;
        }

        // 5. Desenvolva o endpoint POST /hotel
        public HotelDto AddHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}