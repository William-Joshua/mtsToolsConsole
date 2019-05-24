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

namespace mtsToolsConsole.Pages.Error
{
    public partial class Page404 : DevExpress.XtraEditors.XtraUserControl
    {
        private XtraForm _rebackPage = new XtraForm();
        public Page404(XtraForm rebackPage)
        {
            InitializeComponent();
            _rebackPage = rebackPage;
        }

        private void _btnGoHome_Click(object sender, EventArgs e)
        {
            this.Dispose();
            _rebackPage.Show();
        }
    }
}
