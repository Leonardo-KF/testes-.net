using UsersDto.Dto;
using Users.Models;
using System.Security.Cryptography;

namespace Users.Services
{
    public class UserServices
    {
        public static User user = new User();

        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }


    }
}