using AutoMapper;
using Entities.Models;
using Shared.TransferObjects;


namespace UserManagmentService
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {


            CreateMap<UserForRegistrationDto, User>();
        }
    }
}
