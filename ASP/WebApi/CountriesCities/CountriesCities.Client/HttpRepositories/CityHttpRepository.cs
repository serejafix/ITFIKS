using CountyCities.Shared.DTO;
using System.Net.Http;
using System.Text.Json;
using System;
using System.Net.Http.Json;

namespace CountriesCities.Client.HttpRepositories
{
    public class CityHttpRepository : ICityHttpRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly JsonSerializerOptions _jsonSerializerOptions;
        private readonly string url = "Cities";

        public CityHttpRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

            _jsonSerializerOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
        }

        public async Task<List<CityDTO>?> GetCities()
        {
            var httpClient = CreateNamedHttpClient();

            //HttpResponseMessage response = await httpClient.GetAsync($"{url}/GetCitiesDetails");
            //string content = await response.Content.ReadAsStringAsync();
            //if (!response.IsSuccessStatusCode)
            //{
            //    throw new ApplicationException(content);
            //}
            //IEnumerable<CityDTO>? cities =
            //    JsonSerializer.Deserialize<IEnumerable<CityDTO>>(content, _jsonSerializerOptions);
            //return cities?.ToList();

            IEnumerable<CityDTO>? response = await httpClient
                .GetFromJsonAsync<IEnumerable<CityDTO>>($"{url}/GetCities");

            return response?.ToList();
        }

        public async Task<List<CityDetailsDTO>?> GetCitiesDetails()
        {
            var httpClient = CreateNamedHttpClient();

            //HttpResponseMessage response = await httpClient.GetAsync($"{url}/GetCitiesDetails");
            //string content = await response.Content.ReadAsStringAsync();
            //if (!response.IsSuccessStatusCode)
            //{
            //    throw new ApplicationException(content);
            //}
            //IEnumerable<CityDetailsDTO>? cities = 
            // JsonSerializer.Deserialize<IEnumerable<CityDetailsDTO>>(content, _jsonSerializerOptions);
            //return cities?.ToList();

            IEnumerable<CityDetailsDTO>? response = await httpClient
                .GetFromJsonAsync<IEnumerable<CityDetailsDTO>>($"{url}/GetCitiesDetails");

            return response?.ToList();
        }


        public async Task<CityDTO?> GetCity(int id)
        {
            var httpClient = CreateNamedHttpClient();
            CityDTO? response = await httpClient
                .GetFromJsonAsync<CityDTO>($"{url}/GetCity/{id}");

            return response;
        }

        public async Task<CityDetailsDTO?> GetCityDetails(int id)
        {
            var httpClient = CreateNamedHttpClient();
            CityDetailsDTO? response = await httpClient
                .GetFromJsonAsync<CityDetailsDTO>($"{url}/GetCityDetails/{id}");

            return response;
        }


        public async Task<CityDTO?> PostCity(CityDTO city)
        {
            var httpClient = CreateNamedHttpClient();

            HttpResponseMessage response = await httpClient
                .PostAsJsonAsync<CityDTO>(url, city);

            if (response.IsSuccessStatusCode)
            {
                string stringResponse = await response.Content.ReadAsStringAsync();

                CityDTO? result = JsonSerializer.Deserialize<CityDTO>(
                    json: stringResponse,
                    options: _jsonSerializerOptions);

                return result;
            }

            return null;
        }

        public async Task<CityDTO?> PutCity(CityDTO city)
        {
            var httpClient = CreateNamedHttpClient();
            HttpResponseMessage response = await httpClient
                .PutAsJsonAsync<CityDTO>($"{url}/{city.Id}", city);

            if (response.IsSuccessStatusCode)
            {
                string stringResponse = await response.Content.ReadAsStringAsync();

                CityDTO? result = JsonSerializer.Deserialize<CityDTO>(
                    json: stringResponse,
                    options: _jsonSerializerOptions);

                return result;
            }

            return null;
        }

        public async Task<CityDTO?> DeleteCity(int id)
        {
            var httpClient = CreateNamedHttpClient();

            HttpResponseMessage response = await httpClient.DeleteAsync($"{url}/{id}");
            if (response.IsSuccessStatusCode)
            {
                string stringResponse = await response.Content.ReadAsStringAsync();

                CityDTO? result = JsonSerializer.Deserialize<CityDTO>(
                    json: stringResponse,
                    options: _jsonSerializerOptions);

                return result;
            }

            return null;
        }

        private HttpClient CreateNamedHttpClient()
        {
            return _httpClientFactory.CreateClient("CitiesAPI");
        }
    }
}