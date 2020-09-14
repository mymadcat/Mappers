using AutoMapper;

namespace ConsoleApp2.AutoMaper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Person, PersonDto>();
        }
    }
}
