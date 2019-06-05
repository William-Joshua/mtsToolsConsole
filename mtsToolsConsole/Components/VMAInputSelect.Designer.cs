namespace mtsToolsConsole.Components
{
    partial class VMAInputSelect
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
            this.components = new System.ComponentModel.Container();
            this._pnlInputSpaceText = new System.Windows.Forms.Panel();
            this._lblInputDesc = new DevExpress.XtraEditors.LabelControl();
            this._pnlInputSpaceImage = new System.Windows.Forms.Panel();
            this._picInputSpaceImage = new DevExpress.XtraEditors.PictureEdit();
            this._pnlInputSpaceTitle = new System.Windows.Forms.Panel();
            this._lblInputTitle = new System.Windows.Forms.Label();
            this._lblInputSpaceSpara = new System.Windows.Forms.Label();
            this._pnlInputSpace = new System.Windows.Forms.Panel();
            this._cmenuSelectItems = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._pnlInputSpaceText.SuspendLayout();
            this._pnlInputSpaceImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picInputSpaceImage.Properties)).BeginInit();
            this._pnlInputSpaceTitle.SuspendLayout();
            this._pnlInputSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnlInputSpaceText
            // 
            this._pnlInputSpaceText.Controls.Add(this._lblInputDesc);
            this._pnlInputSpaceText.Controls.Add(this._pnlInputSpaceImage);
            this._pnlInputSpaceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlInputSpaceText.Location = new System.Drawing.Point(0, 18);
            this._pnlInputSpaceText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnlInputSpaceText.Name = "_pnlInputSpaceText";
            this._pnlInputSpaceText.Size = new System.Drawing.Size(240, 28);
            this._pnlInputSpaceText.TabIndex = 2;
            this._pnlInputSpaceText.Click += new System.EventHandler(this._picInputSpaceImage_Click);
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
            this._lblInputDesc.Click += new System.EventHandler(this._picInputSpaceImage_Click);
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
            this._picInputSpaceImage.EditValue = global::mtsToolsConsole.Properties.Resources.baseline_arrow_drop_down_black_18dp;
            this._picInputSpaceImage.Location = new System.Drawing.Point(0, 0);
            this._picInputSpaceImage.Name = "_picInputSpaceImage";
            this._picInputSpaceImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this._picInputSpaceImage.Properties.Appearance.Options.UseBackColor = true;
            this._picInputSpaceImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this._picInputSpaceImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this._picInputSpaceImage.Size = new System.Drawing.Size(28, 28);
            this._picInputSpaceImage.TabIndex = 0;
            this._picInputSpaceImage.Click += new System.EventHandler(this._picInputSpaceImage_Click);
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
            // _lblInputSpaceSpara
            // 
            this._lblInputSpaceSpara.BackColor = System.Drawing.Color.DarkGray;
            this._lblInputSpaceSpara.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._lblInputSpaceSpara.Location = new System.Drawing.Point(0, 46);
            this._lblInputSpaceSpara.Name = "_lblInputSpaceSpara";
            this._lblInputSpaceSpara.Size = new System.Drawing.Size(240, 2);
            this._lblInputSpaceSpara.TabIndex = 1;
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
            this._pnlInputSpace.TabIndex = 1;
            // 
            // _cmenuSelectItems
            // 
            this._cmenuSelectItems.Name = "_cmenuSelectItems";
            this._cmenuSelectItems.Size = new System.Drawing.Size(61, 4);
            // 
            // VMAInputSelect
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pnlInputSpace);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VMAInputSelect";
            this.Size = new System.Drawing.Size(240, 48);
            this._pnlInputSpaceText.ResumeLayout(false);
            this._pnlInputSpaceText.PerformLayout();
            this._pnlInputSpaceImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picInputSpaceImage.Properties)).EndInit();
            this._pnlInputSpaceTitle.ResumeLayout(false);
            this._pnlInputSpaceTitle.PerformLayout();
            this._pnlInputSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlInputSpaceText;
        private DevExpress.XtraEditors.LabelControl _lblInputDesc;
        private System.Windows.Forms.Panel _pnlInputSpaceImage;
        private DevExpress.XtraEditors.PictureEdit _picInputSpaceImage;
        private System.Windows.Forms.Panel _pnlInputSpaceTitle;
        private System.Windows.Forms.Label _lblInputTitle;
        private System.Windows.Forms.Label _lblInputSpaceSpara;
        private System.Windows.Forms.Panel _pnlInputSpace;
        private System.Windows.Forms.ContextMenuStrip _cmenuSelectItems;
    }
}
