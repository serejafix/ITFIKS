using CountriesCities.API.Data;
using CountriesCities.API.Data.Entities;
using CountriesCities.API.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CountriesCities.API.Repositories
{
    public class CityRepository : ICityRepository
    {
        private readonly ApplicationContext _context;

        public CityRepository(ApplicationContext context)
        {
            _context = context;
        }



        public async Task<IEnumerable<City>> GetCities()
        {
            IQueryable<City> entities = _context.Cities
                .Where(c => c.IsDeleted == false);

            return await entities.ToListAsync();
        }

        public async Task<IEnumerable<City>> GetCitiesDetails()
        {
            IQueryable<City> entities = _context.Cities
                 // .Include(c => c.Country) // явно подгрузим ниже,
                 // Здесь мы не можем выбрать страны, где IsDeleted == false
                 .Where(c => c.IsDeleted == false);

            foreach (City entity in entities)
            {
                // подгружаем страны, у которых Id == City.CountryId && IsDeleted == false
                await _context.Countries
                    .Where(c => c.Id == entity.CountryId && c.IsDeleted == false)
                    .LoadAsync();
            }

            return await entities.ToListAsync();

        }

        public async Task<City?> GetCity(int id)
        {
            City? entity = await _context.Cities
                 // .Include(_c => _c.Country) // город получит CityDTO, но не CityDetailsDTO
                 .FirstOrDefaultAsync(c => c.Id == id && c.IsDeleted == false);

            if (entity is null)
            {
                return null;
            }
            return entity;

        }

        public async Task<City?> GetCityDetails(int id)
        {

            City? entity = await _context.Cities
                // .Include(_c => _c.Country) // явно подгрузим ниже,
                // Здесь мы не можем выбрать страны, где IsDeleted == false
                .FirstOrDefaultAsync(c => c.Id == id && c.IsDeleted == false);

            if (entity is null)
            {
                return null;
            }
            // подгружаем страны, у которых Id == City.CountryId && IsDeleted == false
            await _context.Countries
                .Where(c => c.Id == entity.CountryId && c.IsDeleted == false)
                .LoadAsync();

            return entity;

        }

        public async Task<City> PostCity(City entity)
        {
            EntityEntry<City> addedEntity = await _context.Cities.AddAsync(entity);
            await SaveChangesAsync(); // (!)

            return addedEntity.Entity;

        }

        public async Task<City> PutCity(City entity)
        {
            //_context.Entry(entity).State = EntityState.Modified;
            EntityEntry<City> updatedEntity = _context.Cities.Update(entity);
            await SaveChangesAsync();

            return updatedEntity.Entity;

        }
        public async Task<City> DeleteCity(City entity)
        {
            //EntityEntry<City> deletedEntity = _context.Cities.Remove(entity);
            //await SaveChangesAsync();
            //return deletedEntity.Entity;
            //2 варианта
            entity.IsDeleted = true;
            await SaveChangesAsync();
            return entity;

        }
        private async Task SaveChangesAsync() // (!)
        {
            await _context.SaveChangesAsync();
        }

        public bool CityExists(int id)
        {
            return _context.Cities.Any(e => e.Id == id);
        }
    }
}
