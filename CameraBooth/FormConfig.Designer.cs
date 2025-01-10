namespace CameraBooth
{
    partial class FormConfig
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
            this.btBackground = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbEffect = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btEffect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEffect)).BeginInit();
            this.SuspendLayout();
            // 
            // btBackground
            // 
            this.btBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btBackground.Location = new System.Drawing.Point(277, 22);
            this.btBackground.Name = "btBackground";
            this.btBackground.Size = new System.Drawing.Size(52, 39);
            this.btBackground.TabIndex = 0;
            this.btBackground.Text = "...";
            this.btBackground.UseVisualStyleBackColor = true;
            this.btBackground.Click += new System.EventHandler(this.btBackground_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Background";
            // 
            // pbBackground
            // 
            this.pbBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBackground.Location = new System.Drawing.Point(465, 26);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(117, 179);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 2;
            this.pbBackground.TabStop = false;
            // 
            // pbEffect
            // 
            this.pbEffect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbEffect.Location = new System.Drawing.Point(623, 26);
            this.pbEffect.Name = "pbEffect";
            this.pbEffect.Size = new System.Drawing.Size(117, 179);
            this.pbEffect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEffect.TabIndex = 3;
            this.pbEffect.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Effect";
            // 
            // btEffect
            // 
            this.btEffect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEffect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btEffect.Location = new System.Drawing.Point(199, 104);
            this.btEffect.Name = "btEffect";
            this.btEffect.Size = new System.Drawing.Size(52, 39);
            this.btEffect.TabIndex = 4;
            this.btEffect.Text = "...";
            this.btEffect.UseVisualStyleBackColor = true;
            this.btEffect.Click += new System.EventHandler(this.btEffect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(491, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "BG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(656, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "EF";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 470);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btEffect);
            this.Controls.Add(this.pbEffect);
            this.Controls.Add(this.pbBackground);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfig";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEffect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbEffect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btEffect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}