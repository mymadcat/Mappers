using AutoMapper;

namespace ConsoleApp2
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;

        public PersonService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public PersonDto GetDto()
        {
            var person = new Person() { Name = "Ivan", LastName = "Pikuza" };
            return _mapper.Map<PersonDto>(person);
        }
    }
}
