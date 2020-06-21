namespace Calculator
{
    partial class frmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblAbout = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendEmail = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bntEmail = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnInstagram = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnWhatsapp = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnGithub = new Bunifu.UI.WinForms.BunifuImageButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Ratings = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.ForeColor = System.Drawing.Color.White;
            this.lblAbout.Location = new System.Drawing.Point(156, 7);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(70, 24);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "About";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.lblAbout;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btnSendEmail);
            this.panel1.Controls.Add(this.bntEmail);
            this.panel1.Controls.Add(this.btnInstagram);
            this.panel1.Controls.Add(this.btnWhatsapp);
            this.panel1.Controls.Add(this.btnGithub);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.Ratings);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDes);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 176);
            this.panel1.TabIndex = 2;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.ActiveImage = global::Calculator.Properties.Resources.sendMail_Active_48px;
            this.btnSendEmail.AllowAnimations = true;
            this.btnSendEmail.AllowBuffering = false;
            this.btnSendEmail.AllowZooming = true;
            this.btnSendEmail.BackColor = System.Drawing.Color.Transparent;
            this.btnSendEmail.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSendEmail.ErrorImage")));
            this.btnSendEmail.FadeWhenInactive = false;
            this.btnSendEmail.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSendEmail.Image = global::Calculator.Properties.Resources.sendMail_Inactive_48px;
            this.btnSendEmail.ImageActive = global::Calculator.Properties.Resources.sendMail_Active_48px;
            this.btnSendEmail.ImageLocation = null;
            this.btnSendEmail.ImageMargin = 10;
            this.btnSendEmail.ImageSize = new System.Drawing.Size(25, 23);
            this.btnSendEmail.ImageZoomSize = new System.Drawing.Size(35, 33);
            this.btnSendEmail.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSendEmail.InitialImage")));
            this.btnSendEmail.Location = new System.Drawing.Point(249, 139);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Rotation = 0;
            this.btnSendEmail.ShowActiveImage = true;
            this.btnSendEmail.ShowCursorChanges = true;
            this.btnSendEmail.ShowImageBorders = true;
            this.btnSendEmail.ShowSizeMarkers = false;
            this.btnSendEmail.Size = new System.Drawing.Size(35, 33);
            this.btnSendEmail.TabIndex = 23;
            this.btnSendEmail.ToolTipText = "Send the Ratings";
            this.btnSendEmail.WaitOnLoad = false;
            this.btnSendEmail.Zoom = 10;
            this.btnSendEmail.ZoomSpeed = 10;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // bntEmail
            // 
            this.bntEmail.ActiveImage = global::Calculator.Properties.Resources.mail_Active_48px;
            this.bntEmail.AllowAnimations = true;
            this.bntEmail.AllowBuffering = false;
            this.bntEmail.AllowZooming = true;
            this.bntEmail.BackColor = System.Drawing.Color.Transparent;
            this.bntEmail.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bntEmail.ErrorImage")));
            this.bntEmail.FadeWhenInactive = false;
            this.bntEmail.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bntEmail.Image = global::Calculator.Properties.Resources.mail_Inacttive_48px;
            this.bntEmail.ImageActive = global::Calculator.Properties.Resources.mail_Active_48px;
            this.bntEmail.ImageLocation = null;
            this.bntEmail.ImageMargin = 10;
            this.bntEmail.ImageSize = new System.Drawing.Size(40, 39);
            this.bntEmail.ImageZoomSize = new System.Drawing.Size(50, 49);
            this.bntEmail.InitialImage = ((System.Drawing.Image)(resources.GetObject("bntEmail.InitialImage")));
            this.bntEmail.Location = new System.Drawing.Point(254, 78);
            this.bntEmail.Name = "bntEmail";
            this.bntEmail.Rotation = 0;
            this.bntEmail.ShowActiveImage = true;
            this.bntEmail.ShowCursorChanges = true;
            this.bntEmail.ShowImageBorders = true;
            this.bntEmail.ShowSizeMarkers = false;
            this.bntEmail.Size = new System.Drawing.Size(50, 49);
            this.bntEmail.TabIndex = 22;
            this.bntEmail.ToolTipText = "Email";
            this.bntEmail.WaitOnLoad = false;
            this.bntEmail.Zoom = 10;
            this.bntEmail.ZoomSpeed = 10;
            this.bntEmail.Click += new System.EventHandler(this.bntEmail_Click);
            // 
            // btnInstagram
            // 
            this.btnInstagram.ActiveImage = global::Calculator.Properties.Resources.instagram_Active_60px;
            this.btnInstagram.AllowAnimations = true;
            this.btnInstagram.AllowBuffering = false;
            this.btnInstagram.AllowZooming = true;
            this.btnInstagram.BackColor = System.Drawing.Color.Transparent;
            this.btnInstagram.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnInstagram.ErrorImage")));
            this.btnInstagram.FadeWhenInactive = false;
            this.btnInstagram.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnInstagram.Image = global::Calculator.Properties.Resources.instagram_Inactive_64px;
            this.btnInstagram.ImageActive = global::Calculator.Properties.Resources.instagram_Active_60px;
            this.btnInstagram.ImageLocation = null;
            this.btnInstagram.ImageMargin = 5;
            this.btnInstagram.ImageSize = new System.Drawing.Size(49, 47);
            this.btnInstagram.ImageZoomSize = new System.Drawing.Size(54, 52);
            this.btnInstagram.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnInstagram.InitialImage")));
            this.btnInstagram.Location = new System.Drawing.Point(191, 77);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Rotation = 0;
            this.btnInstagram.ShowActiveImage = true;
            this.btnInstagram.ShowCursorChanges = true;
            this.btnInstagram.ShowImageBorders = true;
            this.btnInstagram.ShowSizeMarkers = false;
            this.btnInstagram.Size = new System.Drawing.Size(54, 52);
            this.btnInstagram.TabIndex = 21;
            this.btnInstagram.ToolTipText = "Instagram";
            this.btnInstagram.WaitOnLoad = false;
            this.btnInstagram.Zoom = 5;
            this.btnInstagram.ZoomSpeed = 10;
            this.btnInstagram.Click += new System.EventHandler(this.bntInstagram_Click);
            // 
            // btnWhatsapp
            // 
            this.btnWhatsapp.ActiveImage = global::Calculator.Properties.Resources.whatsapp_Active_60px;
            this.btnWhatsapp.AllowAnimations = true;
            this.btnWhatsapp.AllowBuffering = false;
            this.btnWhatsapp.AllowZooming = true;
            this.btnWhatsapp.BackColor = System.Drawing.Color.Transparent;
            this.btnWhatsapp.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnWhatsapp.ErrorImage")));
            this.btnWhatsapp.FadeWhenInactive = false;
            this.btnWhatsapp.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnWhatsapp.Image = global::Calculator.Properties.Resources.whatsapp_Inactive_64px;
            this.btnWhatsapp.ImageActive = global::Calculator.Properties.Resources.whatsapp_Active_60px;
            this.btnWhatsapp.ImageLocation = null;
            this.btnWhatsapp.ImageMargin = 5;
            this.btnWhatsapp.ImageSize = new System.Drawing.Size(49, 47);
            this.btnWhatsapp.ImageZoomSize = new System.Drawing.Size(54, 52);
            this.btnWhatsapp.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnWhatsapp.InitialImage")));
            this.btnWhatsapp.Location = new System.Drawing.Point(128, 77);
            this.btnWhatsapp.Name = "btnWhatsapp";
            this.btnWhatsapp.Rotation = 0;
            this.btnWhatsapp.ShowActiveImage = true;
            this.btnWhatsapp.ShowCursorChanges = true;
            this.btnWhatsapp.ShowImageBorders = true;
            this.btnWhatsapp.ShowSizeMarkers = false;
            this.btnWhatsapp.Size = new System.Drawing.Size(54, 52);
            this.btnWhatsapp.TabIndex = 20;
            this.btnWhatsapp.ToolTipText = "Whatsapp";
            this.btnWhatsapp.WaitOnLoad = false;
            this.btnWhatsapp.Zoom = 5;
            this.btnWhatsapp.ZoomSpeed = 10;
            this.btnWhatsapp.Click += new System.EventHandler(this.btnWhatsapp_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.ActiveImage = global::Calculator.Properties.Resources.gitHub_Active_64px;
            this.btnGithub.AllowAnimations = true;
            this.btnGithub.AllowBuffering = false;
            this.btnGithub.AllowZooming = true;
            this.btnGithub.BackColor = System.Drawing.Color.Transparent;
            this.btnGithub.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnGithub.ErrorImage")));
            this.btnGithub.FadeWhenInactive = false;
            this.btnGithub.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnGithub.Image = global::Calculator.Properties.Resources.gitHub_Inactive_64px;
            this.btnGithub.ImageActive = global::Calculator.Properties.Resources.gitHub_Active_64px;
            this.btnGithub.ImageLocation = null;
            this.btnGithub.ImageMargin = 10;
            this.btnGithub.ImageSize = new System.Drawing.Size(49, 50);
            this.btnGithub.ImageZoomSize = new System.Drawing.Size(59, 60);
            this.btnGithub.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnGithub.InitialImage")));
            this.btnGithub.Location = new System.Drawing.Point(60, 71);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Rotation = 0;
            this.btnGithub.ShowActiveImage = true;
            this.btnGithub.ShowCursorChanges = true;
            this.btnGithub.ShowImageBorders = true;
            this.btnGithub.ShowSizeMarkers = false;
            this.btnGithub.Size = new System.Drawing.Size(59, 60);
            this.btnGithub.TabIndex = 19;
            this.btnGithub.ToolTipText = "github";
            this.btnGithub.WaitOnLoad = false;
            this.btnGithub.Zoom = 10;
            this.btnGithub.ZoomSpeed = 10;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(250, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 19);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BITS 2020";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // Ratings
            // 
            this.Ratings.BorderColor = System.Drawing.Color.Silver;
            this.Ratings.FillColor = System.Drawing.Color.Transparent;
            this.Ratings.FocusedColor = System.Drawing.Color.Silver;
            this.Ratings.Location = new System.Drawing.Point(102, 141);
            this.Ratings.Name = "Ratings";
            this.Ratings.RatingColor = System.Drawing.Color.Silver;
            this.Ratings.Size = new System.Drawing.Size(138, 28);
            this.Ratings.TabIndex = 15;
            this.Ratings.ValueChanged += new System.EventHandler(this.Ratings_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(50)))), ((int)(((byte)(42)))));
            this.label1.Location = new System.Drawing.Point(82, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Not for commercial usage.";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.ForeColor = System.Drawing.Color.Gray;
            this.lblDes.Location = new System.Drawing.Point(30, 16);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(225, 19);
            this.lblDes.TabIndex = 13;
            this.lblDes.Text = "This project is made for\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Calculator.Properties.Resources.warning_shield_30px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(44, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 36);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.White;
            this.btnClose.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnClose.ActiveLineColor = System.Drawing.Color.White;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "X";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 2;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnClose.IdleForecolor = System.Drawing.Color.White;
            this.btnClose.IdleLineColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(344, -1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnClose.Size = new System.Drawing.Size(25, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 6;
            this.bunifuElipse2.TargetControl = this.panel1;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(375, 222);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAbout";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label lblAbout;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2RatingStar Ratings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDes;
        private Bunifu.UI.WinForms.BunifuImageButton bntEmail;
        private Bunifu.UI.WinForms.BunifuImageButton btnInstagram;
        private Bunifu.UI.WinForms.BunifuImageButton btnWhatsapp;
        private Bunifu.UI.WinForms.BunifuImageButton btnGithub;
        private Bunifu.UI.WinForms.BunifuImageButton btnSendEmail;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}
