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
            // 设置下拉菜单宽度
            this._cmenuSelectItems.Width = _pnlInputSpaceText.Width;
            this._cmenuSelectItems.MaximumSize = new Size(_pnlInputSpaceText.Width, 480);
            this._cmenuSelectItems.Show(this._pnlInputSpaceText.Location.X, this._pnlInputSpace.Location.Y);
        }

        private void InitVMATextInputUI()
        {
            _lblInputDesc.Text = _textInputTitle;
            _lblInputTitle.Text = _textInputTitle;

            // 颜色转换
            int[] colorRGBBackColor = DrawColorConsole.ConvertStr2RGB(_inputTitleForeColor);
            this._lblInputTitle.ForeColor = Color.FromArgb(colorRGBBackColor[0], colorRGBBackColor[1], colorRGBBackColor[2]);
        }
    }
}
