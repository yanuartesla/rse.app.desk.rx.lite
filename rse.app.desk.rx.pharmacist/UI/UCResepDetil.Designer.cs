namespace rse.app.desk.rx.pharmacist.UI
{
    partial class UCResepDetil
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvResep = new Guna.UI2.WinForms.Guna2DataGridView();
            this.bsResep = new System.Windows.Forms.BindingSource(this.components);
            this.yakkumdb = new rse.app.desk.rx.pharmacist.Dataset.yakkumdb();
            this.resep_detilTableAdapter = new rse.app.desk.rx.pharmacist.Dataset.yakkumdbTableAdapters.resep_detilTableAdapter();
            this.innourutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcnamaobatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numjmlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vc_satuan_pb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numdd1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numdd2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vcsignalainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numjmliterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namagolonganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(635, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 393);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(635, 55);
            this.guna2Panel2.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvResep);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(635, 293);
            this.pnlMain.TabIndex = 2;
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
            this.dgvResep.ColumnHeadersHeight = 25;
            this.dgvResep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.innourutDataGridViewTextBoxColumn,
            this.vcnamaobatDataGridViewTextBoxColumn,
            this.numjmlDataGridViewTextBoxColumn,
            this.vc_satuan_pb,
            this.numdd1DataGridViewTextBoxColumn,
            this.dd,
            this.numdd2DataGridViewTextBoxColumn,
            this.vcsignalainDataGridViewTextBoxColumn,
            this.numjmliterDataGridViewTextBoxColumn,
            this.namagolonganDataGridViewTextBoxColumn});
            this.dgvResep.DataSource = this.bsResep;
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
            this.dgvResep.RowHeadersVisible = false;
            this.dgvResep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResep.Size = new System.Drawing.Size(635, 293);
            this.dgvResep.TabIndex = 0;
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
            this.dgvResep.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvResep.ThemeStyle.ReadOnly = false;
            this.dgvResep.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvResep.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvResep.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvResep.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvResep.ThemeStyle.RowsStyle.Height = 22;
            this.dgvResep.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvResep.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // bsResep
            // 
            this.bsResep.DataMember = "resep_detil";
            this.bsResep.DataSource = this.yakkumdb;
            // 
            // yakkumdb
            // 
            this.yakkumdb.DataSetName = "yakkumdb";
            this.yakkumdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resep_detilTableAdapter
            // 
            this.resep_detilTableAdapter.ClearBeforeFill = true;
            // 
            // innourutDataGridViewTextBoxColumn
            // 
            this.innourutDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.innourutDataGridViewTextBoxColumn.DataPropertyName = "in_no_urut";
            this.innourutDataGridViewTextBoxColumn.FillWeight = 20F;
            this.innourutDataGridViewTextBoxColumn.Frozen = true;
            this.innourutDataGridViewTextBoxColumn.HeaderText = "No.";
            this.innourutDataGridViewTextBoxColumn.Name = "innourutDataGridViewTextBoxColumn";
            this.innourutDataGridViewTextBoxColumn.Width = 34;
            // 
            // vcnamaobatDataGridViewTextBoxColumn
            // 
            this.vcnamaobatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.vcnamaobatDataGridViewTextBoxColumn.DataPropertyName = "vc_namaobat";
            this.vcnamaobatDataGridViewTextBoxColumn.FillWeight = 300F;
            this.vcnamaobatDataGridViewTextBoxColumn.Frozen = true;
            this.vcnamaobatDataGridViewTextBoxColumn.HeaderText = "Nama Obat";
            this.vcnamaobatDataGridViewTextBoxColumn.Name = "vcnamaobatDataGridViewTextBoxColumn";
            this.vcnamaobatDataGridViewTextBoxColumn.Width = 250;
            // 
            // numjmlDataGridViewTextBoxColumn
            // 
            this.numjmlDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.numjmlDataGridViewTextBoxColumn.DataPropertyName = "num_jml";
            this.numjmlDataGridViewTextBoxColumn.FillWeight = 25F;
            this.numjmlDataGridViewTextBoxColumn.Frozen = true;
            this.numjmlDataGridViewTextBoxColumn.HeaderText = "Jumlah";
            this.numjmlDataGridViewTextBoxColumn.Name = "numjmlDataGridViewTextBoxColumn";
            this.numjmlDataGridViewTextBoxColumn.Width = 33;
            // 
            // vc_satuan_pb
            // 
            this.vc_satuan_pb.DataPropertyName = "vc_satuan_pb";
            this.vc_satuan_pb.FillWeight = 50F;
            this.vc_satuan_pb.HeaderText = "Satuan";
            this.vc_satuan_pb.Name = "vc_satuan_pb";
            // 
            // numdd1DataGridViewTextBoxColumn
            // 
            this.numdd1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.numdd1DataGridViewTextBoxColumn.DataPropertyName = "num_dd1";
            this.numdd1DataGridViewTextBoxColumn.HeaderText = "Aturan";
            this.numdd1DataGridViewTextBoxColumn.Name = "numdd1DataGridViewTextBoxColumn";
            this.numdd1DataGridViewTextBoxColumn.Width = 34;
            // 
            // dd
            // 
            this.dd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dd.DataPropertyName = "dd";
            this.dd.FillWeight = 20F;
            this.dd.HeaderText = "";
            this.dd.Name = "dd";
            this.dd.ReadOnly = true;
            // 
            // numdd2DataGridViewTextBoxColumn
            // 
            this.numdd2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.numdd2DataGridViewTextBoxColumn.DataPropertyName = "num_dd2";
            this.numdd2DataGridViewTextBoxColumn.HeaderText = "Pakai";
            this.numdd2DataGridViewTextBoxColumn.Name = "numdd2DataGridViewTextBoxColumn";
            this.numdd2DataGridViewTextBoxColumn.Width = 33;
            // 
            // vcsignalainDataGridViewTextBoxColumn
            // 
            this.vcsignalainDataGridViewTextBoxColumn.DataPropertyName = "vc_signalain";
            this.vcsignalainDataGridViewTextBoxColumn.HeaderText = "Signa Lain";
            this.vcsignalainDataGridViewTextBoxColumn.Name = "vcsignalainDataGridViewTextBoxColumn";
            // 
            // numjmliterDataGridViewTextBoxColumn
            // 
            this.numjmliterDataGridViewTextBoxColumn.DataPropertyName = "num_jmliter";
            this.numjmliterDataGridViewTextBoxColumn.FillWeight = 20F;
            this.numjmliterDataGridViewTextBoxColumn.HeaderText = "Iter";
            this.numjmliterDataGridViewTextBoxColumn.Name = "numjmliterDataGridViewTextBoxColumn";
            // 
            // namagolonganDataGridViewTextBoxColumn
            // 
            this.namagolonganDataGridViewTextBoxColumn.DataPropertyName = "nama_golongan";
            this.namagolonganDataGridViewTextBoxColumn.FillWeight = 50F;
            this.namagolonganDataGridViewTextBoxColumn.HeaderText = "Golongan";
            this.namagolonganDataGridViewTextBoxColumn.Name = "namagolonganDataGridViewTextBoxColumn";
            // 
            // UCResepDetil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UCResepDetil";
            this.Size = new System.Drawing.Size(635, 448);
            this.Load += new System.EventHandler(this.UCResepDetil_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2DataGridView dgvResep;
        private System.Windows.Forms.BindingSource bsResep;
        private Dataset.yakkumdb yakkumdb;
        private Dataset.yakkumdbTableAdapters.resep_detilTableAdapter resep_detilTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn innourutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcnamaobatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numjmlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vc_satuan_pb;
        private System.Windows.Forms.DataGridViewTextBoxColumn numdd1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dd;
        private System.Windows.Forms.DataGridViewTextBoxColumn numdd2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vcsignalainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numjmliterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namagolonganDataGridViewTextBoxColumn;
    }
}
