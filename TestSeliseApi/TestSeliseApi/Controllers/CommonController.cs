using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TestSelise.Entities.Models;
using TestSeliseApi.Helper;
using TestSeliseApi.Interface;

namespace TestSeliseApi.Controllers
{
    [Route("api/Common")]
    [ApiController]
    public class CommonController : ControllerBase
    {
        private readonly dbTestContext _db = new dbTestContext();
        private readonly ICommonService _iCommonService;
        ApiReturnObj returnObj = new ApiReturnObj();


        public CommonController(ICommonService iCommonService, dbTestContext db)
        {
            _iCommonService = iCommonService;
            _db = db;
        }
        [HttpGet]
        [Route("get-by-type/{type}")]
        public IActionResult GetByType(string type)
        {
            try
            {
                var data = _iCommonService.GetAll(_db,type);
                if (data.Any())
                {   
                    returnObj.IsExecute = true;
                    returnObj.ApiData = data;
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

                returnObj.IsExecute = false;
                returnObj.Message = ex.Message;
                returnObj.ApiData = null;
                return Ok(returnObj);
            }
        }

    }
}
