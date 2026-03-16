using AutoMapper;
using JWTRefreshToken.DTO;
using JWTRefreshToken.Model;
namespace JWTRefreshToken.Data.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, UserResponse>();
            CreateMap<ApplicationUser, CurrentUserResponse>();
            CreateMap<UserRegisterRequest, ApplicationUser>();

        }
    }
}
