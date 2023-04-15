using CountriesCities.API.Data.Entities;

namespace CountriesCities.API.Interfaces
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetCountries();
        Task<IEnumerable<Country>> GetCountriesDetails();
        Task<Country?> GetCountry(int id);
        Task<Country?> GetCountryDetails(int id);
        Task<Country> PostCountry(Country entity);
        Task<Country> PutCountry(Country entity);
        Task<Country> DeleteCountry(Country entity);
        bool CountryExists(int id);
    }
}
