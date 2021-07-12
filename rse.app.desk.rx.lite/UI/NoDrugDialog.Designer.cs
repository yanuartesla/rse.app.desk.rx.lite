
namespace rse.app.desk.rx.lite.UI
{
    partial class NoDrugDialog
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rbTanpaObat = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbRujuk = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbOpname = new Guna.UI2.WinForms.Guna2RadioButton();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 16;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.ResizeForm = false;
            // 
            // btnSave
            // 
            this.btnSave.AutoRoundedCorners = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 21;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(109, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 21;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Salmon;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(345, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(38, 40);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(559, 79);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Tidak ada inputan Terapi Obat pada Pasien ini, \r\nMohon berikan informasi tambahan" +
    " pada Pilihan berikut : \r\n";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbTanpaObat
            // 
            this.rbTanpaObat.AutoSize = true;
            this.rbTanpaObat.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTanpaObat.CheckedState.BorderThickness = 0;
            this.rbTanpaObat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbTanpaObat.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbTanpaObat.CheckedState.InnerOffset = -4;
            this.rbTanpaObat.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTanpaObat.Location = new System.Drawing.Point(38, 155);
            this.rbTanpaObat.Name = "rbTanpaObat";
            this.rbTanpaObat.Size = new System.Drawing.Size(178, 21);
            this.rbTanpaObat.TabIndex = 3;
            this.rbTanpaObat.Text = "Pasien tanpa Terapi Obat";
            this.rbTanpaObat.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbTanpaObat.UncheckedState.BorderThickness = 2;
            this.rbTanpaObat.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbTanpaObat.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbRujuk
            // 
            this.rbRujuk.AutoSize = true;
            this.rbRujuk.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbRujuk.CheckedState.BorderThickness = 0;
            this.rbRujuk.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbRujuk.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbRujuk.CheckedState.InnerOffset = -4;
            this.rbRujuk.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbRujuk.Location = new System.Drawing.Point(290, 155);
            this.rbRujuk.Name = "rbRujuk";
            this.rbRujuk.Size = new System.Drawing.Size(118, 21);
            this.rbRujuk.TabIndex = 4;
            this.rbRujuk.Text = "Pasien di Rujuk";
            this.rbRujuk.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbRujuk.UncheckedState.BorderThickness = 2;
            this.rbRujuk.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbRujuk.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbOpname
            // 
            this.rbOpname.AutoSize = true;
            this.rbOpname.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbOpname.CheckedState.BorderThickness = 0;
            this.rbOpname.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbOpname.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbOpname.CheckedState.InnerOffset = -4;
            this.rbOpname.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.rbOpname.Location = new System.Drawing.Point(476, 155);
            this.rbOpname.Name = "rbOpname";
            this.rbOpname.Size = new System.Drawing.Size(121, 21);
            this.rbOpname.TabIndex = 5;
            this.rbOpname.Text = "Pasien Opname";
            this.rbOpname.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbOpname.UncheckedState.BorderThickness = 2;
            this.rbOpname.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbOpname.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // NoDrugDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 284);
            this.Controls.Add(this.rbOpname);
            this.Controls.Add(this.rbRujuk);
            this.Controls.Add(this.rbTanpaObat);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NoDrugDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoDrugDialog";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2RadioButton rbOpname;
        private Guna.UI2.WinForms.Guna2RadioButton rbRujuk;
        private Guna.UI2.WinForms.Guna2RadioButton rbTanpaObat;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}