namespace mtsToolsConsole.Components
{
    partial class VMAGroupCard
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
            this._pnlMainCard = new System.Windows.Forms.Panel();
            this._pnlCardTitle = new System.Windows.Forms.Panel();
            this._pnlCardContainer = new System.Windows.Forms.Panel();
            this._lblCardTitle = new System.Windows.Forms.Label();
            this._pnlMainCard.SuspendLayout();
            this._pnlCardTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pnlMainCard
            // 
            this._pnlMainCard.BackColor = System.Drawing.Color.Transparent;
            this._pnlMainCard.Controls.Add(this._pnlCardContainer);
            this._pnlMainCard.Controls.Add(this._pnlCardTitle);
            this._pnlMainCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlMainCard.Location = new System.Drawing.Point(0, 0);
            this._pnlMainCard.Name = "_pnlMainCard";
            this._pnlMainCard.Size = new System.Drawing.Size(425, 186);
            this._pnlMainCard.TabIndex = 0;
            // 
            // _pnlCardTitle
            // 
            this._pnlCardTitle.Controls.Add(this._lblCardTitle);
            this._pnlCardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._pnlCardTitle.Location = new System.Drawing.Point(0, 0);
            this._pnlCardTitle.Name = "_pnlCardTitle";
            this._pnlCardTitle.Size = new System.Drawing.Size(425, 48);
            this._pnlCardTitle.TabIndex = 0;
            // 
            // _pnlCardContainer
            // 
            this._pnlCardContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlCardContainer.Location = new System.Drawing.Point(0, 48);
            this._pnlCardContainer.Name = "_pnlCardContainer";
            this._pnlCardContainer.Size = new System.Drawing.Size(425, 138);
            this._pnlCardContainer.TabIndex = 1;
            // 
            // _lblCardTitle
            // 
            this._lblCardTitle.AutoSize = true;
            this._lblCardTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this._lblCardTitle.ForeColor = System.Drawing.Color.DimGray;
            this._lblCardTitle.Location = new System.Drawing.Point(17, 14);
            this._lblCardTitle.Name = "_lblCardTitle";
            this._lblCardTitle.Size = new System.Drawing.Size(97, 21);
            this._lblCardTitle.TabIndex = 1;
            this._lblCardTitle.Text = "Card Name";
            // 
            // VMAGroupCard
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._pnlMainCard);
            this.Name = "VMAGroupCard";
            this.Size = new System.Drawing.Size(425, 186);
            this._pnlMainCard.ResumeLayout(false);
            this._pnlCardTitle.ResumeLayout(false);
            this._pnlCardTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlMainCard;
        private System.Windows.Forms.Panel _pnlCardTitle;
        private System.Windows.Forms.Panel _pnlCardContainer;
        private System.Windows.Forms.Label _lblCardTitle;
    }
}
