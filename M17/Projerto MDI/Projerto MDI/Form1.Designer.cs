namespace Projerto_MDI
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registoLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registoLoginToolStripMenuItem,
            this.eventoToolStripMenuItem,
            this.tipoDeEventoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "gdfgdg";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarToolStripMenuItem,
            this.pesquisarToolStripMenuItem1});
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.eventoToolStripMenuItem.Text = "Evento";
            // 
            // criarToolStripMenuItem
            // 
            this.criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            this.criarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.criarToolStripMenuItem.Text = "Gestão";
            this.criarToolStripMenuItem.Click += new System.EventHandler(this.criarToolStripMenuItem_Click);
            this.criarToolStripMenuItem.MouseHover += new System.EventHandler(this.criarToolStripMenuItem_MouseHover);
            // 
            // registoLoginToolStripMenuItem
            // 
            this.registoLoginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registoToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.apagarToolStripMenuItem,
            this.pesquisarToolStripMenuItem});
            this.registoLoginToolStripMenuItem.Name = "registoLoginToolStripMenuItem";
            this.registoLoginToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.registoLoginToolStripMenuItem.Text = "Cliente";
            this.registoLoginToolStripMenuItem.Click += new System.EventHandler(this.registoLoginToolStripMenuItem_Click);
            // 
            // registoToolStripMenuItem
            // 
            this.registoToolStripMenuItem.Name = "registoToolStripMenuItem";
            this.registoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registoToolStripMenuItem.Text = "Registo";
            this.registoToolStripMenuItem.Click += new System.EventHandler(this.registoToolStripMenuItem_Click);
            this.registoToolStripMenuItem.MouseHover += new System.EventHandler(this.registoToolStripMenuItem_MouseHover);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginToolStripMenuItem.Text = "Visualizar";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            this.loginToolStripMenuItem.MouseHover += new System.EventHandler(this.loginToolStripMenuItem_MouseHover);
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apagarToolStripMenuItem.Text = "Gestão";
            this.apagarToolStripMenuItem.Click += new System.EventHandler(this.apagarToolStripMenuItem_Click);
            this.apagarToolStripMenuItem.MouseHover += new System.EventHandler(this.apagarToolStripMenuItem_MouseHover);
            // 
            // tipoDeEventoToolStripMenuItem
            // 
            this.tipoDeEventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apagarToolStripMenuItem1,
            this.visualizarToolStripMenuItem1});
            this.tipoDeEventoToolStripMenuItem.Name = "tipoDeEventoToolStripMenuItem";
            this.tipoDeEventoToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.tipoDeEventoToolStripMenuItem.Text = "TipoDeEvento";
            // 
            // apagarToolStripMenuItem1
            // 
            this.apagarToolStripMenuItem1.Name = "apagarToolStripMenuItem1";
            this.apagarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.apagarToolStripMenuItem1.Text = "Gestão";
            this.apagarToolStripMenuItem1.Click += new System.EventHandler(this.apagarToolStripMenuItem1_Click);
            this.apagarToolStripMenuItem1.MouseHover += new System.EventHandler(this.apagarToolStripMenuItem1_MouseHover);
            // 
            // visualizarToolStripMenuItem1
            // 
            this.visualizarToolStripMenuItem1.Name = "visualizarToolStripMenuItem1";
            this.visualizarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.visualizarToolStripMenuItem1.Text = "Visualizar";
            this.visualizarToolStripMenuItem1.Click += new System.EventHandler(this.visualizarToolStripMenuItem1_Click);
            this.visualizarToolStripMenuItem1.MouseHover += new System.EventHandler(this.visualizarToolStripMenuItem1_MouseHover);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.pesquisarToolStripMenuItem_Click);
            this.pesquisarToolStripMenuItem.MouseHover += new System.EventHandler(this.pesquisarToolStripMenuItem_MouseHover);
            // 
            // pesquisarToolStripMenuItem1
            // 
            this.pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
            this.pesquisarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pesquisarToolStripMenuItem1.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem1.Click += new System.EventHandler(this.pesquisarToolStripMenuItem1_Click);
            this.pesquisarToolStripMenuItem1.MouseHover += new System.EventHandler(this.pesquisarToolStripMenuItem1_MouseHover);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa de Eventos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registoLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDeEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

