using SMS.Dtos;
using SMS.Models;
using AutoMapper;

namespace SMS.Dto
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Subject, SubjectDto>(); // Map from Subject to SubjectDto
        }
    }
}
