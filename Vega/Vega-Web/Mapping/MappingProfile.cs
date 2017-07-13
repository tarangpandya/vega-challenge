using AutoMapper;
using Vega_Web.Controllers.Resources;
using Vega_Web.Models;

namespace Vega_Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make,MakeResource>();
            CreateMap<Model,ModelResource>();
            CreateMap<Feature,FeatureResource>();
        }

    }
}