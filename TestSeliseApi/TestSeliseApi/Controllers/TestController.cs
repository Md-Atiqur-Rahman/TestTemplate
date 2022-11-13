using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TestSeliseApi.Helper;
using TestSeliseApi.Interface;
using TestSelise.Entities.Models;
using TestSelise.Models.Models;
using Microsoft.AspNetCore.Authorization;

namespace TestSeliseApi.Controllers
{
    [Route("api/Test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        
        private readonly dbTestContext _db = new dbTestContext();
        private readonly IPersonService _ipersonService;
        private readonly ICommonService _iCommonService;
        ApiReturnObj returnObj = new ApiReturnObj();

        public TestController(IPersonService ipersonService, ICommonService iCommonService, dbTestContext db)
        {
            _ipersonService = ipersonService;
            _iCommonService = iCommonService;
            _db = db;
        }
        [Authorize]
        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            try
            {
                var data = _ipersonService.GetAll(_db);
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

        [HttpPost("add")]
        public IActionResult Add(CreateUpdateDataModel<PersonVm> model)
        {
            using (var dbTransaction = _db.Database.BeginTransaction())
            {
                try
                {
                   
                    var data = _ipersonService.Add(model.Data, _db);
                    if (data.PersonId > 0 )
                    {
                        var doc = _iCommonService.SaveDoc(data.PersonId, model.Data.DocumentInfos, _db);
                        dbTransaction.Commit();
                        returnObj.IsExecute = true;
                        returnObj.ApiData = true;
                        returnObj.Message = MessageConst.Insert;
                        return Ok(returnObj);
                    }
                    else
                    {
                        dbTransaction.Rollback();
                        returnObj.IsExecute = false;
                        returnObj.ApiData = null;
                        return Ok(returnObj);
                    }
                }
                catch (Exception ex)
                {
                    dbTransaction.Rollback();
                    returnObj.IsExecute = false;
                    returnObj.ApiData = null;
                    return Ok(returnObj);
                }

            }

        }

        [HttpGet("get-person-by-id/{id}")]
        public IActionResult GetPersonById(int id)
        {
            try
            {
                PersonVm data = _ipersonService.GetPersonById(id,_db);
                DocumentInfoVM doc = new DocumentInfoVM();
                doc.ForeignKeyId = id;
                doc.TableName = "Person";
                data.DocumentInfos  =_iCommonService.GetDocuments(doc, _db);
                if (data!=null)
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
