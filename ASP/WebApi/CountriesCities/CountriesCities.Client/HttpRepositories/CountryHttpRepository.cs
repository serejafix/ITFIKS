using CountyCities.Shared.DTO;
using System.Net.Http.Json;
using System.Text.Json;

namespace CountriesCities.Client.HttpRepositories
{
    public class CountryHttpRepository : ICountryHttpRepository
    {
        private readonly HttpClient _typedHttpClient;
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        private readonly string url = "Countries";

        public CountryHttpRepository(HttpClient typedHttpClient)
        {
            _typedHttpClient = typedHttpClient;

            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
        }

        public async Task<List<CountryDTO>?> GetCountries()
        {
            IEnumerable<CountryDTO>? response = await _typedHttpClient
                .GetFromJsonAsync<IEnumerable<CountryDTO>>($"{url}/GetCountries");

            return response?.ToList();
        }

        public async Task<List<CountryDetailsDTO>?> GetCountriesDetails()
        {
            IEnumerable<CountryDetailsDTO>? response = await _typedHttpClient
                .GetFromJsonAsync<IEnumerable<CountryDetailsDTO>>($"{url}/GetCountriesDetails");

            return response?.ToList();
        }
    }
}
