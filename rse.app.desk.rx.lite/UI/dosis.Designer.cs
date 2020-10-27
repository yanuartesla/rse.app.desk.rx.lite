namespace rse.app.desk.rx.lite.UI
{
    partial class dosis
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
            this.Obat = new System.Windows.Forms.Label();
            this.bsObat = new System.Windows.Forms.BindingSource(this.components);
            this.yakkumdb = new rse.app.desk.rx.lite.dataset.yakkumdb();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.txtdd2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtdd1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSatuan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSatuanDosis = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtJumlah = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblkodeobat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numiter = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.favCheckBox = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EtherCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.txtSignalain = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.retensi = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.view_rse_fa_obatTableAdapter = new rse.app.desk.rx.lite.dataset.yakkumdbTableAdapters.view_rse_fa_obatTableAdapter();
            this.bsRxD = new System.Windows.Forms.BindingSource(this.components);
            this.fa_rx_resep_dTableAdapter = new rse.app.desk.rx.lite.dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bsObat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRxD)).BeginInit();
            this.SuspendLayout();
            // 
            // Obat
            // 
            this.Obat.AutoSize = true;
            this.Obat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObat, "vc_namaobat", true));
            this.Obat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Obat.Location = new System.Drawing.Point(24, 35);
            this.Obat.Name = "Obat";
            this.Obat.Size = new System.Drawing.Size(102, 19);
            this.Obat.TabIndex = 0;
            this.Obat.Text = "Nama Obat";
            this.Obat.Click += new System.EventHandler(this.Obat_Click);
            // 
            // bsObat
            // 
            this.bsObat.DataMember = "view_rse_fa_obat";
            this.bsObat.DataSource = this.yakkumdb;
            this.bsObat.CurrentChanged += new System.EventHandler(this.bsObat_CurrentChanged);
            // 
            // yakkumdb
            // 
            this.yakkumdb.DataSetName = "yakkumdb";
            this.yakkumdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.txtdd2);
            this.guna2ShadowPanel1.Controls.Add(this.txtdd1);
            this.guna2ShadowPanel1.Controls.Add(this.lblSatuan);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Controls.Add(this.cmbSatuanDosis);
            this.guna2ShadowPanel1.Controls.Add(this.txtJumlah);
            this.guna2ShadowPanel1.Controls.Add(this.lblkodeobat);
            this.guna2ShadowPanel1.Controls.Add(this.numiter);
            this.guna2ShadowPanel1.Controls.Add(this.favCheckBox);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.EtherCheck);
            this.guna2ShadowPanel1.Controls.Add(this.txtSignalain);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.retensi);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Controls.Add(this.btnCancel);
            this.guna2ShadowPanel1.Controls.Add(this.btnSave);
            this.guna2ShadowPanel1.Controls.Add(this.Obat);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 18;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(491, 446);
            this.guna2ShadowPanel1.TabIndex = 1;
            this.guna2ShadowPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
            // 
            // txtdd2
            // 
            this.txtdd2.Animated = true;
            this.txtdd2.AutoRoundedCorners = true;
            this.txtdd2.BorderRadius = 17;
            this.txtdd2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdd2.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsRxD, "nvc_dd2", true));
            this.txtdd2.DefaultText = "";
            this.txtdd2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdd2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdd2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdd2.DisabledState.Parent = this.txtdd2;
            this.txtdd2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdd2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdd2.FocusedState.Parent = this.txtdd2;
            this.txtdd2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdd2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdd2.HoverState.Parent = this.txtdd2;
            this.txtdd2.Location = new System.Drawing.Point(172, 111);
            this.txtdd2.MaxLength = 4;
            this.txtdd2.Name = "txtdd2";
            this.txtdd2.PasswordChar = '\0';
            this.txtdd2.PlaceholderText = "de die";
            this.txtdd2.SelectedText = "";
            this.txtdd2.ShadowDecoration.Parent = this.txtdd2;
            this.txtdd2.Size = new System.Drawing.Size(81, 36);
            this.txtdd2.TabIndex = 20;
            // 
            // txtdd1
            // 
            this.txtdd1.Animated = true;
            this.txtdd1.AutoRoundedCorners = true;
            this.txtdd1.BorderRadius = 17;
            this.txtdd1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdd1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsRxD, "nvc_dd1", true));
            this.txtdd1.DefaultText = "";
            this.txtdd1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdd1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdd1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdd1.DisabledState.Parent = this.txtdd1;
            this.txtdd1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdd1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdd1.FocusedState.Parent = this.txtdd1;
            this.txtdd1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdd1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdd1.HoverState.Parent = this.txtdd1;
            this.txtdd1.Location = new System.Drawing.Point(29, 111);
            this.txtdd1.MaxLength = 4;
            this.txtdd1.Name = "txtdd1";
            this.txtdd1.PasswordChar = '\0';
            this.txtdd1.PlaceholderText = "de die";
            this.txtdd1.SelectedText = "";
            this.txtdd1.ShadowDecoration.Parent = this.txtdd1;
            this.txtdd1.Size = new System.Drawing.Size(86, 36);
            this.txtdd1.TabIndex = 19;
            // 
            // lblSatuan
            // 
            this.lblSatuan.AutoSize = true;
            this.lblSatuan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObat, "satuan_pb", true));
            this.lblSatuan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSatuan.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSatuan.Location = new System.Drawing.Point(196, 168);
            this.lblSatuan.Name = "lblSatuan";
            this.lblSatuan.Size = new System.Drawing.Size(93, 32);
            this.lblSatuan.TabIndex = 18;
            this.lblSatuan.Text = "Satuan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Satuan Dosis";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbSatuanDosis
            // 
            this.cmbSatuanDosis.Animated = true;
            this.cmbSatuanDosis.AutoRoundedCorners = true;
            this.cmbSatuanDosis.BackColor = System.Drawing.Color.Transparent;
            this.cmbSatuanDosis.BorderRadius = 17;
            this.cmbSatuanDosis.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObat, "vc_satuan_ps", true));
            this.cmbSatuanDosis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSatuanDosis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatuanDosis.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSatuanDosis.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSatuanDosis.FocusedState.Parent = this.cmbSatuanDosis;
            this.cmbSatuanDosis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSatuanDosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSatuanDosis.HoverState.Parent = this.cmbSatuanDosis;
            this.cmbSatuanDosis.ItemHeight = 30;
            this.cmbSatuanDosis.Items.AddRange(new object[] {
            "C",
            "Cth",
            "Kapsul",
            "ML",
            "Ovula",
            "Rectal Tube",
            "Spray",
            "Suppositoria",
            "Tablet",
            "Tetes",
            "Tetes Mata",
            "Tetes Telinga",
            "ue",
            "Unit"});
            this.cmbSatuanDosis.ItemsAppearance.Parent = this.cmbSatuanDosis;
            this.cmbSatuanDosis.Location = new System.Drawing.Point(289, 112);
            this.cmbSatuanDosis.Name = "cmbSatuanDosis";
            this.cmbSatuanDosis.ShadowDecoration.Parent = this.cmbSatuanDosis;
            this.cmbSatuanDosis.Size = new System.Drawing.Size(148, 36);
            this.cmbSatuanDosis.Sorted = true;
            this.cmbSatuanDosis.StartIndex = 0;
            this.cmbSatuanDosis.TabIndex = 2;
            this.cmbSatuanDosis.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // txtJumlah
            // 
            this.txtJumlah.Animated = true;
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
            this.txtJumlah.Location = new System.Drawing.Point(29, 168);
            this.txtJumlah.MaxLength = 4;
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.PasswordChar = '\0';
            this.txtJumlah.PlaceholderText = "Jumlah";
            this.txtJumlah.SelectedText = "";
            this.txtJumlah.ShadowDecoration.Parent = this.txtJumlah;
            this.txtJumlah.Size = new System.Drawing.Size(152, 36);
            this.txtJumlah.TabIndex = 3;
            this.txtJumlah.TextChanged += new System.EventHandler(this.txtJumlah_TextChanged);
            this.txtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlah_KeyPress);
            // 
            // lblkodeobat
            // 
            this.lblkodeobat.BackColor = System.Drawing.Color.Transparent;
            this.lblkodeobat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObat, "vc_kodeobat", true));
            this.lblkodeobat.Location = new System.Drawing.Point(413, 73);
            this.lblkodeobat.Name = "lblkodeobat";
            this.lblkodeobat.Size = new System.Drawing.Size(48, 15);
            this.lblkodeobat.TabIndex = 14;
            this.lblkodeobat.Text = "kodeobat";
            this.lblkodeobat.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblkodeobat.Click += new System.EventHandler(this.lblkodeobat_Click);
            // 
            // numiter
            // 
            this.numiter.AutoRoundedCorners = true;
            this.numiter.BackColor = System.Drawing.Color.Transparent;
            this.numiter.BorderRadius = 17;
            this.numiter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numiter.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsRxD, "num_jmliter", true));
            this.numiter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numiter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numiter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numiter.DisabledState.Parent = this.numiter;
            this.numiter.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numiter.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numiter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numiter.FocusedState.Parent = this.numiter;
            this.numiter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numiter.Location = new System.Drawing.Point(101, 315);
            this.numiter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numiter.Name = "numiter";
            this.numiter.ShadowDecoration.Parent = this.numiter;
            this.numiter.Size = new System.Drawing.Size(54, 36);
            this.numiter.TabIndex = 13;
            this.numiter.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numiter.Visible = false;
            this.numiter.ValueChanged += new System.EventHandler(this.numiter_ValueChanged);
            // 
            // favCheckBox
            // 
            this.favCheckBox.CheckedState.Image = global::rse.app.desk.rx.lite.Properties.Resources.star__1_;
            this.favCheckBox.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.favCheckBox.CheckedState.Parent = this.favCheckBox;
            this.favCheckBox.HoverState.Parent = this.favCheckBox;
            this.favCheckBox.Image = global::rse.app.desk.rx.lite.Properties.Resources.star;
            this.favCheckBox.ImageSize = new System.Drawing.Size(30, 30);
            this.favCheckBox.IndicateFocus = true;
            this.favCheckBox.Location = new System.Drawing.Point(419, 12);
            this.favCheckBox.Name = "favCheckBox";
            this.favCheckBox.PressedState.Parent = this.favCheckBox;
            this.favCheckBox.Size = new System.Drawing.Size(41, 42);
            this.favCheckBox.TabIndex = 12;
            this.favCheckBox.TabStop = false;
            this.favCheckBox.CheckedChanged += new System.EventHandler(this.favCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(51, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Iter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EtherCheck
            // 
            this.EtherCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EtherCheck.CheckedState.BorderRadius = 2;
            this.EtherCheck.CheckedState.BorderThickness = 0;
            this.EtherCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EtherCheck.CheckedState.Parent = this.EtherCheck;
            this.EtherCheck.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsRxD, "bt_iter", true));
            this.EtherCheck.Location = new System.Drawing.Point(29, 324);
            this.EtherCheck.Name = "EtherCheck";
            this.EtherCheck.ShadowDecoration.Parent = this.EtherCheck;
            this.EtherCheck.Size = new System.Drawing.Size(20, 20);
            this.EtherCheck.TabIndex = 5;
            this.EtherCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.EtherCheck.UncheckedState.BorderRadius = 2;
            this.EtherCheck.UncheckedState.BorderThickness = 0;
            this.EtherCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.EtherCheck.UncheckedState.Parent = this.EtherCheck;
            this.EtherCheck.CheckedChanged += new System.EventHandler(this.guna2CustomCheckBox1_CheckedChanged);
            // 
            // txtSignalain
            // 
            this.txtSignalain.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSignalain.DefaultText = "";
            this.txtSignalain.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSignalain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSignalain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSignalain.DisabledState.Parent = this.txtSignalain;
            this.txtSignalain.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSignalain.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSignalain.FocusedState.Parent = this.txtSignalain;
            this.txtSignalain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSignalain.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSignalain.HoverState.Parent = this.txtSignalain;
            this.txtSignalain.Location = new System.Drawing.Point(29, 223);
            this.txtSignalain.Multiline = true;
            this.txtSignalain.Name = "txtSignalain";
            this.txtSignalain.PasswordChar = '\0';
            this.txtSignalain.PlaceholderText = "Signa Lain";
            this.txtSignalain.SelectedText = "";
            this.txtSignalain.ShadowDecoration.Parent = this.txtSignalain;
            this.txtSignalain.Size = new System.Drawing.Size(432, 73);
            this.txtSignalain.TabIndex = 4;
            this.txtSignalain.TextChanged += new System.EventHandler(this.txtSignalain_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(121, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "dd";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // retensi
            // 
            this.retensi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObat, "retensi_full", true));
            this.retensi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.retensi.ForeColor = System.Drawing.Color.White;
            this.retensi.Location = new System.Drawing.Point(28, 73);
            this.retensi.Name = "retensi";
            this.retensi.ShadowDecoration.Parent = this.retensi;
            this.retensi.Size = new System.Drawing.Size(244, 23);
            this.retensi.TabIndex = 4;
            this.retensi.Text = "Retriksi";
            this.retensi.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.retensi.Click += new System.EventHandler(this.retensi_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(28, 57);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(433, 10);
            this.guna2Separator1.TabIndex = 3;
            this.guna2Separator1.Click += new System.EventHandler(this.guna2Separator1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 21;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FillColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(278, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(183, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 21;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.FillColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(40, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.ContainerControl = this;
            this.guna2DragControl1.TargetControl = this.guna2ShadowPanel1;
            this.guna2DragControl1.TransparentWhileDrag = true;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // view_rse_fa_obatTableAdapter
            // 
            this.view_rse_fa_obatTableAdapter.ClearBeforeFill = true;
            // 
            // bsRxD
            // 
            this.bsRxD.DataMember = "fa_rx_resep_d";
            this.bsRxD.DataSource = this.yakkumdb;
            // 
            // fa_rx_resep_dTableAdapter
            // 
            this.fa_rx_resep_dTableAdapter.ClearBeforeFill = true;
            // 
            // dosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(491, 446);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dosis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "dosis";
            this.Load += new System.EventHandler(this.dosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsObat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numiter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRxD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Obat;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Chip retensi;
        private System.Windows.Forms.BindingSource bsObat;
        private dataset.yakkumdb yakkumdb;
        private dataset.yakkumdbTableAdapters.view_rse_fa_obatTableAdapter view_rse_fa_obatTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox txtSignalain;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomCheckBox EtherCheck;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageCheckBox favCheckBox;
        private Guna.UI2.WinForms.Guna2NumericUpDown numiter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblkodeobat;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlah;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSatuanDosis;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label lblSatuan;
        private Guna.UI2.WinForms.Guna2TextBox txtdd2;
        private Guna.UI2.WinForms.Guna2TextBox txtdd1;
        private System.Windows.Forms.BindingSource bsRxD;
        private dataset.yakkumdbTableAdapters.fa_rx_resep_dTableAdapter fa_rx_resep_dTableAdapter;
    }
}