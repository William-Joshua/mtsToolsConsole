namespace mtsToolsConsole.Components
{
    partial class VMATextInput
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
            this._pnlInputSpace = new System.Windows.Forms.Panel();
            this._pnlInputSpaceText = new System.Windows.Forms.Panel();
            this._txtInputDesc = new DevExpress.XtraEditors.TextEdit();
            this._lblInputDesc = new DevExpress.XtraEditors.LabelControl();
            this._pnlInputSpaceImage = new System.Windows.Forms.Panel();
            this._picInputSpaceImage = new DevExpress.XtraEditors.PictureEdit();
            this._lblInputSpaceSpara = new System.Windows.Forms.Label();
            this._pnlInputSpaceTitle = new System.Windows.Forms.Panel();
            this._lblInputTitle = new System.Windows.Forms.Label();
            this._pnlInputSpace.SuspendLayout();
            this._pnlInputSpaceText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtInputDesc.Properties)).BeginInit();
            this._pnlInputSpaceImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picInputSpaceImage.Properties)).BeginInit();
            this._pnlInputSpaceTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnlInputSpace
            // 
            this._pnlInputSpace.Controls.Add(this._pnlInputSpaceText);
            this._pnlInputSpace.Controls.Add(this._lblInputSpaceSpara);
            this._pnlInputSpace.Controls.Add(this._pnlInputSpaceTitle);
            this._pnlInputSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlInputSpace.Location = new System.Drawing.Point(0, 0);
            this._pnlInputSpace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnlInputSpace.Name = "_pnlInputSpace";
            this._pnlInputSpace.Size = new System.Drawing.Size(240, 48);
            this._pnlInputSpace.TabIndex = 0;
            // 
            // _pnlInputSpaceText
            // 
            this._pnlInputSpaceText.Controls.Add(this._txtInputDesc);
            this._pnlInputSpaceText.Controls.Add(this._lblInputDesc);
            this._pnlInputSpaceText.Controls.Add(this._pnlInputSpaceImage);
            this._pnlInputSpaceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlInputSpaceText.Location = new System.Drawing.Point(0, 18);
            this._pnlInputSpaceText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnlInputSpaceText.Name = "_pnlInputSpaceText";
            this._pnlInputSpaceText.Size = new System.Drawing.Size(240, 28);
            this._pnlInputSpaceText.TabIndex = 2;
            this._pnlInputSpaceText.Click += new System.EventHandler(this._pnlInputSpaceText_Click);
            // 
            // _txtInputDesc
            // 
            this._txtInputDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtInputDesc.Location = new System.Drawing.Point(0, 0);
            this._txtInputDesc.Name = "_txtInputDesc";
            this._txtInputDesc.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtInputDesc.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this._txtInputDesc.Properties.Appearance.Options.UseFont = true;
            this._txtInputDesc.Properties.Appearance.Options.UseForeColor = true;
            this._txtInputDesc.Properties.Appearance.Options.UseTextOptions = true;
            this._txtInputDesc.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this._txtInputDesc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._txtInputDesc.Size = new System.Drawing.Size(212, 24);
            this._txtInputDesc.TabIndex = 4;
            this._txtInputDesc.Visible = false;
            this._txtInputDesc.EditValueChanged += new System.EventHandler(this._txtInputDesc_EditValueChanged);
            this._txtInputDesc.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this._txtInputDesc_EditValueChanging);
            this._txtInputDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this._txtInputDesc_KeyDown);
            this._txtInputDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._txtInputDesc_KeyPress);
            this._txtInputDesc.KeyUp += new System.Windows.Forms.KeyEventHandler(this._txtInputDesc_KeyUp);
            this._txtInputDesc.Leave += new System.EventHandler(this._txtInputDesc_Leave);
            // 
            // _lblInputDesc
            // 
            this._lblInputDesc.Appearance.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblInputDesc.Appearance.ForeColor = System.Drawing.Color.DarkGray;
            this._lblInputDesc.Appearance.Options.UseFont = true;
            this._lblInputDesc.Appearance.Options.UseForeColor = true;
            this._lblInputDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._lblInputDesc.Location = new System.Drawing.Point(0, 7);
            this._lblInputDesc.Name = "_lblInputDesc";
            this._lblInputDesc.Size = new System.Drawing.Size(32, 21);
            this._lblInputDesc.TabIndex = 3;
            this._lblInputDesc.Text = "Title";
            this._lblInputDesc.Click += new System.EventHandler(this._pnlInputSpaceText_Click);
            // 
            // _pnlInputSpaceImage
            // 
            this._pnlInputSpaceImage.Controls.Add(this._picInputSpaceImage);
            this._pnlInputSpaceImage.Dock = System.Windows.Forms.DockStyle.Right;
            this._pnlInputSpaceImage.Location = new System.Drawing.Point(212, 0);
            this._pnlInputSpaceImage.Name = "_pnlInputSpaceImage";
            this._pnlInputSpaceImage.Size = new System.Drawing.Size(28, 28);
            this._pnlInputSpaceImage.TabIndex = 2;
            this._pnlInputSpaceImage.Visible = false;
            // 
            // _picInputSpaceImage
            // 
            this._picInputSpaceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._picInputSpaceImage.Location = new System.Drawing.Point(0, 0);
            this._picInputSpaceImage.Name = "_picInputSpaceImage";
            this._picInputSpaceImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._picInputSpaceImage.Properties.Appearance.Options.UseBackColor = true;
            this._picInputSpaceImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._picInputSpaceImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this._picInputSpaceImage.Size = new System.Drawing.Size(28, 28);
            this._picInputSpaceImage.TabIndex = 0;
            this._picInputSpaceImage.MouseEnter += new System.EventHandler(this._picInputSpaceImage_MouseEnter);
            this._picInputSpaceImage.MouseLeave += new System.EventHandler(this._picInputSpaceImage_MouseLeave);
            // 
            // _lblInputSpaceSpara
            // 
            this._lblInputSpaceSpara.BackColor = System.Drawing.Color.DarkGray;
            this._lblInputSpaceSpara.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._lblInputSpaceSpara.Location = new System.Drawing.Point(0, 46);
            this._lblInputSpaceSpara.Name = "_lblInputSpaceSpara";
            this._lblInputSpaceSpara.Size = new System.Drawing.Size(240, 2);
            this._lblInputSpaceSpara.TabIndex = 1;
            // 
            // _pnlInputSpaceTitle
            // 
            this._pnlInputSpaceTitle.Controls.Add(this._lblInputTitle);
            this._pnlInputSpaceTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlInputSpaceTitle.Location = new System.Drawing.Point(0, 0);
            this._pnlInputSpaceTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnlInputSpaceTitle.Name = "_pnlInputSpaceTitle";
            this._pnlInputSpaceTitle.Size = new System.Drawing.Size(240, 18);
            this._pnlInputSpaceTitle.TabIndex = 0;
            this._pnlInputSpaceTitle.Visible = false;
            // 
            // _lblInputTitle
            // 
            this._lblInputTitle.AutoSize = true;
            this._lblInputTitle.BackColor = System.Drawing.Color.Transparent;
            this._lblInputTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this._lblInputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(68)))), ((int)(((byte)(186)))));
            this._lblInputTitle.Location = new System.Drawing.Point(0, 0);
            this._lblInputTitle.Name = "_lblInputTitle";
            this._lblInputTitle.Size = new System.Drawing.Size(32, 17);
            this._lblInputTitle.TabIndex = 0;
            this._lblInputTitle.Text = "Title";
            // 
            // VMATextInput
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pnlInputSpace);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VMATextInput";
            this.Size = new System.Drawing.Size(240, 48);
            this._pnlInputSpace.ResumeLayout(false);
            this._pnlInputSpaceText.ResumeLayout(false);
            this._pnlInputSpaceText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._txtInputDesc.Properties)).EndInit();
            this._pnlInputSpaceImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picInputSpaceImage.Properties)).EndInit();
            this._pnlInputSpaceTitle.ResumeLayout(false);
            this._pnlInputSpaceTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlInputSpace;
        private System.Windows.Forms.Panel _pnlInputSpaceText;
        private System.Windows.Forms.Label _lblInputSpaceSpara;
        private System.Windows.Forms.Panel _pnlInputSpaceTitle;
        private System.Windows.Forms.Label _lblInputTitle;
        private System.Windows.Forms.Panel _pnlInputSpaceImage;
        private DevExpress.XtraEditors.PictureEdit _picInputSpaceImage;
        private DevExpress.XtraEditors.TextEdit _txtInputDesc;
        private DevExpress.XtraEditors.LabelControl _lblInputDesc;
    }
}
