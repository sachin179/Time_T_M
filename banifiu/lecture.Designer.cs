namespace banifiu
{
    partial class lecture
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lecture));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.btnAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnClear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvLecturer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbBuilding = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbCenter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbDepartment = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbFaculty = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLecturerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLecturerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.logoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 20;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.logoAnimator.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.btnSave, BunifuAnimatorNS.DecorationType.None);
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
            this.btnSave.Location = new System.Drawing.Point(811, 707);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(187, 43);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseTransparentBackground = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 20;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.logoAnimator.SetDecoration(this.btnClear, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.btnClear, BunifuAnimatorNS.DecorationType.None);
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnClear.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(240)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnClear.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.btnClear.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(236)))));
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.IndicateFocus = true;
            this.btnClear.Location = new System.Drawing.Point(1044, 707);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(187, 43);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseTransparentBackground = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.txtSearch.BorderRadius = 19;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logoAnimator.SetDecoration(this.txtSearch, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.txtSearch, BunifuAnimatorNS.DecorationType.None);
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(811, 60);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSearch.PlaceholderText = "    Search...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(295, 41);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.logoAnimator.SetDecoration(this.btnDelete, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.btnDelete, BunifuAnimatorNS.DecorationType.None);
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(240)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnDelete.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.btnDelete.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(236)))));
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.IndicateFocus = true;
            this.btnDelete.Location = new System.Drawing.Point(1277, 707);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(187, 43);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // dgvLecturer
            // 
            this.dgvLecturer.AllowUserToAddRows = false;
            this.dgvLecturer.AllowUserToDeleteRows = false;
            this.dgvLecturer.AllowUserToResizeColumns = false;
            this.dgvLecturer.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvLecturer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLecturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLecturer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvLecturer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLecturer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLecturer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLecturer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLecturer.ColumnHeadersHeight = 40;
            this.dgvLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.logoAnimator.SetDecoration(this.dgvLecturer, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.dgvLecturer, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLecturer.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLecturer.EnableHeadersVisualStyles = false;
            this.dgvLecturer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvLecturer.Location = new System.Drawing.Point(722, 119);
            this.dgvLecturer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLecturer.MultiSelect = false;
            this.dgvLecturer.Name = "dgvLecturer";
            this.dgvLecturer.ReadOnly = true;
            this.dgvLecturer.RowHeadersVisible = false;
            this.dgvLecturer.RowHeadersWidth = 40;
            this.dgvLecturer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLecturer.Size = new System.Drawing.Size(981, 546);
            this.dgvLecturer.TabIndex = 12;
            this.dgvLecturer.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgvLecturer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvLecturer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLecturer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLecturer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLecturer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLecturer.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvLecturer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvLecturer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(115)))), ((int)(((byte)(219)))));
            this.dgvLecturer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLecturer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLecturer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLecturer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLecturer.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvLecturer.ThemeStyle.ReadOnly = true;
            this.dgvLecturer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvLecturer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLecturer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvLecturer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLecturer.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLecturer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvLecturer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvLecturer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLecturer_CellContentClick_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.logoAnimator.SetDecoration(this.btnUpdate, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.btnUpdate, BunifuAnimatorNS.DecorationType.None);
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(140)))), ((int)(((byte)(255)))));
            this.btnUpdate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(77)))), ((int)(((byte)(240)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(250)))));
            this.btnUpdate.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(75)))), ((int)(((byte)(236)))));
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.IndicateFocus = true;
            this.btnUpdate.Location = new System.Drawing.Point(1511, 707);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(187, 43);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // guna2GradientPanel2
            // 
            this.logoAnimator.SetDecoration(this.guna2GradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.guna2GradientPanel2, BunifuAnimatorNS.DecorationType.None);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(11)))), ((int)(((byte)(69)))));
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(27)))));
            this.guna2GradientPanel2.Location = new System.Drawing.Point(1, 50);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(1715, 5);
            this.guna2GradientPanel2.TabIndex = 15;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2ShadowPanel1.Controls.Add(this.cmbLevel);
            this.guna2ShadowPanel1.Controls.Add(this.cmbBuilding);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel8);
            this.guna2ShadowPanel1.Controls.Add(this.cmbCenter);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2ShadowPanel1.Controls.Add(this.cmbDepartment);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2ShadowPanel1.Controls.Add(this.cmbFaculty);
            this.guna2ShadowPanel1.Controls.Add(this.txtLecturerID);
            this.guna2ShadowPanel1.Controls.Add(this.txtLecturerName);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel3);
            this.logoAnimator.SetDecoration(this.guna2ShadowPanel1, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.guna2ShadowPanel1, BunifuAnimatorNS.DecorationType.None);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(27)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(92, 138);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 5;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(586, 597);
            this.guna2ShadowPanel1.TabIndex = 21;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimator.SetDecoration(this.guna2HtmlLabel2, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2HtmlLabel2, BunifuAnimatorNS.DecorationType.None);
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(23, 28);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(97, 30);
            this.guna2HtmlLabel2.TabIndex = 0;
            this.guna2HtmlLabel2.Text = "Lecturer ID";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimator.SetDecoration(this.guna2HtmlLabel1, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2HtmlLabel1, BunifuAnimatorNS.DecorationType.None);
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(23, 89);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(130, 30);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Lecturer Name";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimator.SetDecoration(this.guna2HtmlLabel5, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2HtmlLabel5, BunifuAnimatorNS.DecorationType.None);
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(23, 411);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(47, 30);
            this.guna2HtmlLabel5.TabIndex = 0;
            this.guna2HtmlLabel5.Text = "Level";
            // 
            // cmbLevel
            // 
            this.cmbLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.cmbLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.logoAnimator.SetDecoration(this.cmbLevel, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbLevel, BunifuAnimatorNS.DecorationType.None);
            this.cmbLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLevel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLevel.FocusedState.Parent = this.cmbLevel;
            this.cmbLevel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbLevel.HoverState.Parent = this.cmbLevel;
            this.cmbLevel.ItemHeight = 30;
            this.cmbLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbLevel.ItemsAppearance.Parent = this.cmbLevel;
            this.cmbLevel.Location = new System.Drawing.Point(193, 398);
            this.cmbLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.ShadowDecoration.Parent = this.cmbLevel;
            this.cmbLevel.Size = new System.Drawing.Size(275, 36);
            this.cmbLevel.TabIndex = 3;
            // 
            // cmbBuilding
            // 
            this.cmbBuilding.Animated = true;
            this.cmbBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.cmbBuilding.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.logoAnimator.SetDecoration(this.cmbBuilding, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbBuilding, BunifuAnimatorNS.DecorationType.None);
            this.cmbBuilding.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuilding.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBuilding.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBuilding.FocusedState.Parent = this.cmbBuilding;
            this.cmbBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbBuilding.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBuilding.HoverState.Parent = this.cmbBuilding;
            this.cmbBuilding.ItemHeight = 30;
            this.cmbBuilding.Items.AddRange(new object[] {
            "New building",
            "D-block"});
            this.cmbBuilding.ItemsAppearance.Parent = this.cmbBuilding;
            this.cmbBuilding.Location = new System.Drawing.Point(193, 336);
            this.cmbBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuilding.Name = "cmbBuilding";
            this.cmbBuilding.ShadowDecoration.Parent = this.cmbBuilding;
            this.cmbBuilding.Size = new System.Drawing.Size(275, 36);
            this.cmbBuilding.TabIndex = 3;
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimator.SetDecoration(this.guna2HtmlLabel8, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2HtmlLabel8, BunifuAnimatorNS.DecorationType.None);
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(23, 347);
            this.guna2HtmlLabel8.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(75, 30);
            this.guna2HtmlLabel8.TabIndex = 0;
            this.guna2HtmlLabel8.Text = "Building";
            // 
            // cmbCenter
            // 
            this.cmbCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.cmbCenter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.logoAnimator.SetDecoration(this.cmbCenter, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbCenter, BunifuAnimatorNS.DecorationType.None);
            this.cmbCenter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCenter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCenter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCenter.FocusedState.Parent = this.cmbCenter;
            this.cmbCenter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCenter.HoverState.Parent = this.cmbCenter;
            this.cmbCenter.ItemHeight = 30;
            this.cmbCenter.Items.AddRange(new object[] {
            "Malabe",
            "Metro",
            "Matara",
            "Kandy",
            "Kurunagala",
            "Jaffna"});
            this.cmbCenter.ItemsAppearance.Parent = this.cmbCenter;
            this.cmbCenter.Location = new System.Drawing.Point(193, 274);
            this.cmbCenter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCenter.Name = "cmbCenter";
            this.cmbCenter.ShadowDecoration.Parent = this.cmbCenter;
            this.cmbCenter.Size = new System.Drawing.Size(275, 36);
            this.cmbCenter.TabIndex = 3;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimator.SetDecoration(this.guna2HtmlLabel7, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2HtmlLabel7, BunifuAnimatorNS.DecorationType.None);
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(23, 283);
            this.guna2HtmlLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(60, 30);
            this.guna2HtmlLabel7.TabIndex = 0;
            this.guna2HtmlLabel7.Text = "Center ";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.cmbDepartment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.logoAnimator.SetDecoration(this.cmbDepartment, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbDepartment, BunifuAnimatorNS.DecorationType.None);
            this.cmbDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepartment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDepartment.FocusedState.Parent = this.cmbDepartment;
            this.cmbDepartment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDepartment.HoverState.Parent = this.cmbDepartment;
            this.cmbDepartment.ItemHeight = 30;
            this.cmbDepartment.Items.AddRange(new object[] {
            "IT",
            "SE",
            "DS",
            "CS"});
            this.cmbDepartment.ItemsAppearance.Parent = this.cmbDepartment;
            this.cmbDepartment.Location = new System.Drawing.Point(193, 213);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.ShadowDecoration.Parent = this.cmbDepartment;
            this.cmbDepartment.Size = new System.Drawing.Size(275, 36);
            this.cmbDepartment.TabIndex = 3;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimator.SetDecoration(this.guna2HtmlLabel4, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2HtmlLabel4, BunifuAnimatorNS.DecorationType.None);
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(23, 219);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(108, 30);
            this.guna2HtmlLabel4.TabIndex = 0;
            this.guna2HtmlLabel4.Text = "Department ";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.cmbFaculty.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.logoAnimator.SetDecoration(this.cmbFaculty, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.cmbFaculty, BunifuAnimatorNS.DecorationType.None);
            this.cmbFaculty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaculty.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFaculty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFaculty.FocusedState.Parent = this.cmbFaculty;
            this.cmbFaculty.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFaculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFaculty.HoverState.Parent = this.cmbFaculty;
            this.cmbFaculty.ItemHeight = 30;
            this.cmbFaculty.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Sciences"});
            this.cmbFaculty.ItemsAppearance.Parent = this.cmbFaculty;
            this.cmbFaculty.Location = new System.Drawing.Point(193, 151);
            this.cmbFaculty.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.ShadowDecoration.Parent = this.cmbFaculty;
            this.cmbFaculty.Size = new System.Drawing.Size(275, 36);
            this.cmbFaculty.TabIndex = 3;
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.txtLecturerID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.txtLecturerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logoAnimator.SetDecoration(this.txtLecturerID, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.txtLecturerID, BunifuAnimatorNS.DecorationType.None);
            this.txtLecturerID.DefaultText = "";
            this.txtLecturerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLecturerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLecturerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLecturerID.DisabledState.Parent = this.txtLecturerID;
            this.txtLecturerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLecturerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLecturerID.FocusedState.Parent = this.txtLecturerID;
            this.txtLecturerID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLecturerID.ForeColor = System.Drawing.Color.Black;
            this.txtLecturerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLecturerID.HoverState.Parent = this.txtLecturerID;
            this.txtLecturerID.Location = new System.Drawing.Point(193, 28);
            this.txtLecturerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.PasswordChar = '\0';
            this.txtLecturerID.PlaceholderText = "";
            this.txtLecturerID.SelectedText = "";
            this.txtLecturerID.ShadowDecoration.Parent = this.txtLecturerID;
            this.txtLecturerID.Size = new System.Drawing.Size(276, 44);
            this.txtLecturerID.TabIndex = 1;
            // 
            // txtLecturerName
            // 
            this.txtLecturerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(69)))));
            this.txtLecturerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(70)))), ((int)(((byte)(138)))));
            this.txtLecturerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logoAnimator.SetDecoration(this.txtLecturerName, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.txtLecturerName, BunifuAnimatorNS.DecorationType.None);
            this.txtLecturerName.DefaultText = "";
            this.txtLecturerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLecturerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLecturerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLecturerName.DisabledState.Parent = this.txtLecturerName;
            this.txtLecturerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLecturerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLecturerName.FocusedState.Parent = this.txtLecturerName;
            this.txtLecturerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLecturerName.ForeColor = System.Drawing.Color.Black;
            this.txtLecturerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLecturerName.HoverState.Parent = this.txtLecturerName;
            this.txtLecturerName.Location = new System.Drawing.Point(193, 90);
            this.txtLecturerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLecturerName.Name = "txtLecturerName";
            this.txtLecturerName.PasswordChar = '\0';
            this.txtLecturerName.PlaceholderText = "";
            this.txtLecturerName.SelectedText = "";
            this.txtLecturerName.ShadowDecoration.Parent = this.txtLecturerName;
            this.txtLecturerName.Size = new System.Drawing.Size(276, 44);
            this.txtLecturerName.TabIndex = 1;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimator.SetDecoration(this.guna2HtmlLabel3, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this.guna2HtmlLabel3, BunifuAnimatorNS.DecorationType.None);
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(247)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(23, 155);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(65, 30);
            this.guna2HtmlLabel3.TabIndex = 0;
            this.guna2HtmlLabel3.Text = "Faculty";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2ShadowPanel1);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2GradientPanel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnUpdate);
            this.guna2CustomGradientPanel1.Controls.Add(this.dgvLecturer);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnDelete);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtSearch);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnClear);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnSave);
            this.logoAnimator.SetDecoration(this.guna2CustomGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimator.SetDecoration(this.guna2CustomGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Navy;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(6)))), ((int)(((byte)(54)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(8)))), ((int)(((byte)(42)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(19)))), ((int)(((byte)(111)))));
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1737, 895);
            this.guna2CustomGradientPanel1.TabIndex = 23;
            // 
            // logoAnimator
            // 
            this.logoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.logoAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.logoAnimator.DefaultAnimation = animation4;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            // 
            // lecture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1737, 895);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.btnAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "lecture";
            this.Text = "lecture";
            this.Load += new System.EventHandler(this.lecture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturer)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition btnAnimator;
        private BunifuAnimatorNS.BunifuTransition logoAnimator;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLevel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBuilding;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCenter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDepartment;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFaculty;
        private Guna.UI2.WinForms.Guna2TextBox txtLecturerID;
        private Guna.UI2.WinForms.Guna2TextBox txtLecturerName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientButton btnUpdate;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLecturer;
        private Guna.UI2.WinForms.Guna2GradientButton btnDelete;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnClear;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
    }
}