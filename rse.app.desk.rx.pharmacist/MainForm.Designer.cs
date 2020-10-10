namespace rse.app.desk.rx.pharmacist
{
    partial class MainForm
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
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panelResepD = new System.Windows.Forms.Panel();
            this.cardResep1 = new rse.app.desk.rx.pharmacist.UI.CardResep();
            this.bsResepOrder = new System.Windows.Forms.BindingSource(this.components);
            this.yakkumdb = new rse.app.desk.rx.pharmacist.Dataset.yakkumdb();
            this.resep_orderTableAdapter = new rse.app.desk.rx.pharmacist.Dataset.yakkumdbTableAdapters.resep_orderTableAdapter();
            this.flowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsResepOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayout
            // 
            this.flowLayout.AutoScroll = true;
            this.flowLayout.BackColor = System.Drawing.Color.LightSlateGray;
            this.flowLayout.Controls.Add(this.cardResep1);
            this.flowLayout.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayout.Location = new System.Drawing.Point(699, 0);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.flowLayout.Size = new System.Drawing.Size(365, 681);
            this.flowLayout.TabIndex = 0;
            // 
            // panelResepD
            // 
            this.panelResepD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResepD.Location = new System.Drawing.Point(0, 0);
            this.panelResepD.Name = "panelResepD";
            this.panelResepD.Size = new System.Drawing.Size(699, 681);
            this.panelResepD.TabIndex = 1;
            // 
            // cardResep1
            // 
            this.cardResep1.alamat = null;
            this.cardResep1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cardResep1.jk = null;
            this.cardResep1.Location = new System.Drawing.Point(18, 13);
            this.cardResep1.Nama = null;
            this.cardResep1.namaklinik = null;
            this.cardResep1.Name = "cardResep1";
            this.cardResep1.NOreg = null;
            this.cardResep1.NoResep = null;
            this.cardResep1.NoRM = null;
            this.cardResep1.Size = new System.Drawing.Size(323, 118);
            this.cardResep1.TabIndex = 0;
            this.cardResep1.tgllahir = null;
            this.cardResep1.Visible = false;
            // 
            // bsResepOrder
            // 
            this.bsResepOrder.DataMember = "resep_order";
            this.bsResepOrder.DataSource = this.yakkumdb;
            // 
            // yakkumdb
            // 
            this.yakkumdb.DataSetName = "yakkumdb";
            this.yakkumdb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resep_orderTableAdapter
            // 
            this.resep_orderTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.panelResepD);
            this.Controls.Add(this.flowLayout);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsResepOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakkumdb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Panel panelResepD;
        private UI.CardResep cardResep1;
        private System.Windows.Forms.BindingSource bsResepOrder;
        private Dataset.yakkumdb yakkumdb;
        private Dataset.yakkumdbTableAdapters.resep_orderTableAdapter resep_orderTableAdapter;
    }
}