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
            this.info = new System.Windows.Forms.GroupBox();
            this.checkMotorista = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMotoristas = new System.Windows.Forms.ComboBox();
            this.Btm_Setar = new System.Windows.Forms.Button();
            this.info.SuspendLayout();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.Controls.Add(this.checkMotorista);
            this.info.Controls.Add(this.label2);
            this.info.Controls.Add(this.comboEmpresa);
            this.info.Controls.Add(this.label1);
            this.info.Controls.Add(this.comboMotoristas);
            this.info.Controls.Add(this.Btm_Setar);
            this.info.Location = new System.Drawing.Point(20, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(528, 171);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Empresa";
            // 
            // comboEmpresa
            // 
            this.comboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEmpresa.FormattingEnabled = true;
            this.comboEmpresa.Location = new System.Drawing.Point(71, 77);
            this.comboEmpresa.Name = "comboEmpresa";
            this.comboEmpresa.Size = new System.Drawing.Size(309, 21);
            this.comboEmpresa.TabIndex = 10;
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
            this.Btm_Setar.Location = new System.Drawing.Point(398, 34);
            this.Btm_Setar.Name = "Btm_Setar";
            this.Btm_Setar.Size = new System.Drawing.Size(114, 104);
            this.Btm_Setar.TabIndex = 7;
            this.Btm_Setar.Text = "Setar Empresa";
            this.Btm_Setar.UseVisualStyleBackColor = true;
            this.Btm_Setar.Click += new System.EventHandler(this.Btm_Setar_Click);
            // 
            // Frm_SetarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 190);
            this.Controls.Add(this.info);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_SetarEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setar Empresa";
            this.Load += new System.EventHandler(this.Frm_Ativar_Load);
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMotoristas;
        private System.Windows.Forms.Button Btm_Setar;
        private System.Windows.Forms.CheckBox checkMotorista;
    }
}