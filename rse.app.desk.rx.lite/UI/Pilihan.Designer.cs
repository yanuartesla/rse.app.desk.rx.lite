namespace rse.app.desk.rx.lite.UI
{
    partial class Pilihan
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
            this.label1 = new System.Windows.Forms.Label();
            this.btYA = new System.Windows.Forms.Button();
            this.btTidak = new System.Windows.Forms.Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apakah ada penggunaan";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btYA
            // 
            this.btYA.BackColor = System.Drawing.Color.DarkViolet;
            this.btYA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btYA.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btYA.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btYA.Location = new System.Drawing.Point(12, 107);
            this.btYA.Name = "btYA";
            this.btYA.Size = new System.Drawing.Size(130, 42);
            this.btYA.TabIndex = 1;
            this.btYA.Text = "Ya";
            this.btYA.UseVisualStyleBackColor = false;
            this.btYA.Click += new System.EventHandler(this.btYA_Click);
            // 
            // btTidak
            // 
            this.btTidak.BackColor = System.Drawing.Color.LimeGreen;
            this.btTidak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTidak.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTidak.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btTidak.Location = new System.Drawing.Point(182, 107);
            this.btTidak.Name = "btTidak";
            this.btTidak.Size = new System.Drawing.Size(125, 42);
            this.btTidak.TabIndex = 2;
            this.btTidak.Text = "Tidak";
            this.btTidak.UseVisualStyleBackColor = false;
            this.btTidak.Click += new System.EventHandler(this.btTidak_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 32;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "ALAT KESEHATAN HABIS PAKAI ?";
            // 
            // Pilihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(335, 161);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btTidak);
            this.Controls.Add(this.btYA);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pilihan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pilihan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btYA;
        private System.Windows.Forms.Button btTidak;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label2;
    }
}