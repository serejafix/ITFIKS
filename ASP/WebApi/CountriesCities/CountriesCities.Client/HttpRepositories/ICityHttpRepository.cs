using CountyCities.Shared.DTO;

namespace CountriesCities.Client.HttpRepositories
{
    public interface ICityHttpRepository
    {
        Task<List<CityDTO>?> GetCities();
        Task<List<CityDetailsDTO>?> GetCitiesDetails();
        Task<CityDTO?> GetCity(int id);
        Task<CityDetailsDTO?> GetCityDetails(int id);

        Task<CityDTO?> PostCity(CityDTO city);
        Task<CityDTO?> PutCity(CityDTO city);
        Task<CityDTO?> DeleteCity(int id);

    }
}
