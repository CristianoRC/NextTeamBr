namespace NextteamBr
{
    partial class Frm_InformacoesPessoais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InformacoesPessoais));
            this.dataFretes = new System.Windows.Forms.DataGridView();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_listarTodos = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.alterarNomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redefinirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_pontuacao = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_fretes = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataFretes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataFretes
            // 
            this.dataFretes.AllowUserToAddRows = false;
            this.dataFretes.AllowUserToDeleteRows = false;
            this.dataFretes.AllowUserToOrderColumns = true;
            this.dataFretes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFretes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataFretes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataFretes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFretes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataFretes.Location = new System.Drawing.Point(0, 188);
            this.dataFretes.Name = "dataFretes";
            this.dataFretes.ReadOnly = true;
            this.dataFretes.Size = new System.Drawing.Size(1107, 311);
            this.dataFretes.TabIndex = 1;
            this.dataFretes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataFretes_CellFormatting);
            this.dataFretes.SelectionChanged += new System.EventHandler(this.dataFretes_SelectionChanged);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Atualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_Atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.ForeColor = System.Drawing.Color.Black;
            this.btn_Atualizar.Location = new System.Drawing.Point(149, 124);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(101, 23);
            this.btn_Atualizar.TabIndex = 2;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_listarTodos
            // 
            this.btn_listarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listarTodos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_listarTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_listarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_listarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listarTodos.ForeColor = System.Drawing.Color.Black;
            this.btn_listarTodos.Location = new System.Drawing.Point(28, 124);
            this.btn_listarTodos.Name = "btn_listarTodos";
            this.btn_listarTodos.Size = new System.Drawing.Size(101, 23);
            this.btn_listarTodos.TabIndex = 3;
            this.btn_listarTodos.Text = "Listar todos";
            this.btn_listarTodos.UseVisualStyleBackColor = true;
            this.btn_listarTodos.Click += new System.EventHandler(this.btn_listarTodos_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1105, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarNomeToolStripMenuItem,
            this.redefinirToolStripMenuItem});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(93, 22);
            this.toolStripSplitButton1.Text = "Alterar dados";
            // 
            // alterarNomeToolStripMenuItem
            // 
            this.alterarNomeToolStripMenuItem.Name = "alterarNomeToolStripMenuItem";
            this.alterarNomeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.alterarNomeToolStripMenuItem.Text = "Alterar Nome";
            this.alterarNomeToolStripMenuItem.Click += new System.EventHandler(this.alterarNomeToolStripMenuItem_Click);
            // 
            // redefinirToolStripMenuItem
            // 
            this.redefinirToolStripMenuItem.Name = "redefinirToolStripMenuItem";
            this.redefinirToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.redefinirToolStripMenuItem.Text = "Redefinir senha";
            this.redefinirToolStripMenuItem.Click += new System.EventHandler(this.redefinirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::NextteamBr.Properties.Resources.Header;
            this.panel1.Controls.Add(this.lbl_pontuacao);
            this.panel1.Controls.Add(this.btn_listarTodos);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btn_Atualizar);
            this.panel1.Controls.Add(this.lbl_fretes);
            this.panel1.Controls.Add(this.lbl_nome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 160);
            this.panel1.TabIndex = 0;
            // 
            // lbl_pontuacao
            // 
            this.lbl_pontuacao.AutoSize = true;
            this.lbl_pontuacao.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pontuacao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pontuacao.Location = new System.Drawing.Point(105, 83);
            this.lbl_pontuacao.Name = "lbl_pontuacao";
            this.lbl_pontuacao.Size = new System.Drawing.Size(92, 22);
            this.lbl_pontuacao.TabIndex = 10;
            this.lbl_pontuacao.Text = "Em breve";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Pontos:";
            // 
            // lbl_fretes
            // 
            this.lbl_fretes.AutoSize = true;
            this.lbl_fretes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fretes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fretes.Location = new System.Drawing.Point(98, 49);
            this.lbl_fretes.Name = "lbl_fretes";
            this.lbl_fretes.Size = new System.Drawing.Size(61, 22);
            this.lbl_fretes.TabIndex = 7;
            this.lbl_fretes.Text = "Nome";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(121, 13);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(61, 22);
            this.lbl_nome.TabIndex = 5;
            this.lbl_nome.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fretes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motorista:";
            // 
            // Frm_InformacoesPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 501);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataFretes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_InformacoesPessoais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações pessoais";
            this.Load += new System.EventHandler(this.Frm_InformacoesPessoais_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFretes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fretes;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.DataGridView dataFretes;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_listarTodos;
        private System.Windows.Forms.Label lbl_pontuacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem redefinirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarNomeToolStripMenuItem;
    }
}