namespace Numch
{
    partial class GameMode
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
            this.GameModelb = new System.Windows.Forms.Label();
            this.gmNum1 = new System.Windows.Forms.Button();
            this.gmLetters = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameModelb
            // 
            this.GameModelb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GameModelb.AutoSize = true;
            this.GameModelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameModelb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameModelb.Location = new System.Drawing.Point(423, 9);
            this.GameModelb.Name = "GameModelb";
            this.GameModelb.Size = new System.Drawing.Size(398, 69);
            this.GameModelb.TabIndex = 0;
            this.GameModelb.Text = "Game Modes";
            // 
            // gmNum1
            // 
            this.gmNum1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gmNum1.Location = new System.Drawing.Point(245, 160);
            this.gmNum1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gmNum1.Name = "gmNum1";
            this.gmNum1.Size = new System.Drawing.Size(173, 31);
            this.gmNum1.TabIndex = 1;
            this.gmNum1.Text = "Play with Numbers";
            this.gmNum1.UseVisualStyleBackColor = true;
            this.gmNum1.Click += new System.EventHandler(this.gmNum1_Click);
            // 
            // gmLetters
            // 
            this.gmLetters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gmLetters.Location = new System.Drawing.Point(807, 160);
            this.gmLetters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gmLetters.Name = "gmLetters";
            this.gmLetters.Size = new System.Drawing.Size(173, 31);
            this.gmLetters.TabIndex = 2;
            this.gmLetters.Text = "Play with Letters";
            this.gmLetters.UseVisualStyleBackColor = true;
            this.gmLetters.Click += new System.EventHandler(this.gmLetters_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(1068, 406);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 26);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::Numch.Properties.Resources.Back;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(1068, 406);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 26);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = global::Numch.Properties.Resources.Letters;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(807, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 31);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::Numch.Properties.Resources.Numbers;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(245, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 31);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1261, 447);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gmLetters);
            this.Controls.Add(this.gmNum1);
            this.Controls.Add(this.GameModelb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameMode";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameModelb;
        private System.Windows.Forms.Button gmNum1;
        private System.Windows.Forms.Button gmLetters;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}