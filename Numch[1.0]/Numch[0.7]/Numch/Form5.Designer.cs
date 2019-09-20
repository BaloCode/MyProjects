namespace Numch
{
    partial class GameLetters
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
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtAnswr = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblDisp = new System.Windows.Forms.Label();
            this.showLett = new System.Windows.Forms.Timer(this.components);
            this.wait = new System.Windows.Forms.Timer(this.components);
            this.lblhi = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblScore.Location = new System.Drawing.Point(976, 11);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(152, 48);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score :";
            // 
            // txtAnswr
            // 
            this.txtAnswr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnswr.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAnswr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnswr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswr.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAnswr.Location = new System.Drawing.Point(425, 313);
            this.txtAnswr.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnswr.Name = "txtAnswr";
            this.txtAnswr.Size = new System.Drawing.Size(390, 36);
            this.txtAnswr.TabIndex = 12;
            this.txtAnswr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswr_KeyDown);
            // 
            // btnCheck
            // 
            this.btnCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCheck.Location = new System.Drawing.Point(565, 404);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(97, 28);
            this.btnCheck.TabIndex = 11;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(1109, 404);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblDisp
            // 
            this.lblDisp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDisp.AutoSize = true;
            this.lblDisp.Font = new System.Drawing.Font("Arial", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisp.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDisp.Location = new System.Drawing.Point(577, 148);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(0, 115);
            this.lblDisp.TabIndex = 14;
            // 
            // showLett
            // 
            this.showLett.Enabled = true;
            this.showLett.Interval = 1000;
            this.showLett.Tick += new System.EventHandler(this.time_Tick);
            // 
            // wait
            // 
            this.wait.Enabled = true;
            this.wait.Interval = 3000;
            this.wait.Tick += new System.EventHandler(this.wait_Tick);
            // 
            // lblhi
            // 
            this.lblhi.AutoSize = true;
            this.lblhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblhi.Location = new System.Drawing.Point(63, 11);
            this.lblhi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhi.Name = "lblhi";
            this.lblhi.Size = new System.Drawing.Size(206, 48);
            this.lblhi.TabIndex = 15;
            this.lblhi.Text = "Hi-Score :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::Numch.Properties.Resources.Back;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(1109, 401);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 31);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox2.BackgroundImage = global::Numch.Properties.Resources.Check;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(565, 404);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 28);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // GameLetters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1225, 447);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblhi);
            this.Controls.Add(this.lblDisp);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtAnswr);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameLetters";
            this.Text = "Form5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GameLetters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtAnswr;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblDisp;
        private System.Windows.Forms.Timer showLett;
        private System.Windows.Forms.Timer wait;
        private System.Windows.Forms.Label lblhi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}