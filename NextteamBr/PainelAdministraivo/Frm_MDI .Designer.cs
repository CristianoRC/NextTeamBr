namespace NextteamBr.PainelAdministraivo
{
    partial class Frm_MDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MDI));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.motoristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeFretesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ativarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desativarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motoristaToolStripMenuItem,
            this.rankingToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // motoristaToolStripMenuItem
            // 
            this.motoristaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeFretesToolStripMenuItem,
            this.ativarToolStripMenuItem,
            this.desativarToolStripMenuItem,
            this.resetarSenhaToolStripMenuItem});
            this.motoristaToolStripMenuItem.Name = "motoristaToolStripMenuItem";
            this.motoristaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.motoristaToolStripMenuItem.Text = "&Motorista";
            // 
            // relatórioDeFretesToolStripMenuItem
            // 
            this.relatórioDeFretesToolStripMenuItem.Name = "relatórioDeFretesToolStripMenuItem";
            this.relatórioDeFretesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.relatórioDeFretesToolStripMenuItem.Text = "Relatório de &fretes";
            this.relatórioDeFretesToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeFretesToolStripMenuItem_Click);
            // 
            // ativarToolStripMenuItem
            // 
            this.ativarToolStripMenuItem.Name = "ativarToolStripMenuItem";
            this.ativarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ativarToolStripMenuItem.Text = "&Ativar";
            this.ativarToolStripMenuItem.Click += new System.EventHandler(this.ativarToolStripMenuItem_Click);
            // 
            // desativarToolStripMenuItem
            // 
            this.desativarToolStripMenuItem.Name = "desativarToolStripMenuItem";
            this.desativarToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.desativarToolStripMenuItem.Text = "&Desativar";
            this.desativarToolStripMenuItem.Click += new System.EventHandler(this.desativarToolStripMenuItem_Click);
            // 
            // resetarSenhaToolStripMenuItem
            // 
            this.resetarSenhaToolStripMenuItem.Name = "resetarSenhaToolStripMenuItem";
            this.resetarSenhaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.resetarSenhaToolStripMenuItem.Text = "&Resetar Senha";
            this.resetarSenhaToolStripMenuItem.Click += new System.EventHandler(this.resetarSenhaToolStripMenuItem_Click);
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetarToolStripMenuItem});
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.rankingToolStripMenuItem.Text = "&Ranking";
            // 
            // resetarToolStripMenuItem
            // 
            this.resetarToolStripMenuItem.Name = "resetarToolStripMenuItem";
            this.resetarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetarToolStripMenuItem.Text = "&Resetar";
            this.resetarToolStripMenuItem.Click += new System.EventHandler(this.resetarToolStripMenuItem_Click);
            // 
            // Frm_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NextteamBr.Properties.Resources.Logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1020, 431);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Frm_MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel Administrativo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem motoristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ativarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desativarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeFretesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetarToolStripMenuItem;
    }
}



