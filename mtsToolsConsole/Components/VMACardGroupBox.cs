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
using System.ComponentModel.Design;

namespace mtsToolsConsole.Components
{
    public partial class VMACardGroupBox : DevExpress.XtraEditors.XtraUserControl
    {
        #region Card Title BackGround
        private string _cardTitleBackGround = string.Format("255, 255, 255");
        [Description("标题栏背景色，仅支持 RGB 模式， xxx, xxx, xxx 格式"), Category("Card 标题栏背景色")]
        public string CardTitleBackGround
        {
            get
            {
                return _cardTitleBackGround;
            }
            set
            {
                _cardTitleBackGround = value;
                InitVMACardGroupBoxUI();
            }
        }

        private string _cardTitleForeColor = string.Format("32, 31, 53");
        [Description("标题栏文字颜色，仅支持 RGB 模式， xxx, xxx, xxx 格式"), Category("Card 标题栏文字颜色")]
        public string CardTitleForeColor
        {
            get
            {
                return _cardTitleForeColor;
            }
            set
            {
                _cardTitleForeColor = value;
                InitVMACardGroupBoxUI();
            }
        }

        private string _cardTitleText = string.Format("Card Name");
        [Description("标题栏名称"), Category("Card 标题栏名称 ")]
        public string CardTitleText
        {
            get
            {
                return _cardTitleText;
            }
            set
            {
                _cardTitleText = value;
                InitVMACardGroupBoxUI();
            }
        }
        #endregion
        public VMACardGroupBox()
        {
            InitializeComponent();
        }

        private void InitVMACardGroupBoxUI()
        {
            this._lblCardTitle.Text = _cardTitleText.Trim();
            // 颜色转换
            int[] colorRGBBackColor = DrawColorConsole.ConvertStr2RGB(_cardTitleBackGround);
            this._pnlCardTitle.BackColor = Color.FromArgb(colorRGBBackColor[0], colorRGBBackColor[1], colorRGBBackColor[2]);
           int[] colorRGBForeColor = DrawColorConsole.ConvertStr2RGB(_cardTitleForeColor);
            this._lblCardTitle.ForeColor = Color.FromArgb(colorRGBForeColor[0], colorRGBForeColor[1], colorRGBForeColor[2]);
        }
    }
}
