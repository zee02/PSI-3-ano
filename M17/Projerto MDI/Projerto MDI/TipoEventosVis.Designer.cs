namespace Projerto_MDI
{
    partial class TipoEventosVis
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
            this.dgvTipEventos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipEventos
            // 
            this.dgvTipEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipEventos.Location = new System.Drawing.Point(0, 0);
            this.dgvTipEventos.Name = "dgvTipEventos";
            this.dgvTipEventos.Size = new System.Drawing.Size(471, 201);
            this.dgvTipEventos.TabIndex = 0;
            this.dgvTipEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipEventos_CellContentClick);
            // 
            // TipoEventosVis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 127);
            this.Controls.Add(this.dgvTipEventos);
            this.Name = "TipoEventosVis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TipoEventosVis";
            this.Load += new System.EventHandler(this.TipoEventosVis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipEventos;
    }
}