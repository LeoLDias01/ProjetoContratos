namespace ProjetoContratos
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginTitleLabel = new System.Windows.Forms.Label();
            this.LoginLabel1 = new System.Windows.Forms.Label();
            this.LoginLabel2 = new System.Windows.Forms.Label();
            this.LoginTxtBox1 = new System.Windows.Forms.TextBox();
            this.LoginTxtBox2 = new System.Windows.Forms.TextBox();
            this.LoginSubmitBT = new System.Windows.Forms.Button();
            this.LoginCadBT = new System.Windows.Forms.Button();
            this.LoginLableConcilig = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginTitleLabel
            // 
            this.LoginTitleLabel.AutoSize = true;
            this.LoginTitleLabel.BackColor = System.Drawing.Color.Black;
            this.LoginTitleLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 28F, System.Drawing.FontStyle.Bold);
            this.LoginTitleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LoginTitleLabel.Location = new System.Drawing.Point(65, 105);
            this.LoginTitleLabel.Name = "LoginTitleLabel";
            this.LoginTitleLabel.Size = new System.Drawing.Size(391, 45);
            this.LoginTitleLabel.TabIndex = 0;
            this.LoginTitleLabel.Text = "ENTRE NO SISTEMA";
            this.LoginTitleLabel.Click += new System.EventHandler(this.LoginTitleLabel_Click);
            // 
            // LoginLabel1
            // 
            this.LoginLabel1.AutoSize = true;
            this.LoginLabel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LoginLabel1.Location = new System.Drawing.Point(37, 278);
            this.LoginLabel1.Name = "LoginLabel1";
            this.LoginLabel1.Size = new System.Drawing.Size(100, 25);
            this.LoginLabel1.TabIndex = 1;
            this.LoginLabel1.Text = "Usuário:";
            // 
            // LoginLabel2
            // 
            this.LoginLabel2.AutoSize = true;
            this.LoginLabel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LoginLabel2.Location = new System.Drawing.Point(37, 360);
            this.LoginLabel2.Name = "LoginLabel2";
            this.LoginLabel2.Size = new System.Drawing.Size(86, 25);
            this.LoginLabel2.TabIndex = 2;
            this.LoginLabel2.Text = "Senha:";
            // 
            // LoginTxtBox1
            // 
            this.LoginTxtBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LoginTxtBox1.Location = new System.Drawing.Point(143, 278);
            this.LoginTxtBox1.Name = "LoginTxtBox1";
            this.LoginTxtBox1.Size = new System.Drawing.Size(269, 29);
            this.LoginTxtBox1.TabIndex = 4;
            // 
            // LoginTxtBox2
            // 
            this.LoginTxtBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.LoginTxtBox2.Location = new System.Drawing.Point(143, 356);
            this.LoginTxtBox2.Name = "LoginTxtBox2";
            this.LoginTxtBox2.PasswordChar = '*';
            this.LoginTxtBox2.Size = new System.Drawing.Size(269, 29);
            this.LoginTxtBox2.TabIndex = 5;
            this.LoginTxtBox2.TextChanged += new System.EventHandler(this.LoginTxtBox2_TextChanged);
            // 
            // LoginSubmitBT
            // 
            this.LoginSubmitBT.BackColor = System.Drawing.Color.Black;
            this.LoginSubmitBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LoginSubmitBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginSubmitBT.Location = new System.Drawing.Point(182, 428);
            this.LoginSubmitBT.Name = "LoginSubmitBT";
            this.LoginSubmitBT.Size = new System.Drawing.Size(155, 40);
            this.LoginSubmitBT.TabIndex = 6;
            this.LoginSubmitBT.Text = "Entrar";
            this.LoginSubmitBT.UseVisualStyleBackColor = false;
            this.LoginSubmitBT.Click += new System.EventHandler(this.LoginSubmitBT_Click);
            // 
            // LoginCadBT
            // 
            this.LoginCadBT.BackColor = System.Drawing.Color.Black;
            this.LoginCadBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LoginCadBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LoginCadBT.Location = new System.Drawing.Point(182, 494);
            this.LoginCadBT.Name = "LoginCadBT";
            this.LoginCadBT.Size = new System.Drawing.Size(155, 40);
            this.LoginCadBT.TabIndex = 7;
            this.LoginCadBT.Text = "Cadastrar";
            this.LoginCadBT.UseVisualStyleBackColor = false;
            this.LoginCadBT.Click += new System.EventHandler(this.LoginCadBT_Click);
            // 
            // LoginLableConcilig
            // 
            this.LoginLableConcilig.AutoSize = true;
            this.LoginLableConcilig.BackColor = System.Drawing.Color.Transparent;
            this.LoginLableConcilig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginLableConcilig.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LoginLableConcilig.Location = new System.Drawing.Point(178, 183);
            this.LoginLableConcilig.Name = "LoginLableConcilig";
            this.LoginLableConcilig.Size = new System.Drawing.Size(148, 20);
            this.LoginLableConcilig.TabIndex = 3;
            this.LoginLableConcilig.Text = "CONCILIG BAURU";
            this.LoginLableConcilig.Click += new System.EventHandler(this.LoginLableConcilig_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(505, 559);
            this.Controls.Add(this.LoginCadBT);
            this.Controls.Add(this.LoginSubmitBT);
            this.Controls.Add(this.LoginTxtBox2);
            this.Controls.Add(this.LoginTxtBox1);
            this.Controls.Add(this.LoginLableConcilig);
            this.Controls.Add(this.LoginLabel2);
            this.Controls.Add(this.LoginLabel1);
            this.Controls.Add(this.LoginTitleLabel);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Contratos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginTitleLabel;
        private System.Windows.Forms.Label LoginLabel1;
        private System.Windows.Forms.Label LoginLabel2;
        private System.Windows.Forms.TextBox LoginTxtBox1;
        private System.Windows.Forms.TextBox LoginTxtBox2;
        private System.Windows.Forms.Button LoginSubmitBT;
        private System.Windows.Forms.Button LoginCadBT;
        private System.Windows.Forms.Label LoginLableConcilig;
    }
}

