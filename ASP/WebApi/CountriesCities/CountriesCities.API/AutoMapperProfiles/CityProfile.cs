using AutoMapper;
using CountriesCities.API.Data.Entities;
using CountyCities.Shared.DTO;

namespace CountriesCities.API.AutoMapperProfiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            CreateMap<City, CityDTO>().ReverseMap();

            CreateMap<City, CityDetailsDTO>()
                .ForMember(destination => destination.CountryName,
                           opt => opt.MapFrom(
                               source => source.Country!.Name))
                .ForMember(destination => destination.CountryCode,
                           opt => opt.MapFrom(
                               source => source.Country!.Code))
                .ReverseMap();

            // CreateMap<CityDetailsDTO, CityDTO>();
        }
    }

}

}
