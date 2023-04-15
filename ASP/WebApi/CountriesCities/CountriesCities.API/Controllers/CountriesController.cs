using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CountriesCities.API.Data;
using CountriesCities.API.Data.Entities;
using CountriesCities.API.Interfaces;
using CountriesCities.API.Services;
using CountyCities.Shared.DTO;

namespace CountriesCities.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        private readonly ICountryService _countryService;

        public CountriesController(ApplicationContext context,
            ICountryService countryService)
        {
            _context = context;
            _countryService = countryService;
        }

        // GET: api/Countries/GetCountries
        [HttpGet("GetCountries")]
        public async Task<ActionResult<IEnumerable<CountryDTO>>> GetCountries()
        {
            // return await _context.Countries.ToListAsync();
            IEnumerable<CountryDTO> countries = await _countryService.GetCountries();
            return Ok(countries);
        }

        // GET: api/Countries/GetCountries
        [HttpGet("GetCountriesDetails")]
        public async Task<ActionResult<IEnumerable<CountryDetailsDTO>>> GetCountriesDetails()
        {
            // return await _context.Countries.ToListAsync();
            IEnumerable<CountryDetailsDTO> countries = await _countryService.GetCountriesDetails();
            return Ok(countries);
        }


        // GET: api/Countries/GetCountry/5
        [HttpGet("GetCountry/{id}")]
        public async Task<ActionResult<CountryDTO>> GetCountry(int id)
        {
            CountryDTO? country = await _countryService.GetCountry(id);

            if (country == null)
            {
                return NotFound();
            }

            return country;
        }

        // GET: api/Countries/GetCountryDetails/5
        [HttpGet("GetCountryDetails/{id}")]
        public async Task<ActionResult<CountryDetailsDTO>> GetCountryDetails(int id)
        {
            CountryDetailsDTO? country = await _countryService.GetCountryDetails(id);

            if (country == null)
            {
                return NotFound();
            }

            return country;
        }


        // POST: api/Countries
        [HttpPost]
        public async Task<ActionResult<CountryDTO>> PostCountry(CountryDTO country)
        {
            if (country.Id > 0)
            {
                return BadRequest();
            }

            CountryDTO result = await _countryService.PostCountry(country);

            return result;
            //CreatedAtAction("GetCountry", new { id = result.Id }, result);
        }


        // PUT: api/Countries/5
        [HttpPut("{id}")]
        public async Task<ActionResult<CountryDTO>> PutCountry(int id, CountryDTO country)
        {
            if (id != country.Id)
            {
                return BadRequest();
            }
            CountryDTO? result = null;

            try
            {
                result = await _countryService.PutCountry(country);
                if (result is null)
                {
                    return NotFound();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_countryService.CountryExists(id))
                {
                    return NotFound();
                }

                else
                {
                    throw;
                }
            }

            return result;
        }



        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CountryDTO>> DeleteCountry(int id)
        {
            CountryDTO? result = await _countryService.DeleteCountry(id);
            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

    }
}
