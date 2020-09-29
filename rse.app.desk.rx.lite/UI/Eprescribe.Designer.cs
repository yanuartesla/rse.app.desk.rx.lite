namespace rse.app.desk.rx.lite
{
    partial class Eprescribe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eprescribe));
            this.NavPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.rMKUNJUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakkumdbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakkumdb = new rse.app.desk.rx.lite.dataset.yakkumdb();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblKlinik = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblkdokter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNoreg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NamaPASIEN = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.NoRM = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoadPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnAddRx = new Guna.UI2.WinForms.Guna2Button();
            this.rM_KUNJUNGTableAdapter = new rse.app.desk.rx.lite.dataset.yakkumdbTableAdapters.RM_KUNJUNGTableAdapter();
            this.vc_no_rm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vc_nama_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vc_jenis_k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in_umurth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGambar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.NavPanel.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMKUNJUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.LoadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.Transparent;
            this.NavPanel.Controls.Add(this.guna2ShadowPanel1);
            this.NavPanel.Controls.Add(this.panel2);
            this.NavPanel.Controls.Add(this.panel1);
            this.NavPanel.Controls.Add(this.guna2Panel2);
            this.NavPanel.Controls.Add(this.guna2Panel1);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.FillColor = System.Drawing.Color.Teal;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Radius = 18;
            this.NavPanel.ShadowColor = System.Drawing.Color.Black;
            this.NavPanel.Size = new System.Drawing.Size(300, 622);
            this.NavPanel.TabIndex = 0;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.guna2DataGridView1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(300, 84);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 18;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(0, 514);
            this.guna2ShadowPanel1.TabIndex = 3;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.guna2DataGridView1.ColumnHeadersHeight = 21;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vc_no_rm,
            this.vc_nama_p,
            this.vc_jenis_k,
            this.in_umurth});
            this.guna2DataGridView1.DataSource = this.rMKUNJUNGBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(0, 514);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.GreenSea;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(226)))), ((int)(((byte)(218)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(224)))), ((int)(((byte)(216)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 21;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(230)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(191)))), ((int)(((byte)(173)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellDoubleClick);
            // 
            // rMKUNJUNGBindingSource
            // 
            this.rMKUNJUNGBindingSource.DataMember = "RM_KUNJUNG";
            this.rMKUNJUNGBindingSource.DataSource = this.yakkumdbBindingSource;
            // 
            // yakkumdbBindingSource
            // 
            this.yakkumdbBindingSource.DataSource = this.yakkumdb;
            this.yakkumdbBindingSource.Position = 0;
            // 
            // yakkumdb
            // 
            this.yakkumdb.DataSetName = "yakkumdb";
            this.yakkumdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(300, 598);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 24);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(278, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 538);
            this.panel1.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(300, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(0, 84);
            this.guna2Panel2.TabIndex = 2;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.HoverState.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.Location = new System.Drawing.Point(6, 24);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = global::rse.app.desk.rx.lite.Properties.Resources.back_button__1_;
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblKlinik);
            this.guna2Panel1.Controls.Add(this.lblkdokter);
            this.guna2Panel1.Controls.Add(this.lblNoreg);
            this.guna2Panel1.Controls.Add(this.NamaPASIEN);
            this.guna2Panel1.Controls.Add(this.NoRM);
            this.guna2Panel1.Controls.Add(this.guna2TextBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(300, 622);
            this.guna2Panel1.TabIndex = 1;
            // 
            // lblKlinik
            // 
            this.lblKlinik.BackColor = System.Drawing.Color.Transparent;
            this.lblKlinik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rMKUNJUNGBindingSource, "VC_K_KLINIK", true));
            this.lblKlinik.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKlinik.ForeColor = System.Drawing.Color.White;
            this.lblKlinik.Location = new System.Drawing.Point(23, 402);
            this.lblKlinik.Name = "lblKlinik";
            this.lblKlinik.Size = new System.Drawing.Size(111, 32);
            this.lblKlinik.TabIndex = 5;
            this.lblKlinik.Text = "KodeKlinik";
            // 
            // lblkdokter
            // 
            this.lblkdokter.BackColor = System.Drawing.Color.Transparent;
            this.lblkdokter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rMKUNJUNGBindingSource, "VC_K_DOKTER", true));
            this.lblkdokter.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkdokter.ForeColor = System.Drawing.Color.White;
            this.lblkdokter.Location = new System.Drawing.Point(23, 364);
            this.lblkdokter.Name = "lblkdokter";
            this.lblkdokter.Size = new System.Drawing.Size(121, 32);
            this.lblkdokter.TabIndex = 4;
            this.lblkdokter.Text = "KodeDokter";
            // 
            // lblNoreg
            // 
            this.lblNoreg.BackColor = System.Drawing.Color.Transparent;
            this.lblNoreg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rMKUNJUNGBindingSource, "VC_NO_REGJ", true));
            this.lblNoreg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoreg.ForeColor = System.Drawing.Color.White;
            this.lblNoreg.Location = new System.Drawing.Point(23, 326);
            this.lblNoreg.Name = "lblNoreg";
            this.lblNoreg.Size = new System.Drawing.Size(83, 32);
            this.lblNoreg.TabIndex = 3;
            this.lblNoreg.Text = "No. Reg";
            // 
            // NamaPASIEN
            // 
            this.NamaPASIEN.BackColor = System.Drawing.Color.Transparent;
            this.NamaPASIEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rMKUNJUNGBindingSource, "vc_nama_p", true));
            this.NamaPASIEN.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaPASIEN.ForeColor = System.Drawing.Color.White;
            this.NamaPASIEN.Location = new System.Drawing.Point(23, 288);
            this.NamaPASIEN.Name = "NamaPASIEN";
            this.NamaPASIEN.Size = new System.Drawing.Size(61, 32);
            this.NamaPASIEN.TabIndex = 2;
            this.NamaPASIEN.Text = "Nama";
            // 
            // NoRM
            // 
            this.NoRM.BackColor = System.Drawing.Color.Transparent;
            this.NoRM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rMKUNJUNGBindingSource, "vc_no_rm", true));
            this.NoRM.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoRM.ForeColor = System.Drawing.Color.White;
            this.NoRM.Location = new System.Drawing.Point(23, 250);
            this.NoRM.Name = "NoRM";
            this.NoRM.Size = new System.Drawing.Size(73, 32);
            this.NoRM.TabIndex = 1;
            this.NoRM.Text = "No RM\r\n";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 19;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(23, 166);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Cari Pasien : Nama / No . RM";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(251, 41);
            this.guna2TextBox1.TabIndex = 0;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.guna2TextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2TextBox1_MouseDown);
            // 
            // LoadPanel
            // 
            this.LoadPanel.BackColor = System.Drawing.Color.Transparent;
            this.LoadPanel.Controls.Add(this.btnAddRx);
            this.LoadPanel.Controls.Add(this.btnGambar);
            this.LoadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadPanel.FillColor = System.Drawing.Color.White;
            this.LoadPanel.Location = new System.Drawing.Point(300, 0);
            this.LoadPanel.Name = "LoadPanel";
            this.LoadPanel.Radius = 18;
            this.LoadPanel.ShadowColor = System.Drawing.Color.Black;
            this.LoadPanel.Size = new System.Drawing.Size(842, 622);
            this.LoadPanel.TabIndex = 1;
            // 
            // btnAddRx
            // 
            this.btnAddRx.Animated = true;
            this.btnAddRx.AutoRoundedCorners = true;
            this.btnAddRx.BorderRadius = 26;
            this.btnAddRx.CheckedState.Parent = this.btnAddRx;
            this.btnAddRx.CustomImages.Parent = this.btnAddRx;
            this.btnAddRx.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddRx.ForeColor = System.Drawing.Color.White;
            this.btnAddRx.HoverState.Parent = this.btnAddRx;
            this.btnAddRx.Location = new System.Drawing.Point(290, 166);
            this.btnAddRx.Name = "btnAddRx";
            this.btnAddRx.ShadowDecoration.Parent = this.btnAddRx;
            this.btnAddRx.Size = new System.Drawing.Size(247, 55);
            this.btnAddRx.TabIndex = 1;
            this.btnAddRx.Text = "+    Add Prescription";
            this.btnAddRx.Click += new System.EventHandler(this.btnAddRx_Click);
            // 
            // rM_KUNJUNGTableAdapter
            // 
            this.rM_KUNJUNGTableAdapter.ClearBeforeFill = true;
            // 
            // vc_no_rm
            // 
            this.vc_no_rm.DataPropertyName = "vc_no_rm";
            this.vc_no_rm.HeaderText = "No. RM";
            this.vc_no_rm.Name = "vc_no_rm";
            this.vc_no_rm.ReadOnly = true;
            // 
            // vc_nama_p
            // 
            this.vc_nama_p.DataPropertyName = "vc_nama_p";
            this.vc_nama_p.HeaderText = "Nama";
            this.vc_nama_p.Name = "vc_nama_p";
            this.vc_nama_p.ReadOnly = true;
            // 
            // vc_jenis_k
            // 
            this.vc_jenis_k.DataPropertyName = "vc_jenis_k";
            this.vc_jenis_k.HeaderText = "Jns Kelamin";
            this.vc_jenis_k.Name = "vc_jenis_k";
            this.vc_jenis_k.ReadOnly = true;
            // 
            // in_umurth
            // 
            this.in_umurth.DataPropertyName = "in_umurth";
            this.in_umurth.HeaderText = "Umur";
            this.in_umurth.Name = "in_umurth";
            this.in_umurth.ReadOnly = true;
            // 
            // btnGambar
            // 
            this.btnGambar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnGambar.CheckedState.Parent = this.btnGambar;
            this.btnGambar.HoverState.Image = global::rse.app.desk.rx.lite.Properties.Resources.home;
            this.btnGambar.HoverState.ImageSize = new System.Drawing.Size(600, 750);
            this.btnGambar.HoverState.Parent = this.btnGambar;
            this.btnGambar.Image = global::rse.app.desk.rx.lite.Properties.Resources.home;
            this.btnGambar.ImageRotate = 0F;
            this.btnGambar.ImageSize = new System.Drawing.Size(600, 750);
            this.btnGambar.IndicateFocus = true;
            this.btnGambar.Location = new System.Drawing.Point(177, 12);
            this.btnGambar.Name = "btnGambar";
            this.btnGambar.PressedState.Image = global::rse.app.desk.rx.lite.Properties.Resources.home;
            this.btnGambar.PressedState.ImageSize = new System.Drawing.Size(600, 750);
            this.btnGambar.PressedState.Parent = this.btnGambar;
            this.btnGambar.Size = new System.Drawing.Size(479, 598);
            this.btnGambar.TabIndex = 2;
            // 
            // Eprescribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 622);
            this.Controls.Add(this.LoadPanel);
            this.Controls.Add(this.NavPanel);
            this.Name = "Eprescribe";
            this.Text = "Eprescribe";
            this.Load += new System.EventHandler(this.Eprescribe_Load);
            this.NavPanel.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMKUNJUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.LoadPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel NavPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel LoadPanel;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.BindingSource yakkumdbBindingSource;
        private dataset.yakkumdb yakkumdb;
        private System.Windows.Forms.BindingSource rMKUNJUNGBindingSource;
        private dataset.yakkumdbTableAdapters.RM_KUNJUNGTableAdapter rM_KUNJUNGTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel NoRM;
        private Guna.UI2.WinForms.Guna2HtmlLabel NamaPASIEN;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblkdokter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNoreg;
        private Guna.UI2.WinForms.Guna2Button btnAddRx;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblKlinik;
        private System.Windows.Forms.DataGridViewTextBoxColumn vc_no_rm;
        private System.Windows.Forms.DataGridViewTextBoxColumn vc_nama_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn vc_jenis_k;
        private System.Windows.Forms.DataGridViewTextBoxColumn in_umurth;
        private Guna.UI2.WinForms.Guna2ImageButton btnGambar;
    }
}

