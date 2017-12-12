namespace NextteamBr.PainelAdministraivo
{
    partial class frm_ExcluirMotorista
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
            this.info = new System.Windows.Forms.GroupBox();
            this.checkMotorista = new System.Windows.Forms.CheckBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMotoristas = new System.Windows.Forms.ComboBox();
            this.Btm_Setar = new System.Windows.Forms.Button();
            this.info.SuspendLayout();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.Controls.Add(this.checkMotorista);
            this.info.Controls.Add(this.txt_senha);
            this.info.Controls.Add(this.label3);
            this.info.Controls.Add(this.label1);
            this.info.Controls.Add(this.comboMotoristas);
            this.info.Controls.Add(this.Btm_Setar);
            this.info.Location = new System.Drawing.Point(20, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(528, 162);
            this.info.TabIndex = 7;
            this.info.TabStop = false;
            this.info.Text = "Informações";
            // 
            // checkMotorista
            // 
            this.checkMotorista.AutoSize = true;
            this.checkMotorista.Checked = true;
            this.checkMotorista.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMotorista.Location = new System.Drawing.Point(71, 121);
            this.checkMotorista.Name = "checkMotorista";
            this.checkMotorista.Size = new System.Drawing.Size(183, 17);
            this.checkMotorista.TabIndex = 14;
            this.checkMotorista.Text = "Somente motoristas sem empresa";
            this.checkMotorista.UseVisualStyleBackColor = true;
            this.checkMotorista.CheckedChanged += new System.EventHandler(this.checkMotorista_CheckedChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(71, 77);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(309, 20);
            this.txt_senha.TabIndex = 13;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Motorista";
            // 
            // comboMotoristas
            // 
            this.comboMotoristas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMotoristas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMotoristas.FormattingEnabled = true;
            this.comboMotoristas.Location = new System.Drawing.Point(71, 34);
            this.comboMotoristas.Name = "comboMotoristas";
            this.comboMotoristas.Size = new System.Drawing.Size(309, 21);
            this.comboMotoristas.TabIndex = 8;
            // 
            // Btm_Setar
            // 
            this.Btm_Setar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Setar.Location = new System.Drawing.Point(397, 19);
            this.Btm_Setar.Name = "Btm_Setar";
            this.Btm_Setar.Size = new System.Drawing.Size(114, 104);
            this.Btm_Setar.TabIndex = 7;
            this.Btm_Setar.Text = "Excluir Motorista";
            this.Btm_Setar.UseVisualStyleBackColor = true;
            this.Btm_Setar.Click += new System.EventHandler(this.Btm_Setar_Click);
            // 
            // frm_ExcluirMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 184);
            this.Controls.Add(this.info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_ExcluirMotorista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excluir Motorista";
            this.Load += new System.EventHandler(this.Frm_Ativar_Load);
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMotoristas;
        private System.Windows.Forms.Button Btm_Setar;
        private System.Windows.Forms.CheckBox checkMotorista;
    }
}