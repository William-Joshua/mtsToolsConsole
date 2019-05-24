using mtsToolsConsole.Common;
using mtsToolsConsole.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolsConsole.Controller
{
    public class UserController
    {
        private MTSWebAPIConsole _mtsWebAPIConsole = new MTSWebAPIConsole();
        private WebApiAsyncResponse _webApiAsyncResponse = new WebApiAsyncResponse();
        private WebApiAsyncParameter _webApiAsyncParameter = new WebApiAsyncParameter();
        /// <summary>
        /// 验证后台接口
        /// </summary>
        /// <param name="userAccount"></param>
        /// <returns></returns>
        public WebApiAsyncResponse VerifyUserAccount(UserAccount userAccount)
        {

            _webApiAsyncParameter.Operation = string.Format("/api/Users/VerifyUserAccount");
            _webApiAsyncParameter.Parameter = userAccount;
            _webApiAsyncResponse = _mtsWebAPIConsole.PostAsJsonAsync(_webApiAsyncParameter);
            return _webApiAsyncResponse;
        }
        /// <summary>
        /// 加载用户菜单接口
        /// </summary>
        /// <param name="userAccountID"></param>
        /// <returns></returns>
        public WebApiAsyncResponse LoadUserMenuTree(string userAccountID)
        {
            UserAccessRequest userAccessRequest = new UserAccessRequest
            {
                UserID = userAccountID,
                SoftPlatform = "PCS"
            };
            _webApiAsyncParameter.Operation = string.Format("/api/Users/GetUserMenuTree");
            _webApiAsyncParameter.Parameter = userAccessRequest;
            _webApiAsyncResponse = _mtsWebAPIConsole.PostAsJsonAsync(_webApiAsyncParameter);
            return _webApiAsyncResponse;
        }
    }
}
