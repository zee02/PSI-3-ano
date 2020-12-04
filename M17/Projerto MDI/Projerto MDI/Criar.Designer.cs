namespace Projerto_MDI
{
    partial class GestãoEventos
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
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.dataPicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCriar = new System.Windows.Forms.TabPage();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.tabEliminar = new System.Windows.Forms.TabPage();
            this.btnApagar = new System.Windows.Forms.Button();
            this.dgvEvento = new System.Windows.Forms.DataGridView();
            this.tabVisualiza = new System.Windows.Forms.TabPage();
            this.dgvVisua = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabCriar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).BeginInit();
            this.tabVisualiza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisua)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(235, 95);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(170, 20);
            this.txtEvento.TabIndex = 0;
            this.txtEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEvento_KeyPress);
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(235, 171);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(170, 20);
            this.txtHora.TabIndex = 3;
            this.txtHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHora_KeyPress);
            // 
            // dataPicker
            // 
            this.dataPicker.Location = new System.Drawing.Point(235, 133);
            this.dataPicker.Name = "dataPicker";
            this.dataPicker.Size = new System.Drawing.Size(143, 20);
            this.dataPicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NIF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código do Evento: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hora:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCriar);
            this.tabControl1.Controls.Add(this.tabEliminar);
            this.tabControl1.Controls.Add(this.tabVisualiza);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 286);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabCriar
            // 
            this.tabCriar.Controls.Add(this.txtNIF);
            this.tabCriar.Controls.Add(this.pictureBox1);
            this.tabCriar.Controls.Add(this.btnInserir);
            this.tabCriar.Controls.Add(this.btnLimpa);
            this.tabCriar.Controls.Add(this.label1);
            this.tabCriar.Controls.Add(this.txtHora);
            this.tabCriar.Controls.Add(this.dataPicker);
            this.tabCriar.Controls.Add(this.label2);
            this.tabCriar.Controls.Add(this.txtEvento);
            this.tabCriar.Controls.Add(this.label4);
            this.tabCriar.Controls.Add(this.label3);
            this.tabCriar.Location = new System.Drawing.Point(4, 22);
            this.tabCriar.Name = "tabCriar";
            this.tabCriar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCriar.Size = new System.Drawing.Size(484, 260);
            this.tabCriar.TabIndex = 0;
            this.tabCriar.Text = "Criar";
            this.tabCriar.UseVisualStyleBackColor = true;
            // 
            // txtNIF
            // 
            this.txtNIF.Location = new System.Drawing.Point(235, 57);
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(170, 20);
            this.txtNIF.TabIndex = 12;
            this.txtNIF.TextChanged += new System.EventHandler(this.txtNIF_TextChanged);
            this.txtNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNIF_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projerto_MDI.Properties.Resources._4836033;
            this.pictureBox1.InitialImage = global::Projerto_MDI.Properties.Resources._483603;
            this.pictureBox1.Location = new System.Drawing.Point(18, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 76);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(401, 227);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Guardar";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(8, 227);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 9;
            this.btnLimpa.Text = "Limpar";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // tabEliminar
            // 
            this.tabEliminar.Controls.Add(this.btnApagar);
            this.tabEliminar.Controls.Add(this.dgvEvento);
            this.tabEliminar.Location = new System.Drawing.Point(4, 22);
            this.tabEliminar.Name = "tabEliminar";
            this.tabEliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabEliminar.Size = new System.Drawing.Size(484, 260);
            this.tabEliminar.TabIndex = 1;
            this.tabEliminar.Text = "Eliminar";
            this.tabEliminar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(372, 228);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click_1);
            // 
            // dgvEvento
            // 
            this.dgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvento.Location = new System.Drawing.Point(0, 50);
            this.dgvEvento.Name = "dgvEvento";
            this.dgvEvento.Size = new System.Drawing.Size(488, 160);
            this.dgvEvento.TabIndex = 0;
            this.dgvEvento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvento_CellClick);
            // 
            // tabVisualiza
            // 
            this.tabVisualiza.Controls.Add(this.dgvVisua);
            this.tabVisualiza.Location = new System.Drawing.Point(4, 22);
            this.tabVisualiza.Name = "tabVisualiza";
            this.tabVisualiza.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisualiza.Size = new System.Drawing.Size(484, 260);
            this.tabVisualiza.TabIndex = 2;
            this.tabVisualiza.Text = "Visualizar";
            this.tabVisualiza.UseVisualStyleBackColor = true;
            // 
            // dgvVisua
            // 
            this.dgvVisua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisua.Location = new System.Drawing.Point(0, 51);
            this.dgvVisua.Name = "dgvVisua";
            this.dgvVisua.Size = new System.Drawing.Size(484, 159);
            this.dgvVisua.TabIndex = 0;
            // 
            // GestãoEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 284);
            this.Controls.Add(this.tabControl1);
            this.Name = "GestãoEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestãoEventos";
            this.Load += new System.EventHandler(this.Criar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCriar.ResumeLayout(false);
            this.tabCriar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabEliminar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvento)).EndInit();
            this.tabVisualiza.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisua)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.DateTimePicker dataPicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCriar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnLimpa;
        private System.Windows.Forms.TabPage tabEliminar;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.DataGridView dgvEvento;
        private System.Windows.Forms.TabPage tabVisualiza;
        private System.Windows.Forms.DataGridView dgvVisua;
        private System.Windows.Forms.Button btnApagar;
    }
}