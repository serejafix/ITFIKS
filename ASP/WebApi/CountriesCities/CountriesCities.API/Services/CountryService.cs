using AutoMapper;
using CountriesCities.API.Data.Entities;
using CountriesCities.API.Interfaces;
using CountyCities.Shared.DTO;

namespace CountriesCities.API.Services
{
    public class CountryService : ICountryService
    {
            private readonly IMapper _mapper;
            private readonly ICountryRepository _countryRepository;

            public CountryService(ICountryRepository countryRepository, IMapper mapper)
            {
                _countryRepository = countryRepository;
                _mapper = mapper;
            }

            public async Task<IEnumerable<CountryDTO>> GetCountries()
            {
                IEnumerable<Country> entities = await _countryRepository.GetCountries();
                IEnumerable<CountryDTO> countries =
                    _mapper.Map<IEnumerable<CountryDTO>>(entities);

                return countries;
            }

            public async Task<IEnumerable<CountryDetailsDTO>> GetCountriesDetails()
            {
                IEnumerable<Country> entities = await _countryRepository.GetCountriesDetails();
                IEnumerable<CountryDetailsDTO> countries =
                    _mapper.Map<IEnumerable<CountryDetailsDTO>>(entities);

                return countries;
            }

            public async Task<CountryDTO?> GetCountry(int id)
            {
                Country? entity = await _countryRepository.GetCountry(id);
                if (entity is null)
                {
                    return null;
                }

                CountryDTO country = _mapper.Map<CountryDTO>(entity);
                return country;
            }

            public async Task<CountryDetailsDTO?> GetCountryDetails(int id)
            {
                Country? entity = await _countryRepository.GetCountryDetails(id);
                if (entity is null)
                {
                    return null;
                }

                CountryDetailsDTO country = _mapper.Map<CountryDetailsDTO>(entity);
                return country;
            }

            public async Task<CountryDTO> PostCountry(CountryDTO country)
            {
                Country entity = _mapper.Map<Country>(country);
                Country addedEntity = await _countryRepository.PostCountry(entity);

                country = _mapper.Map<CountryDTO>(addedEntity);
                return country;
            }

            public async Task<CountryDTO?> PutCountry(CountryDTO country)
            {
                Country? entity = _mapper.Map<Country>(country);
                if (entity is null)
                {
                    return null;
                }
                Country updatedEntity = await _countryRepository.PutCountry(entity);

                country = _mapper.Map<CountryDTO>(updatedEntity);
                return country;
            }

            public async Task<CountryDTO?> DeleteCountry(int id)
            {
                // GetCountryDetails(id) ниже,
                // потому что этот запрос так же включит City в выборку,
                // по которым в репозитории мы пробежимся
                // и установим у них city.IdDeleted = true,
                // так же как и установим саму country.IsDeleted = true.
                // Что так же сделает их мягко удаленными из БД.
                // Если вы хотите сделать мягкое удаление Country с коллекцией City из БД,
                // тогда раскомментируйте строку ниже и закомментируйте следующую строку.
                // Так же смотрите комментарии в репозитории в методе
                // DeleteCountry для дальнейших действий.

                // Штатная же незакоментированая реализация просто удаляет Country из БД,
                // оставляя City нетронутыми.

                // Country? entity = await _countryRepository.GetCountryDetails(id);

                Country? entity = await _countryRepository.GetCountry(id);

                if (entity is null)
                {
                    return null;
                }

                Country deletedEntity = await _countryRepository.DeleteCountry(entity);
                CountryDTO result = _mapper.Map<CountryDTO>(deletedEntity);
                return result;
            }

        public bool CountryExists(int id)
        {
            return _countryRepository.CountryExists(id);
        }
    }
}
