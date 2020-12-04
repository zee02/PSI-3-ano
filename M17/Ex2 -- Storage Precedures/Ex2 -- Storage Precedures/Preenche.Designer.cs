namespace Ex2____Storage_Precedures
{
    partial class PesquisaLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaLivros));
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.btnProcura = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivros
            // 
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(1, 103);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.Size = new System.Drawing.Size(456, 150);
            this.dgvLivros.TabIndex = 0;
            this.dgvLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellContentClick);
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(42, 23);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(373, 20);
            this.txtProcurar.TabIndex = 1;
            // 
            // btnProcura
            // 
            this.btnProcura.Location = new System.Drawing.Point(190, 62);
            this.btnProcura.Name = "btnProcura";
            this.btnProcura.Size = new System.Drawing.Size(75, 23);
            this.btnProcura.TabIndex = 2;
            this.btnProcura.Text = "Search";
            this.btnProcura.UseVisualStyleBackColor = true;
            this.btnProcura.Click += new System.EventHandler(this.btnProcura_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ex2____Storage_Precedures.Properties.Resources.tras1;
            this.pictureBox1.Location = new System.Drawing.Point(410, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 35);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PesquisaLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProcura);
            this.Controls.Add(this.txtProcurar);
            this.Controls.Add(this.dgvLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisaLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisaLivros";
            this.Load += new System.EventHandler(this.Preenche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Button btnProcura;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}