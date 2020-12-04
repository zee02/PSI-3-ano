namespace MDI2
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirAtravésDeUmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirFormMuitasVezesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharTodosOsFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirAtravésDeUmToolStripMenuItem,
            this.abrirFormMuitasVezesToolStripMenuItem,
            this.fecharTodosOsFormsToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // abrirAtravésDeUmToolStripMenuItem
            // 
            this.abrirAtravésDeUmToolStripMenuItem.Name = "abrirAtravésDeUmToolStripMenuItem";
            this.abrirAtravésDeUmToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.abrirAtravésDeUmToolStripMenuItem.Text = "Abrir form uma vez";
            this.abrirAtravésDeUmToolStripMenuItem.Click += new System.EventHandler(this.abrirAtravésDeUmToolStripMenuItem_Click);
            // 
            // abrirFormMuitasVezesToolStripMenuItem
            // 
            this.abrirFormMuitasVezesToolStripMenuItem.Name = "abrirFormMuitasVezesToolStripMenuItem";
            this.abrirFormMuitasVezesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.abrirFormMuitasVezesToolStripMenuItem.Text = "Abrir form muitas vezes";
            this.abrirFormMuitasVezesToolStripMenuItem.Click += new System.EventHandler(this.abrirFormMuitasVezesToolStripMenuItem_Click);
            // 
            // fecharTodosOsFormsToolStripMenuItem
            // 
            this.fecharTodosOsFormsToolStripMenuItem.Name = "fecharTodosOsFormsToolStripMenuItem";
            this.fecharTodosOsFormsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.fecharTodosOsFormsToolStripMenuItem.Text = "Fechar todos os forms";
            this.fecharTodosOsFormsToolStripMenuItem.Click += new System.EventHandler(this.fecharTodosOsFormsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirAtravésDeUmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirFormMuitasVezesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharTodosOsFormsToolStripMenuItem;
    }
}

