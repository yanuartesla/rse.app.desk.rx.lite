
namespace rse.app.desk.rx.lite.UI.Layout
{
    partial class CardHistoriPasien
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
            this.pnlStatus = new Guna.UI2.WinForms.Guna2Panel();
            this.lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlUtama = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNama = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNoRM = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlStatus.SuspendLayout();
            this.pnlUtama.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.Orange;
            this.pnlStatus.Controls.Add(this.lblStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlStatus.Enabled = false;
            this.pnlStatus.Location = new System.Drawing.Point(122, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.ShadowDecoration.Parent = this.pnlStatus;
            this.pnlStatus.Size = new System.Drawing.Size(73, 42);
            this.pnlStatus.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Enabled = false;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 42);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Waiting";
            this.lblStatus.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlUtama
            // 
            this.pnlUtama.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlUtama.Controls.Add(this.lblNama);
            this.pnlUtama.Controls.Add(this.lblNoRM);
            this.pnlUtama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUtama.Enabled = false;
            this.pnlUtama.Location = new System.Drawing.Point(0, 0);
            this.pnlUtama.Name = "pnlUtama";
            this.pnlUtama.ShadowDecoration.Parent = this.pnlUtama;
            this.pnlUtama.Size = new System.Drawing.Size(122, 42);
            this.pnlUtama.TabIndex = 1;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = false;
            this.lblNama.BackColor = System.Drawing.Color.Transparent;
            this.lblNama.Enabled = false;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(6, 24);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(110, 17);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama";
            // 
            // lblNoRM
            // 
            this.lblNoRM.BackColor = System.Drawing.Color.Transparent;
            this.lblNoRM.Enabled = false;
            this.lblNoRM.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRM.Location = new System.Drawing.Point(6, 2);
            this.lblNoRM.Name = "lblNoRM";
            this.lblNoRM.Size = new System.Drawing.Size(57, 23);
            this.lblNoRM.TabIndex = 0;
            this.lblNoRM.Text = "888888";
            // 
            // CardHistoriPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.Controls.Add(this.pnlUtama);
            this.Controls.Add(this.pnlStatus);
            this.Name = "CardHistoriPasien";
            this.Size = new System.Drawing.Size(195, 42);
            this.MouseEnter += new System.EventHandler(this.CardHistoriPasien_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CardHistoriPasien_MouseLeave);
            this.pnlStatus.ResumeLayout(false);
            this.pnlUtama.ResumeLayout(false);
            this.pnlUtama.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel pnlUtama;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNoRM;
        private Guna.UI2.WinForms.Guna2Panel pnlStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNama;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
    }
}
