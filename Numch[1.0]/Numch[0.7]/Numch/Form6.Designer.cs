namespace Numch
{
    partial class Help
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.text = new System.Windows.Forms.RichTextBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHideCursor = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1305, 164);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // text
            // 
            this.text.AccessibleRole = System.Windows.Forms.AccessibleRole.HelpBalloon;
            this.text.BackColor = System.Drawing.Color.Black;
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Cursor = System.Windows.Forms.Cursors.Default;
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.White;
            this.text.Location = new System.Drawing.Point(0, 164);
            this.text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(1305, 439);
            this.text.TabIndex = 1;
            this.text.Text = "";
            this.text.Enter += new System.EventHandler(this.EnterText);
            this.text.Leave += new System.EventHandler(this.LeaveText);
            // 
            // picTitle
            // 
            this.picTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picTitle.BackgroundImage = global::Numch.Properties.Resources.Numch;
            this.picTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.picTitle.Image = global::Numch.Properties.Resources.Numch;
            this.picTitle.Location = new System.Drawing.Point(399, 2);
            this.picTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(471, 154);
            this.picTitle.TabIndex = 8;
            this.picTitle.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(1189, 560);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHideCursor
            // 
            this.lblHideCursor.AutoSize = true;
            this.lblHideCursor.Location = new System.Drawing.Point(16, 11);
            this.lblHideCursor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHideCursor.Name = "lblHideCursor";
            this.lblHideCursor.Size = new System.Drawing.Size(0, 17);
            this.lblHideCursor.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackgroundImage = global::Numch.Properties.Resources.Back;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Location = new System.Drawing.Point(1189, 557);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 31);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1305, 603);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblHideCursor);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.text);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Help";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHideCursor;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}