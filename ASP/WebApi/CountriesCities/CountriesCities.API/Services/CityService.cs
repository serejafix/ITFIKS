using AutoMapper;
using CountriesCities.API.Data.Entities;
using CountriesCities.API.Interfaces;
using CountyCities.Shared.DTO;

namespace CountriesCities.API.Services
{
    public class CityService : ICityService
    {
        private readonly IMapper _mapper;
        private readonly ICityRepository _cityRepository;

        public CityService(IMapper mapper, ICityRepository cityRepository)
        {
            _mapper = mapper;
            _cityRepository = cityRepository;
        }


        public async Task<IEnumerable<CityDTO>> GetCities()
        {
            IEnumerable<City> entities = await _cityRepository.GetCities();

            IEnumerable<CityDTO> cities =
                _mapper.Map<IEnumerable<CityDTO>>(entities);

            return cities;

        }

        public async Task<IEnumerable<CityDetailsDTO>> GetCitiesDetails()
        {
            IEnumerable<City> entities = await _cityRepository.GetCitiesDetails();

            IEnumerable<CityDetailsDTO> cities =
                _mapper.Map<IEnumerable<CityDetailsDTO>>(entities);

            return cities;
        }

        public async Task<CityDTO?> GetCity(int id)
        {
            City? entity = await _cityRepository.GetCity(id);
            if (entity is null)
            {
                return null;
            }

            CityDTO city = _mapper.Map<CityDTO>(entity);

            return city;
        }

        public async  Task<CityDetailsDTO?> GetCityDetails(int id)
        {
            City? entity = await _cityRepository.GetCityDetails(id);
            if (entity is null)
            {
                return null;
            }

            CityDetailsDTO city = _mapper.Map<CityDetailsDTO>(entity);

            return city;

        }

        public async Task<CityDTO> PostCity(CityDTO city)
        {
            City entity = _mapper.Map<City>(city);
            City addedEntity = await _cityRepository.PostCity(entity);

            city = _mapper.Map<CityDTO>(addedEntity);
            return city;

        }

        public async Task<CityDTO> PutCity(CityDTO city)
        {
            City? entity = _mapper.Map<City>(city);
            if (entity is null)
            {
                return null;
            }
            City updatedEntity = await _cityRepository.PutCity(entity);

            city = _mapper.Map<CityDTO>(updatedEntity);
            return city;

        }
        public async Task<CityDTO> DeleteCity(int id)
        {

            City? entity = await _cityRepository.GetCity(id);
            if (entity is null)
            {
                return null;
            }

            City deletedEntity = await _cityRepository.DeleteCity(entity);
            CityDTO result = _mapper.Map<CityDTO>(deletedEntity);
            return result;

        }

        public bool CityExists(int id)
        {
            return _cityRepository.CityExists(id);
        }
    }
}
