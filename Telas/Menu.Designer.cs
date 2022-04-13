namespace ProjetoContratos
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MenuTitleLabel = new System.Windows.Forms.Label();
            this.MenuSelectBT1 = new System.Windows.Forms.Button();
            this.MenuSelectBT2 = new System.Windows.Forms.Button();
            this.ExistBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MenuTitleLabel
            // 
            this.MenuTitleLabel.AutoSize = true;
            this.MenuTitleLabel.BackColor = System.Drawing.Color.Black;
            this.MenuTitleLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 28F, System.Drawing.FontStyle.Bold);
            this.MenuTitleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.MenuTitleLabel.Location = new System.Drawing.Point(164, 132);
            this.MenuTitleLabel.Name = "MenuTitleLabel";
            this.MenuTitleLabel.Size = new System.Drawing.Size(132, 45);
            this.MenuTitleLabel.TabIndex = 1;
            this.MenuTitleLabel.Text = "MENU";
            this.MenuTitleLabel.Click += new System.EventHandler(this.LoginTitleLabel_Click);
            // 
            // MenuSelectBT1
            // 
            this.MenuSelectBT1.BackColor = System.Drawing.Color.Black;
            this.MenuSelectBT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.MenuSelectBT1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MenuSelectBT1.Location = new System.Drawing.Point(127, 250);
            this.MenuSelectBT1.Name = "MenuSelectBT1";
            this.MenuSelectBT1.Size = new System.Drawing.Size(210, 76);
            this.MenuSelectBT1.TabIndex = 7;
            this.MenuSelectBT1.Text = "Importar Cadastro";
            this.MenuSelectBT1.UseVisualStyleBackColor = false;
            this.MenuSelectBT1.Click += new System.EventHandler(this.LoginSubmitBT_Click);
            // 
            // MenuSelectBT2
            // 
            this.MenuSelectBT2.BackColor = System.Drawing.Color.Black;
            this.MenuSelectBT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.MenuSelectBT2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MenuSelectBT2.Location = new System.Drawing.Point(127, 350);
            this.MenuSelectBT2.Name = "MenuSelectBT2";
            this.MenuSelectBT2.Size = new System.Drawing.Size(210, 76);
            this.MenuSelectBT2.TabIndex = 8;
            this.MenuSelectBT2.Text = "Consultar Cadastro";
            this.MenuSelectBT2.UseVisualStyleBackColor = false;
            this.MenuSelectBT2.Click += new System.EventHandler(this.MenuSelectBT2_Click);
            // 
            // ExistBT
            // 
            this.ExistBT.BackColor = System.Drawing.Color.Black;
            this.ExistBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ExistBT.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ExistBT.Location = new System.Drawing.Point(127, 449);
            this.ExistBT.Name = "ExistBT";
            this.ExistBT.Size = new System.Drawing.Size(210, 76);
            this.ExistBT.TabIndex = 9;
            this.ExistBT.Text = "Sair";
            this.ExistBT.UseVisualStyleBackColor = false;
            this.ExistBT.Click += new System.EventHandler(this.ExistBT_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(466, 599);
            this.Controls.Add(this.ExistBT);
            this.Controls.Add(this.MenuSelectBT2);
            this.Controls.Add(this.MenuSelectBT1);
            this.Controls.Add(this.MenuTitleLabel);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Contratos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MenuTitleLabel;
        private System.Windows.Forms.Button MenuSelectBT1;
        private System.Windows.Forms.Button MenuSelectBT2;
        private System.Windows.Forms.Button ExistBT;
    }
}