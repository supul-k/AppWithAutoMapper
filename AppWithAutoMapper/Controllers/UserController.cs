using AppWithAutoMapper.DTO;
using AppWithAutoMapper.Interfaces;
using AppWithAutoMapper.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AppWithAutoMapper.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UserResponseDTO>> GetUsers()
        {
            var users = _userRepository.GetUserResponse();
            return Ok(users);
        }

        [HttpPost("register")]
        public ActionResult<UserRegisterDTO> RegisterUser(UserRegisterDTO userRegisterDTO)
        {
            // Map the DTO to the User entity
            var user = _mapper.Map<User>(userRegisterDTO);

            // Register the user and get the registered user DTO
            _userRepository.Register(user);

            return StatusCode(201, "User created successfully.");
        }
    }
}
