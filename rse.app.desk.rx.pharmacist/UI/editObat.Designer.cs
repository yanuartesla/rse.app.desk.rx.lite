namespace rse.app.desk.rx.pharmacist.UI
{
    partial class editObat
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblNamaObat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.bsObat = new System.Windows.Forms.BindingSource(this.components);
            this.yakkumdb = new rse.app.desk.rx.pharmacist.Dataset.yakkumdb();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtJumlah = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.resep_detilTableAdapter = new rse.app.desk.rx.pharmacist.Dataset.yakkumdbTableAdapters.resep_detilTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bsObat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 32;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblNamaObat
            // 
            this.lblNamaObat.BackColor = System.Drawing.Color.Transparent;
            this.lblNamaObat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObat, "vc_nama_obat", true));
            this.lblNamaObat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaObat.Location = new System.Drawing.Point(12, 12);
            this.lblNamaObat.Name = "lblNamaObat";
            this.lblNamaObat.Size = new System.Drawing.Size(90, 23);
            this.lblNamaObat.TabIndex = 1;
            this.lblNamaObat.TabStop = false;
            this.lblNamaObat.Text = "Nama Obat";
            // 
            // bsObat
            // 
            this.bsObat.DataMember = "resep_detil";
            this.bsObat.DataSource = this.yakkumdb;
            // 
            // yakkumdb
            // 
            this.yakkumdb.DataSetName = "yakkumdb";
            this.yakkumdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(12, 41);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(330, 10);
            this.guna2Separator1.TabIndex = 12;
            this.guna2Separator1.TabStop = false;
            // 
            // txtJumlah
            // 
            this.txtJumlah.AutoRoundedCorners = true;
            this.txtJumlah.BorderRadius = 23;
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
            this.txtJumlah.Location = new System.Drawing.Point(22, 72);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.PasswordChar = '\0';
            this.txtJumlah.PlaceholderText = "Masukan Jumlah";
            this.txtJumlah.SelectedText = "";
            this.txtJumlah.ShadowDecoration.Parent = this.txtJumlah;
            this.txtJumlah.Size = new System.Drawing.Size(131, 49);
            this.txtJumlah.TabIndex = 0;
            this.txtJumlah.TextChanged += new System.EventHandler(this.txtJumlah_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BorderRadius = 21;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(22, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(131, 45);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.RoyalBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(177, 155);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(131, 45);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Cancel";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsObat, "vc_satuan", true));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(177, 86);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(90, 23);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "Nama Obat";
            // 
            // resep_detilTableAdapter
            // 
            this.resep_detilTableAdapter.ClearBeforeFill = true;
            // 
            // editObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 222);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.lblNamaObat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editObat";
            this.Load += new System.EventHandler(this.editObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsObat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtJumlah;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNamaObat;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.BindingSource bsObat;
        private Dataset.yakkumdb yakkumdb;
        private Dataset.yakkumdbTableAdapters.resep_detilTableAdapter resep_detilTableAdapter;
    }
}