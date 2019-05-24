namespace mtsToolsConsole.Pages.Error
{
    partial class ErrorPageContainer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._pnlContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _pnlContainer
            // 
            this._pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pnlContainer.Location = new System.Drawing.Point(0, 0);
            this._pnlContainer.Name = "_pnlContainer";
            this._pnlContainer.Size = new System.Drawing.Size(1078, 736);
            this._pnlContainer.TabIndex = 0;
            this._pnlContainer.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this._pnlContainer_ControlRemoved);
            // 
            // ErrorPageContainer
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 736);
            this.Controls.Add(this._pnlContainer);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookAndFeel.SkinName = "Office 2019 Colorful";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 768);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 768);
            this.Name = "ErrorPageContainer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel _pnlContainer;
    }
}