using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using TestSelise.Models.Models;

namespace TestApplication.Helper
{
    public static class GetDropdownData
    {
        public static async Task<List<CommonCodeVM>> GetCommmonCodeTypes(this CallApi _callApi, string type)
        {
            try
            {
                var resMsg = await _callApi.client.GetAsync(APIAddress.NSIGetCommonCodeByType + type);
                var returnObj = resMsg.Content.ReadAsAsync<ServiceReturnModel>().Result;
                var result = (List<CommonCodeVM>)returnObj.ApiData.ToObject<List<CommonCodeVM>>();
                return result;
                return null;
            }
            catch (Exception)
            {
                return new List<CommonCodeVM>();
            }
        }
    }
}
