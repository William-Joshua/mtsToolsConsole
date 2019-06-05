using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using DevExpress.XtraEditors;
using System.Drawing.Design;
using System.Collections;
using mtsToolsConsole.Common;

namespace mtsToolsConsole.Components
{
    [Designer(typeof(VMAGroupCardDesigner))]
    public partial class VMAGroupCard : DevExpress.XtraEditors.XtraUserControl
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
        #region 工作区
        public Panel CardContainer
        {
            get { return this._pnlCardContainer; }
        }

        #endregion

        public VMAGroupCard()
        {
            InitializeComponent();
            TypeDescriptor.AddAttributes(this._pnlCardContainer,
                new DesignerAttribute(typeof(VMAGroupCardPanelDesigner)));
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

    public class VMAGroupCardDesigner : ParentControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            var contentsPanel = ((VMAGroupCard)this.Control).CardContainer;
            this.EnableDesignMode(contentsPanel, "CardContainer");
        }

        public override bool CanParent(Control control)
        {
            return false;
        }

        protected override void OnDragDrop(DragEventArgs de)
        {
            de.Effect = DragDropEffects.None;
        }

        protected override IComponent[] CreateToolCore(ToolboxItem tool, int x, int y, int width, int height, bool hasLocation, bool hasSize)
        {
            return null;
        }
    }

    public class VMAGroupCardPanelDesigner:ParentControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                SelectionRules selectionRules = base.SelectionRules;
                selectionRules &= ~SelectionRules.AllSizeable;
                return selectionRules;
            }
        }

        protected override void PostFilterAttributes(IDictionary attributes)
        {
            base.PostFilterAttributes(attributes);
            attributes[typeof(DockingAttribute)] = new DockingAttribute(DockingBehavior.Never);
        }

        protected override void PostFilterProperties(IDictionary properties)
        {
            base.PostFilterProperties(properties);
            base.PostFilterProperties(properties);
            var propertiesToRemove = new string[] {
                "Dock", "Anchor",
                "Size", "Location",
                "Width", "Height",
                "MinimumSize", "MaximumSize",
                "AutoSize", "AutoSizeMode",
                "Visible", "Enabled",
            };
            foreach (var item in propertiesToRemove)
            {
                if (properties.Contains(item))
                    properties[item] = TypeDescriptor.CreateProperty(this.Component.GetType(),
                        (PropertyDescriptor)properties[item],
                        new BrowsableAttribute(false));
            }
        }
    }
}
