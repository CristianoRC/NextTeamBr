namespace NextteamBr
{
    partial class Frm_InfoMotorista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InfoMotorista));
            this.Btm_LocalizarImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Empresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Codigo = new System.Windows.Forms.TextBox();
            this.Pic_Motorista = new System.Windows.Forms.PictureBox();
            this.Btm_SalvarInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Motorista)).BeginInit();
            this.SuspendLayout();
            // 
            // Btm_LocalizarImagen
            // 
            this.Btm_LocalizarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_LocalizarImagen.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_LocalizarImagen.Location = new System.Drawing.Point(105, 199);
            this.Btm_LocalizarImagen.Name = "Btm_LocalizarImagen";
            this.Btm_LocalizarImagen.Size = new System.Drawing.Size(175, 23);
            this.Btm_LocalizarImagen.TabIndex = 1;
            this.Btm_LocalizarImagen.Text = "Alterar Foto";
            this.Btm_LocalizarImagen.UseVisualStyleBackColor = true;
            this.Btm_LocalizarImagen.Click += new System.EventHandler(this.Btm_LocalizarImagen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(66, 253);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(288, 20);
            this.Txt_Nome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empresa";
            // 
            // Txt_Empresa
            // 
            this.Txt_Empresa.Location = new System.Drawing.Point(66, 298);
            this.Txt_Empresa.Name = "Txt_Empresa";
            this.Txt_Empresa.Size = new System.Drawing.Size(288, 20);
            this.Txt_Empresa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numeração";
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(66, 340);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Size = new System.Drawing.Size(288, 20);
            this.Txt_Codigo.TabIndex = 7;
            // 
            // Pic_Motorista
            // 
            this.Pic_Motorista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Motorista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pic_Motorista.Location = new System.Drawing.Point(108, 12);
            this.Pic_Motorista.Name = "Pic_Motorista";
            this.Pic_Motorista.Size = new System.Drawing.Size(172, 181);
            this.Pic_Motorista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Motorista.TabIndex = 0;
            this.Pic_Motorista.TabStop = false;
            // 
            // Btm_SalvarInfo
            // 
            this.Btm_SalvarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_SalvarInfo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btm_SalvarInfo.Location = new System.Drawing.Point(66, 386);
            this.Btm_SalvarInfo.Name = "Btm_SalvarInfo";
            this.Btm_SalvarInfo.Size = new System.Drawing.Size(288, 25);
            this.Btm_SalvarInfo.TabIndex = 8;
            this.Btm_SalvarInfo.Text = "Salvar Informações";
            this.Btm_SalvarInfo.UseVisualStyleBackColor = true;
            this.Btm_SalvarInfo.Click += new System.EventHandler(this.Btm_SalvarInfo_Click);
            // 
            // Frm_InfoMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(379, 423);
            this.Controls.Add(this.Btm_SalvarInfo);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.Txt_Empresa);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Btm_LocalizarImagen);
            this.Controls.Add(this.Pic_Motorista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_InfoMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações do motorista";
            this.Load += new System.EventHandler(this.Frm_InfoMotorista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Motorista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Motorista;
        private System.Windows.Forms.Button Btm_LocalizarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Empresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Codigo;
        private System.Windows.Forms.Button Btm_SalvarInfo;
    }
}