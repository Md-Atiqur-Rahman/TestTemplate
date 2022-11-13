using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestApplication.Helper;
using TestApplication.Models;
using TestSelise.Models.Models;

using Microsoft.AspNetCore.Http;
using System.IO;
using System.Net.Http.Headers;

namespace TestApplication.Controllers
{
    public class LogGateController : Controller
    {
        private readonly CallApi _callApi = new CallApi();
        private readonly INotyfService _notyf;
        private HttpResponseMessage _resMsg;

        public LogGateController(INotyfService notyf)
        {
            _notyf = notyf;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  async Task<IActionResult> Register(User user)
        {
            try
            {
                _resMsg = await _callApi.client.PostAsJsonAsync(APIAddress.authRegister, user);
                var resReturnObj = _resMsg.Content.ReadAsAsync<ServiceReturnModel>().Result;
                _notyf.Success("Registered Successfully.");
                return View();
            }
            catch (Exception ex)
            {
                _notyf.Error(ex.Message);
                return View();
            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            //var clientHelper = _callApi.GetClientProfile();
            User user = new User();
            //ViewBag.PageInfo = PageInfoDict.GetPageInfo("লগইন", "লগইন");
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(User model, string otherDevice)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    _notyf.Error("Validation Error!");
                    return RedirectToAction("Login", "LogGate");
                }

                _resMsg = await _callApi.client.PostAsJsonAsync(APIAddress.AuthLogin, model);
                var resReturnObj = _resMsg.Content.ReadAsAsync<ServiceReturnModel>().Result;
                if (resReturnObj.ApiData == null)
                {
                    _notyf.Error(resReturnObj.Message);
                    return RedirectToAction("Login", "LogGate");
                }
                else
                {
                    Token tokenData = resReturnObj.ApiData.ToObject<Token>();
                    //HttpContext.Session.SetString("JwtTokenData", JsonConvert.SerializeObject(tokenData));
                    HttpContext.Session.SetObjectAsJson("JwtTokenData", tokenData);
                    _notyf.Success("Login Successfully.");
                }
                return RedirectToAction("IndexChild", "Check");
            }
            catch (Exception ex)
            {
                _notyf.Error(ex.Message);
                return RedirectToAction("Login", "LogGate");
                
            }

        }
        [HttpGet]
        public async Task<ActionResult> Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "LogGate");
        }

    }
}
