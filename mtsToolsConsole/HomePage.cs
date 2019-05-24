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
using System.Net.Mail;
using mtsToolsConsole.Support;
using mtsToolsConsole.Components;
using mtsToolsConsole.Model;
using Newtonsoft.Json;
using mtsToolsConsole.Pages;
using mtsToolsConsole.Controller;
using mtsToolsConsole.Libraries;
using mtsToolsConsole.Repository;

namespace mtsToolsConsole
{
    public partial class HomePage : DevExpress.XtraEditors.XtraForm
    {
        private bool HomeFullScreen = false;
        private string _userAccountID = string.Empty;
        private UserController userController = new UserController();
        public HomePage(string userAccountID)
        {
            _userAccountID = userAccountID;
            InitializeComponent();
            List<UserMenuItem> userMenuItems = GetUserMenuItems();
            // 加载用户对应 Navi Menu
            LoadUserPermissionMenu(userMenuItems);
            InitDefinePage();
        }

        #region UI 相关
        private void _picShowNaviMenu_MouseEnter(object sender, EventArgs e)
        {
            _picShowNaviMenu.BackColor = Color.FromArgb(161, 166, 213);
        }

        private void _picShowNaviMenu_MouseLeave(object sender, EventArgs e)
        {
            _picShowNaviMenu.BackColor = Color.Transparent;
        }

        private void _picShowNaviMenu_Click(object sender, EventArgs e)
        {
            _pnlNaviMenu.Visible = !(_pnlNaviMenu.Visible);
            _pnlHomeLogo.Focus();
        }

        private void _picStaticFloatUser_MouseEnter(object sender, EventArgs e)
        {
            _picStaticFloatUser.BackColor = Color.FromArgb(161, 166, 213);
        }

        private void _picStaticFloatUser_MouseLeave(object sender, EventArgs e)
        {
            _picStaticFloatUser.BackColor = Color.Transparent;
        }

        private void _picStaticFloatExpand_MouseEnter(object sender, EventArgs e)
        {
            _picStaticFloatExpand.BackColor = Color.FromArgb(161, 166, 213);
        }

        private void _picStaticFloatExpand_MouseLeave(object sender, EventArgs e)
        {
            _picStaticFloatExpand.BackColor = Color.Transparent;
        }

        private void _pnlStaticFloatHelp_MouseEnter(object sender, EventArgs e)
        {
            _pnlStaticFloatHelp.BackColor = Color.FromArgb(161, 166, 213);
        }

        private void _pnlStaticFloatHelp_MouseLeave(object sender, EventArgs e)
        {
            _pnlStaticFloatHelp.BackColor = Color.Transparent;
        }

        private void _picStaticFloatExpand_Click(object sender, EventArgs e)
        {
            if (!HomeFullScreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                _picStaticFloatExpand.Image = Properties.Resources.baseline_fullscreen_exit_white_24dp;
                HomeFullScreen = true;
                _pnlNaviMenu.Visible = false;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                _picStaticFloatExpand.Image = Properties.Resources.baseline_fullscreen_white_24dp;
                HomeFullScreen = false;
            }
        }

        private void _pnlStaticFloatHelp_Click(object sender, EventArgs e)
        {
            // 软件报告异常
            BugReportPage bugReportPage = new BugReportPage();
            bugReportPage.ShowDialog();
        }
        #endregion
        
        private List<UserMenuItem> GetUserMenuItems()
        {
            try
            {
                WebApiAsyncResponse webApiAsyncResponse = userController.LoadUserMenuTree(_userAccountID);
                if (webApiAsyncResponse.StatusCode == "200")
                {
                    List<UserMenuItem> userMenuItems = JsonConvert.DeserializeObject<List<UserMenuItem>>(webApiAsyncResponse.JsonReValue);
                    return userMenuItems;
                }
                else
                {
                    UIPageLoadHelper.GetErrorUIPageForm(webApiAsyncResponse, this).Show();
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void LoadUserPermissionMenu(List<UserMenuItem> userMenuItems)
        {
            List<NaviMenuBar> naviMenuBars = new List<NaviMenuBar>();
            MenuTreeRepository menuTreeRepository = new MenuTreeRepository();
            naviMenuBars = menuTreeRepository.ConvertMenuToNaviMenu(userMenuItems);
            VMAVertNavi vmaVertNavi = new VMAVertNavi
            {
                ItemDisplayPage = this._pnlWorkFrame,
                ItemNaviMenuSource = naviMenuBars,
                Dock = DockStyle.Fill
            };
            this._pnlVertNaviBar.Controls.Add(vmaVertNavi);
        }

        private void InitDefinePage()
        {
            //Control homepage = new ProdProcessRecord();
            //homepage.Dock = DockStyle.Fill;
            //_pnlWorkFrame.Controls.Add(homepage);
        }
    }
}