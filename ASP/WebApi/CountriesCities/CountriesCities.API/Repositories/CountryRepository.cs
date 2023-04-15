using CountriesCities.API.Data;
using CountriesCities.API.Interfaces;

namespace CountriesCities.API.Repositories
{
    public class CountryRepository : ICountryRepository
    {

        private readonly ApplicationContext _context;

        public CountryRepository(ApplicationContext context)
        {
            _context = context;
        }

    }
}
