using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSelise.Entities.Models;
using TestSelise.Models.Models;
using TestSeliseApi.Helper;
using TestSeliseApi.Interface;
using static TestSeliseApi.Helper.CommonHelper;

namespace TestSeliseApi.Service
{
    public class UserInfoService : IUserInfoService
    {
        public User GetUserInfoById(int UserId, dbTestContext _db)
        {
            var user= _db.UserInfos.AsQueryable().FirstOrDefault(x => x.UserId == UserId);
            User entity = new User();
            entity.UserName = user.UserName;
            entity.Password = user.Password;
            entity.DateOfBirth = user.DateOfBirth;
            entity.EMail = user.Email;
            entity.HashPassword = user.HashPassword;
            entity.PasswordSalt = user.PasswordSalt;
            return entity;

        }

        public List<User> GetUserInformations(dbTestContext _db)
        {
            List<User> list = new List<User>();
            var userInfos = _db.UserInfos.ToList();
            foreach (var user in userInfos)
            {
                User entity = new User();
                entity.UserName = user.UserName;
                entity.Password = user.Password;
                entity.DateOfBirth = user.DateOfBirth;
                entity.EMail = user.Email;
                entity.HashPassword = user.HashPassword;
                entity.PasswordSalt = user.PasswordSalt;
                list.Add(entity);
            }
            return list;
        }

        public Token LogIn(User model,dbTestContext _context)
        {
            var registerUser = _context.UserInfos.FirstOrDefault(x => x.Email == model.EMail && x.Password == model.Password);
            if (registerUser == null)
                return null;
            var passwordHash = CommonHelper.HashUsingPbkdf2(model.Password, registerUser.PasswordSalt);

            if (registerUser.HashPassword != passwordHash)
                return null;
            var token = TokenHelper.GenerateToken(registerUser);
            var obj = new Token
            {
                Username = registerUser.UserName,
                Email = registerUser.Email,
                JwtToken = token
            };
            return obj;
        }
        public UserInfo GenerateRecord(User entity)
        {
            UserInfo user = new UserInfo()
            {
                UserName = entity.UserName,
                Password = entity.Password,
                DateOfBirth = entity.DateOfBirth,
                Email = entity.EMail,
                HashPassword = entity.HashPassword,
                PasswordSalt = entity.PasswordSalt
            };
            return user;
        }

        public string RegisterUser(User entity, dbTestContext _db)
        {
            try
            {
                var salt = CommonHelper.GenerateSalt();
                var passwordHash = CommonHelper.HashUsingPbkdf2(entity.Password, salt);
                entity.PasswordSalt = salt;
                entity.HashPassword = passwordHash;

                var model = GenerateRecord(entity);
                _db.UserInfos.Add(model);
                _db.SaveChanges();
                return ConstMessage.Register;
            }
            catch (System.Exception ex)
            {
                return ex.Message;

            }
        }
    }
}
