using AppWithAutoMapper.DatabaseAccess;
using AppWithAutoMapper.DTO;
using AppWithAutoMapper.Interfaces;
using AppWithAutoMapper.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AppWithAutoMapper.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public UserRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<UserResponseDTO> GetUserResponse()
        {
            try
            {
                var users = _context.Users.ToList();
                var userResponseDTOs = _mapper.Map<IEnumerable<UserResponseDTO>>(users);
                return userResponseDTOs;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                throw new Exception("An error occurred while fetching users", ex);
            }
        }

        public UserRegisterDTO Register(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();

                // Map the saved user entity to the UserRegisterDTO
                var userRegisterDTO = _mapper.Map<UserRegisterDTO>(user);
                return userRegisterDTO;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                throw new Exception("An error occurred while registering the user", ex);
            }
        }
    }
}
