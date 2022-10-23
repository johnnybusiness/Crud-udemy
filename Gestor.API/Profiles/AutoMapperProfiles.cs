using AutoMapper;
using Gestor.API.DataModels;

namespace Gestor.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Galeria, Galeria>()
                        .ReverseMap();

            CreateMap<DataModels.GalleryType, GalleryType>()
                        .ReverseMap();
                        
            CreateMap<DataModels.Concession, Concession>()
                        .ReverseMap();
        }
       
    }
}