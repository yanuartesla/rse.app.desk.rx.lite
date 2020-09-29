namespace rse.app.desk.rx.lite.UI
{
    partial class obat
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
            this.txtCariObat = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvResep = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKodeRtx = new System.Windows.Forms.Label();
            this.vckoderxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vckoderxdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vckodeobatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vckoderacikanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btracikanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numdd1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numdd2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcsignalainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btiterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numjmliterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btfavDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsResepdetail = new System.Windows.Forms.BindingSource(this.components);
            this.yakkumdb = new rse.app.desk.rx.lite.dataset.yakkumdb();
            this.bsObat = new System.Windows.Forms.BindingSource(this.components);
            this.view_rse_fa_obatTableAdapter = new rse.app.desk.rx.lite.dataset.yakkumdbTableAdapters.view_rse_fa_obatTableAdapter();
            this.fa_rx_resep_dTableAdapter = new rse.app.desk.rx.lite.dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResep)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsResepdetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCariObat
            // 
            this.txtCariObat.AutoRoundedCorners = true;
            this.txtCariObat.BorderRadius = 18;
            this.txtCariObat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariObat.DefaultText = "";
            this.txtCariObat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCariObat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCariObat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariObat.DisabledState.Parent = this.txtCariObat;
            this.txtCariObat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCariObat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariObat.FocusedState.Parent = this.txtCariObat;
            this.txtCariObat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCariObat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCariObat.HoverState.Parent = this.txtCariObat;
            this.txtCariObat.Location = new System.Drawing.Point(0, 32);
            this.txtCariObat.Name = "txtCariObat";
            this.txtCariObat.PasswordChar = '\0';
            this.txtCariObat.PlaceholderText = "Cari Obat";
            this.txtCariObat.SelectedText = "";
            this.txtCariObat.ShadowDecoration.Parent = this.txtCariObat;
            this.txtCariObat.Size = new System.Drawing.Size(360, 38);
            this.txtCariObat.TabIndex = 0;
            this.txtCariObat.TextChanged += new System.EventHandler(this.txtCariObat_TextChanged);
            this.txtCariObat.Load += new System.EventHandler(this.txtCariObat_Load);
            this.txtCariObat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCariObat_KeyDown);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(70, 506);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(70, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(807, 506);
            this.guna2Panel2.TabIndex = 2;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.panel2);
            this.guna2Panel4.Controls.Add(this.panel1);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 115);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(807, 391);
            this.guna2Panel4.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.dgvResep);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(613, 391);
            this.panel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 339);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(613, 52);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // dgvResep
            // 
            this.dgvResep.AllowUserToAddRows = false;
            this.dgvResep.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvResep.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResep.AutoGenerateColumns = false;
            this.dgvResep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResep.BackgroundColor = System.Drawing.Color.White;
            this.dgvResep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvResep.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResep.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResep.ColumnHeadersHeight = 4;
            this.dgvResep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vckoderxDataGridViewTextBoxColumn,
            this.vckoderxdDataGridViewTextBoxColumn,
            this.vckodeobatDataGridViewTextBoxColumn,
            this.vckoderacikanDataGridViewTextBoxColumn,
            this.btracikanDataGridViewCheckBoxColumn,
            this.numdd1DataGridViewTextBoxColumn,
            this.numdd2DataGridViewTextBoxColumn,
            this.vcsignalainDataGridViewTextBoxColumn,
            this.btiterDataGridViewCheckBoxColumn,
            this.numjmliterDataGridViewTextBoxColumn,
            this.btfavDataGridViewCheckBoxColumn});
            this.dgvResep.DataSource = this.bsResepdetail;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResep.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResep.EnableHeadersVisualStyles = false;
            this.dgvResep.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvResep.Location = new System.Drawing.Point(0, 0);
            this.dgvResep.Name = "dgvResep";
            this.dgvResep.ReadOnly = true;
            this.dgvResep.RowHeadersVisible = false;
            this.dgvResep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResep.Size = new System.Drawing.Size(613, 391);
            this.dgvResep.TabIndex = 1;
            this.dgvResep.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvResep.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvResep.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvResep.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvResep.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvResep.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvResep.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvResep.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvResep.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvResep.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvResep.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvResep.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvResep.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvResep.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvResep.ThemeStyle.ReadOnly = true;
            this.dgvResep.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvResep.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResep.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvResep.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvResep.ThemeStyle.RowsStyle.Height = 22;
            this.dgvResep.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvResep.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(613, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 391);
            this.panel1.TabIndex = 2;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.lblKodeRtx);
            this.guna2Panel3.Controls.Add(this.txtCariObat);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(807, 115);
            this.guna2Panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "No. Resep :";
            // 
            // lblKodeRtx
            // 
            this.lblKodeRtx.AutoSize = true;
            this.lblKodeRtx.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKodeRtx.Location = new System.Drawing.Point(93, 86);
            this.lblKodeRtx.Name = "lblKodeRtx";
            this.lblKodeRtx.Size = new System.Drawing.Size(13, 16);
            this.lblKodeRtx.TabIndex = 1;
            this.lblKodeRtx.Text = "-";
            // 
            // vckoderxDataGridViewTextBoxColumn
            // 
            this.vckoderxDataGridViewTextBoxColumn.DataPropertyName = "vc_kode_rx";
            this.vckoderxDataGridViewTextBoxColumn.HeaderText = "vc_kode_rx";
            this.vckoderxDataGridViewTextBoxColumn.Name = "vckoderxDataGridViewTextBoxColumn";
            this.vckoderxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vckoderxdDataGridViewTextBoxColumn
            // 
            this.vckoderxdDataGridViewTextBoxColumn.DataPropertyName = "vc_kode_rx_d";
            this.vckoderxdDataGridViewTextBoxColumn.HeaderText = "vc_kode_rx_d";
            this.vckoderxdDataGridViewTextBoxColumn.Name = "vckoderxdDataGridViewTextBoxColumn";
            this.vckoderxdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vckodeobatDataGridViewTextBoxColumn
            // 
            this.vckodeobatDataGridViewTextBoxColumn.DataPropertyName = "vc_kode_obat";
            this.vckodeobatDataGridViewTextBoxColumn.HeaderText = "vc_kode_obat";
            this.vckodeobatDataGridViewTextBoxColumn.Name = "vckodeobatDataGridViewTextBoxColumn";
            this.vckodeobatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vckoderacikanDataGridViewTextBoxColumn
            // 
            this.vckoderacikanDataGridViewTextBoxColumn.DataPropertyName = "vc_kode_racikan";
            this.vckoderacikanDataGridViewTextBoxColumn.HeaderText = "vc_kode_racikan";
            this.vckoderacikanDataGridViewTextBoxColumn.Name = "vckoderacikanDataGridViewTextBoxColumn";
            this.vckoderacikanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btracikanDataGridViewCheckBoxColumn
            // 
            this.btracikanDataGridViewCheckBoxColumn.DataPropertyName = "bt_racikan";
            this.btracikanDataGridViewCheckBoxColumn.HeaderText = "bt_racikan";
            this.btracikanDataGridViewCheckBoxColumn.Name = "btracikanDataGridViewCheckBoxColumn";
            this.btracikanDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // numdd1DataGridViewTextBoxColumn
            // 
            this.numdd1DataGridViewTextBoxColumn.DataPropertyName = "num_dd1";
            this.numdd1DataGridViewTextBoxColumn.HeaderText = "num_dd1";
            this.numdd1DataGridViewTextBoxColumn.Name = "numdd1DataGridViewTextBoxColumn";
            this.numdd1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numdd2DataGridViewTextBoxColumn
            // 
            this.numdd2DataGridViewTextBoxColumn.DataPropertyName = "num_dd2";
            this.numdd2DataGridViewTextBoxColumn.HeaderText = "num_dd2";
            this.numdd2DataGridViewTextBoxColumn.Name = "numdd2DataGridViewTextBoxColumn";
            this.numdd2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vcsignalainDataGridViewTextBoxColumn
            // 
            this.vcsignalainDataGridViewTextBoxColumn.DataPropertyName = "vc_signalain";
            this.vcsignalainDataGridViewTextBoxColumn.HeaderText = "vc_signalain";
            this.vcsignalainDataGridViewTextBoxColumn.Name = "vcsignalainDataGridViewTextBoxColumn";
            this.vcsignalainDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btiterDataGridViewCheckBoxColumn
            // 
            this.btiterDataGridViewCheckBoxColumn.DataPropertyName = "bt_iter";
            this.btiterDataGridViewCheckBoxColumn.HeaderText = "bt_iter";
            this.btiterDataGridViewCheckBoxColumn.Name = "btiterDataGridViewCheckBoxColumn";
            this.btiterDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // numjmliterDataGridViewTextBoxColumn
            // 
            this.numjmliterDataGridViewTextBoxColumn.DataPropertyName = "num_jmliter";
            this.numjmliterDataGridViewTextBoxColumn.HeaderText = "num_jmliter";
            this.numjmliterDataGridViewTextBoxColumn.Name = "numjmliterDataGridViewTextBoxColumn";
            this.numjmliterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btfavDataGridViewCheckBoxColumn
            // 
            this.btfavDataGridViewCheckBoxColumn.DataPropertyName = "bt_fav";
            this.btfavDataGridViewCheckBoxColumn.HeaderText = "bt_fav";
            this.btfavDataGridViewCheckBoxColumn.Name = "btfavDataGridViewCheckBoxColumn";
            this.btfavDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bsResepdetail
            // 
            this.bsResepdetail.DataMember = "fa_rx_resep_d";
            this.bsResepdetail.DataSource = this.yakkumdb;
            // 
            // yakkumdb
            // 
            this.yakkumdb.DataSetName = "yakkumdb";
            this.yakkumdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsObat
            // 
            this.bsObat.DataMember = "view_rse_fa_obat";
            this.bsObat.DataSource = this.yakkumdb;
            // 
            // view_rse_fa_obatTableAdapter
            // 
            this.view_rse_fa_obatTableAdapter.ClearBeforeFill = true;
            // 
            // fa_rx_resep_dTableAdapter
            // 
            this.fa_rx_resep_dTableAdapter.ClearBeforeFill = true;
            // 
            // obat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "obat";
            this.Size = new System.Drawing.Size(877, 506);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResep)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsResepdetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCariObat;
        private System.Windows.Forms.BindingSource bsObat;
        private dataset.yakkumdb yakkumdb;
        private dataset.yakkumdbTableAdapters.view_rse_fa_obatTableAdapter view_rse_fa_obatTableAdapter;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvResep;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label lblKodeRtx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsResepdetail;
        private dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter fa_rx_resep_dTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vckoderxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vckoderxdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vckodeobatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vckoderacikanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btracikanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numdd1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numdd2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcsignalainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btiterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numjmliterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn btfavDataGridViewCheckBoxColumn;
    }
}
