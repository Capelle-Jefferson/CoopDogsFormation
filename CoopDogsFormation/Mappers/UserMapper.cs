using CoopDogsFormation.Dtos;
using CoopDogsFormation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopDogsFormation.Mappers
{
    public static class UserMapper
    {
        /// <summary>
        /// Converti un model user en dto 
        /// </summary>
        /// <param name="model">User</param>
        /// <returns>UserDto</returns>
        public static UserDto ConvertUserModelToDto(User model)
        {
            return new UserDto
            {
                Firstname = model.Firstname,
                Id = model.Id,
                Lastname = model.Lastname,
                Username = model.Username,            
            };
        }

        /// <summary>
        /// Converti un model user en dto 
        /// </summary>
        /// <param name="model">User</param>
        /// <returns>UserDto</returns>
        public static AdminUserDto ConvertAdminUserModelToDto(UserAdmin model)
        {
            return new AdminUserDto
            {
                Id = model.Id,
                Username = model.Username,
            };
        }

        /// <summary>
        /// Converti un AddUserFormModel en User
        /// </summary>
        /// <param name="model">AddUserFormModel</param>
        /// <returns>User</returns>
        public static User ConvertAddUserFormModelToUser(AddUserFormModel model)
        {
            return new User
            {
                Firstname = model.Firstname,
                Lastname = model.Lastname,
                Password = model.Password,
                Username = model.Username,
            };
        }
    }
}
