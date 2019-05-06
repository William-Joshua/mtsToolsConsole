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

namespace mtsToolsConsole.Components
{
    public partial class VMAVertNavi : DevExpress.XtraEditors.XtraUserControl
    {
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
            // Load Root Menu
            VMAVertMenuItem rootVertMenuItem = new VMAVertMenuItem();
            NaviMenuItem rootMenuItem = naviMenuBar.RootMenuItem;
            rootVertMenuItem.ItemMenuSource = rootMenuItem;

            this._flowVertNaviBar.Controls.Add(rootVertMenuItem);

            if (rootMenuItem.ExpandEnable == true)
            {
                foreach(NaviMenuItem subMenuItem in naviMenuBar.SubMenuItems)
                {
                    VMAVertMenuItem subVertMenItem = new VMAVertMenuItem();
                    subVertMenItem.ItemMenuSource = subMenuItem;
                    this._flowVertNaviBar.Controls.Add(subVertMenItem);
                }
            }
        }
    }
}
