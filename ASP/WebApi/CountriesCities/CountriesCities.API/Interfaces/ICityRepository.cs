using CountriesCities.API.Data.Entities;

namespace CountriesCities.API.Interfaces
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> GetCities();
        Task<IEnumerable<City>> GetCitiesDetails();
        Task<City?> GetCity(int id);
        Task<City?> GetCityDetails(int id);
        Task<City> PostCity(City entity);
        Task<City> PutCity(City entity);
        Task<City> DeleteCity(City entity);
        bool CityExists(int id);
    }
}
