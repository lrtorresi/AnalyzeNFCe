namespace AnalyzeNFC_e.Forms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTotalPlugins = new System.Windows.Forms.Label();
            this.lblpluginsAlert = new System.Windows.Forms.Label();
            this.pluginsView = new System.Windows.Forms.ListView();
            this.serie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serie2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nf2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotalMigrate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.migrateView = new System.Windows.Forms.ListView();
            this.seriemigrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nfmigrate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serieplugins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nfplugins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 489);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotalPlugins);
            this.tabPage1.Controls.Add(this.lblpluginsAlert);
            this.tabPage1.Controls.Add(this.pluginsView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(808, 463);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Orchestra (Plugins)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblTotalPlugins
            // 
            this.lblTotalPlugins.AutoSize = true;
            this.lblTotalPlugins.Location = new System.Drawing.Point(8, 27);
            this.lblTotalPlugins.Name = "lblTotalPlugins";
            this.lblTotalPlugins.Size = new System.Drawing.Size(34, 13);
            this.lblTotalPlugins.TabIndex = 2;
            this.lblTotalPlugins.Text = "Total:";
            // 
            // lblpluginsAlert
            // 
            this.lblpluginsAlert.AutoSize = true;
            this.lblpluginsAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpluginsAlert.ForeColor = System.Drawing.Color.Red;
            this.lblpluginsAlert.Location = new System.Drawing.Point(8, 7);
            this.lblpluginsAlert.Name = "lblpluginsAlert";
            this.lblpluginsAlert.Size = new System.Drawing.Size(379, 15);
            this.lblpluginsAlert.TabIndex = 1;
            this.lblpluginsAlert.Text = "XML que ESTÃO no Orchestra (plugins), mas NÃO estão na Migrate.\r\n";
            // 
            // pluginsView
            // 
            this.pluginsView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pluginsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serie,
            this.nf,
            this.serie2,
            this.nf2});
            this.pluginsView.GridLines = true;
            this.pluginsView.Location = new System.Drawing.Point(3, 46);
            this.pluginsView.Name = "pluginsView";
            this.pluginsView.Size = new System.Drawing.Size(785, 379);
            this.pluginsView.TabIndex = 0;
            this.pluginsView.UseCompatibleStateImageBehavior = false;
            this.pluginsView.View = System.Windows.Forms.View.Details;
            // 
            // serie
            // 
            this.serie.Text = "Série (Orchestra Plugins)";
            this.serie.Width = 148;
            // 
            // nf
            // 
            this.nf.Text = "Cupom Fiscal (Orchestra Plugins)";
            this.nf.Width = 182;
            // 
            // serie2
            // 
            this.serie2.Text = "Série (MIGRATE)";
            this.serie2.Width = 162;
            // 
            // nf2
            // 
            this.nf2.Text = "Cupom Fiscal (MIGRATE)";
            this.nf2.Width = 170;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTotalMigrate);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.migrateView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(808, 463);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MIGRATE (Portal)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotalMigrate
            // 
            this.lblTotalMigrate.AutoSize = true;
            this.lblTotalMigrate.Location = new System.Drawing.Point(8, 27);
            this.lblTotalMigrate.Name = "lblTotalMigrate";
            this.lblTotalMigrate.Size = new System.Drawing.Size(34, 13);
            this.lblTotalMigrate.TabIndex = 5;
            this.lblTotalMigrate.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(436, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "XML que ESTÃO no Portal Migrate, mas NÃO estão no sistema MDC (Plugins).\r\n";
            // 
            // migrateView
            // 
            this.migrateView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.migrateView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.seriemigrate,
            this.nfmigrate,
            this.serieplugins,
            this.nfplugins});
            this.migrateView.GridLines = true;
            this.migrateView.Location = new System.Drawing.Point(3, 46);
            this.migrateView.Name = "migrateView";
            this.migrateView.Size = new System.Drawing.Size(785, 379);
            this.migrateView.TabIndex = 3;
            this.migrateView.UseCompatibleStateImageBehavior = false;
            this.migrateView.View = System.Windows.Forms.View.Details;
            // 
            // seriemigrate
            // 
            this.seriemigrate.Text = "Série (Migrate)";
            this.seriemigrate.Width = 150;
            // 
            // nfmigrate
            // 
            this.nfmigrate.Text = "Cupom Fiscal (Migrate)";
            this.nfmigrate.Width = 166;
            // 
            // serieplugins
            // 
            this.serieplugins.Text = "Série (Orchestra Plugins)";
            this.serieplugins.Width = 167;
            // 
            // nfplugins
            // 
            this.nfplugins.Text = "Cupom Fiscal (Orchestra Plugins)";
            this.nfplugins.Width = 206;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AnalyzeNFC_e.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "AnalyzeNFC-e :: Compare";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView pluginsView;
        private System.Windows.Forms.ColumnHeader serie;
        private System.Windows.Forms.ColumnHeader nf;
        private System.Windows.Forms.ColumnHeader serie2;
        private System.Windows.Forms.ColumnHeader nf2;
        private System.Windows.Forms.Label lblTotalPlugins;
        private System.Windows.Forms.Label lblpluginsAlert;
        private System.Windows.Forms.Label lblTotalMigrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView migrateView;
        private System.Windows.Forms.ColumnHeader seriemigrate;
        private System.Windows.Forms.ColumnHeader nfmigrate;
        private System.Windows.Forms.ColumnHeader serieplugins;
        private System.Windows.Forms.ColumnHeader nfplugins;
    }
}