using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Helper
{
    public class ReadSetting
    {
        public string url { get; set; }
    }
    public class CallApi
    {
        internal HttpClient client = new HttpClient();
        private readonly static string _url = "";
        public CallApi()
        {
            BaseUrlSet();
        }
        static CallApi()
        {
            if (_url == "")
            {
                using StreamReader r = new StreamReader("appsettings.json");
                string json = r.ReadToEnd();
                var item = JsonConvert.DeserializeObject<ReadSetting>(json);
                _url = item.url;
            }
        }
        public void BaseUrlSet()
        {

            client.BaseAddress = new Uri(_url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public T Deserialize<T>(HttpResponseMessage response) where T : class
        {
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
            response.EnsureSuccessStatusCode();

            var result = response.Content;
            var content = result.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content.Result);
        }
        public StringContent Serialize<T>(T input)
        {
            var folderAsJosn = JsonConvert.SerializeObject(input);
            return new StringContent(folderAsJosn, Encoding.UTF8, "application/json");
        }
    }
    public class ServiceReturnModel
    {
        public bool IsExecute { get; set; } = false;
        public bool IsMessage { get; set; } = false;
        public bool IsError { get; set; } = false;
        public dynamic ApiData { get; set; } = null;
        public string MessageCode { get; set; }
        public string Message { get; set; }
        public bool IsSearchMsg { get; set; }

    }
}
