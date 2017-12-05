namespace NextteamBr
{
    partial class Frm_Empresas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Empresas));
            this.dataRanking = new System.Windows.Forms.DataGridView();
            this.pictureEmpresa = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboEmpresas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_KmRodadoAnual = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_NumeroMotoristas = new System.Windows.Forms.Label();
            this.lbl_KMRodado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmpresa)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataRanking
            // 
            this.dataRanking.AllowUserToAddRows = false;
            this.dataRanking.AllowUserToDeleteRows = false;
            this.dataRanking.AllowUserToOrderColumns = true;
            this.dataRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRanking.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataRanking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRanking.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataRanking.Location = new System.Drawing.Point(198, 255);
            this.dataRanking.Name = "dataRanking";
            this.dataRanking.ReadOnly = true;
            this.dataRanking.Size = new System.Drawing.Size(493, 133);
            this.dataRanking.TabIndex = 2;
            this.dataRanking.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataRanking_CellFormatting);
            this.dataRanking.SelectionChanged += new System.EventHandler(this.dataRanking_SelectionChanged);
            // 
            // pictureEmpresa
            // 
            this.pictureEmpresa.BackgroundImage = global::NextteamBr.Properties.Resources.office;
            this.pictureEmpresa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureEmpresa.Location = new System.Drawing.Point(17, 259);
            this.pictureEmpresa.Name = "pictureEmpresa";
            this.pictureEmpresa.Size = new System.Drawing.Size(152, 129);
            this.pictureEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEmpresa.TabIndex = 3;
            this.pictureEmpresa.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::NextteamBr.Properties.Resources.Header2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 254);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboEmpresas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_KmRodadoAnual);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbl_NumeroMotoristas);
            this.groupBox1.Controls.Add(this.lbl_KMRodado);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(21, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 224);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Empresa";
            // 
            // comboEmpresas
            // 
            this.comboEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEmpresas.FormattingEnabled = true;
            this.comboEmpresas.Location = new System.Drawing.Point(109, 38);
            this.comboEmpresas.Name = "comboEmpresas";
            this.comboEmpresas.Size = new System.Drawing.Size(192, 21);
            this.comboEmpresas.TabIndex = 8;
            this.comboEmpresas.SelectedIndexChanged += new System.EventHandler(this.comboEmpresas_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nº Motorista:";
            // 
            // lbl_KmRodadoAnual
            // 
            this.lbl_KmRodadoAnual.AutoSize = true;
            this.lbl_KmRodadoAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KmRodadoAnual.Location = new System.Drawing.Point(139, 189);
            this.lbl_KmRodadoAnual.Name = "lbl_KmRodadoAnual";
            this.lbl_KmRodadoAnual.Size = new System.Drawing.Size(0, 15);
            this.lbl_KmRodadoAnual.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "KM Rodados mensal:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "KM Rodados anual:";
            // 
            // lbl_NumeroMotoristas
            // 
            this.lbl_NumeroMotoristas.AutoSize = true;
            this.lbl_NumeroMotoristas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroMotoristas.Location = new System.Drawing.Point(106, 92);
            this.lbl_NumeroMotoristas.Name = "lbl_NumeroMotoristas";
            this.lbl_NumeroMotoristas.Size = new System.Drawing.Size(0, 15);
            this.lbl_NumeroMotoristas.TabIndex = 4;
            // 
            // lbl_KMRodado
            // 
            this.lbl_KMRodado.AutoSize = true;
            this.lbl_KMRodado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KMRodado.Location = new System.Drawing.Point(148, 137);
            this.lbl_KMRodado.Name = "lbl_KMRodado";
            this.lbl_KMRodado.Size = new System.Drawing.Size(0, 15);
            this.lbl_KMRodado.TabIndex = 5;
            // 
            // Frm_Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(703, 400);
            this.Controls.Add(this.pictureEmpresa);
            this.Controls.Add(this.dataRanking);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Empresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações empresas";
            this.Load += new System.EventHandler(this.Frm_Empresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEmpresa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_KMRodado;
        private System.Windows.Forms.Label lbl_NumeroMotoristas;
        private System.Windows.Forms.Label lbl_KmRodadoAnual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboEmpresas;
        private System.Windows.Forms.DataGridView dataRanking;
        private System.Windows.Forms.PictureBox pictureEmpresa;
    }
}