namespace Rotux
{
    partial class ExceptionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionWindow));
            this.errortext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // errortext
            // 
            this.errortext.Location = new System.Drawing.Point(12, 12);
            this.errortext.Multiline = true;
            this.errortext.Name = "errortext";
            this.errortext.ReadOnly = true;
            this.errortext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.errortext.Size = new System.Drawing.Size(374, 334);
            this.errortext.TabIndex = 0;
            // 
            // ExceptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 358);
            this.Controls.Add(this.errortext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExceptionWindow";
            this.Text = "Fatal Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox errortext;
    }
}