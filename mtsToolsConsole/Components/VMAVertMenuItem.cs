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

    public partial class VMAVertMenuItem : DevExpress.XtraEditors.XtraUserControl
    {
        #region 数据源，自定义属性
        private object _itemMenuSource;
        [Description("标签对应数据源"), Category("ItemMenu 数据源")]
        public object ItemMenuSource
        {
            get
            {
                return _itemMenuSource;
            }
            set
            {
                _itemMenuSource = value;
                InitVMAVertMenuItemUI();
            }
        }
        #endregion
        public VMAVertMenuItem()
        {
            InitializeComponent();
        }

        public void InitVMAVertMenuItemUI()
        {
            NaviMenuItem naviMenuItem = ItemMenuSource as NaviMenuItem;
            this._lblMenuItemTitle.Text = naviMenuItem.MenuName;
            if(naviMenuItem.ExpandEnable == false)
            {
                this._picSubMenuExpand.Visible = false;
            }
            else
            {
                if(naviMenuItem.CurrentExpandState == false)
                {
                    this._picSubMenuExpand.Image = Properties.Resources.baseline_expand_less_black_24dp;
                }
                else
                {
                    this._picSubMenuExpand.Image = Properties.Resources.baseline_expand_more_black_24dp;
                }
            }
            if (naviMenuItem.MenuIconEnable == false)
            {
                this._picMenuTypeIcon.Visible = false;
            }
            else
            {
                switch(naviMenuItem.MenuIcon)
                {
                    case "process": this._picMenuTypeIcon.Image = Properties.Resources.baseline_view_day_black_24dp;break;
                    case "board": this._picMenuTypeIcon.Image = Properties.Resources.baseline_dvr_black_24dp; break;
                    case "repair": this._picMenuTypeIcon.Image = Properties.Resources.baseline_devices_other_black_24dp; break;
                    case "store": this._picMenuTypeIcon.Image = Properties.Resources.baseline_store_black_24dp; break;
                    default: this._picMenuTypeIcon.Image = Properties.Resources.baseline_new_releases_black_24dp; break;
                }
            }
        }
    }
}
