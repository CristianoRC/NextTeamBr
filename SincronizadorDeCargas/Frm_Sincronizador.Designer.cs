namespace SincronizadorDeCargas
{
    partial class Frm_Sincronizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sincronizador));
            this.Lbl_Informacao = new System.Windows.Forms.Label();
            this.Btm_Sincronizar = new System.Windows.Forms.Button();
            this.Lbl_Instalação = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Caminho = new System.Windows.Forms.TextBox();
            this.Btm_Procurar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Lbl_Informacao
            // 
            this.Lbl_Informacao.AutoSize = true;
            this.Lbl_Informacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Informacao.ForeColor = System.Drawing.Color.Green;
            this.Lbl_Informacao.Location = new System.Drawing.Point(123, 261);
            this.Lbl_Informacao.Name = "Lbl_Informacao";
            this.Lbl_Informacao.Size = new System.Drawing.Size(0, 15);
            this.Lbl_Informacao.TabIndex = 1;
            // 
            // Btm_Sincronizar
            // 
            this.Btm_Sincronizar.BackgroundImage = global::SincronizadorDeCargas.Properties.Resources.Connection_Sync_100;
            this.Btm_Sincronizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btm_Sincronizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_Sincronizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Sincronizar.Location = new System.Drawing.Point(122, 44);
            this.Btm_Sincronizar.Name = "Btm_Sincronizar";
            this.Btm_Sincronizar.Size = new System.Drawing.Size(258, 197);
            this.Btm_Sincronizar.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Btm_Sincronizar, "Sincronizar carga");
            this.Btm_Sincronizar.UseVisualStyleBackColor = true;
            this.Btm_Sincronizar.Click += new System.EventHandler(this.Btm_Sincronizar_Click);
            // 
            // Lbl_Instalação
            // 
            this.Lbl_Instalação.AutoSize = true;
            this.Lbl_Instalação.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Instalação.ForeColor = System.Drawing.Color.Green;
            this.Lbl_Instalação.Location = new System.Drawing.Point(161, 247);
            this.Lbl_Instalação.Name = "Lbl_Instalação";
            this.Lbl_Instalação.Size = new System.Drawing.Size(0, 15);
            this.Lbl_Instalação.TabIndex = 2;
            this.Lbl_Instalação.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Game.sii:";
            // 
            // Txt_Caminho
            // 
            this.Txt_Caminho.Location = new System.Drawing.Point(98, 18);
            this.Txt_Caminho.Name = "Txt_Caminho";
            this.Txt_Caminho.Size = new System.Drawing.Size(315, 20);
            this.Txt_Caminho.TabIndex = 4;
            // 
            // Btm_Procurar
            // 
            this.Btm_Procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Procurar.Location = new System.Drawing.Point(419, 17);
            this.Btm_Procurar.Name = "Btm_Procurar";
            this.Btm_Procurar.Size = new System.Drawing.Size(80, 23);
            this.Btm_Procurar.TabIndex = 5;
            this.Btm_Procurar.Text = "Procurar";
            this.Btm_Procurar.UseVisualStyleBackColor = true;
            this.Btm_Procurar.Click += new System.EventHandler(this.Btm_Procurar_Click);
            // 
            // Frm_Sincronizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 291);
            this.Controls.Add(this.Btm_Procurar);
            this.Controls.Add(this.Txt_Caminho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Instalação);
            this.Controls.Add(this.Lbl_Informacao);
            this.Controls.Add(this.Btm_Sincronizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Sincronizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sincronizador de cargas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Sincronizador_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btm_Sincronizar;
        private System.Windows.Forms.Label Lbl_Informacao;
        private System.Windows.Forms.Label Lbl_Instalação;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Caminho;
        private System.Windows.Forms.Button Btm_Procurar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}