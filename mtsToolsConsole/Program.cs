using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mtsToolsConsole
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#if DEBUG //跳过验证，用管理员直接登录
            Application.Run(new HomePage("ITECH_MTS_ADMIN"));
#endif
#if (!DEBUG)
            LoginPage loginPage = new LoginPage();//直接先召出登陆界面，然后成功登陆后关闭登陆界面即可。
            if (DialogResult.OK == loginPage.ShowDialog())
            {
                Application.Run(new HomePage(loginPage.userAccountID));
            }
#endif
        }
    }
}
