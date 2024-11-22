using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDto>
            {
                new CityDto
                {
                    Id = 1,
                    Name = "Rome",
                    Description = "The capital city of Italy, known for its ancient history and landmarks like the Colosseum."
                },
                new CityDto
                {
                    Id = 2,
                    Name = "Milan",
                    Description = "A global capital of fashion and design, located in northern Italy."
                },
                new CityDto
                {
                    Id = 3,
                    Name = "Naples"
                }
            };
        }
    }
}
