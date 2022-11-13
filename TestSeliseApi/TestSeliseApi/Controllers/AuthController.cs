using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSelise.Entities.Models;
using TestSelise.Models.Models;
using TestSeliseApi.Helper;
using TestSeliseApi.Interface;

namespace TestSeliseApi.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        ApiReturnObj returnObj = new ApiReturnObj();
        private readonly IUserInfoService _userInfoService;
        private readonly dbTestContext _db = new dbTestContext();
        public AuthController(IUserInfoService userInfoService, dbTestContext db)
        {
            _userInfoService = userInfoService;
            _db = db;
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(User model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest("NO Data is Found.");
                }
                var msg = _userInfoService.RegisterUser(model, _db);
                returnObj.Message = msg;
                returnObj.IsExecute = true;
                returnObj.ApiData = msg;
                return Ok(returnObj);

            }
            catch (Exception ex)
            {

                returnObj.Message = ex.Message;
                returnObj.IsExecute = false;
                returnObj.ApiData = null;
                return Ok(returnObj);
            }
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Login(User loginRequest)
        {
            try
            {
                if (loginRequest == null)
                {
                    if (string.IsNullOrEmpty(loginRequest.EMail))
                        return BadRequest("Missing UserName");
                    if (string.IsNullOrEmpty(loginRequest.Password))
                        return BadRequest("Missing Password");

                }
                var loginResponse = _userInfoService.LogIn(loginRequest, _db);

                if (loginResponse == null)
                {
                    return BadRequest($"Invalid credentials");
                }
                if (loginResponse != null)
                {
                    returnObj.IsExecute = true;
                    returnObj.ApiData = loginResponse;
                    return Ok(returnObj);
                }
                else
                {
                    returnObj.IsExecute = false;
                    returnObj.ApiData = null;
                    return Ok(returnObj);
                }
            }
            catch (Exception ex)
            {
                returnObj.Message = ex.Message;
                returnObj.IsExecute = false;
                returnObj.ApiData = null;
                return Ok(returnObj);
            }

        }
    }
}
