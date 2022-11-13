using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSelise.Entities.Models;
using TestSelise.Models.Models;

namespace TestSeliseApi.Interface
{
    public interface IUserInfoService
    {
        List<User> GetUserInformations(dbTestContext _db);
        User GetUserInfoById(int UserId, dbTestContext _db);
        string RegisterUser(User userInformation, dbTestContext _db);
        Token LogIn(User model, dbTestContext _db);
    }
}
