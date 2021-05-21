namespace banifiu
{
    partial class Student_add
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_add));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.cmbGrp = new System.Windows.Forms.ComboBox();
            this.cmbSubgrp = new System.Windows.Forms.ComboBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.cmbPrg = new System.Windows.Forms.ComboBox();
            this.cmbAca = new System.Windows.Forms.ComboBox();
            this.txtStuID = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dataStu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelStu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.guna2GradientButton8 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton7 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataStu)).BeginInit();
            this.panelStu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbGrp
            // 
            this.bunifuTransition1.SetDecoration(this.cmbGrp, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.cmbGrp, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbGrp, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.cmbGrp, BunifuAnimatorNS.DecorationType.None);
            this.cmbGrp.FormattingEnabled = true;
            this.cmbGrp.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbGrp.Location = new System.Drawing.Point(90, 515);
            this.cmbGrp.Name = "cmbGrp";
            this.cmbGrp.Size = new System.Drawing.Size(243, 24);
            this.cmbGrp.TabIndex = 15;
            // 
            // cmbSubgrp
            // 
            this.bunifuTransition1.SetDecoration(this.cmbSubgrp, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.cmbSubgrp, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbSubgrp, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.cmbSubgrp, BunifuAnimatorNS.DecorationType.None);
            this.cmbSubgrp.FormattingEnabled = true;
            this.cmbSubgrp.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbSubgrp.Location = new System.Drawing.Point(95, 698);
            this.cmbSubgrp.Name = "cmbSubgrp";
            this.cmbSubgrp.Size = new System.Drawing.Size(121, 24);
            this.cmbSubgrp.TabIndex = 14;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // cmbPrg
            // 
            this.bunifuTransition1.SetDecoration(this.cmbPrg, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.cmbPrg, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbPrg, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.cmbPrg, BunifuAnimatorNS.DecorationType.None);
            this.cmbPrg.FormattingEnabled = true;
            this.cmbPrg.Items.AddRange(new object[] {
            "Information Technology",
            "Software Engineering",
            "Cyber Security",
            "Data Science"});
            this.cmbPrg.Location = new System.Drawing.Point(90, 404);
            this.cmbPrg.Name = "cmbPrg";
            this.cmbPrg.Size = new System.Drawing.Size(243, 24);
            this.cmbPrg.TabIndex = 14;
            // 
            // cmbAca
            // 
            this.bunifuTransition1.SetDecoration(this.cmbAca, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.cmbAca, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbAca, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.cmbAca, BunifuAnimatorNS.DecorationType.None);
            this.cmbAca.FormattingEnabled = true;
            this.cmbAca.Items.AddRange(new object[] {
            "Y1.S1",
            "Y1.S2",
            "Y2.S1",
            "Y2.S2",
            "Y3.S1",
            "Y3.S2",
            "Y4.S1",
            "Y4.S2"});
            this.cmbAca.Location = new System.Drawing.Point(90, 309);
            this.cmbAca.Name = "cmbAca";
            this.cmbAca.Size = new System.Drawing.Size(243, 24);
            this.cmbAca.TabIndex = 14;
            // 
            // txtStuID
            // 
            this.txtStuID.BackColor = System.Drawing.Color.White;
            this.txtStuID.BorderColor = System.Drawing.Color.SeaGreen;
            this.logoAnimator.SetDecoration(this.txtStuID, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.txtStuID, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.txtStuID, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.txtStuID, BunifuAnimatorNS.DecorationType.None);
            this.txtStuID.Location = new System.Drawing.Point(90, 232);
            this.txtStuID.Name = "txtStuID";
            this.txtStuID.ReadOnly = true;
            this.txtStuID.Size = new System.Drawing.Size(100, 22);
            this.txtStuID.TabIndex = 2;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.dataStu);
            this.bunifuGradientPanel1.Controls.Add(this.guna2TextBox1);
            this.bunifuGradientPanel1.Controls.Add(this.guna2GradientButton4);
            this.bunifuGradientPanel1.Controls.Add(this.guna2GradientButton3);
            this.bunifuGradientPanel1.Controls.Add(this.guna2GradientButton2);
            this.bunifuGradientPanel1.Controls.Add(this.guna2GradientButton1);
            this.bunifuGradientPanel1.Controls.Add(this.btnSave);
            this.bunifuGradientPanel1.Controls.Add(this.panelStu);
            this.btnAnimator.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1910, 875);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // dataStu
            // 
            this.dataStu.AllowUserToAddRows = false;
            this.dataStu.AllowUserToDeleteRows = false;
            this.dataStu.AllowUserToResizeColumns = false;
            this.dataStu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataStu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataStu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataStu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataStu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataStu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataStu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataStu.ColumnHeadersHeight = 40;
            this.dataStu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.logoAnimator.SetDecoration(this.dataStu, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.dataStu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.dataStu, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.dataStu, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataStu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataStu.EnableHeadersVisualStyles = false;
            this.dataStu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataStu.Location = new System.Drawing.Point(794, 194);
            this.dataStu.Margin = new System.Windows.Forms.Padding(4);
            this.dataStu.MultiSelect = false;
            this.dataStu.Name = "dataStu";
            this.dataStu.ReadOnly = true;
            this.dataStu.RowHeadersVisible = false;
            this.dataStu.RowHeadersWidth = 40;
            this.dataStu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStu.Size = new System.Drawing.Size(993, 546);
            this.dataStu.TabIndex = 27;
            this.dataStu.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dataStu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataStu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataStu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataStu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataStu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataStu.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dataStu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dataStu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(219)))));
            this.dataStu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataStu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataStu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataStu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataStu.ThemeStyle.HeaderStyle.Height = 40;
            this.dataStu.ThemeStyle.ReadOnly = true;
            this.dataStu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dataStu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataStu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataStu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataStu.ThemeStyle.RowsStyle.Height = 22;
            this.dataStu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dataStu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataStu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStu_CellContentClick);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.BorderRadius = 19;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnAnimator.SetDecoration(this.guna2TextBox1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.guna2TextBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.guna2TextBox1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2TextBox1, BunifuAnimatorNS.DecorationType.None);
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(794, 145);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TextBox1.PlaceholderText = "    Search...";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(251, 41);
            this.guna2TextBox1.TabIndex = 26;
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.Animated = true;
            this.guna2GradientButton4.AutoRoundedCorners = true;
            this.guna2GradientButton4.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton4.BorderRadius = 20;
            this.guna2GradientButton4.CheckedState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.CustomImages.Parent = this.guna2GradientButton4;
            this.btnAnimator.SetDecoration(this.guna2GradientButton4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.guna2GradientButton4, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.guna2GradientButton4, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2GradientButton4, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientButton4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(240)))));
            this.guna2GradientButton4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton4.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.guna2GradientButton4.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(236)))));
            this.guna2GradientButton4.HoverState.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.IndicateFocus = true;
            this.guna2GradientButton4.Location = new System.Drawing.Point(1092, 143);
            this.guna2GradientButton4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.ShadowDecoration.Parent = this.guna2GradientButton4;
            this.guna2GradientButton4.Size = new System.Drawing.Size(143, 43);
            this.guna2GradientButton4.TabIndex = 25;
            this.guna2GradientButton4.Text = "Search";
            this.guna2GradientButton4.UseTransparentBackground = true;
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Animated = true;
            this.guna2GradientButton3.AutoRoundedCorners = true;
            this.guna2GradientButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton3.BorderRadius = 20;
            this.guna2GradientButton3.CheckedState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.CustomImages.Parent = this.guna2GradientButton3;
            this.btnAnimator.SetDecoration(this.guna2GradientButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.guna2GradientButton3, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.guna2GradientButton3, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2GradientButton3, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(240)))));
            this.guna2GradientButton3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton3.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(236)))));
            this.guna2GradientButton3.HoverState.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.IndicateFocus = true;
            this.guna2GradientButton3.Location = new System.Drawing.Point(1622, 748);
            this.guna2GradientButton3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.ShadowDecoration.Parent = this.guna2GradientButton3;
            this.guna2GradientButton3.Size = new System.Drawing.Size(143, 43);
            this.guna2GradientButton3.TabIndex = 24;
            this.guna2GradientButton3.Text = "Clear";
            this.guna2GradientButton3.UseTransparentBackground = true;
            this.guna2GradientButton3.Click += new System.EventHandler(this.guna2GradientButton3_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Animated = true;
            this.guna2GradientButton2.AutoRoundedCorners = true;
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderRadius = 20;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.btnAnimator.SetDecoration(this.guna2GradientButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.guna2GradientButton2, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.guna2GradientButton2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2GradientButton2, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(240)))));
            this.guna2GradientButton2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(236)))));
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.IndicateFocus = true;
            this.guna2GradientButton2.Location = new System.Drawing.Point(1328, 748);
            this.guna2GradientButton2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(143, 43);
            this.guna2GradientButton2.TabIndex = 23;
            this.guna2GradientButton2.Text = "Delete";
            this.guna2GradientButton2.UseTransparentBackground = true;
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 20;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.btnAnimator.SetDecoration(this.guna2GradientButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.guna2GradientButton1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.guna2GradientButton1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2GradientButton1, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientButton1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(240)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(236)))));
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.IndicateFocus = true;
            this.guna2GradientButton1.Location = new System.Drawing.Point(1075, 748);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(143, 43);
            this.guna2GradientButton1.TabIndex = 22;
            this.guna2GradientButton1.Text = "Update";
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 20;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnAnimator.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnSave.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(240)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.btnSave.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(236)))));
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.IndicateFocus = true;
            this.btnSave.Location = new System.Drawing.Point(794, 748);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(143, 43);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseTransparentBackground = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelStu
            // 
            this.panelStu.BackColor = System.Drawing.Color.Transparent;
            this.panelStu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelStu.BackgroundImage")));
            this.panelStu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStu.Controls.Add(this.guna2GradientButton8);
            this.panelStu.Controls.Add(this.guna2GradientButton7);
            this.panelStu.Controls.Add(this.guna2GradientButton6);
            this.panelStu.Controls.Add(this.guna2GradientButton5);
            this.panelStu.Controls.Add(this.bunifuCustomLabel5);
            this.panelStu.Controls.Add(this.bunifuCustomLabel4);
            this.panelStu.Controls.Add(this.bunifuCustomLabel3);
            this.panelStu.Controls.Add(this.bunifuCustomLabel1);
            this.panelStu.Controls.Add(this.bunifuCustomLabel2);
            this.panelStu.Controls.Add(this.cmbGrp);
            this.panelStu.Controls.Add(this.cmbSubgrp);
            this.panelStu.Controls.Add(this.cmbPrg);
            this.panelStu.Controls.Add(this.cmbAca);
            this.panelStu.Controls.Add(this.txtStuID);
            this.btnAnimator.SetDecoration(this.panelStu, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelStu, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.panelStu, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.panelStu, BunifuAnimatorNS.DecorationType.None);
            this.panelStu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStu.GradientBottomLeft = System.Drawing.Color.Black;
            this.panelStu.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.panelStu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(49)))));
            this.panelStu.GradientTopRight = System.Drawing.Color.Navy;
            this.panelStu.Location = new System.Drawing.Point(0, 0);
            this.panelStu.Name = "panelStu";
            this.panelStu.Quality = 10;
            this.panelStu.Size = new System.Drawing.Size(635, 873);
            this.panelStu.TabIndex = 17;
            // 
            // guna2GradientButton8
            // 
            this.guna2GradientButton8.Animated = true;
            this.guna2GradientButton8.AutoRoundedCorners = true;
            this.guna2GradientButton8.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton8.BorderRadius = 19;
            this.guna2GradientButton8.CheckedState.Parent = this.guna2GradientButton8;
            this.guna2GradientButton8.CustomImages.Parent = this.guna2GradientButton8;
            this.btnAnimator.SetDecoration(this.guna2GradientButton8, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.guna2GradientButton8, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.guna2GradientButton8, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2GradientButton8, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientButton8.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2GradientButton8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.guna2GradientButton8.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(240)))));
            this.guna2GradientButton8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.guna2GradientButton8.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton8.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton8.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton8.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.guna2GradientButton8.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(236)))));
            this.guna2GradientButton8.HoverState.Parent = this.guna2GradientButton8;
            this.guna2GradientButton8.IndicateFocus = true;
            this.guna2GradientButton8.Location = new System.Drawing.Point(278, 740);
            this.guna2GradientButton8.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton8.Name = "guna2GradientButton8";
            this.guna2GradientButton8.ShadowDecoration.Parent = this.guna2GradientButton8;
            this.guna2GradientButton8.Size = new System.Drawing.Size(197, 40);
            this.guna2GradientButton8.TabIndex = 64;
            this.guna2GradientButton8.Text = "Delete sGroup ID";
            this.guna2GradientButton8.UseTransparentBackground = true;
            this.guna2GradientButton8.Click += new System.EventHandler(this.guna2GradientButton8_Click);
            // 
            // guna2GradientButton7
            // 
            this.guna2GradientButton7.Animated = true;
            this.guna2GradientButton7.AutoRoundedCorners = true;
            this.guna2GradientButton7.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton7.BorderRadius = 19;
            this.guna2GradientButton7.CheckedState.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.CustomImages.Parent = this.guna2GradientButton7;
            this.btnAnimator.SetDecoration(this.guna2GradientButton7, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.guna2GradientButton7, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.guna2GradientButton7, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2GradientButton7, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientButton7.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2GradientButton7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.guna2GradientButton7.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(240)))));
            this.guna2GradientButton7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.guna2GradientButton7.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton7.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton7.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton7.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.guna2GradientButton7.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(236)))));
            this.guna2GradientButton7.HoverState.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.IndicateFocus = true;
            this.guna2GradientButton7.Location = new System.Drawing.Point(74, 573);
            this.guna2GradientButton7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton7.Name = "guna2GradientButton7";
            this.guna2GradientButton7.ShadowDecoration.Parent = this.guna2GradientButton7;
            this.guna2GradientButton7.Size = new System.Drawing.Size(203, 40);
            this.guna2GradientButton7.TabIndex = 63;
            this.guna2GradientButton7.Text = "Generate Group ID";
            this.guna2GradientButton7.UseTransparentBackground = true;
            this.guna2GradientButton7.Click += new System.EventHandler(this.guna2GradientButton7_Click);
            // 
            // guna2GradientButton6
            // 
            this.guna2GradientButton6.Animated = true;
            this.guna2GradientButton6.AutoRoundedCorners = true;
            this.guna2GradientButton6.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton6.BorderRadius = 18;
            this.guna2GradientButton6.CheckedState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.CustomImages.Parent = this.guna2GradientButton6;
            this.btnAnimator.SetDecoration(this.guna2GradientButton6, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.guna2GradientButton6, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.guna2GradientButton6, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2GradientButton6, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientButton6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2GradientButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.guna2GradientButton6.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(240)))));
            this.guna2GradientButton6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.guna2GradientButton6.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton6.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton6.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton6.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.guna2GradientButton6.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(236)))));
            this.guna2GradientButton6.HoverState.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.IndicateFocus = true;
            this.guna2GradientButton6.Location = new System.Drawing.Point(66, 742);
            this.guna2GradientButton6.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.ShadowDecoration.Parent = this.guna2GradientButton6;
            this.guna2GradientButton6.Size = new System.Drawing.Size(195, 38);
            this.guna2GradientButton6.TabIndex = 62;
            this.guna2GradientButton6.Text = "Generate sGroup ID";
            this.guna2GradientButton6.UseTransparentBackground = true;
            this.guna2GradientButton6.Click += new System.EventHandler(this.guna2GradientButton6_Click);
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.Animated = true;
            this.guna2GradientButton5.AutoRoundedCorners = true;
            this.guna2GradientButton5.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton5.BorderRadius = 19;
            this.guna2GradientButton5.CheckedState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.CustomImages.Parent = this.guna2GradientButton5;
            this.btnAnimator.SetDecoration(this.guna2GradientButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.guna2GradientButton5, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.guna2GradientButton5, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2GradientButton5, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientButton5.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.guna2GradientButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(240)))));
            this.guna2GradientButton5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientButton5.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton5.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.guna2GradientButton5.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(236)))));
            this.guna2GradientButton5.HoverState.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.IndicateFocus = true;
            this.guna2GradientButton5.Location = new System.Drawing.Point(290, 573);
            this.guna2GradientButton5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.ShadowDecoration.Parent = this.guna2GradientButton5;
            this.guna2GradientButton5.Size = new System.Drawing.Size(197, 40);
            this.guna2GradientButton5.TabIndex = 61;
            this.guna2GradientButton5.Text = "Delete Group ID";
            this.guna2GradientButton5.UseTransparentBackground = true;
            this.guna2GradientButton5.Click += new System.EventHandler(this.guna2GradientButton5_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(85, 663);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(200, 25);
            this.bunifuCustomLabel5.TabIndex = 60;
            this.bunifuCustomLabel5.Text = "Select Group Number";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(90, 478);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(200, 25);
            this.bunifuCustomLabel4.TabIndex = 59;
            this.bunifuCustomLabel4.Text = "Select Group Number";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(91, 364);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(113, 25);
            this.bunifuCustomLabel3.TabIndex = 58;
            this.bunifuCustomLabel3.Text = "Programme";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(85, 272);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(275, 25);
            this.bunifuCustomLabel1.TabIndex = 57;
            this.bunifuCustomLabel1.Text = "Acadamic Year And Semester";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.logoAnimator.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(91, 193);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(31, 25);
            this.bunifuCustomLabel2.TabIndex = 56;
            this.bunifuCustomLabel2.Text = "ID";
            // 
            // panelAnimator
            // 
            this.panelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.panelAnimator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.panelAnimator.DefaultAnimation = animation2;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.logoAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.logoAnimator.DefaultAnimation = animation4;
            // 
            // btnAnimator
            // 
            this.btnAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.btnAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 1;
            animation3.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 2F;
            animation3.TransparencyCoeff = 0F;
            this.btnAnimator.DefaultAnimation = animation3;
            // 
            // Student_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 875);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Student_add";
            this.Text = "Student_add";
            this.Load += new System.EventHandler(this.Student_add_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataStu)).EndInit();
            this.panelStu.ResumeLayout(false);
            this.panelStu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGrp;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition panelAnimator;
        private BunifuAnimatorNS.BunifuTransition btnAnimator;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private System.Windows.Forms.ComboBox cmbSubgrp;
        private System.Windows.Forms.ComboBox cmbPrg;
        private System.Windows.Forms.ComboBox cmbAca;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtStuID;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel panelStu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dataStu;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton8;
    }
}