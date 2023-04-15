using CountyCities.Shared.DTO;

namespace CountriesCities.API.Interfaces
{
    public interface ICityService
    {
        Task<IEnumerable<CityDTO>> GetCities();
        Task<IEnumerable<CityDetailsDTO>> GetCitiesDetails();
        Task<CityDTO?> GetCity(int id);
        Task<CityDetailsDTO?> GetCityDetails(int id);
    }
}
