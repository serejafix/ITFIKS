using CountyCities.Shared.DTO;

namespace CountriesCities.API.Interfaces
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryDTO>> GetCountries();
        Task<IEnumerable<CountryDetailsDTO>> GetCountriesDetails();
        Task<CountryDTO?> GetCountry(int id);
        Task<CountryDetailsDTO?> GetCountryDetails(int id);
        Task<CountryDTO> PostCountry(CountryDTO country);
        Task<CountryDTO?> PutCountry(CountryDTO country);
        Task<CountryDTO?> DeleteCountry(int id);
        bool CountryExists(int id);
    }
}
