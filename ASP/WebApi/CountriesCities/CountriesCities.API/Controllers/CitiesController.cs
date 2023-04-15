using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CountriesCities.API.Data;
using CountriesCities.API.Data.Entities;
using AutoMapper;
using CountyCities.Shared.DTO;
using CountriesCities.API.Interfaces;

namespace CountriesCities.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _cityService;
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        public CitiesController(ApplicationContext context,IMapper mapper,
            ICityService cityService)
        {
            _context = context;
            _mapper = mapper;
            _cityService = cityService;
        }

        // GET: api/Cities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CityDetailsDTO>>> GetCities()
        {
            IEnumerable<CityDTO> cities = await _cityService.GetCities();
            return Ok(cities);
        }
        [HttpGet("GetCitiesDetails")]
        public async Task<ActionResult<IEnumerable<CityDetailsDTO>>> GetCitiesDetails()
        {
            IEnumerable<CityDetailsDTO> cities = await _cityService.GetCitiesDetails();
            return Ok(cities);
        }

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CityDTO>> GetCity(int id)
        {
            CityDTO? city = await _cityService.GetCity(id);

            if (city == null)
            {
                return NotFound();
            }

            return city;
        }
        // GET: api/Cities/GetCityDetails/5
        [HttpGet("GetCityDetails/{id}")]
        public async Task<ActionResult<CityDetailsDTO>> GetCityDetails(int id)
        {
            CityDetailsDTO? city = await _cityService.GetCityDetails(id);

            if (city == null)
            {
                return NotFound();
            }

            return city;
        }

        // PUT: api/Cities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCity(int id, City city)
        {
            if (id != city.Id)
            {
                return BadRequest();
            }

            _context.Entry(city).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<City>> PostCity(City city)
        {
          if (_context.Cities == null)
          {
              return Problem("Entity set 'ApplicationContext.Cities'  is null.");
          }
            _context.Cities.Add(city);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCity", new { id = city.Id }, city);
        }

        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            if (_context.Cities == null)
            {
                return NotFound();
            }
            var city = await _context.Cities.FindAsync(id);
            if (city == null)
            {
                return NotFound();
            }

            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CityExists(int id)
        {
            return (_context.Cities?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
