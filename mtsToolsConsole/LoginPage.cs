using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using mtsToolsConsole.Model;
using mtsToolsConsole.Controller;
using mtsToolsConsole.Libraries;

namespace mtsToolsConsole
{
    public partial class LoginPage : DevExpress.XtraEditors.XtraForm
    {
        private UserController _userController = new UserController();
        public string userAccountID = string.Empty;
        public LoginPage()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Abort;
        }

        private void _btnLoginSubmit_Click(object sender, EventArgs e)
        {
            // 校验输入数据
            UserAccount userAccount = VerifyUserPwdInput();
            if (userAccount == null)
            {
                return;
            }
            WebApiAsyncResponse webApiAsyncResponse = _userController.VerifyUserAccount(userAccount);
            // 返回 200 ,判断密码
            if (webApiAsyncResponse.StatusCode == "200")
            {
                // 登录
                if (webApiAsyncResponse.JsonReValue.ToUpper() == "TRUE")
                {
                    userAccountID = userAccount.Account;
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                    return;
                }
                else
                {
                    _lblWarnMessage.Text = string.Format(@"输入的用户名/密码错误！");
                    _pnlWarnMessage.Visible = true;
                }
            }
            else // 其他异常
            {
                UIPageLoadHelper.GetErrorUIPageForm(webApiAsyncResponse, this).Show();
                return;
            }

        }

        private void _vtiLoginUserID_KeyDown(object sender, KeyEventArgs e)
        {
            _pnlWarnMessage.Visible = false;
        }

        private void _vtiLoginPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            _pnlWarnMessage.Visible = false;
        }

        private UserAccount VerifyUserPwdInput()
        {
            try
            {
                UserAccount userAccount = new UserAccount();
                string account = this._vtiLoginUserID.TextInputValue.Trim().ToString();
                string password = this._vtiLoginPassWord.TextInputValue.Trim().ToString();
                if (account.Length == 0 || password.Length == 0)
                {
                    _lblWarnMessage.Text = string.Format(@"用户名/密码不能为空！");
                    _pnlWarnMessage.Visible = true;
                    return null;
                }
                userAccount.Account = account;
                userAccount.PassWord = password;
                return userAccount;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}