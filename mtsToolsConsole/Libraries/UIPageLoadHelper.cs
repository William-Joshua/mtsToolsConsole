using DevExpress.XtraEditors;
using mtsToolsConsole.Model;
using mtsToolsConsole.Pages.Error;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolsConsole.Libraries
{
    public class UIPageLoadHelper
    {
        public static DevExpress.XtraEditors.XtraForm GetErrorUIPageForm(WebApiAsyncResponse webApiAsyncResponse,XtraForm rebackPage)
        {
            XtraForm uiDisplayPage = new XtraForm();
            switch (webApiAsyncResponse.StatusCode)
            {
                case "403":
                    {
                        Page403 page403Control = new Page403(rebackPage);
                        ErrorPageContainer errorPageContainer = new ErrorPageContainer(page403Control);
                        uiDisplayPage = errorPageContainer;
                    }
                    break;
                case "404": {
                        Page404 page404Control = new Page404(rebackPage);
                        ErrorPageContainer errorPageContainer = new ErrorPageContainer(page404Control);
                        uiDisplayPage = errorPageContainer;
                    } break;
                case "500": {
                        Page500 page500Control = new Page500(rebackPage);
                        ErrorPageContainer errorPageContainer = new ErrorPageContainer(page500Control);
                        uiDisplayPage = errorPageContainer;
                    } break;
                default: {
                        Page404 page404Control = new Page404(rebackPage);
                        ErrorPageContainer errorPageContainer = new ErrorPageContainer(page404Control);
                        uiDisplayPage = errorPageContainer;
                    } break;
            }
            return uiDisplayPage;
        }
    }
}
