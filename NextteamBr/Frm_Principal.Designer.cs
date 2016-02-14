namespace NextteamBr
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Lbl_Cambio = new System.Windows.Forms.Label();
            this.Lbl_KMH = new System.Windows.Forms.Label();
            this.Lbl_RPM = new System.Windows.Forms.Label();
            this.Lbl_KMRegistrado = new System.Windows.Forms.Label();
            this.Lbl_CidadeInicial = new System.Windows.Forms.Label();
            this.Lbl_EmpresaInicial = new System.Windows.Forms.Label();
            this.Lbl_CidadeDestino = new System.Windows.Forms.Label();
            this.Lbl_EmpresaDestino = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Btm_FreteCancelado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Cambio
            // 
            this.Lbl_Cambio.AutoSize = true;
            this.Lbl_Cambio.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cambio.Location = new System.Drawing.Point(33, 49);
            this.Lbl_Cambio.Name = "Lbl_Cambio";
            this.Lbl_Cambio.Size = new System.Drawing.Size(23, 15);
            this.Lbl_Cambio.TabIndex = 0;
            this.Lbl_Cambio.Text = "00";
            // 
            // Lbl_KMH
            // 
            this.Lbl_KMH.AutoSize = true;
            this.Lbl_KMH.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_KMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KMH.Location = new System.Drawing.Point(92, 49);
            this.Lbl_KMH.Name = "Lbl_KMH";
            this.Lbl_KMH.Size = new System.Drawing.Size(23, 15);
            this.Lbl_KMH.TabIndex = 1;
            this.Lbl_KMH.Text = "00";
            // 
            // Lbl_RPM
            // 
            this.Lbl_RPM.AutoSize = true;
            this.Lbl_RPM.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_RPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RPM.Location = new System.Drawing.Point(150, 49);
            this.Lbl_RPM.Name = "Lbl_RPM";
            this.Lbl_RPM.Size = new System.Drawing.Size(23, 15);
            this.Lbl_RPM.TabIndex = 2;
            this.Lbl_RPM.Text = "00";
            // 
            // Lbl_KMRegistrado
            // 
            this.Lbl_KMRegistrado.AutoSize = true;
            this.Lbl_KMRegistrado.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_KMRegistrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KMRegistrado.Location = new System.Drawing.Point(33, 102);
            this.Lbl_KMRegistrado.Name = "Lbl_KMRegistrado";
            this.Lbl_KMRegistrado.Size = new System.Drawing.Size(23, 15);
            this.Lbl_KMRegistrado.TabIndex = 3;
            this.Lbl_KMRegistrado.Text = "00";
            // 
            // Lbl_CidadeInicial
            // 
            this.Lbl_CidadeInicial.AutoSize = true;
            this.Lbl_CidadeInicial.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CidadeInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CidadeInicial.Location = new System.Drawing.Point(243, 89);
            this.Lbl_CidadeInicial.Name = "Lbl_CidadeInicial";
            this.Lbl_CidadeInicial.Size = new System.Drawing.Size(10, 13);
            this.Lbl_CidadeInicial.TabIndex = 4;
            this.Lbl_CidadeInicial.Text = ".";
            // 
            // Lbl_EmpresaInicial
            // 
            this.Lbl_EmpresaInicial.AutoSize = true;
            this.Lbl_EmpresaInicial.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_EmpresaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EmpresaInicial.Location = new System.Drawing.Point(243, 112);
            this.Lbl_EmpresaInicial.Name = "Lbl_EmpresaInicial";
            this.Lbl_EmpresaInicial.Size = new System.Drawing.Size(10, 13);
            this.Lbl_EmpresaInicial.TabIndex = 5;
            this.Lbl_EmpresaInicial.Text = ".";
            // 
            // Lbl_CidadeDestino
            // 
            this.Lbl_CidadeDestino.AutoSize = true;
            this.Lbl_CidadeDestino.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CidadeDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CidadeDestino.Location = new System.Drawing.Point(320, 89);
            this.Lbl_CidadeDestino.Name = "Lbl_CidadeDestino";
            this.Lbl_CidadeDestino.Size = new System.Drawing.Size(10, 13);
            this.Lbl_CidadeDestino.TabIndex = 6;
            this.Lbl_CidadeDestino.Text = ".";
            // 
            // Lbl_EmpresaDestino
            // 
            this.Lbl_EmpresaDestino.AutoSize = true;
            this.Lbl_EmpresaDestino.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_EmpresaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EmpresaDestino.Location = new System.Drawing.Point(320, 112);
            this.Lbl_EmpresaDestino.Name = "Lbl_EmpresaDestino";
            this.Lbl_EmpresaDestino.Size = new System.Drawing.Size(10, 13);
            this.Lbl_EmpresaDestino.TabIndex = 7;
            this.Lbl_EmpresaDestino.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Btm_FreteCancelado
            // 
            this.Btm_FreteCancelado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btm_FreteCancelado.Enabled = false;
            this.Btm_FreteCancelado.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btm_FreteCancelado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_FreteCancelado.Location = new System.Drawing.Point(483, 113);
            this.Btm_FreteCancelado.Name = "Btm_FreteCancelado";
            this.Btm_FreteCancelado.Size = new System.Drawing.Size(108, 23);
            this.Btm_FreteCancelado.TabIndex = 9;
            this.Btm_FreteCancelado.Text = "Frete Cancelado";
            this.Btm_FreteCancelado.UseVisualStyleBackColor = false;
            this.Btm_FreteCancelado.Click += new System.EventHandler(this.Btm_FreteCancelado_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NextteamBr.Properties.Resources.registro_km_layout;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(603, 148);
            this.Controls.Add(this.Btm_FreteCancelado);
            this.Controls.Add(this.Lbl_EmpresaDestino);
            this.Controls.Add(this.Lbl_CidadeDestino);
            this.Controls.Add(this.Lbl_EmpresaInicial);
            this.Controls.Add(this.Lbl_CidadeInicial);
            this.Controls.Add(this.Lbl_KMRegistrado);
            this.Controls.Add(this.Lbl_RPM);
            this.Controls.Add(this.Lbl_KMH);
            this.Controls.Add(this.Lbl_Cambio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogBook NextTeamBr";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Principal_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Cambio;
        private System.Windows.Forms.Label Lbl_KMH;
        private System.Windows.Forms.Label Lbl_RPM;
        private System.Windows.Forms.Label Lbl_KMRegistrado;
        private System.Windows.Forms.Label Lbl_CidadeInicial;
        private System.Windows.Forms.Label Lbl_EmpresaInicial;
        private System.Windows.Forms.Label Lbl_CidadeDestino;
        private System.Windows.Forms.Label Lbl_EmpresaDestino;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btm_FreteCancelado;
    }
}