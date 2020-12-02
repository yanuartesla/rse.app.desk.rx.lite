namespace rse.app.desk.rx.nurse
{
    partial class JumlahBMHP
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
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.lblNama = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtJumlah = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSatuan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblKodeObat = new System.Windows.Forms.Label();
            this.cmbSatuan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bsDaftarBMHP = new System.Windows.Forms.BindingSource(this.components);
            this.yakkumdb = new rse.app.desk.rx.nurse.yakkumdb();
            this.view_rse_fa_obatTableAdapter = new rse.app.desk.rx.nurse.yakkumdbTableAdapters.view_rse_fa_obatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bsDaftarBMHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // lblNama
            // 
            this.lblNama.BackColor = System.Drawing.Color.Transparent;
            this.lblNama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaftarBMHP, "vc_namaobat", true));
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(12, 12);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(123, 32);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "NamaBMHP";
            // 
            // txtJumlah
            // 
            this.txtJumlah.AutoRoundedCorners = true;
            this.txtJumlah.BorderRadius = 17;
            this.txtJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJumlah.DefaultText = "";
            this.txtJumlah.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtJumlah.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtJumlah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlah.DisabledState.Parent = this.txtJumlah;
            this.txtJumlah.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtJumlah.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlah.FocusedState.Parent = this.txtJumlah;
            this.txtJumlah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtJumlah.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtJumlah.HoverState.Parent = this.txtJumlah;
            this.txtJumlah.Location = new System.Drawing.Point(91, 84);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.PasswordChar = '\0';
            this.txtJumlah.PlaceholderText = "Jumlah";
            this.txtJumlah.SelectedText = "";
            this.txtJumlah.ShadowDecoration.Parent = this.txtJumlah;
            this.txtJumlah.Size = new System.Drawing.Size(142, 36);
            this.txtJumlah.TabIndex = 1;
            // 
            // lblSatuan
            // 
            this.lblSatuan.BackColor = System.Drawing.Color.Transparent;
            this.lblSatuan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaftarBMHP, "satuan_pb", true));
            this.lblSatuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatuan.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSatuan.Location = new System.Drawing.Point(286, 55);
            this.lblSatuan.Name = "lblSatuan";
            this.lblSatuan.Size = new System.Drawing.Size(56, 23);
            this.lblSatuan.TabIndex = 2;
            this.lblSatuan.Text = "Satuan";
            this.lblSatuan.Visible = false;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 50);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(431, 10);
            this.guna2Separator1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 21;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Fuchsia;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(69, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(127, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 21;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(263, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(127, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 32;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblKodeObat
            // 
            this.lblKodeObat.AutoSize = true;
            this.lblKodeObat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaftarBMHP, "vc_kodeobat", true));
            this.lblKodeObat.Location = new System.Drawing.Point(408, 31);
            this.lblKodeObat.Name = "lblKodeObat";
            this.lblKodeObat.Size = new System.Drawing.Size(35, 13);
            this.lblKodeObat.TabIndex = 6;
            this.lblKodeObat.Text = "label1";
            // 
            // cmbSatuan
            // 
            this.cmbSatuan.AutoRoundedCorners = true;
            this.cmbSatuan.BackColor = System.Drawing.Color.Transparent;
            this.cmbSatuan.BorderRadius = 17;
            this.cmbSatuan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsDaftarBMHP, "satuan_pb", true));
            this.cmbSatuan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsDaftarBMHP, "satuan_pb", true));
            this.cmbSatuan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDaftarBMHP, "satuan_pb", true));
            this.cmbSatuan.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsDaftarBMHP, "satuan_pb", true));
            this.cmbSatuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatuan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSatuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSatuan.FocusedState.Parent = this.cmbSatuan;
            this.cmbSatuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSatuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSatuan.HoverState.Parent = this.cmbSatuan;
            this.cmbSatuan.ItemHeight = 30;
            this.cmbSatuan.Items.AddRange(new object[] {
            "- Pilih Satuan",
            "ML",
            "PCS",
            "UNIT",
            "TABLET",
            "KAPSUL",
            "BOX",
            "BUNGKUS",
            "GALON",
            "LEMBAR",
            "PAK",
            "PASANG",
            "PCS",
            "ROL",
            "SET/KIT",
            "TUBE",
            "CM",
            "M",
            "AMP"});
            this.cmbSatuan.ItemsAppearance.Parent = this.cmbSatuan;
            this.cmbSatuan.Location = new System.Drawing.Point(250, 84);
            this.cmbSatuan.Name = "cmbSatuan";
            this.cmbSatuan.ShadowDecoration.Parent = this.cmbSatuan;
            this.cmbSatuan.Size = new System.Drawing.Size(140, 36);
            this.cmbSatuan.StartIndex = 0;
            this.cmbSatuan.TabIndex = 7;
            this.cmbSatuan.SelectedIndexChanged += new System.EventHandler(this.cmbSatuan_SelectedIndexChanged);
            // 
            // bsDaftarBMHP
            // 
            this.bsDaftarBMHP.DataMember = "view_rse_fa_obat";
            this.bsDaftarBMHP.DataSource = this.yakkumdb;
            // 
            // yakkumdb
            // 
            this.yakkumdb.DataSetName = "yakkumdb";
            this.yakkumdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_rse_fa_obatTableAdapter
            // 
            this.view_rse_fa_obatTableAdapter.ClearBeforeFill = true;
            // 
            // JumlahBMHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 257);
            this.Controls.Add(this.cmbSatuan);
            this.Controls.Add(this.lblKodeObat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblSatuan);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.lblNama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JumlahBMHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jumlah BMHP";
            this.Load += new System.EventHandler(this.JumlahBMHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDaftarBMHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSatuan;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlah;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNama;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.BindingSource bsDaftarBMHP;
        private yakkumdb yakkumdb;
        private yakkumdbTableAdapters.view_rse_fa_obatTableAdapter view_rse_fa_obatTableAdapter;
        private System.Windows.Forms.Label lblKodeObat;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSatuan;
    }
}