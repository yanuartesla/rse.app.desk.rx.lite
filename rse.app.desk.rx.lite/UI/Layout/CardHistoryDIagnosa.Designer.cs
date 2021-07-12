
namespace rse.app.desk.rx.lite.UI.Layout
{
    partial class CardHistoryDIagnosa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.title = new Guna.UI2.WinForms.Guna2Panel();
            this.footer = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnCopy = new Guna.UI2.WinForms.Guna2Button();
            this.main = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvDiagnosa = new Guna.UI2.WinForms.Guna2DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.footer.SuspendLayout();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosa)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // title
            // 
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.ShadowDecoration.Parent = this.title;
            this.title.Size = new System.Drawing.Size(332, 46);
            this.title.TabIndex = 0;
            // 
            // footer
            // 
            this.footer.Controls.Add(this.btnCopy);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 203);
            this.footer.Name = "footer";
            this.footer.ShadowDecoration.Parent = this.footer;
            this.footer.Size = new System.Drawing.Size(332, 37);
            this.footer.TabIndex = 1;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.AutoRoundedCorners = true;
            this.btnCopy.BorderRadius = 11;
            this.btnCopy.CheckedState.Parent = this.btnCopy;
            this.btnCopy.CustomImages.Parent = this.btnCopy;
            this.btnCopy.FillColor = System.Drawing.Color.ForestGreen;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.HoverState.Parent = this.btnCopy;
            this.btnCopy.Location = new System.Drawing.Point(111, 6);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.ShadowDecoration.Parent = this.btnCopy;
            this.btnCopy.Size = new System.Drawing.Size(101, 24);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            // 
            // main
            // 
            this.main.Controls.Add(this.dgvDiagnosa);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 46);
            this.main.Name = "main";
            this.main.ShadowDecoration.Parent = this.main;
            this.main.Size = new System.Drawing.Size(332, 157);
            this.main.TabIndex = 2;
            // 
            // dgvDiagnosa
            // 
            this.dgvDiagnosa.AllowUserToAddRows = false;
            this.dgvDiagnosa.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvDiagnosa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiagnosa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiagnosa.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiagnosa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiagnosa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiagnosa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiagnosa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDiagnosa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.icd,
            this.desc});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiagnosa.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDiagnosa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiagnosa.EnableHeadersVisualStyles = false;
            this.dgvDiagnosa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvDiagnosa.Location = new System.Drawing.Point(0, 0);
            this.dgvDiagnosa.Name = "dgvDiagnosa";
            this.dgvDiagnosa.ReadOnly = true;
            this.dgvDiagnosa.RowHeadersVisible = false;
            this.dgvDiagnosa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnosa.Size = new System.Drawing.Size(332, 157);
            this.dgvDiagnosa.TabIndex = 0;
            this.dgvDiagnosa.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Emerald;
            this.dgvDiagnosa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(239)))), ((int)(((byte)(212)))));
            this.dgvDiagnosa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDiagnosa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDiagnosa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDiagnosa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDiagnosa.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDiagnosa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(238)))), ((int)(((byte)(208)))));
            this.dgvDiagnosa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.dgvDiagnosa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDiagnosa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDiagnosa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDiagnosa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosa.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvDiagnosa.ThemeStyle.ReadOnly = true;
            this.dgvDiagnosa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(244)))), ((int)(((byte)(226)))));
            this.dgvDiagnosa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiagnosa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvDiagnosa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDiagnosa.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDiagnosa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(221)))), ((int)(((byte)(160)))));
            this.dgvDiagnosa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // no
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.no.DefaultCellStyle = dataGridViewCellStyle3;
            this.no.FillWeight = 20F;
            this.no.HeaderText = "No.";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // icd
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.icd.DefaultCellStyle = dataGridViewCellStyle4;
            this.icd.FillWeight = 50F;
            this.icd.HeaderText = "Kode ICD";
            this.icd.Name = "icd";
            this.icd.ReadOnly = true;
            // 
            // desc
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.desc.DefaultCellStyle = dataGridViewCellStyle5;
            this.desc.HeaderText = "Desc";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            // 
            // CardHistoryDIagnosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.main);
            this.Controls.Add(this.footer);
            this.Controls.Add(this.title);
            this.Name = "CardHistoryDIagnosa";
            this.Size = new System.Drawing.Size(332, 240);
            this.footer.ResumeLayout(false);
            this.main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel main;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel footer;
        private Guna.UI2.WinForms.Guna2Button btnCopy;
        private Guna.UI2.WinForms.Guna2Panel title;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDiagnosa;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn icd;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
    }
}
