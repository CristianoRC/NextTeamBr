namespace NextteamBr.PainelAdministraivo
{
    partial class Frm_SetarEmpresa
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
            this.Btm_Setar = new System.Windows.Forms.Button();
            this.comboMotoristas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btm_Setar
            // 
            this.Btm_Setar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Setar.Location = new System.Drawing.Point(372, 24);
            this.Btm_Setar.Name = "Btm_Setar";
            this.Btm_Setar.Size = new System.Drawing.Size(114, 104);
            this.Btm_Setar.TabIndex = 0;
            this.Btm_Setar.Text = "Setar Empresa";
            this.Btm_Setar.UseVisualStyleBackColor = true;
            this.Btm_Setar.Click += new System.EventHandler(this.Btm_Ativar_Click);
            // 
            // comboMotoristas
            // 
            this.comboMotoristas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMotoristas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMotoristas.FormattingEnabled = true;
            this.comboMotoristas.Location = new System.Drawing.Point(68, 23);
            this.comboMotoristas.Name = "comboMotoristas";
            this.comboMotoristas.Size = new System.Drawing.Size(298, 21);
            this.comboMotoristas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motorista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empresa";
            // 
            // comboEmpresa
            // 
            this.comboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEmpresa.FormattingEnabled = true;
            this.comboEmpresa.Location = new System.Drawing.Point(68, 66);
            this.comboEmpresa.Name = "comboEmpresa";
            this.comboEmpresa.Size = new System.Drawing.Size(298, 21);
            this.comboEmpresa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(68, 108);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(298, 20);
            this.txt_senha.TabIndex = 6;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // Frm_SetarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 149);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMotoristas);
            this.Controls.Add(this.Btm_Setar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_SetarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setar Empresa";
            this.Load += new System.EventHandler(this.Frm_Ativar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btm_Setar;
        private System.Windows.Forms.ComboBox comboMotoristas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_senha;
    }
}