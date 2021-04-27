
namespace rse.app.desk.rx.lite.UI.Layout
{
    partial class CardResep
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
            this.leftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.rightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.searchContainTextBox1 = new rse.app.desk.rx.lite.Function.SearchContainTextBox();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.ShadowDecoration.Parent = this.leftPanel;
            this.leftPanel.Size = new System.Drawing.Size(170, 481);
            this.leftPanel.TabIndex = 0;
            // 
            // rightPanel
            // 
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(788, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.ShadowDecoration.Parent = this.rightPanel;
            this.rightPanel.Size = new System.Drawing.Size(134, 481);
            this.rightPanel.TabIndex = 1;
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.searchContainTextBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(170, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.ShadowDecoration.Parent = this.topPanel;
            this.topPanel.Size = new System.Drawing.Size(618, 65);
            this.topPanel.TabIndex = 2;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(170, 65);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.ShadowDecoration.Parent = this.MainPanel;
            this.MainPanel.Size = new System.Drawing.Size(618, 416);
            this.MainPanel.TabIndex = 3;
            // 
            // searchContainTextBox1
            // 
            this.searchContainTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchContainTextBox1.DefaultText = "";
            this.searchContainTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchContainTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchContainTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchContainTextBox1.DisabledState.Parent = this.searchContainTextBox1;
            this.searchContainTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchContainTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchContainTextBox1.FocusedState.Parent = this.searchContainTextBox1;
            this.searchContainTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchContainTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchContainTextBox1.HoverState.Parent = this.searchContainTextBox1;
            this.searchContainTextBox1.Location = new System.Drawing.Point(40, 18);
            this.searchContainTextBox1.Name = "searchContainTextBox1";
            this.searchContainTextBox1.PasswordChar = '\0';
            this.searchContainTextBox1.PlaceholderText = "";
            this.searchContainTextBox1.SelectedText = "";
            this.searchContainTextBox1.ShadowDecoration.Parent = this.searchContainTextBox1;
            this.searchContainTextBox1.Size = new System.Drawing.Size(200, 36);
            this.searchContainTextBox1.TabIndex = 0;
            this.searchContainTextBox1.Values = null;
            // 
            // CardResep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Name = "CardResep";
            this.Size = new System.Drawing.Size(922, 481);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel leftPanel;
        private Guna.UI2.WinForms.Guna2Panel rightPanel;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Function.SearchContainTextBox searchContainTextBox1;
    }
}
