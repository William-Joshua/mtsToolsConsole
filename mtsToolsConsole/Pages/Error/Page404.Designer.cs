namespace mtsToolsConsole.Pages.Error
{
    partial class Page404
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
            this._pnlBackCenterTop = new System.Windows.Forms.Panel();
            this._pnlBackGround = new System.Windows.Forms.Panel();
            this._pnlBackCenter = new System.Windows.Forms.Panel();
            this._pnlTextContainer = new System.Windows.Forms.Panel();
            this._btnGoHome = new System.Windows.Forms.Button();
            this._lblPageMessage = new System.Windows.Forms.Label();
            this._lblPageTitle = new System.Windows.Forms.Label();
            this._pnlImageContainer = new System.Windows.Forms.Panel();
            this._pic404Image = new DevExpress.XtraEditors.PictureEdit();
            this._pnlBackCenterBottom = new System.Windows.Forms.Panel();
            this._pnlBackRight = new System.Windows.Forms.Panel();
            this._pnlBackLeft = new System.Windows.Forms.Panel();
            this._pnlBackGround.SuspendLayout();
            this._pnlBackCenter.SuspendLayout();
            this._pnlTextContainer.SuspendLayout();
            this._pnlImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._pic404Image.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // _pnlBackCenterTop
            // 
            this._pnlBackCenterTop.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlBackCenterTop.Location = new System.Drawing.Point(236, 0);
            this._pnlBackCenterTop.Name = "_pnlBackCenterTop";
            this._pnlBackCenterTop.Size = new System.Drawing.Size(608, 150);
            this._pnlBackCenterTop.TabIndex = 2;
            // 
            // _pnlBackGround
            // 
            this._pnlBackGround.BackColor = System.Drawing.Color.Gainsboro;
            this._pnlBackGround.Controls.Add(this._pnlBackCenter);
            this._pnlBackGround.Controls.Add(this._pnlBackCenterBottom);
            this._pnlBackGround.Controls.Add(this._pnlBackCenterTop);
            this._pnlBackGround.Controls.Add(this._pnlBackRight);
            this._pnlBackGround.Controls.Add(this._pnlBackLeft);
            this._pnlBackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlBackGround.Location = new System.Drawing.Point(0, 0);
            this._pnlBackGround.Name = "_pnlBackGround";
            this._pnlBackGround.Size = new System.Drawing.Size(1080, 768);
            this._pnlBackGround.TabIndex = 1;
            // 
            // _pnlBackCenter
            // 
            this._pnlBackCenter.Controls.Add(this._pnlTextContainer);
            this._pnlBackCenter.Controls.Add(this._pnlImageContainer);
            this._pnlBackCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlBackCenter.Location = new System.Drawing.Point(236, 150);
            this._pnlBackCenter.Name = "_pnlBackCenter";
            this._pnlBackCenter.Size = new System.Drawing.Size(608, 468);
            this._pnlBackCenter.TabIndex = 4;
            // 
            // _pnlTextContainer
            // 
            this._pnlTextContainer.Controls.Add(this._btnGoHome);
            this._pnlTextContainer.Controls.Add(this._lblPageMessage);
            this._pnlTextContainer.Controls.Add(this._lblPageTitle);
            this._pnlTextContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlTextContainer.Location = new System.Drawing.Point(341, 0);
            this._pnlTextContainer.Name = "_pnlTextContainer";
            this._pnlTextContainer.Size = new System.Drawing.Size(267, 468);
            this._pnlTextContainer.TabIndex = 1;
            // 
            // _btnGoHome
            // 
            this._btnGoHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(186)))));
            this._btnGoHome.FlatAppearance.BorderSize = 0;
            this._btnGoHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnGoHome.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._btnGoHome.ForeColor = System.Drawing.Color.White;
            this._btnGoHome.Location = new System.Drawing.Point(8, 294);
            this._btnGoHome.Name = "_btnGoHome";
            this._btnGoHome.Size = new System.Drawing.Size(100, 36);
            this._btnGoHome.TabIndex = 3;
            this._btnGoHome.Text = "Go Home";
            this._btnGoHome.UseVisualStyleBackColor = false;
            this._btnGoHome.Click += new System.EventHandler(this._btnGoHome_Click);
            // 
            // _lblPageMessage
            // 
            this._lblPageMessage.AutoSize = true;
            this._lblPageMessage.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._lblPageMessage.Location = new System.Drawing.Point(3, 242);
            this._lblPageMessage.Name = "_lblPageMessage";
            this._lblPageMessage.Size = new System.Drawing.Size(235, 28);
            this._lblPageMessage.TabIndex = 1;
            this._lblPageMessage.Text = "Sorry, page not found.";
            // 
            // _lblPageTitle
            // 
            this._lblPageTitle.AutoSize = true;
            this._lblPageTitle.Font = new System.Drawing.Font("微软雅黑", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._lblPageTitle.Location = new System.Drawing.Point(6, 104);
            this._lblPageTitle.Name = "_lblPageTitle";
            this._lblPageTitle.Size = new System.Drawing.Size(232, 128);
            this._lblPageTitle.TabIndex = 0;
            this._lblPageTitle.Text = "404";
            // 
            // _pnlImageContainer
            // 
            this._pnlImageContainer.Controls.Add(this._pic404Image);
            this._pnlImageContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlImageContainer.Location = new System.Drawing.Point(0, 0);
            this._pnlImageContainer.Name = "_pnlImageContainer";
            this._pnlImageContainer.Size = new System.Drawing.Size(341, 468);
            this._pnlImageContainer.TabIndex = 0;
            // 
            // _pic404Image
            // 
            this._pic404Image.EditValue = global::mtsToolsConsole.Properties.Resources._404;
            this._pic404Image.Location = new System.Drawing.Point(6, 84);
            this._pic404Image.Name = "_pic404Image";
            this._pic404Image.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._pic404Image.Properties.Appearance.Options.UseBackColor = true;
            this._pic404Image.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._pic404Image.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this._pic404Image.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this._pic404Image.Size = new System.Drawing.Size(330, 266);
            this._pic404Image.TabIndex = 0;
            // 
            // _pnlBackCenterBottom
            // 
            this._pnlBackCenterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._pnlBackCenterBottom.Location = new System.Drawing.Point(236, 618);
            this._pnlBackCenterBottom.Name = "_pnlBackCenterBottom";
            this._pnlBackCenterBottom.Size = new System.Drawing.Size(608, 150);
            this._pnlBackCenterBottom.TabIndex = 3;
            // 
            // _pnlBackRight
            // 
            this._pnlBackRight.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnlBackRight.Location = new System.Drawing.Point(844, 0);
            this._pnlBackRight.Name = "_pnlBackRight";
            this._pnlBackRight.Size = new System.Drawing.Size(236, 768);
            this._pnlBackRight.TabIndex = 1;
            // 
            // _pnlBackLeft
            // 
            this._pnlBackLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this._pnlBackLeft.Location = new System.Drawing.Point(0, 0);
            this._pnlBackLeft.Name = "_pnlBackLeft";
            this._pnlBackLeft.Size = new System.Drawing.Size(236, 768);
            this._pnlBackLeft.TabIndex = 0;
            // 
            // Page404
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pnlBackGround);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Page404";
            this.Size = new System.Drawing.Size(1080, 768);
            this._pnlBackGround.ResumeLayout(false);
            this._pnlBackCenter.ResumeLayout(false);
            this._pnlTextContainer.ResumeLayout(false);
            this._pnlTextContainer.PerformLayout();
            this._pnlImageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._pic404Image.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlBackCenterTop;
        private System.Windows.Forms.Panel _pnlBackGround;
        private System.Windows.Forms.Panel _pnlBackCenter;
        private System.Windows.Forms.Panel _pnlTextContainer;
        private System.Windows.Forms.Button _btnGoHome;
        private System.Windows.Forms.Label _lblPageMessage;
        private System.Windows.Forms.Label _lblPageTitle;
        private System.Windows.Forms.Panel _pnlImageContainer;
        private DevExpress.XtraEditors.PictureEdit _pic404Image;
        private System.Windows.Forms.Panel _pnlBackCenterBottom;
        private System.Windows.Forms.Panel _pnlBackRight;
        private System.Windows.Forms.Panel _pnlBackLeft;
    }
}
