//using FashionStore.Application.DTOs;
//using FashionStore.Application.Interfaces;
//using FashionStore.Domain.Entities;
//using FashionStore.Domain.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FashionStore.Application.Services
//{
//    public class UserService : IUserService
//    {
//        private readonly IRepositoryBase _userRepository;

//        public UserService(IRepositoryBase userRepository)
//        {
//            _userRepository = userRepository;
//        }

//        public async Task<UserDto> GetUserByIdAsync(int id)
//        {
//            var user = await _userRepository.GetByIdAsync(id);
//            return new UserDto
//            {
//                //Name = user.Name,
//                Email = user.Email
//            };
//        }

//        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
//        {
//            var users = await _userRepository.GetAllAsync();
//            return users.Select(u => new UserDto
//            {
//                //Name = u.Name,
//                Email = u.Email
//            });
//        }

//        public async Task CreateUserAsync(UserDto userDto)
//        {
//            var user = new AppUser
//            {
//                //Name = userDto.Name,
//                Email = userDto.Email
//            };
//            await _userRepository.AddAsync(user);
//        }
//    }
//}
