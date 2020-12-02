namespace rse.app.desk.rx.nurse
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flpNotif = new System.Windows.Forms.FlowLayoutPanel();
            this.cardResep1 = new rse.app.desk.rx.nurse.CardResep();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblKklinik = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CheckBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.cmbNKlinik = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bsKlinik = new System.Windows.Forms.BindingSource(this.components);
            this.yakkumdb = new rse.app.desk.rx.nurse.yakkumdb();
            this.rMKLINIKTableAdapter = new rse.app.desk.rx.nurse.yakkumdbTableAdapters.RMKLINIKTableAdapter();
            this.bsResep = new System.Windows.Forms.BindingSource(this.components);
            this.resep_waitingTableAdapter = new rse.app.desk.rx.nurse.yakkumdbTableAdapters.resep_waitingTableAdapter();
            this.timerreset = new System.Windows.Forms.Timer(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpNotif.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsKlinik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpNotif
            // 
            this.flpNotif.AutoScroll = true;
            this.flpNotif.Controls.Add(this.cardResep1);
            this.flpNotif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNotif.Location = new System.Drawing.Point(5, 190);
            this.flpNotif.Name = "flpNotif";
            this.flpNotif.Padding = new System.Windows.Forms.Padding(10);
            this.flpNotif.Size = new System.Drawing.Size(391, 400);
            this.flpNotif.TabIndex = 0;
            // 
            // cardResep1
            // 
            this.cardResep1.BackColor = System.Drawing.Color.Indigo;
            this.cardResep1.Dokter = null;
            this.cardResep1.kdokter = null;
            this.cardResep1.Location = new System.Drawing.Point(13, 13);
            this.cardResep1.Nama = null;
            this.cardResep1.namaklinik = null;
            this.cardResep1.Name = "cardResep1";
            this.cardResep1.NoResep = null;
            this.cardResep1.NoRM = null;
            this.cardResep1.Padding = new System.Windows.Forms.Padding(7);
            this.cardResep1.SEP = null;
            this.cardResep1.Size = new System.Drawing.Size(365, 122);
            this.cardResep1.TabIndex = 0;
            this.cardResep1.Visible = false;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.pictureBox2);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(401, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(684, 595);
            this.pnlContent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(257, 528);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilih Pasien";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.flpNotif);
            this.guna2ShadowPanel1.Controls.Add(this.guna2GradientPanel1);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(401, 595);
            this.guna2ShadowPanel1.TabIndex = 2;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Purple;
            this.guna2GradientPanel1.Controls.Add(this.lblKklinik);
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GradientPanel1.Controls.Add(this.guna2Separator1);
            this.guna2GradientPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GradientPanel1.Controls.Add(this.guna2CheckBox1);
            this.guna2GradientPanel1.Controls.Add(this.cmbNKlinik);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.ForeColor = System.Drawing.Color.LightCyan;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(5, 5);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(391, 185);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // lblKklinik
            // 
            this.lblKklinik.BackColor = System.Drawing.Color.Transparent;
            this.lblKklinik.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKklinik.ForeColor = System.Drawing.Color.GhostWhite;
            this.lblKklinik.Location = new System.Drawing.Point(7, 148);
            this.lblKklinik.Name = "lblKklinik";
            this.lblKklinik.Size = new System.Drawing.Size(47, 27);
            this.lblKklinik.TabIndex = 6;
            this.lblKklinik.Text = "0200";
            this.lblKklinik.Visible = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.GhostWhite;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(124, 18);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(260, 27);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Bahan Medis Habis Pakai ";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(0, 172);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(388, 10);
            this.guna2Separator1.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.GhostWhite;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(7, 111);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(57, 27);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Klinik";
            // 
            // guna2CheckBox1
            // 
            this.guna2CheckBox1.AutoSize = true;
            this.guna2CheckBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.CheckedState.BorderRadius = 0;
            this.guna2CheckBox1.CheckedState.BorderThickness = 0;
            this.guna2CheckBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2CheckBox1.Font = new System.Drawing.Font("Segoe UI Light", 8.25F);
            this.guna2CheckBox1.Location = new System.Drawing.Point(163, 148);
            this.guna2CheckBox1.Name = "guna2CheckBox1";
            this.guna2CheckBox1.Size = new System.Drawing.Size(94, 17);
            this.guna2CheckBox1.TabIndex = 1;
            this.guna2CheckBox1.Text = "Jadikan Default";
            this.guna2CheckBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.UncheckedState.BorderRadius = 0;
            this.guna2CheckBox1.UncheckedState.BorderThickness = 0;
            this.guna2CheckBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CheckBox1.CheckedChanged += new System.EventHandler(this.guna2CheckBox1_CheckedChanged);
            // 
            // cmbNKlinik
            // 
            this.cmbNKlinik.Animated = true;
            this.cmbNKlinik.AutoRoundedCorners = true;
            this.cmbNKlinik.BackColor = System.Drawing.Color.Transparent;
            this.cmbNKlinik.BorderRadius = 17;
            this.cmbNKlinik.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNKlinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNKlinik.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNKlinik.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNKlinik.FocusedState.Parent = this.cmbNKlinik;
            this.cmbNKlinik.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNKlinik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbNKlinik.HoverState.Parent = this.cmbNKlinik;
            this.cmbNKlinik.IntegralHeight = false;
            this.cmbNKlinik.ItemHeight = 30;
            this.cmbNKlinik.Items.AddRange(new object[] {
            "2100 | Akupuntur                          ",
            "0200 | Bedah                              ",
            "1500 | Bedah Orthopedi                    ",
            "0600 | Bedah Saraf                        ",
            "2300 | Geriatri",
            "2612 | Gigi dan Mulut Sore                  ",
            "0500 | Ginekologi                         ",
            "2605 | Ginekologi/Kandungan Sore          ",
            "2200 | Gizi                               ",
            "4503 | Hemodialisa",
            "1900 | IRD (Instalasi Rawat Darurat)      ",
            "1300 | Jantung dan Pembuluh Darah",
            "1801 | Karyawan",
            "0300 | Kesehatan Anak                     ",
            "0301 | KIA",
            "1200 | Klinik Gigi dan Mulut                ",
            "0800 | Klinik Jiwa",
            "2400 | Klinik Rehab. Medik",
            "2500 | Klinik Urologi",
            "0503 | Konseling",
            "1100 | Kulit dan Kelamin                    ",
            "1000 | Mata                               ",
            "0400 | ObsGini / Kebidanan dan Kandungan               ",
            "0100 | Penyakit Dalam                     ",
            "2601 | Penyakit Dalam Sore                ",
            "4800 | Rehabilitasi Medik",
            "0700 | Saraf                              ",
            "0900 | THT                                ",
            "1800 | Umum                               "});
            this.cmbNKlinik.ItemsAppearance.Parent = this.cmbNKlinik;
            this.cmbNKlinik.Location = new System.Drawing.Point(70, 106);
            this.cmbNKlinik.Name = "cmbNKlinik";
            this.cmbNKlinik.ShadowDecoration.Parent = this.cmbNKlinik;
            this.cmbNKlinik.Size = new System.Drawing.Size(308, 36);
            this.cmbNKlinik.StartIndex = 0;
            this.cmbNKlinik.TabIndex = 0;
            this.cmbNKlinik.SelectedIndexChanged += new System.EventHandler(this.cmbNKlinik_SelectedIndexChanged);
            // 
            // bsKlinik
            // 
            this.bsKlinik.DataMember = "RMKLINIK";
            this.bsKlinik.DataSource = this.yakkumdb;
            // 
            // yakkumdb
            // 
            this.yakkumdb.DataSetName = "yakkumdb";
            this.yakkumdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rMKLINIKTableAdapter
            // 
            this.rMKLINIKTableAdapter.ClearBeforeFill = true;
            // 
            // bsResep
            // 
            this.bsResep.DataMember = "resep_waiting";
            this.bsResep.DataSource = this.yakkumdb;
            // 
            // resep_waitingTableAdapter
            // 
            this.resep_waitingTableAdapter.ClearBeforeFill = true;
            // 
            // timerreset
            // 
            this.timerreset.Interval = 30000;
            this.timerreset.Tick += new System.EventHandler(this.timerreset_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::rse.app.desk.rx.nurse.Properties.Resources.patient;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(684, 595);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rse.app.desk.rx.nurse.Properties.Resources.medical_equipment;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 595);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "BMHP";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flpNotif.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsKlinik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsResep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpNotif;
        private System.Windows.Forms.Panel pnlContent;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2CheckBox guna2CheckBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNKlinik;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblKklinik;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private CardResep cardResep1;
        private System.Windows.Forms.BindingSource bsKlinik;
        private yakkumdb yakkumdb;
        private yakkumdbTableAdapters.RMKLINIKTableAdapter rMKLINIKTableAdapter;
        private System.Windows.Forms.BindingSource bsResep;
        private yakkumdbTableAdapters.resep_waitingTableAdapter resep_waitingTableAdapter;
        private System.Windows.Forms.Timer timerreset;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}

