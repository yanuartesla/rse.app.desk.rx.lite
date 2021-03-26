
namespace rse.app.desk.rx.lite.UI
{
    partial class Pin
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtPIN = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblWarning = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 6;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DragForm = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(32, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(209, 27);
            this.guna2HtmlLabel1.TabIndex = 99;
            this.guna2HtmlLabel1.TabStop = false;
            this.guna2HtmlLabel1.Text = "Masukan PIN Verifikasi";
            // 
            // txtPIN
            // 
            this.txtPIN.Animated = true;
            this.txtPIN.AutoRoundedCorners = true;
            this.txtPIN.BorderRadius = 17;
            this.txtPIN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPIN.DefaultText = "";
            this.txtPIN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPIN.DisabledState.Parent = this.txtPIN;
            this.txtPIN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPIN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPIN.FocusedState.Parent = this.txtPIN;
            this.txtPIN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPIN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPIN.HoverState.Parent = this.txtPIN;
            this.txtPIN.Location = new System.Drawing.Point(90, 45);
            this.txtPIN.MaxLength = 4;
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.PasswordChar = '\0';
            this.txtPIN.PlaceholderText = "1234";
            this.txtPIN.SelectedText = "";
            this.txtPIN.ShadowDecoration.Parent = this.txtPIN;
            this.txtPIN.Size = new System.Drawing.Size(100, 36);
            this.txtPIN.TabIndex = 0;
            this.txtPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPIN.TextChanged += new System.EventHandler(this.txtPIN_TextChanged);
            // 
            // lblWarning
            // 
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(105, 87);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(65, 15);
            this.lblWarning.TabIndex = 100;
            this.lblWarning.Text = "* PIN Salah !";
            this.lblWarning.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(97, 33);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Pin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 171);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWarning;
        private Guna.UI2.WinForms.Guna2TextBox txtPIN;
    }
}