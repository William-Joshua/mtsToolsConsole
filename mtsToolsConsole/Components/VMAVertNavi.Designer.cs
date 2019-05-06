namespace mtsToolsConsole.Components
{
    partial class VMAVertNavi
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._pnlMainSpace = new System.Windows.Forms.Panel();
            this._xscrollVertNaviBar = new DevExpress.XtraEditors.XtraScrollableControl();
            this._flowVertNaviBar = new System.Windows.Forms.FlowLayoutPanel();
            this._pnlMenuTitle = new System.Windows.Forms.Panel();
            this._lblMenuTitle = new System.Windows.Forms.Label();
            this._pnlMainSpace.SuspendLayout();
            this._xscrollVertNaviBar.SuspendLayout();
            this._flowVertNaviBar.SuspendLayout();
            this._pnlMenuTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnlMainSpace
            // 
            this._pnlMainSpace.Controls.Add(this._xscrollVertNaviBar);
            this._pnlMainSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlMainSpace.Location = new System.Drawing.Point(0, 0);
            this._pnlMainSpace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnlMainSpace.Name = "_pnlMainSpace";
            this._pnlMainSpace.Size = new System.Drawing.Size(260, 678);
            this._pnlMainSpace.TabIndex = 0;
            // 
            // _xscrollVertNaviBar
            // 
            this._xscrollVertNaviBar.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._xscrollVertNaviBar.Appearance.Options.UseBackColor = true;
            this._xscrollVertNaviBar.Controls.Add(this._flowVertNaviBar);
            this._xscrollVertNaviBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._xscrollVertNaviBar.Location = new System.Drawing.Point(0, 0);
            this._xscrollVertNaviBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._xscrollVertNaviBar.Name = "_xscrollVertNaviBar";
            this._xscrollVertNaviBar.Size = new System.Drawing.Size(260, 678);
            this._xscrollVertNaviBar.TabIndex = 0;
            // 
            // _flowVertNaviBar
            // 
            this._flowVertNaviBar.BackColor = System.Drawing.Color.Transparent;
            this._flowVertNaviBar.Controls.Add(this._pnlMenuTitle);
            this._flowVertNaviBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flowVertNaviBar.Location = new System.Drawing.Point(0, 0);
            this._flowVertNaviBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._flowVertNaviBar.Name = "_flowVertNaviBar";
            this._flowVertNaviBar.Size = new System.Drawing.Size(260, 678);
            this._flowVertNaviBar.TabIndex = 0;
            // 
            // _pnlMenuTitle
            // 
            this._pnlMenuTitle.Controls.Add(this._lblMenuTitle);
            this._pnlMenuTitle.Location = new System.Drawing.Point(3, 4);
            this._pnlMenuTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnlMenuTitle.Name = "_pnlMenuTitle";
            this._pnlMenuTitle.Size = new System.Drawing.Size(151, 27);
            this._pnlMenuTitle.TabIndex = 0;
            // 
            // _lblMenuTitle
            // 
            this._lblMenuTitle.AutoSize = true;
            this._lblMenuTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._lblMenuTitle.Location = new System.Drawing.Point(12, 5);
            this._lblMenuTitle.Name = "_lblMenuTitle";
            this._lblMenuTitle.Size = new System.Drawing.Size(44, 17);
            this._lblMenuTitle.TabIndex = 0;
            this._lblMenuTitle.Text = "主控台";
            // 
            // VMAVertNavi
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pnlMainSpace);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VMAVertNavi";
            this.Size = new System.Drawing.Size(260, 678);
            this._pnlMainSpace.ResumeLayout(false);
            this._xscrollVertNaviBar.ResumeLayout(false);
            this._flowVertNaviBar.ResumeLayout(false);
            this._pnlMenuTitle.ResumeLayout(false);
            this._pnlMenuTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlMainSpace;
        private DevExpress.XtraEditors.XtraScrollableControl _xscrollVertNaviBar;
        private System.Windows.Forms.FlowLayoutPanel _flowVertNaviBar;
        private System.Windows.Forms.Panel _pnlMenuTitle;
        private System.Windows.Forms.Label _lblMenuTitle;
    }
}
