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

namespace mtsToolsConsole.Pages
{
    public partial class ProdProcessRecord : DevExpress.XtraEditors.XtraUserControl
    {
        public ProdProcessRecord()
        {
            InitializeComponent();
        }

        private void _chartProcessStatus_Resize(object sender, EventArgs e)
        {
            if(this.Width > 1024)
            {
                this._chartProcessStatus.Legend.Visibility = DevExpress.Utils.DefaultBoolean.Default;
            }
            else
            {
                this._chartProcessStatus.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            }
        }
    }
}
