using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TestApplication.Helper;
using TestApplication.ViewModels;
using TestApplication.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using TestSelise.Models.Models;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Authorization;

namespace TestApplication.Controllers
{
    public class CheckController : Controller
    {
        private readonly CallApi _callApi = new CallApi();
        private HttpResponseMessage _resMsg;
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpGet]
        public async Task<ActionResult> IndexChild()
        {
            var token = "";
            //HttpContext.Session.SetObjectAsJson("Test", myComplexObject);
            var tokenData = HttpContext.Session.GetObjectFromJson<Token>("JwtTokenData");
            
            if (tokenData !=null)
            {
                token = tokenData.JwtToken;
                HttpContext.Session.SetString("UserEmail", tokenData.Email);
            }
            
            //var res = HttpContext.Session.GetString("JwtTokenData");
            //Token tokenData = JsonConvert.DeserializeObject<Token>(res);
            PersonRelatedInfoVm model = new PersonRelatedInfoVm();
            _callApi.client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            _resMsg = await _callApi.client.GetAsync(APIAddress.GetAllPerson);
            var resReturnObj = _resMsg.Content.ReadAsAsync<ServiceReturnModel>().Result;
            if(resReturnObj != null)
            {
                model.persons = resReturnObj.ApiData.ToObject<List<PersonVm>>();
            }
            else
            {
                return RedirectToAction("Login", "LogGate");
            }
            return View(model);
        }
        [HttpGet]
        public async Task<ActionResult> Create(int? id)
        {
            PersonRelatedInfoVm model = new PersonRelatedInfoVm();
            if (id > 0 )
            {
                List<DocumentInfoVM> list = new List<DocumentInfoVM>();
                HttpContext.Session.SetString("SessionDocumentInfo", JsonConvert.SerializeObject(list));
                _resMsg = await _callApi.client.GetAsync(APIAddress.GetPersonById + id);
                var returnObj = _resMsg.Content.ReadAsAsync<ServiceReturnModel>().Result;

                
                model.person = returnObj.ApiData.ToObject<PersonVm>();
                model.person.Photo = FileHandler.GetImage(model.person.Photograph);
                HttpContext.Session.SetString("SessionDocumentInfo", JsonConvert.SerializeObject(model.person.DocumentInfos));
                model.commonVm.Divisions = await _callApi.GetCommmonCodeTypes(CommonCodeConst.DivisionType);
            }
            else
            {
                List<DocumentInfoVM> list = new List<DocumentInfoVM>();
                HttpContext.Session.SetString("SessionDocumentInfo", JsonConvert.SerializeObject(list));
                model.commonVm.Divisions = await _callApi.GetCommmonCodeTypes(CommonCodeConst.DivisionType);

            }
            return View(model);
        }
        
        [HttpPost]
        public async Task<JsonResult> Create(PersonRelatedInfoVm model,IFormFile userPictureSource)
        {
            try
            {
                if (userPictureSource != null)
                {
                    model.person.Photograph = FileHandler.GenerateByte(userPictureSource);
                }
                if (HttpContext.Session.GetString("SessionDocumentInfo") != null)
                {
                    var res = HttpContext.Session.GetString("SessionDocumentInfo");
                    model.person.DocumentInfos = JsonConvert.DeserializeObject<List<DocumentInfoVM>>(res);
                }
                var objCreateUpdate = new CreateUpdateDataModel()
                {
                    //UserId = SessionHandler.SetLayoutInformation().UserId,
                    Data = model.person
                };
               _resMsg = await _callApi.client.PostAsJsonAsync(APIAddress.NSIPresonalInfoAdd, objCreateUpdate);
                if (!_resMsg.IsSuccessStatusCode)
                {
                    
                    return Json("সফল হয়নি");
                }
                var resReturnObj = _resMsg.Content.ReadAsAsync<ServiceReturnModel>().Result;
                if (resReturnObj.ApiData == null)
                {
                    return Json("সফল হয়নি");
                   
                }
                else
                {
                    return Json("সংরক্ষণ সম্পন্ন হয়েছে");
                }
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }
        }


        public async Task<PartialViewResult> UploadFiles(IFormFile file)
        {
            //Session["DocumentInfo"] = null;

            List<DocumentInfoVM> list = new List<DocumentInfoVM>();
            string path = "";
            try
            {
                if (file.Length > 0)
                {
                    string OrgFileName = file.FileName;
                    string fileName = "";
                    string filePath = "";
                    byte[] buffer = Guid.NewGuid().ToByteArray();
                    string uniqueNo = CommonHelper.GetTimestamp(DateTime.Now);
                    string name = Path.GetFileNameWithoutExtension(file.FileName);
                    var fileNumber = CommonHelper.GetTimestamp(DateTime.Now);
                    name = name.Replace('@', '_');
                    name = name.Replace('#', '_');
                    name = name.Replace('^', '_');
                    name = name.Replace('$', '_');
                    name = name.Replace('!', '_');
                    name = name.Replace(',', '_');
                    name = name.Replace('%', '_');
                    string extension = Path.GetExtension(file.FileName);

                    path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "UploadedFiles"));
                    fileName = name + "_"+fileNumber + "" + extension;//name + "_" +
                    filePath = Path.Combine(path, fileName);
                    
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (var fileStream = new FileStream(Path.Combine(filePath), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    
                    if(HttpContext.Session.GetString("SessionDocumentInfo") != null)
                    {
                        var res = HttpContext.Session.GetString("SessionDocumentInfo");
                        list = JsonConvert.DeserializeObject<List<DocumentInfoVM>>(res);
                    }
                    var newList = list.FirstOrDefault(i => i.FileName == fileName);
                    if (newList == null)
                    {
                        var entity = new DocumentInfoVM();
                        entity.FileName = fileName;
                        entity.OrgFileName = file.FileName;
                        entity.FileLocation = filePath;
                        list.Add(entity);
                    }
                    HttpContext.Session.SetString("SessionDocumentInfo", JsonConvert.SerializeObject(list));
                    return PartialView("_AttachmentList", list);
                }
                else
                {
                    return PartialView("_AttachmentList", list);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("File Copy Failed", ex);
            }
        }
        [HttpGet]
        public PartialViewResult RemoveAttachment(string name)
        {
            var list = new List<DocumentInfoVM>();
            if (HttpContext.Session.GetString("SessionDocumentInfo") != null)
            {
                var res = HttpContext.Session.GetString("SessionDocumentInfo");
                list = JsonConvert.DeserializeObject<List<DocumentInfoVM>>(res);
            }
            var newList = list.FirstOrDefault(i => i.FileName == name);
            list.Remove(newList);
            HttpContext.Session.SetString("SessionDocumentInfo", JsonConvert.SerializeObject(list));
            return PartialView("_AttachmentList", list);
        }

        public FileResult DownloadFile(string fileLocation,string fileName)
        {
            //Build the File Path.
            //string path = Path.Combine(this.Environment.WebRootPath, "Files/") + fileName;

            //Read the File data into Byte Array.
            byte[] bytes = System.IO.File.ReadAllBytes(fileLocation);

            //Send the File to Download.
            return File(bytes, "application/octet-stream", fileName);
        }
    }
}
