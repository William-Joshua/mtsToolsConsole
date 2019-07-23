namespace mtsToolsConsole.Components
{
    partial class VMAScrollListPanel
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
            this._xtraMainScollSpace = new DevExpress.XtraEditors.XtraScrollableControl();
            this._flowItemContainer = new System.Windows.Forms.FlowLayoutPanel();
            this._pnlMainSpace.SuspendLayout();
            this._xtraMainScollSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnlMainSpace
            // 
            this._pnlMainSpace.Controls.Add(this._xtraMainScollSpace);
            this._pnlMainSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlMainSpace.Location = new System.Drawing.Point(0, 0);
            this._pnlMainSpace.Name = "_pnlMainSpace";
            this._pnlMainSpace.Size = new System.Drawing.Size(240, 360);
            this._pnlMainSpace.TabIndex = 0;
            // 
            // _xtraMainScollSpace
            // 
            this._xtraMainScollSpace.Appearance.BackColor = System.Drawing.Color.White;
            this._xtraMainScollSpace.Appearance.Options.UseBackColor = true;
            this._xtraMainScollSpace.Controls.Add(this._flowItemContainer);
            this._xtraMainScollSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this._xtraMainScollSpace.Location = new System.Drawing.Point(0, 0);
            this._xtraMainScollSpace.Name = "_xtraMainScollSpace";
            this._xtraMainScollSpace.Size = new System.Drawing.Size(240, 360);
            this._xtraMainScollSpace.TabIndex = 0;
            // 
            // _flowItemContainer
            // 
            this._flowItemContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flowItemContainer.Location = new System.Drawing.Point(0, 0);
            this._flowItemContainer.Name = "_flowItemContainer";
            this._flowItemContainer.Size = new System.Drawing.Size(240, 360);
            this._flowItemContainer.TabIndex = 0;
            // 
            // VMAScrollListPanel
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pnlMainSpace);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "VMAScrollListPanel";
            this.Size = new System.Drawing.Size(240, 360);
            this._pnlMainSpace.ResumeLayout(false);
            this._xtraMainScollSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlMainSpace;
        private DevExpress.XtraEditors.XtraScrollableControl _xtraMainScollSpace;
        private System.Windows.Forms.FlowLayoutPanel _flowItemContainer;
    }
}
