namespace CameraBooth
{
    partial class FormPreview
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btBackgroundRight = new System.Windows.Forms.Panel();
            this.btBackgroundLeft = new System.Windows.Forms.Panel();
            this.lbBackground = new System.Windows.Forms.Label();
            this.btContinue = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(102, 112);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(750, 750);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // btBackgroundRight
            // 
            this.btBackgroundRight.BackgroundImage = global::CameraBooth.Properties.Resources.right_arrow;
            this.btBackgroundRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBackgroundRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBackgroundRight.Location = new System.Drawing.Point(745, 878);
            this.btBackgroundRight.Name = "btBackgroundRight";
            this.btBackgroundRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btBackgroundRight.Size = new System.Drawing.Size(83, 63);
            this.btBackgroundRight.TabIndex = 18;
            this.btBackgroundRight.Click += new System.EventHandler(this.btBackgroundRight_Click);
            // 
            // btBackgroundLeft
            // 
            this.btBackgroundLeft.BackgroundImage = global::CameraBooth.Properties.Resources.left_arrow;
            this.btBackgroundLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBackgroundLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBackgroundLeft.Location = new System.Drawing.Point(125, 878);
            this.btBackgroundLeft.Name = "btBackgroundLeft";
            this.btBackgroundLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btBackgroundLeft.Size = new System.Drawing.Size(83, 63);
            this.btBackgroundLeft.TabIndex = 17;
            this.btBackgroundLeft.Click += new System.EventHandler(this.btBackgroundLeft_Click);
            // 
            // lbBackground
            // 
            this.lbBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbBackground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbBackground.Location = new System.Drawing.Point(214, 878);
            this.lbBackground.Name = "lbBackground";
            this.lbBackground.Size = new System.Drawing.Size(525, 63);
            this.lbBackground.TabIndex = 16;
            this.lbBackground.Text = "Background";
            this.lbBackground.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btContinue
            // 
            this.btContinue.BackColor = System.Drawing.Color.Lime;
            this.btContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btContinue.ForeColor = System.Drawing.Color.White;
            this.btContinue.Location = new System.Drawing.Point(780, 12);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(171, 75);
            this.btContinue.TabIndex = 20;
            this.btContinue.Text = "Continue";
            this.btContinue.UseVisualStyleBackColor = false;
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Red;
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(12, 12);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(171, 75);
            this.btDelete.TabIndex = 19;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(189, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 53);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select Background";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 955);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btContinue);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btBackgroundRight);
            this.Controls.Add(this.btBackgroundLeft);
            this.Controls.Add(this.lbBackground);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPreview";
            this.Load += new System.EventHandler(this.FormPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Panel btBackgroundRight;
        private System.Windows.Forms.Panel btBackgroundLeft;
        private System.Windows.Forms.Label lbBackground;
        private System.Windows.Forms.Button btContinue;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label1;
    }
}