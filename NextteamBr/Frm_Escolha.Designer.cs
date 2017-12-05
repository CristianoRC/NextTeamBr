namespace NextteamBr
{
    partial class Frm_Escolha
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
        /// Required method for Designer support  do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Escolha));
            this.Btm_JobSync = new System.Windows.Forms.Button();
            this.Btm_LogBook = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Plugin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialogets = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btm_JobSync
            // 
            this.Btm_JobSync.BackColor = System.Drawing.Color.Transparent;
            this.Btm_JobSync.BackgroundImage = global::NextteamBr.Properties.Resources.Report;
            this.Btm_JobSync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btm_JobSync.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_JobSync.FlatAppearance.BorderSize = 0;
            this.Btm_JobSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_JobSync.Location = new System.Drawing.Point(34, 12);
            this.Btm_JobSync.Name = "Btm_JobSync";
            this.Btm_JobSync.Size = new System.Drawing.Size(120, 68);
            this.Btm_JobSync.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Btm_JobSync, "Minhas informações");
            this.Btm_JobSync.UseVisualStyleBackColor = false;
            this.Btm_JobSync.Click += new System.EventHandler(this.Btm_JobSync_Click);
            // 
            // Btm_LogBook
            // 
            this.Btm_LogBook.BackColor = System.Drawing.Color.Transparent;
            this.Btm_LogBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btm_LogBook.BackgroundImage")));
            this.Btm_LogBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btm_LogBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_LogBook.FlatAppearance.BorderSize = 0;
            this.Btm_LogBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_LogBook.Location = new System.Drawing.Point(223, 12);
            this.Btm_LogBook.Name = "Btm_LogBook";
            this.Btm_LogBook.Size = new System.Drawing.Size(120, 68);
            this.Btm_LogBook.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Btm_LogBook, "LogBook Eletrônico");
            this.Btm_LogBook.UseVisualStyleBackColor = false;
            this.Btm_LogBook.Click += new System.EventHandler(this.Btm_LogBook_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::NextteamBr.Properties.Resources.podium;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(34, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 68);
            this.button1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button1, "Ranking");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::NextteamBr.Properties.Resources.administrator_male1600;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(34, 220);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 68);
            this.button2.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button2, "Panel Administrativo");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Plugin
            // 
            this.btn_Plugin.BackColor = System.Drawing.Color.Transparent;
            this.btn_Plugin.BackgroundImage = global::NextteamBr.Properties.Resources.System_tools_icon;
            this.btn_Plugin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Plugin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Plugin.FlatAppearance.BorderSize = 0;
            this.btn_Plugin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Plugin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Plugin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Plugin.Location = new System.Drawing.Point(223, 220);
            this.btn_Plugin.Name = "btn_Plugin";
            this.btn_Plugin.Size = new System.Drawing.Size(120, 68);
            this.btn_Plugin.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_Plugin, "Manutenção");
            this.btn_Plugin.UseVisualStyleBackColor = false;
            this.btn_Plugin.Click += new System.EventHandler(this.btn_Plugin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(562, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Sair");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::NextteamBr.Properties.Resources.office;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(223, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 68);
            this.button3.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button3, "Empresas");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_Escolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::NextteamBr.Properties.Resources.Escolha11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(598, 300);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Plugin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btm_LogBook);
            this.Controls.Add(this.Btm_JobSync);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Escolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zero Hora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btm_JobSync;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Btm_LogBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Plugin;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
    }
}