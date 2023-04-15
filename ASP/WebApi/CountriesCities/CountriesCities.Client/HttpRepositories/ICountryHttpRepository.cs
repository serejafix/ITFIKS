using CountyCities.Shared.DTO;

namespace CountriesCities.Client.HttpRepositories
{
    public interface ICountryHttpRepository
    {
        Task<List<CountryDTO>?> GetCountries();
        Task<List<CountryDetailsDTO>?> GetCountriesDetails();
    }
}
