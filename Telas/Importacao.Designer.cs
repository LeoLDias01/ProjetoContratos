namespace ProjetoContratos
{
    partial class Importacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Importacao));
            this.ImportacaoTitleLabel = new System.Windows.Forms.Label();
            this.ImportBT = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportContinuaBT1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ImportacaoTitleLabel
            // 
            this.ImportacaoTitleLabel.AutoSize = true;
            this.ImportacaoTitleLabel.BackColor = System.Drawing.Color.Black;
            this.ImportacaoTitleLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 28F, System.Drawing.FontStyle.Bold);
            this.ImportacaoTitleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ImportacaoTitleLabel.Location = new System.Drawing.Point(128, 116);
            this.ImportacaoTitleLabel.Name = "ImportacaoTitleLabel";
            this.ImportacaoTitleLabel.Size = new System.Drawing.Size(463, 45);
            this.ImportacaoTitleLabel.TabIndex = 2;
            this.ImportacaoTitleLabel.Text = "SELECIONE O ARQUIVO";
            // 
            // ImportBT
            // 
            this.ImportBT.BackColor = System.Drawing.Color.Black;
            this.ImportBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ImportBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ImportBT.Location = new System.Drawing.Point(280, 186);
            this.ImportBT.Name = "ImportBT";
            this.ImportBT.Size = new System.Drawing.Size(155, 40);
            this.ImportBT.TabIndex = 7;
            this.ImportBT.Text = "Carregar";
            this.ImportBT.UseVisualStyleBackColor = false;
            this.ImportBT.Click += new System.EventHandler(this.ImportBT_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.CPF,
            this.Contrato,
            this.Produto,
            this.Vencimento,
            this.Valor});
            this.dataGridView1.Location = new System.Drawing.Point(38, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 278);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // ImportContinuaBT1
            // 
            this.ImportContinuaBT1.BackColor = System.Drawing.Color.Black;
            this.ImportContinuaBT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ImportContinuaBT1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ImportContinuaBT1.Location = new System.Drawing.Point(280, 547);
            this.ImportContinuaBT1.Name = "ImportContinuaBT1";
            this.ImportContinuaBT1.Size = new System.Drawing.Size(155, 40);
            this.ImportContinuaBT1.TabIndex = 9;
            this.ImportContinuaBT1.Text = "Continuar ";
            this.ImportContinuaBT1.UseVisualStyleBackColor = false;
            this.ImportContinuaBT1.Click += new System.EventHandler(this.ImportContinuaBT1_Click);
            // 
            // Importacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(713, 599);
            this.Controls.Add(this.ImportContinuaBT1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ImportBT);
            this.Controls.Add(this.ImportacaoTitleLabel);
            this.Name = "Importacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Contratos";
            this.Load += new System.EventHandler(this.Importacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImportacaoTitleLabel;
        private System.Windows.Forms.Button ImportBT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button ImportContinuaBT1;
    }
}