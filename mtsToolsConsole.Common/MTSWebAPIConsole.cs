using mtsToolsConsole.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolsConsole.Common
{
    public class MTSWebAPIConsole
    {
        public HttpClient httpClient = new HttpClient();
        public HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
        public MTSWebAPIConsole()
        {
            httpClient.BaseAddress = new Uri(ConfigurationManager.AppSettings["mtsToolsWebAPI"].ToString());
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public WebApiAsyncResponse GetAsJsonAsync()
        {
            WebApiAsyncResponse webApiAsyncResponse = new WebApiAsyncResponse();
            return webApiAsyncResponse;
        }

        public WebApiAsyncResponse PostAsJsonAsync(WebApiAsyncParameter webApiAsyncParameter)
        {
            WebApiAsyncResponse webApiAsyncResponse = new WebApiAsyncResponse();
            httpResponseMessage = httpClient.PostAsJsonAsync (webApiAsyncParameter.Operation,webApiAsyncParameter.Parameter).Result;
            webApiAsyncResponse.StatusCode = ((int) httpResponseMessage.StatusCode).ToString();
            webApiAsyncResponse.JsonReValue = httpResponseMessage.Content.ReadAsStringAsync().Result;

            return webApiAsyncResponse;
        }


    }
}
