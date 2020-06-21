namespace Calculator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnAbout = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.picCal = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.PanelTopDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.lblTitleDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.picCalDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btn7 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn8 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn5 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn4 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn3 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn6 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn9 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn0 = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnPlus = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnMinus = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnEqual = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnClear = new Guna.UI2.WinForms.Guna2TileButton();
            this.timerCheckingLength = new System.Windows.Forms.Timer(this.components);
            this.lblMainCointainer = new System.Windows.Forms.Panel();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDot = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnNegPos = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnClearlblMain = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn1overX = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDivide = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnBackspace = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnSqrt = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnSquare = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnMultiply = new Guna.UI2.WinForms.Guna2TileButton();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCal)).BeginInit();
            this.lblMainCointainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panelTop.Controls.Add(this.btnAbout);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.picCal);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(318, 43);
            this.panelTop.TabIndex = 1;
            // 
            // btnAbout
            // 
            this.btnAbout.ActiveImage = global::Calculator.Properties.Resources.about_light;
            this.btnAbout.AllowAnimations = true;
            this.btnAbout.AllowBuffering = false;
            this.btnAbout.AllowZooming = false;
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.ErrorImage")));
            this.btnAbout.FadeWhenInactive = false;
            this.btnAbout.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAbout.Image = global::Calculator.Properties.Resources.about_dark;
            this.btnAbout.ImageActive = global::Calculator.Properties.Resources.about_light;
            this.btnAbout.ImageLocation = null;
            this.btnAbout.ImageMargin = 4;
            this.btnAbout.ImageSize = new System.Drawing.Size(28, 27);
            this.btnAbout.ImageZoomSize = new System.Drawing.Size(32, 31);
            this.btnAbout.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.InitialImage")));
            this.btnAbout.Location = new System.Drawing.Point(222, 5);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Rotation = 0;
            this.btnAbout.ShowActiveImage = true;
            this.btnAbout.ShowCursorChanges = true;
            this.btnAbout.ShowImageBorders = true;
            this.btnAbout.ShowSizeMarkers = false;
            this.btnAbout.Size = new System.Drawing.Size(32, 31);
            this.btnAbout.TabIndex = 6;
            this.btnAbout.ToolTipText = "About the Author";
            this.btnAbout.WaitOnLoad = false;
            this.btnAbout.Zoom = 4;
            this.btnAbout.ZoomSpeed = 10;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.ActiveBorderThickness = 2;
            this.btnMinimize.ActiveCornerRadius = 5;
            this.btnMinimize.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnMinimize.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMinimize.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.ButtonText = " -";
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnMinimize.IdleBorderThickness = 1;
            this.btnMinimize.IdleCornerRadius = 7;
            this.btnMinimize.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnMinimize.IdleForecolor = System.Drawing.Color.Gray;
            this.btnMinimize.IdleLineColor = System.Drawing.Color.Gray;
            this.btnMinimize.Location = new System.Drawing.Point(259, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 34);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 2;
            this.btnClose.ActiveCornerRadius = 5;
            this.btnClose.ActiveFillColor = System.Drawing.Color.Red;
            this.btnClose.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnClose.ActiveLineColor = System.Drawing.Color.Red;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = " X";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 7;
            this.btnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnClose.IdleForecolor = System.Drawing.Color.Red;
            this.btnClose.IdleLineColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(287, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picCal
            // 
            this.picCal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCal.Image = ((System.Drawing.Image)(resources.GetObject("picCal.Image")));
            this.picCal.Location = new System.Drawing.Point(4, 6);
            this.picCal.Name = "picCal";
            this.picCal.Size = new System.Drawing.Size(33, 31);
            this.picCal.TabIndex = 2;
            this.picCal.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(35, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Calculator  #Thulana";
            // 
            // PanelTopDrag
            // 
            this.PanelTopDrag.TargetControl = this.panelTop;
            // 
            // lblTitleDrag
            // 
            this.lblTitleDrag.TargetControl = this.lblTitle;
            // 
            // picCalDrag
            // 
            this.picCalDrag.TargetControl = this.picCal;
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7.Animated = true;
            this.btn7.BorderColor = System.Drawing.Color.White;
            this.btn7.CheckedState.Parent = this.btn7;
            this.btn7.CustomImages.Parent = this.btn7;
            this.btn7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btn7.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.HoverState.Parent = this.btn7;
            this.btn7.Location = new System.Drawing.Point(8, 274);
            this.btn7.Name = "btn7";
            this.btn7.ShadowDecoration.Parent = this.btn7;
            this.btn7.Size = new System.Drawing.Size(67, 56);
            this.btn7.TabIndex = 3;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.OperandClick);
            // 
            // btn8
            // 
            this.btn8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8.Animated = true;
            this.btn8.BorderColor = System.Drawing.Color.White;
            this.btn8.CheckedState.Parent = this.btn8;
            this.btn8.CustomImages.Parent = this.btn8;
            this.btn8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btn8.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.HoverState.Parent = this.btn8;
            this.btn8.Location = new System.Drawing.Point(85, 274);
            this.btn8.Name = "btn8";
            this.btn8.ShadowDecoration.Parent = this.btn8;
            this.btn8.Size = new System.Drawing.Size(67, 56);
            this.btn8.TabIndex = 4;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.OperandClick);
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5.Animated = true;
            this.btn5.BorderColor = System.Drawing.Color.White;
            this.btn5.CheckedState.Parent = this.btn5;
            this.btn5.CustomImages.Parent = this.btn5;
            this.btn5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btn5.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.HoverState.Parent = this.btn5;
            this.btn5.Location = new System.Drawing.Point(85, 339);
            this.btn5.Name = "btn5";
            this.btn5.ShadowDecoration.Parent = this.btn5;
            this.btn5.Size = new System.Drawing.Size(67, 56);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.OperandClick);
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4.Animated = true;
            this.btn4.BorderColor = System.Drawing.Color.White;
            this.btn4.CheckedState.Parent = this.btn4;
            this.btn4.CustomImages.Parent = this.btn4;
            this.btn4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btn4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.HoverState.Parent = this.btn4;
            this.btn4.Location = new System.Drawing.Point(8, 339);
            this.btn4.Name = "btn4";
            this.btn4.ShadowDecoration.Parent = this.btn4;
            this.btn4.Size = new System.Drawing.Size(67, 56);
            this.btn4.TabIndex = 6;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.OperandClick);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Animated = true;
            this.btn1.BorderColor = System.Drawing.Color.White;
            this.btn1.CheckedState.Parent = this.btn1;
            this.btn1.CustomImages.Parent = this.btn1;
            this.btn1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btn1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.HoverState.Parent = this.btn1;
            this.btn1.Location = new System.Drawing.Point(8, 404);
            this.btn1.Name = "btn1";
            this.btn1.ShadowDecoration.Parent = this.btn1;
            this.btn1.Size = new System.Drawing.Size(67, 56);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.OperandClick);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.Animated = true;
            this.btn3.BorderColor = System.Drawing.Color.White;
            this.btn3.CheckedState.Parent = this.btn3;
            this.btn3.CustomImages.Parent = this.btn3;
            this.btn3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btn3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.HoverState.Parent = this.btn3;
            this.btn3.Location = new System.Drawing.Point(162, 404);
            this.btn3.Name = "btn3";
            this.btn3.ShadowDecoration.Parent = this.btn3;
            this.btn3.Size = new System.Drawing.Size(67, 56);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.OperandClick);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Animated = true;
            this.btn2.BorderColor = System.Drawing.Color.White;
            this.btn2.CheckedState.Parent = this.btn2;
            this.btn2.CustomImages.Parent = this.btn2;
            this.btn2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btn2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.HoverState.Parent = this.btn2;
            this.btn2.Location = new System.Drawing.Point(85, 404);
            this.btn2.Name = "btn2";
            this.btn2.ShadowDecoration.Parent = this.btn2;
            this.btn2.Size = new System.Drawing.Size(67, 56);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.OperandClick);
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn6.Animated = true;
            this.btn6.BorderColor = System.Drawing.Color.White;
            this.btn6.CheckedState.Parent = this.btn6;
            this.btn6.CustomImages.Parent = this.btn6;
            this.btn6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btn6.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.HoverState.Parent = this.btn6;
            this.btn6.Location = new System.Drawing.Point(162, 339);
            this.btn6.Name = "btn6";
            this.btn6.ShadowDecoration.Parent = this.btn6;
            this.btn6.Size = new System.Drawing.Size(67, 56);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.OperandClick);
            // 
            // btn9
            // 
            this.btn9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn9.Animated = true;
            this.btn9.BorderColor = System.Drawing.Color.White;
            this.btn9.CheckedState.Parent = this.btn9;
            this.btn9.CustomImages.Parent = this.btn9;
            this.btn9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btn9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.HoverState.Parent = this.btn9;
            this.btn9.Location = new System.Drawing.Point(162, 274);
            this.btn9.Name = "btn9";
            this.btn9.ShadowDecoration.Parent = this.btn9;
            this.btn9.Size = new System.Drawing.Size(67, 56);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.OperandClick);
            // 
            // btn0
            // 
            this.btn0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn0.Animated = true;
            this.btn0.BorderColor = System.Drawing.Color.White;
            this.btn0.CheckedState.Parent = this.btn0;
            this.btn0.CustomImages.Parent = this.btn0;
            this.btn0.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btn0.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.HoverState.Parent = this.btn0;
            this.btn0.Location = new System.Drawing.Point(85, 469);
            this.btn0.Name = "btn0";
            this.btn0.ShadowDecoration.Parent = this.btn0;
            this.btn0.Size = new System.Drawing.Size(67, 56);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.AccessibleName = "+";
            this.btnPlus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlus.Animated = true;
            this.btnPlus.BorderColor = System.Drawing.Color.White;
            this.btnPlus.CheckedState.Parent = this.btnPlus;
            this.btnPlus.CustomImages.Parent = this.btnPlus;
            this.btnPlus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPlus.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.LightGray;
            this.btnPlus.HoverState.Parent = this.btnPlus;
            this.btnPlus.Location = new System.Drawing.Point(241, 273);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.ShadowDecoration.Parent = this.btnPlus;
            this.btnPlus.Size = new System.Drawing.Size(67, 56);
            this.btnPlus.TabIndex = 18;
            this.btnPlus.Text = "+";
            this.btnPlus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // btnMinus
            // 
            this.btnMinus.AccessibleName = "-";
            this.btnMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMinus.Animated = true;
            this.btnMinus.BorderColor = System.Drawing.Color.White;
            this.btnMinus.CheckedState.Parent = this.btnMinus;
            this.btnMinus.CustomImages.Parent = this.btnMinus;
            this.btnMinus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMinus.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.LightGray;
            this.btnMinus.HoverState.Parent = this.btnMinus;
            this.btnMinus.Location = new System.Drawing.Point(240, 338);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.ShadowDecoration.Parent = this.btnMinus;
            this.btnMinus.Size = new System.Drawing.Size(67, 56);
            this.btnMinus.TabIndex = 16;
            this.btnMinus.Text = "-";
            this.btnMinus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // btnEqual
            // 
            this.btnEqual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEqual.Animated = true;
            this.btnEqual.BorderColor = System.Drawing.Color.White;
            this.btnEqual.CheckedState.Parent = this.btnEqual;
            this.btnEqual.CustomImages.Parent = this.btnEqual;
            this.btnEqual.FillColor = System.Drawing.Color.Silver;
            this.btnEqual.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnEqual.HoverState.Parent = this.btnEqual;
            this.btnEqual.Location = new System.Drawing.Point(240, 404);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.ShadowDecoration.Parent = this.btnEqual;
            this.btnEqual.Size = new System.Drawing.Size(67, 120);
            this.btnEqual.TabIndex = 19;
            this.btnEqual.Text = "=";
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.Animated = true;
            this.btnClear.BorderColor = System.Drawing.Color.White;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnClear.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(85, 143);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(67, 56);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // timerCheckingLength
            // 
            this.timerCheckingLength.Enabled = true;
            this.timerCheckingLength.Interval = 1;
            this.timerCheckingLength.Tick += new System.EventHandler(this.timerCheckingLength_Tick);
            // 
            // lblMainCointainer
            // 
            this.lblMainCointainer.Controls.Add(this.lblMain);
            this.lblMainCointainer.Location = new System.Drawing.Point(0, 77);
            this.lblMainCointainer.Name = "lblMainCointainer";
            this.lblMainCointainer.Size = new System.Drawing.Size(311, 54);
            this.lblMainCointainer.TabIndex = 23;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMain.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.White;
            this.lblMain.Location = new System.Drawing.Point(272, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(39, 43);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "0";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSec.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.Silver;
            this.lblSec.Location = new System.Drawing.Point(305, 0);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(0, 13);
            this.lblSec.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.lblSec);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel1.Location = new System.Drawing.Point(1, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 23);
            this.panel1.TabIndex = 2;
            // 
            // btnDot
            // 
            this.btnDot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDot.Animated = true;
            this.btnDot.BorderColor = System.Drawing.Color.White;
            this.btnDot.CheckedState.Parent = this.btnDot;
            this.btnDot.CustomImages.Parent = this.btnDot;
            this.btnDot.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnDot.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.White;
            this.btnDot.HoverState.Parent = this.btnDot;
            this.btnDot.Location = new System.Drawing.Point(8, 469);
            this.btnDot.Name = "btnDot";
            this.btnDot.ShadowDecoration.Parent = this.btnDot;
            this.btnDot.Size = new System.Drawing.Size(67, 56);
            this.btnDot.TabIndex = 24;
            this.btnDot.Text = ".";
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click_1);
            // 
            // btnNegPos
            // 
            this.btnNegPos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNegPos.Animated = true;
            this.btnNegPos.BorderColor = System.Drawing.Color.White;
            this.btnNegPos.CheckedState.Parent = this.btnNegPos;
            this.btnNegPos.CustomImages.Parent = this.btnNegPos;
            this.btnNegPos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnNegPos.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegPos.ForeColor = System.Drawing.Color.White;
            this.btnNegPos.HoverState.Parent = this.btnNegPos;
            this.btnNegPos.Location = new System.Drawing.Point(162, 469);
            this.btnNegPos.Name = "btnNegPos";
            this.btnNegPos.ShadowDecoration.Parent = this.btnNegPos;
            this.btnNegPos.Size = new System.Drawing.Size(67, 56);
            this.btnNegPos.TabIndex = 25;
            this.btnNegPos.Text = "+/-";
            this.btnNegPos.Click += new System.EventHandler(this.btnNegPos_Click);
            // 
            // btnClearlblMain
            // 
            this.btnClearlblMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearlblMain.Animated = true;
            this.btnClearlblMain.BorderColor = System.Drawing.Color.White;
            this.btnClearlblMain.CheckedState.Parent = this.btnClearlblMain;
            this.btnClearlblMain.CustomImages.Parent = this.btnClearlblMain;
            this.btnClearlblMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnClearlblMain.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearlblMain.ForeColor = System.Drawing.Color.White;
            this.btnClearlblMain.HoverState.Parent = this.btnClearlblMain;
            this.btnClearlblMain.Location = new System.Drawing.Point(8, 143);
            this.btnClearlblMain.Name = "btnClearlblMain";
            this.btnClearlblMain.ShadowDecoration.Parent = this.btnClearlblMain;
            this.btnClearlblMain.Size = new System.Drawing.Size(67, 56);
            this.btnClearlblMain.TabIndex = 26;
            this.btnClearlblMain.Text = "CE";
            this.btnClearlblMain.Click += new System.EventHandler(this.btnClearlblMain_Click);
            // 
            // btn1overX
            // 
            this.btn1overX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1overX.Animated = true;
            this.btn1overX.CheckedState.Parent = this.btn1overX;
            this.btn1overX.CustomImages.Parent = this.btn1overX;
            this.btn1overX.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn1overX.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1overX.ForeColor = System.Drawing.Color.White;
            this.btn1overX.HoverState.Parent = this.btn1overX;
            this.btn1overX.Image = ((System.Drawing.Image)(resources.GetObject("btn1overX.Image")));
            this.btn1overX.ImageSize = new System.Drawing.Size(75, 75);
            this.btn1overX.Location = new System.Drawing.Point(8, 209);
            this.btn1overX.Name = "btn1overX";
            this.btn1overX.ShadowDecoration.Parent = this.btn1overX;
            this.btn1overX.Size = new System.Drawing.Size(67, 56);
            this.btn1overX.TabIndex = 27;
            this.btn1overX.Click += new System.EventHandler(this.btn1overX_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.AccessibleName = "/";
            this.btnDivide.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDivide.Animated = true;
            this.btnDivide.BorderColor = System.Drawing.Color.White;
            this.btnDivide.CheckedState.Parent = this.btnDivide;
            this.btnDivide.CustomImages.Parent = this.btnDivide;
            this.btnDivide.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDivide.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.HoverState.Parent = this.btnDivide;
            this.btnDivide.Image = ((System.Drawing.Image)(resources.GetObject("btnDivide.Image")));
            this.btnDivide.Location = new System.Drawing.Point(241, 143);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.ShadowDecoration.Parent = this.btnDivide;
            this.btnDivide.Size = new System.Drawing.Size(67, 56);
            this.btnDivide.TabIndex = 20;
            this.btnDivide.Click += new System.EventHandler(this.OperatorClick);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackspace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBackspace.BorderColor = System.Drawing.Color.White;
            this.btnBackspace.CheckedState.Parent = this.btnBackspace;
            this.btnBackspace.CustomImages.Parent = this.btnBackspace;
            this.btnBackspace.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.btnBackspace.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.ForeColor = System.Drawing.Color.White;
            this.btnBackspace.HoverState.Parent = this.btnBackspace;
            this.btnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackspace.Image")));
            this.btnBackspace.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBackspace.Location = new System.Drawing.Point(162, 143);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.ShadowDecoration.Parent = this.btnBackspace;
            this.btnBackspace.Size = new System.Drawing.Size(67, 56);
            this.btnBackspace.TabIndex = 17;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSqrt.Animated = true;
            this.btnSqrt.BorderColor = System.Drawing.Color.White;
            this.btnSqrt.CheckedState.Parent = this.btnSqrt;
            this.btnSqrt.CustomImages.Parent = this.btnSqrt;
            this.btnSqrt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSqrt.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.ForeColor = System.Drawing.Color.White;
            this.btnSqrt.HoverState.Parent = this.btnSqrt;
            this.btnSqrt.Image = ((System.Drawing.Image)(resources.GetObject("btnSqrt.Image")));
            this.btnSqrt.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSqrt.Location = new System.Drawing.Point(162, 209);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.ShadowDecoration.Parent = this.btnSqrt;
            this.btnSqrt.Size = new System.Drawing.Size(67, 56);
            this.btnSqrt.TabIndex = 15;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSquare.Animated = true;
            this.btnSquare.CheckedState.Parent = this.btnSquare;
            this.btnSquare.CustomImages.Parent = this.btnSquare;
            this.btnSquare.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSquare.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.ForeColor = System.Drawing.Color.White;
            this.btnSquare.HoverState.Parent = this.btnSquare;
            this.btnSquare.Image = ((System.Drawing.Image)(resources.GetObject("btnSquare.Image")));
            this.btnSquare.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSquare.Location = new System.Drawing.Point(85, 209);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.ShadowDecoration.Parent = this.btnSquare;
            this.btnSquare.Size = new System.Drawing.Size(67, 56);
            this.btnSquare.TabIndex = 14;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.AccessibleName = "*";
            this.btnMultiply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMultiply.Animated = true;
            this.btnMultiply.BorderColor = System.Drawing.Color.White;
            this.btnMultiply.CheckedState.Parent = this.btnMultiply;
            this.btnMultiply.CustomImages.Parent = this.btnMultiply;
            this.btnMultiply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMultiply.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.HoverState.Parent = this.btnMultiply;
            this.btnMultiply.Image = ((System.Drawing.Image)(resources.GetObject("btnMultiply.Image")));
            this.btnMultiply.Location = new System.Drawing.Point(241, 208);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.ShadowDecoration.Parent = this.btnMultiply;
            this.btnMultiply.Size = new System.Drawing.Size(67, 56);
            this.btnMultiply.TabIndex = 13;
            this.btnMultiply.Click += new System.EventHandler(this.OperatorClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(318, 537);
            this.Controls.Add(this.btn1overX);
            this.Controls.Add(this.btnClearlblMain);
            this.Controls.Add(this.btnNegPos);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMainCointainer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnBackspace);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCal)).EndInit();
            this.lblMainCointainer.ResumeLayout(false);
            this.lblMainCointainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox picCal;
        private System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMinimize;
        private Guna.UI2.WinForms.Guna2DragControl PanelTopDrag;
        private Guna.UI2.WinForms.Guna2DragControl lblTitleDrag;
        private Guna.UI2.WinForms.Guna2DragControl picCalDrag;
        private Guna.UI2.WinForms.Guna2TileButton btn7;
        private Guna.UI2.WinForms.Guna2TileButton btn8;
        private Guna.UI2.WinForms.Guna2TileButton btn5;
        private Guna.UI2.WinForms.Guna2TileButton btn4;
        private Guna.UI2.WinForms.Guna2TileButton btn1;
        private Guna.UI2.WinForms.Guna2TileButton btn3;
        private Guna.UI2.WinForms.Guna2TileButton btn2;
        private Guna.UI2.WinForms.Guna2TileButton btn6;
        private Guna.UI2.WinForms.Guna2TileButton btn9;
        private Guna.UI2.WinForms.Guna2TileButton btn0;
        private Guna.UI2.WinForms.Guna2TileButton btnSqrt;
        private Guna.UI2.WinForms.Guna2TileButton btnSquare;
        private Guna.UI2.WinForms.Guna2TileButton btnMultiply;
        private Guna.UI2.WinForms.Guna2TileButton btnPlus;
        private Guna.UI2.WinForms.Guna2TileButton btnBackspace;
        private Guna.UI2.WinForms.Guna2TileButton btnMinus;
        private Guna.UI2.WinForms.Guna2TileButton btnDivide;
        private Guna.UI2.WinForms.Guna2TileButton btnEqual;
        private Guna.UI2.WinForms.Guna2TileButton btnClear;
        private System.Windows.Forms.Timer timerCheckingLength;
        private System.Windows.Forms.Panel lblMainCointainer;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TileButton btnDot;
        private Bunifu.UI.WinForms.BunifuImageButton btnAbout;
        private Guna.UI2.WinForms.Guna2TileButton btnNegPos;
        private Guna.UI2.WinForms.Guna2TileButton btnClearlblMain;
        private Guna.UI2.WinForms.Guna2TileButton btn1overX;
        private System.Windows.Forms.Label lblMain;
    }
}

