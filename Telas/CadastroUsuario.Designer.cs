namespace ProjetoContratos
{
    partial class CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroUsuario));
            this.CadTitleLabel = new System.Windows.Forms.Label();
            this.CadTxtBox2 = new System.Windows.Forms.TextBox();
            this.CadTxtBox1 = new System.Windows.Forms.TextBox();
            this.CadLabel2 = new System.Windows.Forms.Label();
            this.CadLabel1 = new System.Windows.Forms.Label();
            this.CadSubmitBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CadTitleLabel
            // 
            this.CadTitleLabel.AutoSize = true;
            this.CadTitleLabel.BackColor = System.Drawing.Color.Black;
            this.CadTitleLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 28F, System.Drawing.FontStyle.Bold);
            this.CadTitleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CadTitleLabel.Location = new System.Drawing.Point(109, 116);
            this.CadTitleLabel.Name = "CadTitleLabel";
            this.CadTitleLabel.Size = new System.Drawing.Size(430, 45);
            this.CadTitleLabel.TabIndex = 2;
            this.CadTitleLabel.Text = "Cadastre seu Usuário";
            // 
            // CadTxtBox2
            // 
            this.CadTxtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CadTxtBox2.Location = new System.Drawing.Point(238, 365);
            this.CadTxtBox2.Name = "CadTxtBox2";
            this.CadTxtBox2.PasswordChar = '*';
            this.CadTxtBox2.Size = new System.Drawing.Size(269, 29);
            this.CadTxtBox2.TabIndex = 9;
            // 
            // CadTxtBox1
            // 
            this.CadTxtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CadTxtBox1.Location = new System.Drawing.Point(238, 287);
            this.CadTxtBox1.Name = "CadTxtBox1";
            this.CadTxtBox1.Size = new System.Drawing.Size(269, 29);
            this.CadTxtBox1.TabIndex = 8;
            // 
            // CadLabel2
            // 
            this.CadLabel2.AutoSize = true;
            this.CadLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CadLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadLabel2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CadLabel2.Location = new System.Drawing.Point(132, 369);
            this.CadLabel2.Name = "CadLabel2";
            this.CadLabel2.Size = new System.Drawing.Size(86, 25);
            this.CadLabel2.TabIndex = 7;
            this.CadLabel2.Text = "Senha:";
            // 
            // CadLabel1
            // 
            this.CadLabel1.AutoSize = true;
            this.CadLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CadLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CadLabel1.Location = new System.Drawing.Point(132, 287);
            this.CadLabel1.Name = "CadLabel1";
            this.CadLabel1.Size = new System.Drawing.Size(100, 25);
            this.CadLabel1.TabIndex = 6;
            this.CadLabel1.Text = "Usuário:";
            // 
            // CadSubmitBT
            // 
            this.CadSubmitBT.BackColor = System.Drawing.Color.Black;
            this.CadSubmitBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CadSubmitBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CadSubmitBT.Location = new System.Drawing.Point(137, 481);
            this.CadSubmitBT.Name = "CadSubmitBT";
            this.CadSubmitBT.Size = new System.Drawing.Size(370, 40);
            this.CadSubmitBT.TabIndex = 10;
            this.CadSubmitBT.Text = "Finalizar Cadastro";
            this.CadSubmitBT.UseVisualStyleBackColor = false;
            this.CadSubmitBT.Click += new System.EventHandler(this.CadSubmitBT_Click);
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(638, 680);
            this.Controls.Add(this.CadSubmitBT);
            this.Controls.Add(this.CadTxtBox2);
            this.Controls.Add(this.CadTxtBox1);
            this.Controls.Add(this.CadLabel2);
            this.Controls.Add(this.CadLabel1);
            this.Controls.Add(this.CadTitleLabel);
            this.Name = "CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Contratos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CadTitleLabel;
        private System.Windows.Forms.TextBox CadTxtBox2;
        private System.Windows.Forms.TextBox CadTxtBox1;
        private System.Windows.Forms.Label CadLabel2;
        private System.Windows.Forms.Label CadLabel1;
        private System.Windows.Forms.Button CadSubmitBT;
    }
}