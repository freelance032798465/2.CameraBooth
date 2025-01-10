namespace CameraBooth
{
    partial class Form1
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
            this.btStart = new System.Windows.Forms.Button();
            this.lbStartCapture = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btContinue = new System.Windows.Forms.Button();
            this.lbScore = new System.Windows.Forms.Label();
            this.btBackgroundRight = new System.Windows.Forms.Panel();
            this.btBackgroundLeft = new System.Windows.Forms.Panel();
            this.btConfig = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btStart.ForeColor = System.Drawing.Color.White;
            this.btStart.Location = new System.Drawing.Point(340, 12);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(171, 75);
            this.btStart.TabIndex = 3;
            this.btStart.Text = "Start Capture";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // lbStartCapture
            // 
            this.lbStartCapture.AutoSize = true;
            this.lbStartCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbStartCapture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbStartCapture.Location = new System.Drawing.Point(655, 235);
            this.lbStartCapture.Name = "lbStartCapture";
            this.lbStartCapture.Size = new System.Drawing.Size(99, 108);
            this.lbStartCapture.TabIndex = 6;
            this.lbStartCapture.Text = "3";
            this.lbStartCapture.Visible = false;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Red;
            this.btDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btDelete.ForeColor = System.Drawing.Color.White;
            this.btDelete.Location = new System.Drawing.Point(596, 12);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(171, 75);
            this.btDelete.TabIndex = 7;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Visible = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(341, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Background";
            // 
            // btContinue
            // 
            this.btContinue.BackColor = System.Drawing.Color.Lime;
            this.btContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btContinue.ForeColor = System.Drawing.Color.White;
            this.btContinue.Location = new System.Drawing.Point(340, 12);
            this.btContinue.Name = "btContinue";
            this.btContinue.Size = new System.Drawing.Size(171, 75);
            this.btContinue.TabIndex = 11;
            this.btContinue.Text = "Continue";
            this.btContinue.UseVisualStyleBackColor = false;
            this.btContinue.Visible = false;
            this.btContinue.Click += new System.EventHandler(this.btContinue_Click);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbScore.Location = new System.Drawing.Point(12, 235);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(181, 108);
            this.lbScore.TabIndex = 12;
            this.lbScore.Text = "0/6";
            // 
            // btBackgroundRight
            // 
            this.btBackgroundRight.BackgroundImage = global::CameraBooth.Properties.Resources.right_arrow;
            this.btBackgroundRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBackgroundRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBackgroundRight.Location = new System.Drawing.Point(574, 487);
            this.btBackgroundRight.Name = "btBackgroundRight";
            this.btBackgroundRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btBackgroundRight.Size = new System.Drawing.Size(48, 44);
            this.btBackgroundRight.TabIndex = 15;
            this.btBackgroundRight.Click += new System.EventHandler(this.btBackgroundRight_Click);
            // 
            // btBackgroundLeft
            // 
            this.btBackgroundLeft.BackgroundImage = global::CameraBooth.Properties.Resources.left_arrow;
            this.btBackgroundLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btBackgroundLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBackgroundLeft.Location = new System.Drawing.Point(228, 487);
            this.btBackgroundLeft.Name = "btBackgroundLeft";
            this.btBackgroundLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btBackgroundLeft.Size = new System.Drawing.Size(48, 44);
            this.btBackgroundLeft.TabIndex = 14;
            this.btBackgroundLeft.Click += new System.EventHandler(this.btBackgroundLeft_Click);
            // 
            // btConfig
            // 
            this.btConfig.BackColor = System.Drawing.Color.White;
            this.btConfig.BackgroundImage = global::CameraBooth.Properties.Resources.config;
            this.btConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfig.ForeColor = System.Drawing.Color.White;
            this.btConfig.Location = new System.Drawing.Point(12, 12);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(51, 55);
            this.btConfig.TabIndex = 13;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(218, 131);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(416, 309);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 543);
            this.Controls.Add(this.btBackgroundRight);
            this.Controls.Add(this.btBackgroundLeft);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.btContinue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.lbStartCapture);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label lbStartCapture;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btContinue;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Panel btConfig;
        private System.Windows.Forms.Panel btBackgroundLeft;
        private System.Windows.Forms.Panel btBackgroundRight;
    }
}

