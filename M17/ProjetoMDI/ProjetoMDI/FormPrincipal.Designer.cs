namespace ProjetoMDI
{
    partial class FormPrincipal
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
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrirFilho1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrirFilho2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrirFilho3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormAberto = new System.Windows.Forms.ToolStripMenuItem();
            this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascata = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIconesMin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.mnuFormAberto,
            this.janelaToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.MdiWindowListItem = this.mnuFormAberto;
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(542, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuStrip2";
            this.mnuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip2_ItemClicked);
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbrirFilho1,
            this.mnuAbrirFilho2,
            this.mnuAbrirFilho3});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // mnuAbrirFilho1
            // 
            this.mnuAbrirFilho1.Name = "mnuAbrirFilho1";
            this.mnuAbrirFilho1.Size = new System.Drawing.Size(180, 22);
            this.mnuAbrirFilho1.Text = "Abrir Filho 1";
            this.mnuAbrirFilho1.Click += new System.EventHandler(this.mnuAbrirFilho1_Click);
            // 
            // mnuAbrirFilho2
            // 
            this.mnuAbrirFilho2.Name = "mnuAbrirFilho2";
            this.mnuAbrirFilho2.Size = new System.Drawing.Size(180, 22);
            this.mnuAbrirFilho2.Text = "Abrir Filho 2";
            this.mnuAbrirFilho2.Click += new System.EventHandler(this.mnuAbrirFilho2_Click);
            // 
            // mnuAbrirFilho3
            // 
            this.mnuAbrirFilho3.Name = "mnuAbrirFilho3";
            this.mnuAbrirFilho3.Size = new System.Drawing.Size(180, 22);
            this.mnuAbrirFilho3.Text = "Abrir Filho 3";
            this.mnuAbrirFilho3.Click += new System.EventHandler(this.mnuAbrirFilho3_Click);
            // 
            // mnuFormAberto
            // 
            this.mnuFormAberto.Name = "mnuFormAberto";
            this.mnuFormAberto.Size = new System.Drawing.Size(96, 20);
            this.mnuFormAberto.Text = "Forms Abertos";
            this.mnuFormAberto.Click += new System.EventHandler(this.formsAbertosToolStripMenuItem_Click);
            // 
            // janelaToolStripMenuItem
            // 
            this.janelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascata,
            this.mnuHorizontal,
            this.mnuVertical,
            this.mnuIconesMin});
            this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
            this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.janelaToolStripMenuItem.Text = "Janela";
            // 
            // mnuCascata
            // 
            this.mnuCascata.Name = "mnuCascata";
            this.mnuCascata.Size = new System.Drawing.Size(191, 22);
            this.mnuCascata.Text = "Cascata";
            this.mnuCascata.Click += new System.EventHandler(this.mnuCascata_Click);
            // 
            // mnuHorizontal
            // 
            this.mnuHorizontal.Name = "mnuHorizontal";
            this.mnuHorizontal.Size = new System.Drawing.Size(191, 22);
            this.mnuHorizontal.Text = "Lado a lado horizontal";
            this.mnuHorizontal.Click += new System.EventHandler(this.mnuHorizontal_Click);
            // 
            // mnuVertical
            // 
            this.mnuVertical.Name = "mnuVertical";
            this.mnuVertical.Size = new System.Drawing.Size(191, 22);
            this.mnuVertical.Text = "Lado a lado vertical";
            this.mnuVertical.Click += new System.EventHandler(this.mnuVertical_Click);
            // 
            // mnuIconesMin
            // 
            this.mnuIconesMin.Name = "mnuIconesMin";
            this.mnuIconesMin.Size = new System.Drawing.Size(191, 22);
            this.mnuIconesMin.Text = "Ícones minimizados";
            this.mnuIconesMin.Click += new System.EventHandler(this.mnuIconesMin_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 389);
            this.Controls.Add(this.mnuPrincipal);
            this.IsMdiContainer = true;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrirFilho1;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrirFilho2;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrirFilho3;
        private System.Windows.Forms.ToolStripMenuItem mnuFormAberto;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCascata;
        private System.Windows.Forms.ToolStripMenuItem mnuHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuIconesMin;
    }
}

