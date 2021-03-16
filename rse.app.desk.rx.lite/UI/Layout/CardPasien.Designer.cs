
namespace rse.app.desk.rx.lite.UI.Layout
{
    partial class CardPasien
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pbJenisKelamin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblNoRM = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNama = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblUmur = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbJenisKelamin)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_ACTIVATE;
            // 
            // pbJenisKelamin
            // 
            this.pbJenisKelamin.BackColor = System.Drawing.Color.RosyBrown;
            this.pbJenisKelamin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbJenisKelamin.Image = global::rse.app.desk.rx.lite.Properties.Resources.pharmacist_female;
            this.pbJenisKelamin.Location = new System.Drawing.Point(0, 0);
            this.pbJenisKelamin.Name = "pbJenisKelamin";
            this.pbJenisKelamin.ShadowDecoration.Parent = this.pbJenisKelamin;
            this.pbJenisKelamin.Size = new System.Drawing.Size(102, 85);
            this.pbJenisKelamin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJenisKelamin.TabIndex = 0;
            this.pbJenisKelamin.TabStop = false;
            // 
            // lblNoRM
            // 
            this.lblNoRM.AutoSize = false;
            this.lblNoRM.BackColor = System.Drawing.Color.Transparent;
            this.lblNoRM.Enabled = false;
            this.lblNoRM.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRM.Location = new System.Drawing.Point(108, 3);
            this.lblNoRM.Name = "lblNoRM";
            this.lblNoRM.Size = new System.Drawing.Size(91, 27);
            this.lblNoRM.TabIndex = 1;
            this.lblNoRM.Text = "88888888";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = false;
            this.lblNama.BackColor = System.Drawing.Color.Transparent;
            this.lblNama.Enabled = false;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(108, 28);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(313, 23);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "Nama Pasien";
            // 
            // lblUmur
            // 
            this.lblUmur.AutoSize = false;
            this.lblUmur.BackColor = System.Drawing.Color.Transparent;
            this.lblUmur.Enabled = false;
            this.lblUmur.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUmur.Location = new System.Drawing.Point(108, 50);
            this.lblUmur.Name = "lblUmur";
            this.lblUmur.Size = new System.Drawing.Size(91, 27);
            this.lblUmur.TabIndex = 3;
            this.lblUmur.Text = "30 tahun";
            // 
            // CardPasien
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.Controls.Add(this.lblUmur);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblNoRM);
            this.Controls.Add(this.pbJenisKelamin);
            this.Name = "CardPasien";
            this.Size = new System.Drawing.Size(435, 85);
            this.MouseEnter += new System.EventHandler(this.CardPasien_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CardPasien_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbJenisKelamin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNoRM;
        private Guna.UI2.WinForms.Guna2PictureBox pbJenisKelamin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNama;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUmur;
    }
}
