using mtsToolsConsole.Common;
using mtsToolsConsole.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolsConsole.Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            MTSWebAPIConsole mtsWebAPIConsole = new MTSWebAPIConsole();
            WebApiAsyncResponse webApiAsyncResponse = new WebApiAsyncResponse();
            WebApiAsyncParameter webApiAsyncParameter = new WebApiAsyncParameter();
            webApiAsyncParameter.Operation = string.Format("/api/Users/VerifyUserAccount");
            UserAccount userAccount = new UserAccount();
            userAccount.Account = "ITECH_MTS_ADMIN";
            userAccount.PassWord = "itech8888";
            webApiAsyncParameter.Parameter = userAccount;
            webApiAsyncResponse = mtsWebAPIConsole.PostAsJsonAsync(webApiAsyncParameter);
            Console.WriteLine(string.Format("返回状态 : {0}", webApiAsyncResponse.StatusCode));
            Console.WriteLine(string.Format("返回值 : {0}", webApiAsyncResponse.JsonReValue));
            Console.Read();
        }
    }
}
