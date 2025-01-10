namespace CameraBooth
{
    partial class FormSum
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbSum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSum)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::CameraBooth.Properties.Resources.qr_code;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(378, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 58);
            this.panel1.TabIndex = 1;
            // 
            // pbSum
            // 
            this.pbSum.Location = new System.Drawing.Point(12, 76);
            this.pbSum.Name = "pbSum";
            this.pbSum.Size = new System.Drawing.Size(427, 657);
            this.pbSum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSum.TabIndex = 0;
            this.pbSum.TabStop = false;
            // 
            // FormSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 745);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbSum);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSum";
            this.Load += new System.EventHandler(this.FormSum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSum;
        private System.Windows.Forms.Panel panel1;
    }
}