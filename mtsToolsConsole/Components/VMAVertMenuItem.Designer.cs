namespace mtsToolsConsole.Components
{
    partial class VMAVertMenuItem
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
            this._pnlMenuItem = new System.Windows.Forms.Panel();
            this._pnlMenuItemTitle = new System.Windows.Forms.Panel();
            this._lblMenuItemTitle = new System.Windows.Forms.Label();
            this._pnlSubMenuExpand = new System.Windows.Forms.Panel();
            this._picSubMenuExpand = new DevExpress.XtraEditors.PictureEdit();
            this._pnlMenuTypeIcon = new System.Windows.Forms.Panel();
            this._picMenuTypeIcon = new DevExpress.XtraEditors.PictureEdit();
            this._pnlMenuItem.SuspendLayout();
            this._pnlMenuItemTitle.SuspendLayout();
            this._pnlSubMenuExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picSubMenuExpand.Properties)).BeginInit();
            this._pnlMenuTypeIcon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picMenuTypeIcon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnlMenuItem
            // 
            this._pnlMenuItem.Controls.Add(this._pnlMenuItemTitle);
            this._pnlMenuItem.Controls.Add(this._pnlSubMenuExpand);
            this._pnlMenuItem.Controls.Add(this._pnlMenuTypeIcon);
            this._pnlMenuItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlMenuItem.Location = new System.Drawing.Point(0, 0);
            this._pnlMenuItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnlMenuItem.Name = "_pnlMenuItem";
            this._pnlMenuItem.Size = new System.Drawing.Size(260, 40);
            this._pnlMenuItem.TabIndex = 0;
            // 
            // _pnlMenuItemTitle
            // 
            this._pnlMenuItemTitle.BackColor = System.Drawing.Color.Transparent;
            this._pnlMenuItemTitle.Controls.Add(this._lblMenuItemTitle);
            this._pnlMenuItemTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlMenuItemTitle.Location = new System.Drawing.Point(56, 0);
            this._pnlMenuItemTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnlMenuItemTitle.Name = "_pnlMenuItemTitle";
            this._pnlMenuItemTitle.Size = new System.Drawing.Size(156, 40);
            this._pnlMenuItemTitle.TabIndex = 2;
            this._pnlMenuItemTitle.Click += new System.EventHandler(this._pnlMenuTypeIcon_Click);
            this._pnlMenuItemTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this._pnlMenuTypeIcon_MouseDown);
            // 
            // _lblMenuItemTitle
            // 
            this._lblMenuItemTitle.AutoSize = true;
            this._lblMenuItemTitle.ForeColor = System.Drawing.Color.Black;
            this._lblMenuItemTitle.Location = new System.Drawing.Point(12, 13);
            this._lblMenuItemTitle.Name = "_lblMenuItemTitle";
            this._lblMenuItemTitle.Size = new System.Drawing.Size(76, 17);
            this._lblMenuItemTitle.TabIndex = 0;
            this._lblMenuItemTitle.Text = "ITem Name";
            this._lblMenuItemTitle.Click += new System.EventHandler(this._pnlMenuTypeIcon_Click);
            this._lblMenuItemTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this._pnlMenuTypeIcon_MouseDown);
            // 
            // _pnlSubMenuExpand
            // 
            this._pnlSubMenuExpand.Controls.Add(this._picSubMenuExpand);
            this._pnlSubMenuExpand.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnlSubMenuExpand.Location = new System.Drawing.Point(212, 0);
            this._pnlSubMenuExpand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnlSubMenuExpand.Name = "_pnlSubMenuExpand";
            this._pnlSubMenuExpand.Size = new System.Drawing.Size(48, 40);
            this._pnlSubMenuExpand.TabIndex = 1;
            this._pnlSubMenuExpand.Click += new System.EventHandler(this._pnlMenuTypeIcon_Click);
            this._pnlSubMenuExpand.MouseDown += new System.Windows.Forms.MouseEventHandler(this._pnlMenuTypeIcon_MouseDown);
            // 
            // _picSubMenuExpand
            // 
            this._picSubMenuExpand.EditValue = global::mtsToolsConsole.Properties.Resources.baseline_expand_less_black_24dp;
            this._picSubMenuExpand.Location = new System.Drawing.Point(6, 3);
            this._picSubMenuExpand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._picSubMenuExpand.Name = "_picSubMenuExpand";
            this._picSubMenuExpand.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._picSubMenuExpand.Properties.Appearance.Options.UseBackColor = true;
            this._picSubMenuExpand.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._picSubMenuExpand.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this._picSubMenuExpand.Size = new System.Drawing.Size(32, 32);
            this._picSubMenuExpand.TabIndex = 0;
            this._picSubMenuExpand.Click += new System.EventHandler(this._pnlMenuTypeIcon_Click);
            this._picSubMenuExpand.MouseDown += new System.Windows.Forms.MouseEventHandler(this._pnlMenuTypeIcon_MouseDown);
            // 
            // _pnlMenuTypeIcon
            // 
            this._pnlMenuTypeIcon.Controls.Add(this._picMenuTypeIcon);
            this._pnlMenuTypeIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlMenuTypeIcon.Location = new System.Drawing.Point(0, 0);
            this._pnlMenuTypeIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnlMenuTypeIcon.Name = "_pnlMenuTypeIcon";
            this._pnlMenuTypeIcon.Size = new System.Drawing.Size(56, 40);
            this._pnlMenuTypeIcon.TabIndex = 0;
            this._pnlMenuTypeIcon.Click += new System.EventHandler(this._pnlMenuTypeIcon_Click);
            this._pnlMenuTypeIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this._pnlMenuTypeIcon_MouseDown);
            // 
            // _picMenuTypeIcon
            // 
            this._picMenuTypeIcon.EditValue = global::mtsToolsConsole.Properties.Resources.baseline_view_day_black_24dp;
            this._picMenuTypeIcon.Location = new System.Drawing.Point(18, 4);
            this._picMenuTypeIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._picMenuTypeIcon.Name = "_picMenuTypeIcon";
            this._picMenuTypeIcon.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._picMenuTypeIcon.Properties.Appearance.Options.UseBackColor = true;
            this._picMenuTypeIcon.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._picMenuTypeIcon.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this._picMenuTypeIcon.Size = new System.Drawing.Size(32, 32);
            this._picMenuTypeIcon.TabIndex = 0;
            this._picMenuTypeIcon.Click += new System.EventHandler(this._pnlMenuTypeIcon_Click);
            this._picMenuTypeIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this._pnlMenuTypeIcon_MouseDown);
            // 
            // VMAVertMenuItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pnlMenuItem);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VMAVertMenuItem";
            this.Size = new System.Drawing.Size(260, 40);
            this._pnlMenuItem.ResumeLayout(false);
            this._pnlMenuItemTitle.ResumeLayout(false);
            this._pnlMenuItemTitle.PerformLayout();
            this._pnlSubMenuExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picSubMenuExpand.Properties)).EndInit();
            this._pnlMenuTypeIcon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picMenuTypeIcon.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlMenuItem;
        private System.Windows.Forms.Panel _pnlMenuItemTitle;
        private System.Windows.Forms.Label _lblMenuItemTitle;
        private System.Windows.Forms.Panel _pnlSubMenuExpand;
        private DevExpress.XtraEditors.PictureEdit _picSubMenuExpand;
        private System.Windows.Forms.Panel _pnlMenuTypeIcon;
        private DevExpress.XtraEditors.PictureEdit _picMenuTypeIcon;
    }
}
