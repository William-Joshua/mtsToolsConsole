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
using mtsToolsConsole.Common;
using System.Collections.ObjectModel;

namespace mtsToolsConsole.Components
{
    public partial class VMAInputSelect : DevExpress.XtraEditors.XtraUserControl
    {
        public VMAInputSelect()
        {
            InitializeComponent();

        }
        
        #region 属性
        private string _textInputTitle = string.Format("Title");
        [Description("标题栏"), Category("文本框标题")]
        public string TextInputTitle
        {
            get
            {
                return _textInputTitle;
            }
            set
            {
                _textInputTitle = value;
                InitVMATextInputUI();
            }
        }

        private string _inputTitleForeColor = string.Format("54, 68, 186");
        [Description("标题字体颜色，仅支持 RGB 模式， xxx, xxx, xxx 格式"), Category("标题字体颜色")]
        public string InputTitleForeColor
        {
            get
            {
                return _inputTitleForeColor;
            }
            set
            {
                _inputTitleForeColor = value;
                InitVMATextInputUI();
            }
        }


        private ObservableCollection<string> _selectionItems = new ObservableCollection<string>();
        [Description("可选成员"), Category("可选成员")]
        public ObservableCollection<string> SelectionItems
        {
            get
            {
                return _selectionItems;
            }
            set
            {
                _selectionItems = value;
                InitVMATextInputUI();
            }
        }
        #endregion
        /// <summary>
        /// 显示下拉菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _picInputSpaceImage_Click(object sender, EventArgs e)
        {
            VMAScrollListPanel vmaScrollListPanel = new VMAScrollListPanel();
            vmaScrollListPanel.Location = this._lblInputDesc.Location;
            vmaScrollListPanel.BringToFront();
            this.Controls.Add(vmaScrollListPanel);
        }

        private void InitVMATextInputUI()
        {
            _lblInputDesc.Text = _textInputTitle;
            _lblInputTitle.Text = _textInputTitle;

            // 颜色转换
            int[] colorRGBBackColor = DrawColorConsole.ConvertStr2RGB(_inputTitleForeColor);
            this._lblInputTitle.ForeColor = Color.FromArgb(colorRGBBackColor[0], colorRGBBackColor[1], colorRGBBackColor[2]);

            if(_selectionItems.Count() == 0)
            {
                return;
            }
            foreach(string selectionItem in _selectionItems)
            {
            }
        }
    }
}
