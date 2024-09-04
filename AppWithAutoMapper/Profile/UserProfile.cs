namespace AppWithAutoMapper.Profile
{
    using AppWithAutoMapper.DTO;
    using AppWithAutoMapper.Models;
    using AutoMapper;

    public class UserProfile : Profile
    {
        public UserProfile()
        {
            // Mapping from User entity to UserResponseDTO
            CreateMap<User, UserResponseDTO>()
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.Ignore());

            // Mapping from UserRegisterDTO to User entity
            CreateMap<UserRegisterDTO, User>()
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.UtcNow))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.UtcNow));
        }
    }
}
