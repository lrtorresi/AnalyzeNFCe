namespace AnalyzeNFC_e
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnProcurar1 = new System.Windows.Forms.Button();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.erro1 = new System.Windows.Forms.PictureBox();
            this.check1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.error2 = new System.Windows.Forms.PictureBox();
            this.check2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPath2 = new System.Windows.Forms.Label();
            this.btnProcurar2 = new System.Windows.Forms.Button();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcurar1
            // 
            this.btnProcurar1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProcurar1.Location = new System.Drawing.Point(298, 72);
            this.btnProcurar1.Name = "btnProcurar1";
            this.btnProcurar1.Size = new System.Drawing.Size(75, 22);
            this.btnProcurar1.TabIndex = 0;
            this.btnProcurar1.Text = "Procurar";
            this.btnProcurar1.UseVisualStyleBackColor = true;
            this.btnProcurar1.Click += new System.EventHandler(this.btnProcurar1_Click);
            // 
            // txtBox1
            // 
            this.txtBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox1.Location = new System.Drawing.Point(9, 73);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(288, 21);
            this.txtBox1.TabIndex = 1;
            // 
            // btnImportar
            // 
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(494, 365);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(96, 23);
            this.btnImportar.TabIndex = 2;
            this.btnImportar.Text = "Avançar >";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.BackColor = System.Drawing.Color.Transparent;
            this.lblPath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPath.Location = new System.Drawing.Point(7, 58);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(124, 13);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "Arquivo selecionado:";
            this.lblPath.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selecione o arquivo XLS gerado através do MDC Orchestra M7 (Plugins)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.erro1);
            this.groupBox1.Controls.Add(this.check1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblPath);
            this.groupBox1.Controls.Add(this.btnProcurar1);
            this.groupBox1.Controls.Add(this.txtBox1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(21, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MDC Orchestra (Plugins)";
            // 
            // erro1
            // 
            this.erro1.Image = global::AnalyzeNFC_e.Properties.Resources.error;
            this.erro1.Location = new System.Drawing.Point(379, 58);
            this.erro1.Name = "erro1";
            this.erro1.Size = new System.Drawing.Size(82, 40);
            this.erro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.erro1.TabIndex = 6;
            this.erro1.TabStop = false;
            this.erro1.Visible = false;
            // 
            // check1
            // 
            this.check1.Image = global::AnalyzeNFC_e.Properties.Resources.check;
            this.check1.Location = new System.Drawing.Point(379, 58);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(82, 40);
            this.check1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check1.TabIndex = 5;
            this.check1.TabStop = false;
            this.check1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.error2);
            this.groupBox2.Controls.Add(this.check2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblPath2);
            this.groupBox2.Controls.Add(this.btnProcurar2);
            this.groupBox2.Controls.Add(this.txtBox2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(21, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 135);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MIGRATE (xls)";
            // 
            // error2
            // 
            this.error2.Image = global::AnalyzeNFC_e.Properties.Resources.error;
            this.error2.Location = new System.Drawing.Point(379, 56);
            this.error2.Name = "error2";
            this.error2.Size = new System.Drawing.Size(82, 40);
            this.error2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.error2.TabIndex = 7;
            this.error2.TabStop = false;
            this.error2.Visible = false;
            // 
            // check2
            // 
            this.check2.Image = global::AnalyzeNFC_e.Properties.Resources.check;
            this.check2.Location = new System.Drawing.Point(379, 56);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(82, 40);
            this.check2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check2.TabIndex = 6;
            this.check2.TabStop = false;
            this.check2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o arquivo XLS gerado através do Portal MIGRATE";
            // 
            // lblPath2
            // 
            this.lblPath2.AutoSize = true;
            this.lblPath2.BackColor = System.Drawing.Color.Transparent;
            this.lblPath2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPath2.Location = new System.Drawing.Point(7, 58);
            this.lblPath2.Name = "lblPath2";
            this.lblPath2.Size = new System.Drawing.Size(124, 13);
            this.lblPath2.TabIndex = 3;
            this.lblPath2.Text = "Arquivo selecionado:";
            this.lblPath2.Visible = false;
            // 
            // btnProcurar2
            // 
            this.btnProcurar2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProcurar2.Location = new System.Drawing.Point(298, 73);
            this.btnProcurar2.Name = "btnProcurar2";
            this.btnProcurar2.Size = new System.Drawing.Size(75, 22);
            this.btnProcurar2.TabIndex = 0;
            this.btnProcurar2.Text = "Procurar";
            this.btnProcurar2.UseVisualStyleBackColor = true;
            this.btnProcurar2.Click += new System.EventHandler(this.btnProcurar2_Click);
            // 
            // txtBox2
            // 
            this.txtBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox2.Location = new System.Drawing.Point(9, 73);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(288, 21);
            this.txtBox2.TabIndex = 1;
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblAlert.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlert.ForeColor = System.Drawing.Color.Red;
            this.lblAlert.Location = new System.Drawing.Point(21, 354);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(454, 16);
            this.lblAlert.TabIndex = 7;
            this.lblAlert.Text = "** Renomear o nome da Aba para [Sheet1] e salvar em formato XLS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AnalyzeNFC_e.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(601, 403);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImportar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnalyzeNFC-e";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcurar1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPath2;
        private System.Windows.Forms.Button btnProcurar2;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.PictureBox check1;
        private System.Windows.Forms.PictureBox check2;
        private System.Windows.Forms.PictureBox erro1;
        private System.Windows.Forms.PictureBox error2;
        private System.Windows.Forms.Label lblAlert;
    }
}

