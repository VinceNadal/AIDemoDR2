using API.DTOs;
using API.Models;
using AutoMapper;

namespace API.MappingProfiles
{
    public class ContactProfile : Profile
    {
        // Use AutoMapper to map the DTOs to the Models and for CreateContactDto generate an ID when it gets converted to the Contact class
        public ContactProfile()
        {
            CreateMap<Contact, ReadContactDTO>().ReverseMap();
            CreateMap<CreateContactDTO, Contact>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ReverseMap();
            CreateMap<UpdateContactDTO, Contact>().ReverseMap();
        }
    }
}
