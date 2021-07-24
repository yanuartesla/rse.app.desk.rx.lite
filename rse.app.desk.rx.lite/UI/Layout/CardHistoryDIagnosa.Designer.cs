
namespace rse.app.desk.rx.lite.UI.Layout
{
    partial class CardHistoryDiagnosa
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
            this.title = new Guna.UI2.WinForms.Guna2Panel();
            this.lblKlinik = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNamaDokter = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTglReg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.footer = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnCopy = new Guna.UI2.WinForms.Guna2Button();
            this.main = new Guna.UI2.WinForms.Guna2Panel();
            this.treeViewDiagnosa = new System.Windows.Forms.TreeView();
            this.title.SuspendLayout();
            this.footer.SuspendLayout();
            this.main.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Beige;
            this.title.Controls.Add(this.lblKlinik);
            this.title.Controls.Add(this.lblNamaDokter);
            this.title.Controls.Add(this.lblTglReg);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.ShadowDecoration.Parent = this.title;
            this.title.Size = new System.Drawing.Size(257, 46);
            this.title.TabIndex = 0;
            // 
            // lblKlinik
            // 
            this.lblKlinik.AutoSize = false;
            this.lblKlinik.BackColor = System.Drawing.Color.Transparent;
            this.lblKlinik.Location = new System.Drawing.Point(106, 3);
            this.lblKlinik.Name = "lblKlinik";
            this.lblKlinik.Size = new System.Drawing.Size(143, 19);
            this.lblKlinik.TabIndex = 6;
            this.lblKlinik.Text = "Klinik";
            this.lblKlinik.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNamaDokter
            // 
            this.lblNamaDokter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNamaDokter.AutoSize = false;
            this.lblNamaDokter.BackColor = System.Drawing.Color.Transparent;
            this.lblNamaDokter.Enabled = false;
            this.lblNamaDokter.Location = new System.Drawing.Point(3, 25);
            this.lblNamaDokter.Name = "lblNamaDokter";
            this.lblNamaDokter.Size = new System.Drawing.Size(246, 18);
            this.lblNamaDokter.TabIndex = 5;
            this.lblNamaDokter.Text = "Nama Dokter";
            this.lblNamaDokter.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTglReg
            // 
            this.lblTglReg.BackColor = System.Drawing.Color.Transparent;
            this.lblTglReg.Enabled = false;
            this.lblTglReg.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTglReg.Location = new System.Drawing.Point(3, 3);
            this.lblTglReg.Name = "lblTglReg";
            this.lblTglReg.Size = new System.Drawing.Size(77, 19);
            this.lblTglReg.TabIndex = 4;
            this.lblTglReg.Text = "14 Mar 2021";
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.Beige;
            this.footer.Controls.Add(this.btnCopy);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.FillColor = System.Drawing.Color.Beige;
            this.footer.FillColor2 = System.Drawing.Color.Wheat;
            this.footer.FillColor3 = System.Drawing.Color.DarkKhaki;
            this.footer.FillColor4 = System.Drawing.Color.LemonChiffon;
            this.footer.Location = new System.Drawing.Point(0, 163);
            this.footer.Name = "footer";
            this.footer.ShadowDecoration.Parent = this.footer;
            this.footer.Size = new System.Drawing.Size(257, 31);
            this.footer.TabIndex = 1;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.AutoRoundedCorners = true;
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnCopy.BorderRadius = 11;
            this.btnCopy.CheckedState.Parent = this.btnCopy;
            this.btnCopy.CustomImages.Parent = this.btnCopy;
            this.btnCopy.FillColor = System.Drawing.Color.ForestGreen;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.HoverState.Parent = this.btnCopy;
            this.btnCopy.Location = new System.Drawing.Point(164, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ShadowDecoration.Parent = this.btnCopy;
            this.btnCopy.Size = new System.Drawing.Size(84, 24);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseTransparentBackground = true;
            // 
            // main
            // 
            this.main.Controls.Add(this.treeViewDiagnosa);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 46);
            this.main.Name = "main";
            this.main.ShadowDecoration.Parent = this.main;
            this.main.Size = new System.Drawing.Size(257, 117);
            this.main.TabIndex = 2;
            // 
            // treeViewDiagnosa
            // 
            this.treeViewDiagnosa.BackColor = System.Drawing.Color.Beige;
            this.treeViewDiagnosa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewDiagnosa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDiagnosa.Indent = 10;
            this.treeViewDiagnosa.ItemHeight = 14;
            this.treeViewDiagnosa.Location = new System.Drawing.Point(0, 0);
            this.treeViewDiagnosa.Name = "treeViewDiagnosa";
            this.treeViewDiagnosa.Scrollable = false;
            this.treeViewDiagnosa.ShowLines = false;
            this.treeViewDiagnosa.ShowPlusMinus = false;
            this.treeViewDiagnosa.Size = new System.Drawing.Size(257, 117);
            this.treeViewDiagnosa.TabIndex = 0;
            this.treeViewDiagnosa.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDiagnosa_AfterSelect);
            // 
            // CardHistoryDiagnosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.main);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.title);
            this.Name = "CardHistoryDiagnosa";
            this.Size = new System.Drawing.Size(257, 194);
            this.Load += new System.EventHandler(this.CardHistoryDiagnosa_Load);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.footer.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel main;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel footer;
        private Guna.UI2.WinForms.Guna2Button btnCopy;
        private Guna.UI2.WinForms.Guna2Panel title;
        private System.Windows.Forms.TreeView treeViewDiagnosa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblKlinik;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNamaDokter;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTglReg;
    }
}
