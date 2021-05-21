namespace banifiu
{
    partial class working
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
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(working));
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            this.btnAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.DGWdata = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddWdaypanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnDlt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnUpd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddWdaypanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEm = new System.Windows.Forms.ComboBox();
            this.cmbSm = new System.Windows.Forms.ComboBox();
            this.cmbEh = new System.Windows.Forms.ComboBox();
            this.cmbSh = new System.Windows.Forms.ComboBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblDay = new System.Windows.Forms.Label();
            this.chbxSun = new System.Windows.Forms.CheckBox();
            this.chbxThu = new System.Windows.Forms.CheckBox();
            this.chbxSat = new System.Windows.Forms.CheckBox();
            this.chbxWed = new System.Windows.Forms.CheckBox();
            this.chbxFri = new System.Windows.Forms.CheckBox();
            this.chbxTus = new System.Windows.Forms.CheckBox();
            this.chbxMon = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLid = new System.Windows.Forms.TextBox();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGWdata)).BeginInit();
            this.panel1.SuspendLayout();
            this.AddWdaypanel2.SuspendLayout();
            this.AddWdaypanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnimator
            // 
            this.btnAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.btnAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 1;
            animation4.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 2F;
            animation4.TransparencyCoeff = 0F;
            this.btnAnimator.DefaultAnimation = animation4;
            // 
            // DGWdata
            // 
            this.DGWdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.panelAnimator.SetDecoration(this.DGWdata, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.DGWdata, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.DGWdata, BunifuAnimatorNS.DecorationType.None);
            this.DGWdata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGWdata.Location = new System.Drawing.Point(623, 0);
            this.DGWdata.Margin = new System.Windows.Forms.Padding(4);
            this.DGWdata.Name = "DGWdata";
            this.DGWdata.ReadOnly = true;
            this.DGWdata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGWdata.Size = new System.Drawing.Size(975, 622);
            this.DGWdata.TabIndex = 17;
            this.DGWdata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWdata_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DGWdata);
            this.panel1.Controls.Add(this.AddWdaypanel2);
            this.panel1.Controls.Add(this.AddWdaypanel1);
            this.btnAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1598, 878);
            this.panel1.TabIndex = 12;
            // 
            // AddWdaypanel2
            // 
            this.AddWdaypanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddWdaypanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddWdaypanel2.BackgroundImage")));
            this.AddWdaypanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddWdaypanel2.Controls.Add(this.btnDlt);
            this.AddWdaypanel2.Controls.Add(this.btnUpd);
            this.AddWdaypanel2.Controls.Add(this.btnAdd);
            this.AddWdaypanel2.Controls.Add(this.btnClear);
            this.btnAnimator.SetDecoration(this.AddWdaypanel2, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.AddWdaypanel2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.AddWdaypanel2, BunifuAnimatorNS.DecorationType.None);
            this.AddWdaypanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddWdaypanel2.GradientBottomLeft = System.Drawing.Color.Black;
            this.AddWdaypanel2.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.AddWdaypanel2.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.AddWdaypanel2.GradientTopRight = System.Drawing.Color.Navy;
            this.AddWdaypanel2.Location = new System.Drawing.Point(623, 622);
            this.AddWdaypanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddWdaypanel2.Name = "AddWdaypanel2";
            this.AddWdaypanel2.Quality = 10;
            this.AddWdaypanel2.Size = new System.Drawing.Size(975, 256);
            this.AddWdaypanel2.TabIndex = 16;
            // 
            // btnDlt
            // 
            this.btnDlt.ActiveBorderThickness = 1;
            this.btnDlt.ActiveCornerRadius = 20;
            this.btnDlt.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDlt.ActiveForecolor = System.Drawing.Color.White;
            this.btnDlt.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDlt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDlt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDlt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDlt.BackgroundImage")));
            this.btnDlt.ButtonText = "DELETE";
            this.btnDlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimator.SetDecoration(this.btnDlt, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnDlt, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnDlt, BunifuAnimatorNS.DecorationType.None);
            this.btnDlt.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDlt.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDlt.IdleBorderThickness = 1;
            this.btnDlt.IdleCornerRadius = 20;
            this.btnDlt.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnDlt.IdleForecolor = System.Drawing.Color.White;
            this.btnDlt.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.btnDlt.Location = new System.Drawing.Point(495, 87);
            this.btnDlt.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(165, 39);
            this.btnDlt.TabIndex = 15;
            this.btnDlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDlt.Click += new System.EventHandler(this.btnDlt_Click);
            // 
            // btnUpd
            // 
            this.btnUpd.ActiveBorderThickness = 1;
            this.btnUpd.ActiveCornerRadius = 20;
            this.btnUpd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnUpd.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnUpd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpd.BackgroundImage")));
            this.btnUpd.ButtonText = "UPDATE";
            this.btnUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimator.SetDecoration(this.btnUpd, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnUpd, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnUpd, BunifuAnimatorNS.DecorationType.None);
            this.btnUpd.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnUpd.IdleBorderThickness = 1;
            this.btnUpd.IdleCornerRadius = 20;
            this.btnUpd.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnUpd.IdleForecolor = System.Drawing.Color.White;
            this.btnUpd.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpd.Location = new System.Drawing.Point(288, 87);
            this.btnUpd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(165, 39);
            this.btnUpd.TabIndex = 14;
            this.btnUpd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "ADD";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimator.SetDecoration(this.btnAdd, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnAdd, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnAdd, BunifuAnimatorNS.DecorationType.None);
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.IdleForecolor = System.Drawing.Color.White;
            this.btnAdd.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.Location = new System.Drawing.Point(88, 87);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 39);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "CLEAR";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimator.SetDecoration(this.btnClear, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnClear, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnClear, BunifuAnimatorNS.DecorationType.None);
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.IdleForecolor = System.Drawing.Color.White;
            this.btnClear.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.btnClear.Location = new System.Drawing.Point(673, 87);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(165, 39);
            this.btnClear.TabIndex = 22;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // AddWdaypanel1
            // 
            this.AddWdaypanel1.BackColor = System.Drawing.Color.Transparent;
            this.AddWdaypanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddWdaypanel1.BackgroundImage")));
            this.AddWdaypanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddWdaypanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddWdaypanel1.Controls.Add(this.label9);
            this.AddWdaypanel1.Controls.Add(this.cmbEm);
            this.AddWdaypanel1.Controls.Add(this.cmbSm);
            this.AddWdaypanel1.Controls.Add(this.cmbEh);
            this.AddWdaypanel1.Controls.Add(this.cmbSh);
            this.AddWdaypanel1.Controls.Add(this.lbl2);
            this.AddWdaypanel1.Controls.Add(this.lbl1);
            this.AddWdaypanel1.Controls.Add(this.label6);
            this.AddWdaypanel1.Controls.Add(this.label7);
            this.AddWdaypanel1.Controls.Add(this.label8);
            this.AddWdaypanel1.Controls.Add(this.btnSearch);
            this.AddWdaypanel1.Controls.Add(this.lblDay);
            this.AddWdaypanel1.Controls.Add(this.chbxSun);
            this.AddWdaypanel1.Controls.Add(this.chbxThu);
            this.AddWdaypanel1.Controls.Add(this.chbxSat);
            this.AddWdaypanel1.Controls.Add(this.chbxWed);
            this.AddWdaypanel1.Controls.Add(this.chbxFri);
            this.AddWdaypanel1.Controls.Add(this.chbxTus);
            this.AddWdaypanel1.Controls.Add(this.chbxMon);
            this.AddWdaypanel1.Controls.Add(this.label5);
            this.AddWdaypanel1.Controls.Add(this.label4);
            this.AddWdaypanel1.Controls.Add(this.label2);
            this.AddWdaypanel1.Controls.Add(this.label3);
            this.AddWdaypanel1.Controls.Add(this.label1);
            this.AddWdaypanel1.Controls.Add(this.txtLid);
            this.btnAnimator.SetDecoration(this.AddWdaypanel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.AddWdaypanel1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.AddWdaypanel1, BunifuAnimatorNS.DecorationType.None);
            this.AddWdaypanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddWdaypanel1.ForeColor = System.Drawing.Color.White;
            this.AddWdaypanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.AddWdaypanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.AddWdaypanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.AddWdaypanel1.GradientTopRight = System.Drawing.Color.Navy;
            this.AddWdaypanel1.Location = new System.Drawing.Point(0, 0);
            this.AddWdaypanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddWdaypanel1.Name = "AddWdaypanel1";
            this.AddWdaypanel1.Quality = 10;
            this.AddWdaypanel1.Size = new System.Drawing.Size(623, 878);
            this.AddWdaypanel1.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.label9, BunifuAnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(141, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "Add Working Days and Hours";
            // 
            // cmbEm
            // 
            this.panelAnimator.SetDecoration(this.cmbEm, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbEm, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.cmbEm, BunifuAnimatorNS.DecorationType.None);
            this.cmbEm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEm.FormattingEnabled = true;
            this.cmbEm.Items.AddRange(new object[] {
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "00"});
            this.cmbEm.Location = new System.Drawing.Point(387, 522);
            this.cmbEm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEm.Name = "cmbEm";
            this.cmbEm.Size = new System.Drawing.Size(121, 24);
            this.cmbEm.TabIndex = 29;
            // 
            // cmbSm
            // 
            this.panelAnimator.SetDecoration(this.cmbSm, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbSm, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.cmbSm, BunifuAnimatorNS.DecorationType.None);
            this.cmbSm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSm.FormattingEnabled = true;
            this.cmbSm.Items.AddRange(new object[] {
            "05",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "00"});
            this.cmbSm.Location = new System.Drawing.Point(387, 460);
            this.cmbSm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSm.Name = "cmbSm";
            this.cmbSm.Size = new System.Drawing.Size(121, 24);
            this.cmbSm.TabIndex = 29;
            // 
            // cmbEh
            // 
            this.panelAnimator.SetDecoration(this.cmbEh, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbEh, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.cmbEh, BunifuAnimatorNS.DecorationType.None);
            this.cmbEh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEh.FormattingEnabled = true;
            this.cmbEh.Items.AddRange(new object[] {
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18"});
            this.cmbEh.Location = new System.Drawing.Point(197, 522);
            this.cmbEh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEh.Name = "cmbEh";
            this.cmbEh.Size = new System.Drawing.Size(121, 24);
            this.cmbEh.TabIndex = 29;
            // 
            // cmbSh
            // 
            this.panelAnimator.SetDecoration(this.cmbSh, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbSh, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.cmbSh, BunifuAnimatorNS.DecorationType.None);
            this.cmbSh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSh.FormattingEnabled = true;
            this.cmbSh.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.cmbSh.Location = new System.Drawing.Point(197, 460);
            this.cmbSh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSh.Name = "cmbSh";
            this.cmbSh.Size = new System.Drawing.Size(121, 24);
            this.cmbSh.TabIndex = 29;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.logoAnimator.SetDecoration(this.lbl2, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.lbl2, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.lbl2, BunifuAnimatorNS.DecorationType.None);
            this.lbl2.Location = new System.Drawing.Point(365, 526);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 17);
            this.lbl2.TabIndex = 28;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.logoAnimator.SetDecoration(this.lbl1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.lbl1, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.lbl1, BunifuAnimatorNS.DecorationType.None);
            this.lbl1.Location = new System.Drawing.Point(365, 460);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 17);
            this.lbl1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(515, 522);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "M";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(325, 522);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "H";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.label8, BunifuAnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(77, 522);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "End Time  :";
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveBorderThickness = 1;
            this.btnSearch.ActiveCornerRadius = 20;
            this.btnSearch.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearch.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.ButtonText = "search";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimator.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F);
            this.btnSearch.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearch.IdleBorderThickness = 1;
            this.btnSearch.IdleCornerRadius = 20;
            this.btnSearch.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.IdleForecolor = System.Drawing.Color.White;
            this.btnSearch.IdleLineColor = System.Drawing.Color.DarkTurquoise;
            this.btnSearch.Location = new System.Drawing.Point(388, 104);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(165, 39);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.logoAnimator.SetDecoration(this.lblDay, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.lblDay, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.lblDay, BunifuAnimatorNS.DecorationType.None);
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(232, 190);
            this.lblDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(27, 20);
            this.lblDay.TabIndex = 20;
            this.lblDay.Text = "__";
            // 
            // chbxSun
            // 
            this.chbxSun.AutoSize = true;
            this.chbxSun.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.chbxSun, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.chbxSun, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.chbxSun, BunifuAnimatorNS.DecorationType.None);
            this.chbxSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxSun.ForeColor = System.Drawing.Color.White;
            this.chbxSun.Location = new System.Drawing.Point(81, 354);
            this.chbxSun.Margin = new System.Windows.Forms.Padding(4);
            this.chbxSun.Name = "chbxSun";
            this.chbxSun.Size = new System.Drawing.Size(86, 24);
            this.chbxSun.TabIndex = 10;
            this.chbxSun.Text = "Sunday";
            this.chbxSun.UseVisualStyleBackColor = false;
            this.chbxSun.CheckedChanged += new System.EventHandler(this.chbxSun_CheckedChanged);
            // 
            // chbxThu
            // 
            this.chbxThu.AutoSize = true;
            this.chbxThu.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.chbxThu, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.chbxThu, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.chbxThu, BunifuAnimatorNS.DecorationType.None);
            this.chbxThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxThu.ForeColor = System.Drawing.Color.White;
            this.chbxThu.Location = new System.Drawing.Point(81, 308);
            this.chbxThu.Margin = new System.Windows.Forms.Padding(4);
            this.chbxThu.Name = "chbxThu";
            this.chbxThu.Size = new System.Drawing.Size(100, 24);
            this.chbxThu.TabIndex = 11;
            this.chbxThu.Text = "Thursday";
            this.chbxThu.UseVisualStyleBackColor = false;
            this.chbxThu.CheckedChanged += new System.EventHandler(this.chbxThu_CheckedChanged);
            // 
            // chbxSat
            // 
            this.chbxSat.AutoSize = true;
            this.chbxSat.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.chbxSat, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.chbxSat, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.chbxSat, BunifuAnimatorNS.DecorationType.None);
            this.chbxSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxSat.ForeColor = System.Drawing.Color.White;
            this.chbxSat.Location = new System.Drawing.Point(409, 308);
            this.chbxSat.Margin = new System.Windows.Forms.Padding(4);
            this.chbxSat.Name = "chbxSat";
            this.chbxSat.Size = new System.Drawing.Size(97, 24);
            this.chbxSat.TabIndex = 12;
            this.chbxSat.Text = "Saturday";
            this.chbxSat.UseVisualStyleBackColor = false;
            this.chbxSat.CheckedChanged += new System.EventHandler(this.chbxSat_CheckedChanged);
            // 
            // chbxWed
            // 
            this.chbxWed.AutoSize = true;
            this.chbxWed.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.chbxWed, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.chbxWed, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.chbxWed, BunifuAnimatorNS.DecorationType.None);
            this.chbxWed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxWed.ForeColor = System.Drawing.Color.White;
            this.chbxWed.Location = new System.Drawing.Point(409, 265);
            this.chbxWed.Margin = new System.Windows.Forms.Padding(4);
            this.chbxWed.Name = "chbxWed";
            this.chbxWed.Size = new System.Drawing.Size(118, 24);
            this.chbxWed.TabIndex = 13;
            this.chbxWed.Text = "Wednesday";
            this.chbxWed.UseVisualStyleBackColor = false;
            this.chbxWed.CheckedChanged += new System.EventHandler(this.chbxWed_CheckedChanged);
            // 
            // chbxFri
            // 
            this.chbxFri.AutoSize = true;
            this.chbxFri.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.chbxFri, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.chbxFri, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.chbxFri, BunifuAnimatorNS.DecorationType.None);
            this.chbxFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxFri.ForeColor = System.Drawing.Color.White;
            this.chbxFri.Location = new System.Drawing.Point(223, 308);
            this.chbxFri.Margin = new System.Windows.Forms.Padding(4);
            this.chbxFri.Name = "chbxFri";
            this.chbxFri.Size = new System.Drawing.Size(77, 24);
            this.chbxFri.TabIndex = 14;
            this.chbxFri.Text = "Friday";
            this.chbxFri.UseVisualStyleBackColor = false;
            this.chbxFri.CheckedChanged += new System.EventHandler(this.chbxFri_CheckedChanged);
            // 
            // chbxTus
            // 
            this.chbxTus.AutoSize = true;
            this.chbxTus.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.chbxTus, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.chbxTus, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.chbxTus, BunifuAnimatorNS.DecorationType.None);
            this.chbxTus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxTus.ForeColor = System.Drawing.Color.White;
            this.chbxTus.Location = new System.Drawing.Point(223, 265);
            this.chbxTus.Margin = new System.Windows.Forms.Padding(4);
            this.chbxTus.Name = "chbxTus";
            this.chbxTus.Size = new System.Drawing.Size(94, 24);
            this.chbxTus.TabIndex = 15;
            this.chbxTus.Text = "Tuesday";
            this.chbxTus.UseVisualStyleBackColor = false;
            this.chbxTus.CheckedChanged += new System.EventHandler(this.chbxTus_CheckedChanged);
            // 
            // chbxMon
            // 
            this.chbxMon.AutoSize = true;
            this.chbxMon.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.chbxMon, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.chbxMon, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.chbxMon, BunifuAnimatorNS.DecorationType.None);
            this.chbxMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxMon.ForeColor = System.Drawing.Color.White;
            this.chbxMon.Location = new System.Drawing.Point(81, 265);
            this.chbxMon.Margin = new System.Windows.Forms.Padding(4);
            this.chbxMon.Name = "chbxMon";
            this.chbxMon.Size = new System.Drawing.Size(89, 24);
            this.chbxMon.TabIndex = 16;
            this.chbxMon.Text = "Monday";
            this.chbxMon.UseVisualStyleBackColor = false;
            this.chbxMon.Click += new System.EventHandler(this.chbxMon_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(515, 460);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 460);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "H";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start Time  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.logoAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number Of Days :";
            // 
            // txtLid
            // 
            this.logoAnimator.SetDecoration(this.txtLid, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.txtLid, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.txtLid, BunifuAnimatorNS.DecorationType.None);
            this.txtLid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLid.Location = new System.Drawing.Point(181, 111);
            this.txtLid.Margin = new System.Windows.Forms.Padding(4);
            this.txtLid.Name = "txtLid";
            this.txtLid.Size = new System.Drawing.Size(160, 26);
            this.txtLid.TabIndex = 9;
            // 
            // doubleBitmapControl1
            // 
            this.panelAnimator.SetDecoration(this.doubleBitmapControl1, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.doubleBitmapControl1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.doubleBitmapControl1, BunifuAnimatorNS.DecorationType.None);
            this.doubleBitmapControl1.Location = new System.Drawing.Point(-96, 167);
            this.doubleBitmapControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 10;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panelAnimator.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation5;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.logoAnimator.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.logoAnimator.DefaultAnimation = animation6;
            // 
            // working
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 878);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.doubleBitmapControl1);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "working";
            this.Text = "working";
            this.Load += new System.EventHandler(this.working_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWdata)).EndInit();
            this.panel1.ResumeLayout(false);
            this.AddWdaypanel2.ResumeLayout(false);
            this.AddWdaypanel1.ResumeLayout(false);
            this.AddWdaypanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition btnAnimator;
        private System.Windows.Forms.Label label9;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDlt;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private System.Windows.Forms.DataGridView DGWdata;
        private Bunifu.Framework.UI.BunifuGradientPanel AddWdaypanel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel AddWdaypanel1;
        private System.Windows.Forms.ComboBox cmbEm;
        private System.Windows.Forms.ComboBox cmbSm;
        private System.Windows.Forms.ComboBox cmbEh;
        private System.Windows.Forms.ComboBox cmbSh;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearch;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.CheckBox chbxSun;
        private System.Windows.Forms.CheckBox chbxThu;
        private System.Windows.Forms.CheckBox chbxSat;
        private System.Windows.Forms.CheckBox chbxWed;
        private System.Windows.Forms.CheckBox chbxFri;
        private System.Windows.Forms.CheckBox chbxTus;
        private System.Windows.Forms.CheckBox chbxMon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLid;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
    }
}