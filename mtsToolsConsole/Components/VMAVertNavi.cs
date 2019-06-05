using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using mtsToolsConsole.Model;
using System.Reflection;

namespace mtsToolsConsole.Components
{
    public partial class VMAVertNavi : DevExpress.XtraEditors.XtraUserControl
    {
        private List<NaviMenuRelationship> naviMenuRelationships = new List<NaviMenuRelationship>();
        #region 数据源，自定义属性
        private object _itemNaviMenuSource;
        [Description("导航栏对应目录数据源"), Category("NaviMenu 数据源")]
        public object ItemNaviMenuSource
        {
            get
            {
                return _itemNaviMenuSource;
            }
            set
            {
                _itemNaviMenuSource = value;
                InitVMAVertNaviUI();
            }
        }


        private object _itemDisplayPage;
        [Description("主页面容器，显示加载点击页面"), Category("主页 加载页面")]
        public object ItemDisplayPage
        {
            get
            {
                return _itemDisplayPage;
            }
            set
            {
                _itemDisplayPage = value;
            }
            
        }
        #endregion
        public VMAVertNavi()
        {
            InitializeComponent();
        }

        public void InitVMAVertNaviUI()
        {
            List<NaviMenuBar> naviMenuBars = ItemNaviMenuSource as List<NaviMenuBar>;
            foreach(NaviMenuBar naviMenuBar in naviMenuBars)
            {
                CreateVertMenuItem(naviMenuBar);
            }
        }
        private void CreateVertMenuItem(NaviMenuBar naviMenuBar)
        {
            NaviMenuRelationship naviMenuRelationship = new NaviMenuRelationship();
            // Load Root Menu
            VMAVertMenuItem rootVertMenuItem = new VMAVertMenuItem();
            NaviMenuItem rootMenuItem = naviMenuBar.RootMenuItem;
            rootVertMenuItem.ItemMenuSource = rootMenuItem;
            this._flowVertNaviBar.Controls.Add(rootVertMenuItem);
            naviMenuRelationship.rootNode = rootVertMenuItem;
            rootVertMenuItem.Click += new EventHandler(rootMenuItem_Click);
            foreach (NaviMenuItem subMenuItem in naviMenuBar.SubMenuItems)
            {
                VMAVertMenuItem subVertMenItem = new VMAVertMenuItem();
                subVertMenItem.ItemMenuSource = subMenuItem;
                this._flowVertNaviBar.Controls.Add(subVertMenItem);
                naviMenuRelationship.subNode.Add(subVertMenItem);
                if (rootMenuItem.CurrentExpandState == true)
                {
                    subVertMenItem.Visible = true;
                }
                else
                {
                    subVertMenItem.Visible = false;
                }
                subVertMenItem.Click += new EventHandler(subMenuItem_Click);
            }
            naviMenuRelationships.Add(naviMenuRelationship);
        }
        
        private void rootMenuItem_Click(object sender, EventArgs e)
        {
            VMAVertMenuItem rootVMAMenuItem = sender as VMAVertMenuItem;
            NaviMenuItem naviMenuItem = rootVMAMenuItem.ItemMenuSource as NaviMenuItem;

            if(naviMenuItem.CurrentExpandState == true)
            {
                naviMenuItem.CurrentExpandState = false;
                rootVMAMenuItem.ItemMenuSource = naviMenuItem;
                UpdateSubMenuItemVisible(rootVMAMenuItem);
            }
            else
            {
                naviMenuItem.CurrentExpandState = true;
                rootVMAMenuItem.ItemMenuSource = naviMenuItem;
                UpdateSubMenuItemVisible(rootVMAMenuItem);
            }
        }

        private void subMenuItem_Click(object sender, EventArgs e)
        {
            Control homeContainer = _itemDisplayPage as Control;
            VMAVertMenuItem subVMAMenuItem = sender as VMAVertMenuItem;
            NaviMenuItem naviMenuItem = subVMAMenuItem.ItemMenuSource as NaviMenuItem;
            string pageName = naviMenuItem.MenuComponent;
            Assembly assembly = Assembly.GetExecutingAssembly();
            object assemblyobj = assembly.CreateInstance(string.Format("mtsToolsConsole.Pages.{0}", pageName));
            Control userPage = assemblyobj as Control;
            userPage.Dock = DockStyle.Fill;
         homeContainer.Controls.Clear();
            homeContainer.Controls.Add(userPage);
        }


        private void UpdateSubMenuItemVisible(VMAVertMenuItem rootVMAMenuItem)
        {
            var vmaVertMenuItems = naviMenuRelationships.Where(ship => ship.rootNode == rootVMAMenuItem).Select(ship => new { ship.subNode });

            foreach(var vmaVertMenuItem in vmaVertMenuItems)
            {
                foreach( VMAVertMenuItem subVertMenuItem in vmaVertMenuItem.subNode)
                {
                    subVertMenuItem.Visible = !subVertMenuItem.Visible;
                }
            }
        }
    }
}
