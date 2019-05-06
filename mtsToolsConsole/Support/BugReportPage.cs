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
using mtsToolsConsole.Common;
using System.Drawing.Imaging;
using System.Threading;

namespace mtsToolsConsole.Support
{
    public partial class BugReportPage : DevExpress.XtraEditors.XtraForm
    {
        private System.Windows.Forms.Timer snapshotTimer = new System.Windows.Forms.Timer();
        public BugReportPage()
        {
            InitializeComponent();
        }
        private void _txtNewBugTitle_KeyDown(object sender, KeyEventArgs e)
        {
            string newBugTitle = this._txtNewBugTitle.Text.Trim();
            if (newBugTitle.Equals("为问题添加标题"))
            {
                this._txtNewBugTitle.Text = string.Empty;
                this._txtNewBugTitle.ForeColor = Color.Black;
            }
        }
        private void _txtNewBugTitle_Click(object sender, EventArgs e)
        {
            string newBugTitle = this._txtNewBugTitle.Text.Trim();
            if(newBugTitle.Equals("为问题添加标题"))
            {
                this._txtNewBugTitle.Text = string.Empty;
                this._txtNewBugTitle.ForeColor = Color.Black;
            }
        }

        private void _memoNewBugDesc_Click(object sender, EventArgs e)
        {
            string newBugDesc = this._memoNewBugDesc.Text.Trim();
            if (newBugDesc.Equals("为问题添加详细描述"))
            {
                this._memoNewBugDesc.Text = string.Empty;
                this._memoNewBugDesc.ForeColor = Color.Black;
            }
        }

        private void _txtNewBugTitle_Leave(object sender, EventArgs e)
        {
            string newBugTitle = this._txtNewBugTitle.Text.Trim();
            if(newBugTitle.Equals(string.Empty))
            {
                this._txtNewBugTitle.Text = string.Format("为问题添加标题");
                this._txtNewBugTitle.ForeColor = Color.DarkGray;
            }
        }
        private void _memoNewBugDesc_KeyDown(object sender, KeyEventArgs e)
        {
            string newBugDesc = this._memoNewBugDesc.Text.Trim();
            if (newBugDesc.Equals("为问题添加详细描述"))
            {
                this._memoNewBugDesc.Text = string.Empty;
                this._memoNewBugDesc.ForeColor = Color.Black;
            }
        }
        private void _memoNewBugDesc_Leave(object sender, EventArgs e)
        {
            string newBugDesc = this._memoNewBugDesc.Text.Trim();
            if (newBugDesc.Equals(string.Empty))
            {
                this._memoNewBugDesc.Text = string.Format("为问题添加详细描述");
                this._memoNewBugDesc.ForeColor = Color.DarkGray;
            }
        }

        private void _picAddPrintScreen_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                Thread.Sleep(200);
                snapshotTimer.Tick += snapshotTimer_Tick;
                snapshotTimer.Start();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void snapshotTimer_Tick(object sender, EventArgs e)
        {
            Image fullScreenImage = HardwareConsole.GetPrintScreenImage();
            HardwareConsole.StoreImageToCache(fullScreenImage, string.Format("{0}/Cache/snapshot_{1}.jpg", Environment.CurrentDirectory, System.Guid.NewGuid().ToString("N")));
            snapshotTimer.Stop();
            snapshotTimer.Tick -= snapshotTimer_Tick;
            this.Visible = true;
        }

        
    }
}