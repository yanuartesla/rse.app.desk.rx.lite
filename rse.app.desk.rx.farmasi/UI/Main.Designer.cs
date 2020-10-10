namespace rse.app.desk.rx.farmasi
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.listPanel = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.cardResep = new rse.app.desk.rx.farmasi.UI.CardResep();
            this.bunifuPanel1.SuspendLayout();
            this.flowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.listPanel.BorderRadius = 32;
            this.listPanel.BorderThickness = 1;
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.listPanel.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.listPanel.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.listPanel.Location = new System.Drawing.Point(466, 0);
            this.listPanel.Name = "listPanel";
            this.listPanel.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.listPanel.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.listPanel.ShadowColor = System.Drawing.Color.DarkGray;
            this.listPanel.ShadowDept = 2;
            this.listPanel.ShadowDepth = 5;
            this.listPanel.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.listPanel.ShadowTopLeftVisible = false;
            this.listPanel.Size = new System.Drawing.Size(346, 476);
            this.listPanel.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.listPanel.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.flowLayout);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(466, 476);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.Controls.Add(this.cardResep);
            this.flowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayout.Location = new System.Drawing.Point(141, 12);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(319, 452);
            this.flowLayout.TabIndex = 0;
            // 
            // cardResep
            // 
            this.cardResep.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cardResep.Location = new System.Drawing.Point(3, 3);
            this.cardResep.Nama = null;
            this.cardResep.Name = "cardResep";
            this.cardResep.NOreg = null;
            this.cardResep.NoResep = null;
            this.cardResep.NoRM = null;
            this.cardResep.Size = new System.Drawing.Size(300, 125);
            this.cardResep.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 476);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.listPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "E - Prescription";
            this.bunifuPanel1.ResumeLayout(false);
            this.flowLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel listPanel;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private UI.CardResep cardResep;
    }
}

