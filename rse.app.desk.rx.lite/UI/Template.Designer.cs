
namespace rse.app.desk.rx.lite.UI
{
    partial class Template
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Template));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.txtNama = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSimpan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvProcedure = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nomor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCariProsedur = new rse.app.desk.rx.lite.Function.MultiLineAutoCompleteTextBox();
            this.dgvDiagnosa = new Guna.UI2.WinForms.Guna2DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icdcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrimary = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCariDiagnosa = new rse.app.desk.rx.lite.Function.MultiLineAutoCompleteTextBox();
            this.bsICD10 = new System.Windows.Forms.BindingSource(this.components);
            this.yakkumdb = new rse.app.desk.rx.lite.dataset.yakkumdb();
            this.iCD10_2019_CodesTableAdapter = new rse.app.desk.rx.lite.dataset.yakkumdbTableAdapters.ICD10_2019_CodesTableAdapter();
            this.bsICD9 = new System.Windows.Forms.BindingSource(this.components);
            this.iCD9_CM_2011_Procedure_CodesTableAdapter = new rse.app.desk.rx.lite.dataset.yakkumdbTableAdapters.ICD9_CM_2011_Procedure_CodesTableAdapter();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsICD10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsICD9)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 12;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.btnClose);
            this.guna2CustomGradientPanel1.Controls.Add(this.txtNama);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(739, 82);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // txtNama
            // 
            this.txtNama.AutoRoundedCorners = true;
            this.txtNama.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNama.BorderRadius = 13;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.DefaultText = "";
            this.txtNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.DisabledState.Parent = this.txtNama;
            this.txtNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNama.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.FocusedState.Parent = this.txtNama;
            this.txtNama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNama.HoverState.Parent = this.txtNama;
            this.txtNama.Location = new System.Drawing.Point(10, 43);
            this.txtNama.Name = "txtNama";
            this.txtNama.PasswordChar = '\0';
            this.txtNama.PlaceholderText = "Nama Template";
            this.txtNama.SelectedText = "";
            this.txtNama.ShadowDecoration.Parent = this.txtNama;
            this.txtNama.Size = new System.Drawing.Size(719, 29);
            this.txtNama.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(10, 3);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(92, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Template";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnSimpan);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 412);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(739, 55);
            this.guna2Panel1.TabIndex = 1;
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
            this.btnSimpan.Location = new System.Drawing.Point(288, 3);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.ShadowDecoration.Parent = this.btnSimpan;
            this.btnSimpan.Size = new System.Drawing.Size(180, 45);
            this.btnSimpan.TabIndex = 0;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel2.Controls.Add(this.dgvProcedure);
            this.guna2Panel2.Controls.Add(this.txtCariProsedur);
            this.guna2Panel2.Controls.Add(this.dgvDiagnosa);
            this.guna2Panel2.Controls.Add(this.txtCariDiagnosa);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 82);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(15);
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(739, 330);
            this.guna2Panel2.TabIndex = 2;
            // 
            // dgvProcedure
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvProcedure.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProcedure.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProcedure.BackgroundColor = System.Drawing.Color.White;
            this.dgvProcedure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProcedure.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProcedure.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProcedure.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProcedure.ColumnHeadersHeight = 25;
            this.dgvProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProcedure.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomor,
            this.code,
            this.desc,
            this.btnDel});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProcedure.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProcedure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProcedure.EnableHeadersVisualStyles = false;
            this.dgvProcedure.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProcedure.Location = new System.Drawing.Point(15, 240);
            this.dgvProcedure.Name = "dgvProcedure";
            this.dgvProcedure.ReadOnly = true;
            this.dgvProcedure.RowHeadersVisible = false;
            this.dgvProcedure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProcedure.Size = new System.Drawing.Size(709, 75);
            this.dgvProcedure.TabIndex = 4;
            this.dgvProcedure.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvProcedure.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProcedure.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProcedure.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProcedure.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProcedure.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProcedure.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProcedure.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProcedure.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProcedure.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProcedure.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProcedure.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProcedure.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProcedure.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvProcedure.ThemeStyle.ReadOnly = true;
            this.dgvProcedure.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProcedure.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProcedure.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProcedure.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProcedure.ThemeStyle.RowsStyle.Height = 22;
            this.dgvProcedure.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProcedure.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProcedure.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProcedure_CellClick);
            this.dgvProcedure.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvProcedure_CellPainting);
            this.dgvProcedure.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvProcedure_RowPostPaint);
            // 
            // nomor
            // 
            this.nomor.FillWeight = 25F;
            this.nomor.HeaderText = "No.";
            this.nomor.Name = "nomor";
            this.nomor.ReadOnly = true;
            // 
            // code
            // 
            this.code.FillWeight = 50F;
            this.code.HeaderText = "Code";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // desc
            // 
            this.desc.HeaderText = "Description";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // btnDel
            // 
            this.btnDel.FillWeight = 20F;
            this.btnDel.HeaderText = "Delete";
            this.btnDel.Name = "btnDel";
            this.btnDel.ReadOnly = true;
            // 
            // txtCariProsedur
            // 
            this.txtCariProsedur.AutoRoundedCorners = true;
            this.txtCariProsedur.BorderRadius = 14;
            this.txtCariProsedur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariProsedur.DefaultText = "";
            this.txtCariProsedur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariProsedur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariProsedur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariProsedur.DisabledState.Parent = this.txtCariProsedur;
            this.txtCariProsedur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariProsedur.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCariProsedur.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariProsedur.FocusedState.Parent = this.txtCariProsedur;
            this.txtCariProsedur.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCariProsedur.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariProsedur.HoverState.Parent = this.txtCariProsedur;
            this.txtCariProsedur.Location = new System.Drawing.Point(15, 210);
            this.txtCariProsedur.Name = "txtCariProsedur";
            this.txtCariProsedur.PasswordChar = '\0';
            this.txtCariProsedur.PlaceholderText = "Cari Prosedur / Tindakan Medis";
            this.txtCariProsedur.SelectedText = "";
            this.txtCariProsedur.ShadowDecoration.Parent = this.txtCariProsedur;
            this.txtCariProsedur.Size = new System.Drawing.Size(709, 30);
            this.txtCariProsedur.TabIndex = 5;
            this.txtCariProsedur.Values = null;
            this.txtCariProsedur.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCariProsedur_KeyDown);
            // 
            // dgvDiagnosa
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.dgvDiagnosa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDiagnosa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiagnosa.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiagnosa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiagnosa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiagnosa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiagnosa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDiagnosa.ColumnHeadersHeight = 25;
            this.dgvDiagnosa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiagnosa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.icdcode,
            this.code_desc,
            this.btnPrimary,
            this.btnDelete});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiagnosa.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDiagnosa.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDiagnosa.EnableHeadersVisualStyles = false;
            this.dgvDiagnosa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.dgvDiagnosa.Location = new System.Drawing.Point(15, 45);
            this.dgvDiagnosa.Name = "dgvDiagnosa";
            this.dgvDiagnosa.ReadOnly = true;
            this.dgvDiagnosa.RowHeadersVisible = false;
            this.dgvDiagnosa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnosa.Size = new System.Drawing.Size(709, 165);
            this.dgvDiagnosa.TabIndex = 3;
            this.dgvDiagnosa.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.DeepPurple;
            this.dgvDiagnosa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(196)))), ((int)(((byte)(233)))));
            this.dgvDiagnosa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDiagnosa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDiagnosa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDiagnosa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDiagnosa.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiagnosa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(193)))), ((int)(((byte)(232)))));
            this.dgvDiagnosa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.dgvDiagnosa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDiagnosa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiagnosa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiagnosa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiagnosa.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvDiagnosa.ThemeStyle.ReadOnly = true;
            this.dgvDiagnosa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(240)))));
            this.dgvDiagnosa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiagnosa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDiagnosa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDiagnosa.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDiagnosa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(123)))), ((int)(((byte)(207)))));
            this.dgvDiagnosa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDiagnosa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosa_CellClick);
            this.dgvDiagnosa.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvDiagnosa_CellPainting);
            this.dgvDiagnosa.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDiagnosa_RowPostPaint);
            // 
            // no
            // 
            this.no.FillWeight = 20F;
            this.no.HeaderText = "No";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // icdcode
            // 
            this.icdcode.FillWeight = 20F;
            this.icdcode.HeaderText = "Code";
            this.icdcode.Name = "icdcode";
            this.icdcode.ReadOnly = true;
            // 
            // code_desc
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.code_desc.DefaultCellStyle = dataGridViewCellStyle13;
            this.code_desc.HeaderText = "Description";
            this.code_desc.Name = "code_desc";
            this.code_desc.ReadOnly = true;
            // 
            // btnPrimary
            // 
            this.btnPrimary.FillWeight = 25F;
            this.btnPrimary.HeaderText = "Primary";
            this.btnPrimary.Name = "btnPrimary";
            this.btnPrimary.ReadOnly = true;
            this.btnPrimary.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnPrimary.Text = "Set Primary";
            // 
            // btnDelete
            // 
            this.btnDelete.FillWeight = 15F;
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            // 
            // txtCariDiagnosa
            // 
            this.txtCariDiagnosa.AutoRoundedCorners = true;
            this.txtCariDiagnosa.BorderRadius = 14;
            this.txtCariDiagnosa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariDiagnosa.DefaultText = "";
            this.txtCariDiagnosa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariDiagnosa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariDiagnosa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariDiagnosa.DisabledState.Parent = this.txtCariDiagnosa;
            this.txtCariDiagnosa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariDiagnosa.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCariDiagnosa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariDiagnosa.FocusedState.Parent = this.txtCariDiagnosa;
            this.txtCariDiagnosa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCariDiagnosa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariDiagnosa.HoverState.Parent = this.txtCariDiagnosa;
            this.txtCariDiagnosa.Location = new System.Drawing.Point(15, 15);
            this.txtCariDiagnosa.Name = "txtCariDiagnosa";
            this.txtCariDiagnosa.PasswordChar = '\0';
            this.txtCariDiagnosa.PlaceholderText = "Cari Diagnosa";
            this.txtCariDiagnosa.SelectedText = "";
            this.txtCariDiagnosa.ShadowDecoration.Parent = this.txtCariDiagnosa;
            this.txtCariDiagnosa.Size = new System.Drawing.Size(709, 30);
            this.txtCariDiagnosa.TabIndex = 2;
            this.txtCariDiagnosa.Values = null;
            this.txtCariDiagnosa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCariDiagnosa_KeyDown);
            // 
            // bsICD10
            // 
            this.bsICD10.DataMember = "ICD10_2019_Codes";
            this.bsICD10.DataSource = this.yakkumdb;
            // 
            // yakkumdb
            // 
            this.yakkumdb.DataSetName = "yakkumdb";
            this.yakkumdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iCD10_2019_CodesTableAdapter
            // 
            this.iCD10_2019_CodesTableAdapter.ClearBeforeFill = true;
            // 
            // bsICD9
            // 
            this.bsICD9.DataMember = "ICD9_CM_2011_Procedure_Codes";
            this.bsICD9.DataSource = this.yakkumdb;
            // 
            // iCD9_CM_2011_Procedure_CodesTableAdapter
            // 
            this.iCD9_CM_2011_Procedure_CodesTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.HoverState.Image")));
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::rse.app.desk.rx.lite.Properties.Resources.x_mark__3_;
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(694, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.PressedState.Image")));
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(45, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 467);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Template";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Template";
            this.Load += new System.EventHandler(this.Template_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcedure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsICD10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsICD9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnSimpan;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDiagnosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn icdcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn code_desc;
        private System.Windows.Forms.DataGridViewButtonColumn btnPrimary;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
        private Function.MultiLineAutoCompleteTextBox txtCariDiagnosa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProcedure;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomor;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewButtonColumn btnDel;
        private Function.MultiLineAutoCompleteTextBox txtCariProsedur;
        private System.Windows.Forms.BindingSource bsICD10;
        private dataset.yakkumdb yakkumdb;
        private dataset.yakkumdbTableAdapters.ICD10_2019_CodesTableAdapter iCD10_2019_CodesTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox txtNama;
        private System.Windows.Forms.BindingSource bsICD9;
        private dataset.yakkumdbTableAdapters.ICD9_CM_2011_Procedure_CodesTableAdapter iCD9_CM_2011_Procedure_CodesTableAdapter;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
    }
}