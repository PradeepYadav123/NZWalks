using AutoMapper;
using Microsoft.Extensions.Options;

namespace NZWalks.API.Profiles
{
    public class RegionsProfile: Profile
    {
        public RegionsProfile()
        {
            CreateMap<Models.Domain.Region, Models.DTO.Region>();
                //.ForMember(des => des.Id, Options => Options.MapFrom(src=> src.Id)); //for different property name mapping
               // .ReverseMap();

        }
    }
}
