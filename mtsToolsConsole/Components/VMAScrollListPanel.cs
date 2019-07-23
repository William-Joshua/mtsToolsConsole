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

namespace mtsToolsConsole.Components
{
    public partial class VMAScrollListPanel : DevExpress.XtraEditors.XtraUserControl
    {
        #region 
        /// <summary>
        /// 下拉菜单数据源
        /// </summary>
        private object _scrollDropDownItemSource;
        public object ScrollDropDownItemSource
        {
            get {
                return _scrollDropDownItemSource;
            }
            set
            {
                _scrollDropDownItemSource = value;
            }
        }
        /// <summary>
        /// 下拉菜单宽度
        /// </summary>
        public int _scrollDropDownWidth;
        public int ScrollDropDownWidth
        {
            get
            {
                return _scrollDropDownWidth;
            }
            set
            {
                _scrollDropDownWidth = value;
            }
        }

        /// <summary>
        /// 下拉框最大高度
        /// </summary>
        private int _scrollDropDownMaxHeight = 240;
        public int ScrollDropDownMaxHeight
        {
            get
            {
                return _scrollDropDownMaxHeight;
            }
            set
            {
                _scrollDropDownMaxHeight = value;
            }
        }

        #endregion
        public VMAScrollListPanel()
        {
            InitializeComponent();
        }
    }
}
