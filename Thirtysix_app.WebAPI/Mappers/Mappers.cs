using AutoMapper;

namespace Thirtysix_app.WebAPI.Mappers
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Database.Bicikli, Model.Bicikli>().ReverseMap();
        }
    }
}
