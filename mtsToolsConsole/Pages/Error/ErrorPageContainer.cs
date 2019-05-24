using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace mtsToolsConsole.Pages.Error
{
    public partial class ErrorPageContainer : DevExpress.XtraEditors.XtraForm
    {
        public ErrorPageContainer(XtraUserControl errorPage)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Abort;
            this._pnlContainer.Controls.Add(errorPage);
            errorPage.Dock = DockStyle.Fill;
        }

        private void _pnlContainer_ControlRemoved(object sender, ControlEventArgs e)
        {
            // 当异常页面控件 Dispose() 时，其Form 容器也要Dispose()
            this.Dispose();
        }
    }
}