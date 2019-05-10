namespace mtsToolsConsole.Components
{
    partial class VMACardGroupBox
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
            this._pnlMainCardSpace = new System.Windows.Forms.Panel();
            this._lblTilteSeparSpace = new System.Windows.Forms.Label();
            this._pnlCardTitle = new System.Windows.Forms.Panel();
            this._lblCardTitle = new System.Windows.Forms.Label();
            this._pnlMainCardSpace.SuspendLayout();
            this._pnlCardTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnlMainCardSpace
            // 
            this._pnlMainCardSpace.BackColor = System.Drawing.Color.Transparent;
            this._pnlMainCardSpace.Controls.Add(this._lblTilteSeparSpace);
            this._pnlMainCardSpace.Controls.Add(this._pnlCardTitle);
            this._pnlMainCardSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlMainCardSpace.Location = new System.Drawing.Point(0, 0);
            this._pnlMainCardSpace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnlMainCardSpace.Name = "_pnlMainCardSpace";
            this._pnlMainCardSpace.Size = new System.Drawing.Size(425, 255);
            this._pnlMainCardSpace.TabIndex = 0;
            // 
            // _lblTilteSeparSpace
            // 
            this._lblTilteSeparSpace.BackColor = System.Drawing.Color.Silver;
            this._lblTilteSeparSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this._lblTilteSeparSpace.Location = new System.Drawing.Point(0, 48);
            this._lblTilteSeparSpace.Name = "_lblTilteSeparSpace";
            this._lblTilteSeparSpace.Size = new System.Drawing.Size(425, 1);
            this._lblTilteSeparSpace.TabIndex = 1;
            // 
            // _pnlCardTitle
            // 
            this._pnlCardTitle.BackColor = System.Drawing.Color.Transparent;
            this._pnlCardTitle.Controls.Add(this._lblCardTitle);
            this._pnlCardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlCardTitle.Location = new System.Drawing.Point(0, 0);
            this._pnlCardTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._pnlCardTitle.Name = "_pnlCardTitle";
            this._pnlCardTitle.Size = new System.Drawing.Size(425, 48);
            this._pnlCardTitle.TabIndex = 0;
            // 
            // _lblCardTitle
            // 
            this._lblCardTitle.AutoSize = true;
            this._lblCardTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._lblCardTitle.ForeColor = System.Drawing.Color.DimGray;
            this._lblCardTitle.Location = new System.Drawing.Point(14, 15);
            this._lblCardTitle.Name = "_lblCardTitle";
            this._lblCardTitle.Size = new System.Drawing.Size(97, 21);
            this._lblCardTitle.TabIndex = 0;
            this._lblCardTitle.Text = "Card Name";
            // 
            // VMACardGroupBox
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pnlMainCardSpace);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VMACardGroupBox";
            this.Size = new System.Drawing.Size(425, 255);
            this._pnlMainCardSpace.ResumeLayout(false);
            this._pnlCardTitle.ResumeLayout(false);
            this._pnlCardTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlMainCardSpace;
        private System.Windows.Forms.Panel _pnlCardTitle;
        private System.Windows.Forms.Label _lblTilteSeparSpace;
        private System.Windows.Forms.Label _lblCardTitle;
    }
}
