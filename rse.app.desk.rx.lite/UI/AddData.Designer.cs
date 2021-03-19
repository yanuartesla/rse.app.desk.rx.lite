
namespace rse.app.desk.rx.lite.UI
{
    partial class AddData
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
            this.pnlDataPasien = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabAnamnesa = new System.Windows.Forms.TabPage();
            this.tabDiagnosa = new System.Windows.Forms.TabPage();
            this.tabResep = new System.Windows.Forms.TabPage();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlDataPasien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.tabData.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.HasFormShadow = false;
            // 
            // pnlDataPasien
            // 
            this.pnlDataPasien.AutoRoundedCorners = true;
            this.pnlDataPasien.BackColor = System.Drawing.Color.SeaShell;
            this.pnlDataPasien.BorderRadius = 50;
            this.pnlDataPasien.Controls.Add(this.guna2PictureBox1);
            this.pnlDataPasien.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDataPasien.Location = new System.Drawing.Point(5, 5);
            this.pnlDataPasien.Name = "pnlDataPasien";
            this.pnlDataPasien.ShadowDecoration.Parent = this.pnlDataPasien;
            this.pnlDataPasien.Size = new System.Drawing.Size(869, 103);
            this.pnlDataPasien.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.guna2PictureBox1.BorderRadius = 16;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = global::rse.app.desk.rx.lite.Properties.Resources.pharmacist_female;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(119, 103);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // tabData
            // 
            this.tabData.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabData.Controls.Add(this.tabAnamnesa);
            this.tabData.Controls.Add(this.tabDiagnosa);
            this.tabData.Controls.Add(this.tabResep);
            this.tabData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabData.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabData.Location = new System.Drawing.Point(5, 108);
            this.tabData.Multiline = true;
            this.tabData.Name = "tabData";
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(869, 488);
            this.tabData.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabData.TabIndex = 1;
            // 
            // tabAnamnesa
            // 
            this.tabAnamnesa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabAnamnesa.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAnamnesa.Location = new System.Drawing.Point(4, 4);
            this.tabAnamnesa.Name = "tabAnamnesa";
            this.tabAnamnesa.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnamnesa.Size = new System.Drawing.Size(840, 480);
            this.tabAnamnesa.TabIndex = 0;
            this.tabAnamnesa.Text = "Anamnesa";
            // 
            // tabDiagnosa
            // 
            this.tabDiagnosa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabDiagnosa.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDiagnosa.Location = new System.Drawing.Point(4, 4);
            this.tabDiagnosa.Name = "tabDiagnosa";
            this.tabDiagnosa.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiagnosa.Size = new System.Drawing.Size(840, 480);
            this.tabDiagnosa.TabIndex = 1;
            this.tabDiagnosa.Text = "Diagnosa";
            // 
            // tabResep
            // 
            this.tabResep.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabResep.Location = new System.Drawing.Point(4, 4);
            this.tabResep.Name = "tabResep";
            this.tabResep.Size = new System.Drawing.Size(840, 480);
            this.tabResep.TabIndex = 2;
            this.tabResep.Text = "Resep";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 16;
            this.guna2Elipse1.TargetControl = this.pnlDataPasien;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 24;
            this.guna2Elipse2.TargetControl = this.tabData;
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(879, 601);
            this.Controls.Add(this.tabData);
            this.Controls.Add(this.pnlDataPasien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddData";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "AddData";
            this.Load += new System.EventHandler(this.AddData_Load);
            this.pnlDataPasien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.tabData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel pnlDataPasien;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.TabPage tabAnamnesa;
        private System.Windows.Forms.TabPage tabDiagnosa;
        private System.Windows.Forms.TabPage tabResep;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}