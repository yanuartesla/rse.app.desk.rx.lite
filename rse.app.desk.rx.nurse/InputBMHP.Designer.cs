namespace rse.app.desk.rx.nurse
{
    partial class InputBMHP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcariBMHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvTindakan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tindakan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvBMHP = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.bsBMHP = new System.Windows.Forms.BindingSource(this.components);
            this.yakkumdb = new rse.app.desk.rx.nurse.yakkumdb();
            this.vcnoresepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcnamatindakanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bstindakan = new System.Windows.Forms.BindingSource(this.components);
            this.bsResepWaiting = new System.Windows.Forms.BindingSource(this.components);
            this.bmhpTableAdapter = new rse.app.desk.rx.nurse.yakkumdbTableAdapters.bmhpTableAdapter();
            this.fa_rx_tindakanTableAdapter = new rse.app.desk.rx.nurse.yakkumdbTableAdapters.fa_rx_tindakanTableAdapter();
            this.resep_waitingTableAdapter = new rse.app.desk.rx.nurse.yakkumdbTableAdapters.resep_waitingTableAdapter();
            this.nomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcnamaobatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numjmlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcsatuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vc_kode_rx_d = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vc_kode_rx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTindakan)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBMHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBMHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstindakan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResepWaiting)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txtcariBMHP);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(714, 142);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsResepWaiting, "vc_no_rm", true));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Indigo;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(16, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(99, 39);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "No. RM";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsResepWaiting, "dokter", true));
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Indigo;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(17, 61);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(132, 32);
            this.guna2HtmlLabel3.TabIndex = 5;
            this.guna2HtmlLabel3.Text = "Nama Dokter";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsResepWaiting, "vc_nama_Peserta", true));
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Indigo;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(16, 33);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(145, 34);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Nama Pasien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(51, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cari BMHP :";
            // 
            // txtcariBMHP
            // 
            this.txtcariBMHP.Animated = true;
            this.txtcariBMHP.AutoRoundedCorners = true;
            this.txtcariBMHP.BorderRadius = 17;
            this.txtcariBMHP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcariBMHP.DefaultText = "";
            this.txtcariBMHP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcariBMHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcariBMHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcariBMHP.DisabledState.Parent = this.txtcariBMHP;
            this.txtcariBMHP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcariBMHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcariBMHP.FocusedState.Parent = this.txtcariBMHP;
            this.txtcariBMHP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcariBMHP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcariBMHP.HoverState.Parent = this.txtcariBMHP;
            this.txtcariBMHP.Location = new System.Drawing.Point(153, 97);
            this.txtcariBMHP.Name = "txtcariBMHP";
            this.txtcariBMHP.PasswordChar = '\0';
            this.txtcariBMHP.PlaceholderText = "Cari BMHP";
            this.txtcariBMHP.SelectedText = "";
            this.txtcariBMHP.ShadowDecoration.Parent = this.txtcariBMHP;
            this.txtcariBMHP.Size = new System.Drawing.Size(431, 36);
            this.txtcariBMHP.TabIndex = 0;
            this.txtcariBMHP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcariBMHP_KeyDown);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.dgvTindakan);
            this.guna2Panel2.Controls.Add(this.guna2ShadowPanel1);
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 414);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(714, 177);
            this.guna2Panel2.TabIndex = 1;
            // 
            // dgvTindakan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTindakan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTindakan.AutoGenerateColumns = false;
            this.dgvTindakan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTindakan.BackgroundColor = System.Drawing.Color.White;
            this.dgvTindakan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTindakan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTindakan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTindakan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTindakan.ColumnHeadersHeight = 21;
            this.dgvTindakan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.tindakan,
            this.vcnoresepDataGridViewTextBoxColumn,
            this.vcnamatindakanDataGridViewTextBoxColumn});
            this.dgvTindakan.DataSource = this.bstindakan;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTindakan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTindakan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTindakan.EnableHeadersVisualStyles = false;
            this.dgvTindakan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTindakan.Location = new System.Drawing.Point(0, 55);
            this.dgvTindakan.Name = "dgvTindakan";
            this.dgvTindakan.RowHeadersVisible = false;
            this.dgvTindakan.RowTemplate.Height = 25;
            this.dgvTindakan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTindakan.Size = new System.Drawing.Size(506, 122);
            this.dgvTindakan.TabIndex = 1;
            this.dgvTindakan.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvTindakan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTindakan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTindakan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTindakan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTindakan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTindakan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTindakan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTindakan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTindakan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTindakan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTindakan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTindakan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTindakan.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvTindakan.ThemeStyle.ReadOnly = false;
            this.dgvTindakan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTindakan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTindakan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTindakan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTindakan.ThemeStyle.RowsStyle.Height = 25;
            this.dgvTindakan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTindakan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTindakan.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvTindakan_EditingControlShowing);
            this.dgvTindakan.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTindakan_RowPostPaint);
            // 
            // no
            // 
            this.no.FillWeight = 15F;
            this.no.HeaderText = "No.";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // tindakan
            // 
            this.tindakan.DataPropertyName = "vc_nama_tindakan";
            this.tindakan.HeaderText = "Nama Tindakan";
            this.tindakan.Name = "tindakan";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(506, 55);
            this.guna2ShadowPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GhostWhite;
            this.label3.Location = new System.Drawing.Point(214, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "( Isikan di Kolom Nama Tindakan )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Masukan Jenis Tindakan";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.btnSimpan);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel4.Location = new System.Drawing.Point(506, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(208, 177);
            this.guna2Panel4.TabIndex = 1;
            // 
            // btnSimpan
            // 
            this.btnSimpan.AutoRoundedCorners = true;
            this.btnSimpan.BorderRadius = 21;
            this.btnSimpan.CheckedState.Parent = this.btnSimpan;
            this.btnSimpan.CustomImages.Parent = this.btnSimpan;
            this.btnSimpan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSimpan.ForeColor = System.Drawing.Color.White;
            this.btnSimpan.HoverState.Parent = this.btnSimpan;
            this.btnSimpan.Location = new System.Drawing.Point(13, 62);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.ShadowDecoration.Parent = this.btnSimpan;
            this.btnSimpan.Size = new System.Drawing.Size(180, 45);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.dgvBMHP);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 142);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(714, 272);
            this.guna2Panel3.TabIndex = 2;
            // 
            // dgvBMHP
            // 
            this.dgvBMHP.AllowUserToAddRows = false;
            this.dgvBMHP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvBMHP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBMHP.AutoGenerateColumns = false;
            this.dgvBMHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBMHP.BackgroundColor = System.Drawing.Color.White;
            this.dgvBMHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBMHP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBMHP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBMHP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBMHP.ColumnHeadersHeight = 30;
            this.dgvBMHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomor,
            this.vcnamaobatDataGridViewTextBoxColumn,
            this.numjmlDataGridViewTextBoxColumn,
            this.vcsatuanDataGridViewTextBoxColumn,
            this.delete,
            this.vc_kode_rx_d,
            this.vc_kode_rx});
            this.dgvBMHP.DataSource = this.bsBMHP;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBMHP.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBMHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBMHP.EnableHeadersVisualStyles = false;
            this.dgvBMHP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBMHP.Location = new System.Drawing.Point(0, 0);
            this.dgvBMHP.Name = "dgvBMHP";
            this.dgvBMHP.ReadOnly = true;
            this.dgvBMHP.RowHeadersVisible = false;
            this.dgvBMHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBMHP.Size = new System.Drawing.Size(714, 272);
            this.dgvBMHP.TabIndex = 0;
            this.dgvBMHP.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvBMHP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBMHP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBMHP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBMHP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBMHP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBMHP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBMHP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBMHP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBMHP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBMHP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBMHP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBMHP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBMHP.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvBMHP.ThemeStyle.ReadOnly = true;
            this.dgvBMHP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBMHP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBMHP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvBMHP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBMHP.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBMHP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBMHP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBMHP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBMHP_CellClick);
            this.dgvBMHP.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvBMHP_CellPainting);
            this.dgvBMHP.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBMHP_RowPostPaint);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this.dgvTindakan;
            // 
            // bsBMHP
            // 
            this.bsBMHP.DataMember = "bmhp";
            this.bsBMHP.DataSource = this.yakkumdb;
            // 
            // yakkumdb
            // 
            this.yakkumdb.DataSetName = "yakkumdb";
            this.yakkumdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vcnoresepDataGridViewTextBoxColumn
            // 
            this.vcnoresepDataGridViewTextBoxColumn.DataPropertyName = "vc_no_resep";
            this.vcnoresepDataGridViewTextBoxColumn.HeaderText = "vc_no_resep";
            this.vcnoresepDataGridViewTextBoxColumn.Name = "vcnoresepDataGridViewTextBoxColumn";
            this.vcnoresepDataGridViewTextBoxColumn.Visible = false;
            // 
            // vcnamatindakanDataGridViewTextBoxColumn
            // 
            this.vcnamatindakanDataGridViewTextBoxColumn.DataPropertyName = "vc_nama_tindakan";
            this.vcnamatindakanDataGridViewTextBoxColumn.HeaderText = "vc_nama_tindakan";
            this.vcnamatindakanDataGridViewTextBoxColumn.Name = "vcnamatindakanDataGridViewTextBoxColumn";
            this.vcnamatindakanDataGridViewTextBoxColumn.Visible = false;
            // 
            // bstindakan
            // 
            this.bstindakan.DataMember = "fa_rx_tindakan";
            this.bstindakan.DataSource = this.yakkumdb;
            // 
            // bsResepWaiting
            // 
            this.bsResepWaiting.DataMember = "resep_waiting";
            this.bsResepWaiting.DataSource = this.yakkumdb;
            // 
            // bmhpTableAdapter
            // 
            this.bmhpTableAdapter.ClearBeforeFill = true;
            // 
            // fa_rx_tindakanTableAdapter
            // 
            this.fa_rx_tindakanTableAdapter.ClearBeforeFill = true;
            // 
            // resep_waitingTableAdapter
            // 
            this.resep_waitingTableAdapter.ClearBeforeFill = true;
            // 
            // nomor
            // 
            this.nomor.FillWeight = 22.25254F;
            this.nomor.HeaderText = "No.";
            this.nomor.Name = "nomor";
            this.nomor.ReadOnly = true;
            // 
            // vcnamaobatDataGridViewTextBoxColumn
            // 
            this.vcnamaobatDataGridViewTextBoxColumn.DataPropertyName = "vc_nama_obat";
            this.vcnamaobatDataGridViewTextBoxColumn.FillWeight = 111.2627F;
            this.vcnamaobatDataGridViewTextBoxColumn.HeaderText = "Nama Alkes";
            this.vcnamaobatDataGridViewTextBoxColumn.Name = "vcnamaobatDataGridViewTextBoxColumn";
            this.vcnamaobatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numjmlDataGridViewTextBoxColumn
            // 
            this.numjmlDataGridViewTextBoxColumn.DataPropertyName = "num_jml";
            this.numjmlDataGridViewTextBoxColumn.FillWeight = 111.2627F;
            this.numjmlDataGridViewTextBoxColumn.HeaderText = "Jumlah";
            this.numjmlDataGridViewTextBoxColumn.Name = "numjmlDataGridViewTextBoxColumn";
            this.numjmlDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vcsatuanDataGridViewTextBoxColumn
            // 
            this.vcsatuanDataGridViewTextBoxColumn.DataPropertyName = "vc_satuan";
            this.vcsatuanDataGridViewTextBoxColumn.FillWeight = 111.2627F;
            this.vcsatuanDataGridViewTextBoxColumn.HeaderText = "Satuan";
            this.vcsatuanDataGridViewTextBoxColumn.Name = "vcsatuanDataGridViewTextBoxColumn";
            this.vcsatuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 30F;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.ToolTipText = "Delete BMHP";
            // 
            // vc_kode_rx_d
            // 
            this.vc_kode_rx_d.DataPropertyName = "vc_kode_rx_d";
            this.vc_kode_rx_d.HeaderText = "vc_kode_rx_d";
            this.vc_kode_rx_d.Name = "vc_kode_rx_d";
            this.vc_kode_rx_d.ReadOnly = true;
            this.vc_kode_rx_d.Visible = false;
            // 
            // vc_kode_rx
            // 
            this.vc_kode_rx.DataPropertyName = "vc_kode_rx";
            this.vc_kode_rx.HeaderText = "vc_kode_rx";
            this.vc_kode_rx.Name = "vc_kode_rx";
            this.vc_kode_rx.ReadOnly = true;
            this.vc_kode_rx.Visible = false;
            // 
            // InputBMHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "InputBMHP";
            this.Size = new System.Drawing.Size(714, 591);
            this.Load += new System.EventHandler(this.InputBMHP_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTindakan)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBMHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBMHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bstindakan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResepWaiting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtcariBMHP;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBMHP;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private System.Windows.Forms.BindingSource bsBMHP;
        private yakkumdb yakkumdb;
        private yakkumdbTableAdapters.bmhpTableAdapter bmhpTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTindakan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.BindingSource bstindakan;
        private yakkumdbTableAdapters.fa_rx_tindakanTableAdapter fa_rx_tindakanTableAdapter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.BindingSource bsResepWaiting;
        private yakkumdbTableAdapters.resep_waitingTableAdapter resep_waitingTableAdapter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn tindakan;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcnoresepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcnamatindakanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcnamaobatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numjmlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcsatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn vc_kode_rx_d;
        private System.Windows.Forms.DataGridViewTextBoxColumn vc_kode_rx;
    }
}
