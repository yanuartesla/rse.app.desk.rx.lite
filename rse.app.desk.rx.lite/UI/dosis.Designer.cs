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
            this.lblkodeobat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.numiter = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.favCheckBox = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.numDD2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.numDD1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.EtherCheck = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.txtSignalain = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.retensi = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.view_rse_fa_obatTableAdapter = new rse.app.desk.rx.lite.dataset.yakkumdbTableAdapters.view_rse_fa_obatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bsObat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numiter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDD1)).BeginInit();
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
            // 
            // bsObat
            // 
            this.bsObat.DataMember = "view_rse_fa_obat";
            this.bsObat.DataSource = this.yakkumdb;
            // 
            // yakkumdb
            // 
            this.yakkumdb.DataSetName = "yakkumdb";
            this.yakkumdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lblkodeobat);
            this.guna2ShadowPanel1.Controls.Add(this.numiter);
            this.guna2ShadowPanel1.Controls.Add(this.favCheckBox);
            this.guna2ShadowPanel1.Controls.Add(this.numDD2);
            this.guna2ShadowPanel1.Controls.Add(this.numDD1);
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
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(491, 371);
            this.guna2ShadowPanel1.TabIndex = 1;
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
            // 
            // numiter
            // 
            this.numiter.AutoRoundedCorners = true;
            this.numiter.BackColor = System.Drawing.Color.Transparent;
            this.numiter.BorderRadius = 17;
            this.numiter.Cursor = System.Windows.Forms.Cursors.IBeam;
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
            this.numiter.Location = new System.Drawing.Point(100, 248);
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
            // numDD2
            // 
            this.numDD2.AutoRoundedCorners = true;
            this.numDD2.BackColor = System.Drawing.Color.Transparent;
            this.numDD2.BorderRadius = 17;
            this.numDD2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numDD2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numDD2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numDD2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numDD2.DisabledState.Parent = this.numDD2;
            this.numDD2.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numDD2.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numDD2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numDD2.FocusedState.Parent = this.numDD2;
            this.numDD2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.numDD2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numDD2.Location = new System.Drawing.Point(193, 111);
            this.numDD2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numDD2.Name = "numDD2";
            this.numDD2.ShadowDecoration.Parent = this.numDD2;
            this.numDD2.Size = new System.Drawing.Size(79, 36);
            this.numDD2.TabIndex = 2;
            this.numDD2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDD2.ValueChanged += new System.EventHandler(this.numDD2_ValueChanged);
            // 
            // numDD1
            // 
            this.numDD1.AutoRoundedCorners = true;
            this.numDD1.BackColor = System.Drawing.Color.Transparent;
            this.numDD1.BorderRadius = 17;
            this.numDD1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numDD1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numDD1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numDD1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numDD1.DisabledState.Parent = this.numDD1;
            this.numDD1.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numDD1.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numDD1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numDD1.FocusedState.Parent = this.numDD1;
            this.numDD1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.numDD1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numDD1.Location = new System.Drawing.Point(28, 111);
            this.numDD1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numDD1.Name = "numDD1";
            this.numDD1.ShadowDecoration.Parent = this.numDD1;
            this.numDD1.Size = new System.Drawing.Size(79, 36);
            this.numDD1.TabIndex = 1;
            this.numDD1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDD1.ValueChanged += new System.EventHandler(this.numDD1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(50, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Iter";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EtherCheck
            // 
            this.EtherCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EtherCheck.CheckedState.BorderRadius = 2;
            this.EtherCheck.CheckedState.BorderThickness = 0;
            this.EtherCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EtherCheck.CheckedState.Parent = this.EtherCheck;
            this.EtherCheck.Location = new System.Drawing.Point(28, 257);
            this.EtherCheck.Name = "EtherCheck";
            this.EtherCheck.ShadowDecoration.Parent = this.EtherCheck;
            this.EtherCheck.Size = new System.Drawing.Size(20, 20);
            this.EtherCheck.TabIndex = 4;
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
            this.txtSignalain.Location = new System.Drawing.Point(28, 164);
            this.txtSignalain.Multiline = true;
            this.txtSignalain.Name = "txtSignalain";
            this.txtSignalain.PasswordChar = '\0';
            this.txtSignalain.PlaceholderText = "Signa Lain";
            this.txtSignalain.SelectedText = "";
            this.txtSignalain.ShadowDecoration.Parent = this.txtSignalain;
            this.txtSignalain.Size = new System.Drawing.Size(432, 71);
            this.txtSignalain.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(128, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "dd";
            // 
            // retensi
            // 
            this.retensi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObat, "retensi_full", true));
            this.retensi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.retensi.ForeColor = System.Drawing.Color.White;
            this.retensi.Location = new System.Drawing.Point(28, 73);
            this.retensi.Name = "retensi";
            this.retensi.ShadowDecoration.Parent = this.retensi;
            this.retensi.Size = new System.Drawing.Size(163, 23);
            this.retensi.TabIndex = 4;
            this.retensi.Text = "Retensi";
            this.retensi.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(28, 57);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(433, 10);
            this.guna2Separator1.TabIndex = 3;
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
            this.btnCancel.Location = new System.Drawing.Point(277, 301);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(183, 45);
            this.btnCancel.TabIndex = 2;
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
            this.btnSave.Location = new System.Drawing.Point(28, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // view_rse_fa_obatTableAdapter
            // 
            this.view_rse_fa_obatTableAdapter.ClearBeforeFill = true;
            // 
            // dosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(491, 371);
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
            ((System.ComponentModel.ISupportInitialize)(this.numDD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDD1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2NumericUpDown numDD1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numDD2;
        private Guna.UI2.WinForms.Guna2ImageCheckBox favCheckBox;
        private Guna.UI2.WinForms.Guna2NumericUpDown numiter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblkodeobat;
    }
}