using CountriesCities.API.Data;
using CountriesCities.API.Data.Entities;
using CountriesCities.API.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace CountriesCities.API.Repositories
{
    public class CountryRepository : ICountryRepository
    {

            private readonly ApplicationContext _context;

            public CountryRepository(ApplicationContext context)
            {
                _context = context;
            }


            public async Task<IEnumerable<Country>> GetCountries()
            {
                IQueryable<Country> entities = _context.Countries
                    // .Include(c => c.Cities) // страны получат CountryDTO,
                    // но не CountryDetailsDTO
                    .Where(c => c.IsDeleted == false);

                return await entities.ToListAsync();
            }


            public async Task<IEnumerable<Country>> GetCountriesDetails()
            {
                IQueryable<Country> entities = _context.Countries
                    // .Include(c => c.Cities) // явно подгрузим ниже,
                    // здесь мы не можем выбрать города, где IsDeleted == false
                    .Where(c => c.IsDeleted == false);

                foreach (Country entity in entities)
                {
                    // подгружаем города, у которых CountryId == Country.Id
                    // && IsDeleted == false
                    await _context.Cities
                        .Where(c => c.CountryId == entity.Id && c.IsDeleted == false)
                        .LoadAsync();
                }

                return await entities.ToListAsync();
            }

            public async Task<Country?> GetCountry(int id)
            {
                Country? entity = await _context.Countries
                    // .Include(c => c.Cities) // страну получит CountryDTO,
                    // но не CountryDetailsDTO
                    .FirstOrDefaultAsync(c => c.Id == id && c.IsDeleted == false);

                if (entity is null)
                {
                    return null;
                }

                return entity;
            }

            public async Task<Country?> GetCountryDetails(int id)
            {
                Country? entity = await _context.Countries
                    // .Include(c => c.Cities) // явно подгрузим ниже,
                    // здесь мы не можем выбрать города, где IsDeleted == false
                    .FirstOrDefaultAsync(c => c.Id == id && c.IsDeleted == false);

                if (entity is null)
                {
                    return null;
                }

                // подгружаем города, у которых CountryId == Country.Id
                // && IsDeleted == false
                await _context.Cities
                    .Where(c => c.CountryId == entity.Id && c.IsDeleted == false)
                    .LoadAsync();

                return entity;
            }

            public async Task<Country> PostCountry(Country entity)
            {
                EntityEntry<Country> addedEntity = await _context.Countries.AddAsync(entity);
                await SaveChangesAsync();

                return addedEntity.Entity;
            }

            public async Task<Country> PutCountry(Country entity)
            {
                EntityEntry<Country> updatedEntity = _context.Countries.Update(entity);
                await SaveChangesAsync();

                return updatedEntity.Entity;
            }

            public async Task<Country> DeleteCountry(Country entity)
            {
                // Закоментированный код ниже мягко удаляет Country и ее коллекцию City.
                // Если вы хотите так сделать, загляните в CountryService метод DeleteCountry
                // и раскоментируйте строку, которая вызывает GetCountryDetails(id),
                // а строку, вызывающую GetCountry(id) закоментируйте.
                // Соответственно - код ниже рскоментировать, а код под ним - закоментировать.

                // Штатная же незакоментированая реализация просто удаляет Country из БД,
                // оставляя City нетронутыми.

                //entity.IsDeleted = true;
                //foreach (City city in entity.Cities)
                //{
                //    city.IsDeleted = true;
                //}
                //await SaveChangesAsync();
                //return entity;

                EntityEntry<Country> deletedEntity = _context.Countries.Remove(entity);
                await SaveChangesAsync();
                return deletedEntity.Entity;
            }

            private async Task SaveChangesAsync()
            {
                await _context.SaveChangesAsync();
            }

        public bool CountryExists(int id)
        {
            return _context.Countries.Any(c => c.Id == id);

        }
    }
}
