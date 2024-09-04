using AppWithAutoMapper.DTO;
using AppWithAutoMapper.Models;

namespace AppWithAutoMapper.Interfaces
{
    public interface IUserRepository
    {
        public UserRegisterDTO Register(User user);
        public IEnumerable<UserResponseDTO> GetUserResponse();
    }
}
