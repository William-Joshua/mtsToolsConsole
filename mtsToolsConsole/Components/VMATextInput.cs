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
    public partial class VMATextInput : DevExpress.XtraEditors.XtraUserControl
    {
        #region
        public enum TextInputType {
            Account,
            EMail,
            MobilePhone,
            PassWord,
            Default,
            Edit,
            Warning
        }

        #endregion
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

        private TextInputType _textBoxType = TextInputType.Default;
        [Description("文本框类型"), Category("文本框类型")]
        public TextInputType TextBoxType
        {
            get
            {
                return _textBoxType;
            }
            set
            {
                _textBoxType = value;
                InitVMATextInputUI();
            }
        }

        private string _textInputValue = string.Empty;
        [Description("文本"), Category("文本内容")]
        public string TextInputValue
        {
            get
            {
                return this._txtInputDesc.Text;
            }
            set
            {
                _textInputValue = value;
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
        #endregion
        #region 事件
        public delegate void TextBoxEditChangedHandler(object sender, System.EventArgs e);
        [Description("文本框编辑事件"), Category("文本框编辑事件")]
        public event TextBoxEditChangedHandler TextBoxEditChanged;
        public delegate void TextBoxEditChangingHandler(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e);
        [Description("文本框编辑事件"), Category("文本框编辑事件")]
        public event TextBoxEditChangingHandler TextBoxEditChanging;
        #endregion
        public VMATextInput()
        {
            InitializeComponent();
        }

        private void InitVMATextInputUI()
        {
            _lblInputDesc.Text = _textInputTitle;
            _lblInputTitle.Text = _textInputTitle;

            switch (_textBoxType)
            {
                case TextInputType.Default: { UpdateInputImage(false, null); } break;
                case TextInputType.Account: { UpdateInputImage(true,Properties.Resources.baseline_perm_identity_black_24dp); };break;
                case TextInputType.EMail: { UpdateInputImage(true, Properties.Resources.baseline_alternate_email_black_24dp); }; break;
                case TextInputType.MobilePhone: { UpdateInputImage(true, Properties.Resources.baseline_phone_black_24dp); }; break;
                case TextInputType.PassWord: {
                        UpdateInputImage(true, Properties.Resources.baseline_lock_black_24dp);
                        this._txtInputDesc.Properties.PasswordChar = '*';
                    }; break;
                case TextInputType.Edit: { UpdateInputImage(true, Properties.Resources.baseline_edit_black_24dp); }; break;
                case TextInputType.Warning: { UpdateInputImage(true, Properties.Resources.baseline_warning_black_24dp); }; break;
                default: { UpdateInputImage(false, null); } break;
            }
            // 颜色转换
            int[] colorRGBBackColor = DrawColorConsole.ConvertStr2RGB(_inputTitleForeColor);
            this._lblInputTitle.ForeColor = Color.FromArgb(colorRGBBackColor[0], colorRGBBackColor[1], colorRGBBackColor[2]);
        }

        private void UpdateInputImage (bool imgVisible,Image inputImage)
        {
            if(imgVisible)
            {
                this._pnlInputSpaceImage.Visible = true;
                this._picInputSpaceImage.Image = inputImage;
                return;
            }
            this._pnlInputSpaceImage.Visible = false;
            return;
        }
        
        private void _pnlInputSpaceText_Click(object sender, EventArgs e)
        {
            if(this._lblInputDesc.Visible == true)
            {
                this._lblInputDesc.Visible = false;
                this._pnlInputSpaceTitle.Visible = true;
                int[] colorRGBBackColor = DrawColorConsole.ConvertStr2RGB(_inputTitleForeColor);
                this._lblInputSpaceSpara.BackColor = Color.FromArgb(colorRGBBackColor[0], colorRGBBackColor[1], colorRGBBackColor[2]);
                this._txtInputDesc.Visible = true;
                this._txtInputDesc.Focus();
            }
        }

        private void _txtInputDesc_Leave(object sender, EventArgs e)
        {
            if (this._lblInputDesc.Visible == false)
            {
                string inputDesc = this._txtInputDesc.Text.Trim();
                if(inputDesc.Equals(string.Empty))
                {
                    this._lblInputDesc.Visible = true;
                    this._pnlInputSpaceTitle.Visible = false;
                    this._txtInputDesc.Visible = false;
                    this._lblInputSpaceSpara.BackColor = Color.DarkGray;
                }
            }
        }
        #region
        private void _txtInputDesc_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }
        private void _txtInputDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
        private void _txtInputDesc_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }
        private void _txtInputDesc_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.TextBoxEditChanged(sender, e);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void _txtInputDesc_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                this.TextBoxEditChanging(sender, e);
            }
            catch (Exception)
            {
                return;
            } 
        }
        #endregion
        
        private void _picInputSpaceImage_MouseEnter(object sender, EventArgs e)
        {
            if (_textBoxType == TextInputType.PassWord)
            {
                this._txtInputDesc.Properties.PasswordChar = '\0';
            }
        }

        private void _picInputSpaceImage_MouseLeave(object sender, EventArgs e)
        {
            if (_textBoxType == TextInputType.PassWord)
            {
                this._txtInputDesc.Properties.PasswordChar = '*';
            }
        }
    }
}
