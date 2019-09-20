namespace Numch
{
    partial class MainMenu
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMuteM = new System.Windows.Forms.Button();
            this.btnMuteS = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CausesValidation = false;
            this.btnClose.Location = new System.Drawing.Point(1067, 404);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMuteM
            // 
            this.btnMuteM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMuteM.Location = new System.Drawing.Point(396, 404);
            this.btnMuteM.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuteM.Name = "btnMuteM";
            this.btnMuteM.Size = new System.Drawing.Size(124, 28);
            this.btnMuteM.TabIndex = 4;
            this.btnMuteM.Text = "Mute Music";
            this.btnMuteM.UseVisualStyleBackColor = true;
            this.btnMuteM.Click += new System.EventHandler(this.btnMuteM_Click);
            // 
            // btnMuteS
            // 
            this.btnMuteS.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMuteS.Location = new System.Drawing.Point(708, 404);
            this.btnMuteS.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuteS.Name = "btnMuteS";
            this.btnMuteS.Size = new System.Drawing.Size(133, 28);
            this.btnMuteS.TabIndex = 5;
            this.btnMuteS.Text = "Mute Sounds";
            this.btnMuteS.UseVisualStyleBackColor = true;
            this.btnMuteS.Click += new System.EventHandler(this.btnMuteS_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Location = new System.Drawing.Point(72, 404);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(123, 28);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // picPlay
            // 
            this.picPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPlay.BackgroundImage = global::Numch.Properties.Resources.StartGame;
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlay.Enabled = false;
            this.picPlay.Image = global::Numch.Properties.Resources.Play;
            this.picPlay.Location = new System.Drawing.Point(567, 287);
            this.picPlay.Margin = new System.Windows.Forms.Padding(4);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(117, 31);
            this.picPlay.TabIndex = 7;
            this.picPlay.TabStop = false;
            // 
            // picTitle
            // 
            this.picTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picTitle.BackgroundImage = global::Numch.Properties.Resources.Numch;
            this.picTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.picTitle.Image = global::Numch.Properties.Resources.Numch;
            this.picTitle.Location = new System.Drawing.Point(248, 15);
            this.picTitle.Margin = new System.Windows.Forms.Padding(4);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(779, 252);
            this.picTitle.TabIndex = 6;
            this.picTitle.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.Image = global::Numch.Properties.Resources.Play;
            this.btnPlay.Location = new System.Drawing.Point(567, 287);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(117, 28);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = global::Numch.Properties.Resources.Help;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(72, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 32);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackgroundImage = global::Numch.Properties.Resources.MuteMusic;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(396, 400);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 32);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox3.BackgroundImage = global::Numch.Properties.Resources.MuteSounds;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(708, 400);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(133, 32);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackgroundImage = global::Numch.Properties.Resources.Exit;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Enabled = false;
            this.pictureBox4.Location = new System.Drawing.Point(1067, 400);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(101, 33);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1280, 494);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.btnMuteS);
            this.Controls.Add(this.btnMuteM);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Numch";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnMuteM;
        private System.Windows.Forms.Button btnMuteS;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

