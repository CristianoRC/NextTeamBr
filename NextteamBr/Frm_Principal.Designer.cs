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
            this.timerTs3 = new System.Windows.Forms.Timer(this.components);
            this.TimerAvisoSonoro = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pic_EmpresaDestino = new System.Windows.Forms.PictureBox();
            this.Pic_EmrpesaPartida = new System.Windows.Forms.PictureBox();
            this.Lbl_InfoGame = new System.Windows.Forms.Label();
            this.Lbl_InfoCarga = new System.Windows.Forms.Label();
            this.Lbl_Destino = new System.Windows.Forms.Label();
            this.Lbl_Partida = new System.Windows.Forms.Label();
            this.pictureSom = new System.Windows.Forms.PictureBox();
            this.PicCarga = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_EmpresaDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_EmrpesaPartida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTs3
            // 
            this.timerTs3.Interval = 25000;
            this.timerTs3.Tick += new System.EventHandler(this.TimerTs3_Tick);
            // 
            // TimerAvisoSonoro
            // 
            this.TimerAvisoSonoro.Enabled = true;
            this.TimerAvisoSonoro.Interval = 2000;
            this.TimerAvisoSonoro.Tick += new System.EventHandler(this.TimerAvisoSonoro_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.Pic_EmpresaDestino);
            this.panel1.Controls.Add(this.Pic_EmrpesaPartida);
            this.panel1.Controls.Add(this.Lbl_InfoGame);
            this.panel1.Controls.Add(this.Lbl_InfoCarga);
            this.panel1.Controls.Add(this.Lbl_Destino);
            this.panel1.Controls.Add(this.Lbl_Partida);
            this.panel1.Controls.Add(this.pictureSom);
            this.panel1.Controls.Add(this.PicCarga);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 300);
            this.panel1.TabIndex = 12;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Pic_EmpresaDestino
            // 
            this.Pic_EmpresaDestino.BackColor = System.Drawing.Color.Transparent;
            this.Pic_EmpresaDestino.Location = new System.Drawing.Point(633, 73);
            this.Pic_EmpresaDestino.Name = "Pic_EmpresaDestino";
            this.Pic_EmpresaDestino.Size = new System.Drawing.Size(92, 36);
            this.Pic_EmpresaDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_EmpresaDestino.TabIndex = 19;
            this.Pic_EmpresaDestino.TabStop = false;
            // 
            // Pic_EmrpesaPartida
            // 
            this.Pic_EmrpesaPartida.BackColor = System.Drawing.Color.Transparent;
            this.Pic_EmrpesaPartida.Location = new System.Drawing.Point(633, 28);
            this.Pic_EmrpesaPartida.Name = "Pic_EmrpesaPartida";
            this.Pic_EmrpesaPartida.Size = new System.Drawing.Size(92, 36);
            this.Pic_EmrpesaPartida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_EmrpesaPartida.TabIndex = 18;
            this.Pic_EmrpesaPartida.TabStop = false;
            // 
            // Lbl_InfoGame
            // 
            this.Lbl_InfoGame.AutoSize = true;
            this.Lbl_InfoGame.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_InfoGame.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoGame.ForeColor = System.Drawing.Color.White;
            this.Lbl_InfoGame.Location = new System.Drawing.Point(10, 266);
            this.Lbl_InfoGame.Name = "Lbl_InfoGame";
            this.Lbl_InfoGame.Size = new System.Drawing.Size(0, 14);
            this.Lbl_InfoGame.TabIndex = 17;
            // 
            // Lbl_InfoCarga
            // 
            this.Lbl_InfoCarga.AutoSize = true;
            this.Lbl_InfoCarga.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_InfoCarga.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoCarga.ForeColor = System.Drawing.Color.White;
            this.Lbl_InfoCarga.Location = new System.Drawing.Point(428, 161);
            this.Lbl_InfoCarga.Name = "Lbl_InfoCarga";
            this.Lbl_InfoCarga.Size = new System.Drawing.Size(0, 23);
            this.Lbl_InfoCarga.TabIndex = 16;
            // 
            // Lbl_Destino
            // 
            this.Lbl_Destino.AutoSize = true;
            this.Lbl_Destino.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Destino.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Destino.Location = new System.Drawing.Point(422, 81);
            this.Lbl_Destino.Name = "Lbl_Destino";
            this.Lbl_Destino.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Destino.TabIndex = 14;
            // 
            // Lbl_Partida
            // 
            this.Lbl_Partida.AutoSize = true;
            this.Lbl_Partida.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Partida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Partida.Location = new System.Drawing.Point(421, 38);
            this.Lbl_Partida.Name = "Lbl_Partida";
            this.Lbl_Partida.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Partida.TabIndex = 13;
            // 
            // pictureSom
            // 
            this.pictureSom.BackColor = System.Drawing.Color.Transparent;
            this.pictureSom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSom.Image = global::NextteamBr.Properties.Resources.Medium_Volume_50;
            this.pictureSom.Location = new System.Drawing.Point(696, 252);
            this.pictureSom.Name = "pictureSom";
            this.pictureSom.Size = new System.Drawing.Size(38, 28);
            this.pictureSom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSom.TabIndex = 12;
            this.pictureSom.TabStop = false;
            this.pictureSom.Click += new System.EventHandler(this.pictureSom_Click);
            // 
            // PicCarga
            // 
            this.PicCarga.BackColor = System.Drawing.Color.Transparent;
            this.PicCarga.Image = global::NextteamBr.Properties.Resources.Carregado;
            this.PicCarga.Location = new System.Drawing.Point(417, 150);
            this.PicCarga.Name = "PicCarga";
            this.PicCarga.Size = new System.Drawing.Size(307, 96);
            this.PicCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCarga.TabIndex = 15;
            this.PicCarga.TabStop = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(749, 300);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogBook NextTeamBr";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_EmpresaDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_EmrpesaPartida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureSom;
        private System.Windows.Forms.Timer timerTs3;
        private System.Windows.Forms.Label Lbl_Destino;
        private System.Windows.Forms.Label Lbl_Partida;
        private System.Windows.Forms.Timer TimerAvisoSonoro;
        private System.Windows.Forms.PictureBox PicCarga;
        private System.Windows.Forms.Label Lbl_InfoCarga;
        private System.Windows.Forms.Label Lbl_InfoGame;
        private System.Windows.Forms.PictureBox Pic_EmpresaDestino;
        private System.Windows.Forms.PictureBox Pic_EmrpesaPartida;
        private System.Windows.Forms.Timer timer1;
    }
}