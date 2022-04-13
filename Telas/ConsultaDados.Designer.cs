namespace ProjetoContratos
{
    partial class ConsultaDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaDados));
            this.ImportLabel1 = new System.Windows.Forms.Label();
            this.BuscaBT = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChamaMenuBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportLabel1
            // 
            this.ImportLabel1.AutoSize = true;
            this.ImportLabel1.BackColor = System.Drawing.Color.Black;
            this.ImportLabel1.Font = new System.Drawing.Font("Lucida Sans Unicode", 28F, System.Drawing.FontStyle.Bold);
            this.ImportLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ImportLabel1.Location = new System.Drawing.Point(45, 89);
            this.ImportLabel1.Name = "ImportLabel1";
            this.ImportLabel1.Size = new System.Drawing.Size(546, 45);
            this.ImportLabel1.TabIndex = 2;
            this.ImportLabel1.Text = "CONSULTA DE CONTRATOS";
            // 
            // BuscaBT
            // 
            this.BuscaBT.BackColor = System.Drawing.Color.Black;
            this.BuscaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BuscaBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BuscaBT.Location = new System.Drawing.Point(184, 163);
            this.BuscaBT.Name = "BuscaBT";
            this.BuscaBT.Size = new System.Drawing.Size(263, 40);
            this.BuscaBT.TabIndex = 7;
            this.BuscaBT.Text = "Buscar dados ";
            this.BuscaBT.UseVisualStyleBackColor = false;
            this.BuscaBT.Click += new System.EventHandler(this.BuscaBT_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.CPF,
            this.Contrato,
            this.Produto,
            this.Vencimento,
            this.Valor});
            this.dataGridView2.Location = new System.Drawing.Point(-3, 230);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(645, 369);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Contrato
            // 
            this.Contrato.HeaderText = "Contrato";
            this.Contrato.Name = "Contrato";
            this.Contrato.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Vencimento
            // 
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // ChamaMenuBT
            // 
            this.ChamaMenuBT.BackColor = System.Drawing.Color.Black;
            this.ChamaMenuBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ChamaMenuBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ChamaMenuBT.Location = new System.Drawing.Point(184, 638);
            this.ChamaMenuBT.Name = "ChamaMenuBT";
            this.ChamaMenuBT.Size = new System.Drawing.Size(263, 40);
            this.ChamaMenuBT.TabIndex = 10;
            this.ChamaMenuBT.Text = "Volta Menu";
            this.ChamaMenuBT.UseVisualStyleBackColor = false;
            this.ChamaMenuBT.Click += new System.EventHandler(this.ChamaMenuBT_Click);
            // 
            // ConsultaDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(638, 690);
            this.Controls.Add(this.ChamaMenuBT);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BuscaBT);
            this.Controls.Add(this.ImportLabel1);
            this.Name = "ConsultaDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Contratos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImportLabel1;
        private System.Windows.Forms.Button BuscaBT;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button ChamaMenuBT;
    }
}