using AutoMapper;
using CountriesCities.API.Data.Entities;
using CountyCities.Shared.DTO;

namespace CountriesCities.API.AutoMapperProfiles
{
    public class CountryProfile : Profile
    {
        public CountryProfile()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<Country, CountryDetailsDTO>().ReverseMap();
        }

    }
}
