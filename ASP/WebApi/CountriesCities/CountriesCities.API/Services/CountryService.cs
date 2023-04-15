using AutoMapper;
using CountriesCities.API.Interfaces;

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

    }
}
