namespace Sistema_Vendas_2C
{
    partial class fm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_login));
            this.bt_prosseguir = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_usuário = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_prosseguir
            // 
            this.bt_prosseguir.Location = new System.Drawing.Point(38, 161);
            this.bt_prosseguir.Name = "bt_prosseguir";
            this.bt_prosseguir.Size = new System.Drawing.Size(75, 23);
            this.bt_prosseguir.TabIndex = 0;
            this.bt_prosseguir.Text = "Prosseguir";
            this.bt_prosseguir.UseVisualStyleBackColor = true;
            this.bt_prosseguir.Click += new System.EventHandler(this.bt_prosseguir_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(234, 161);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(75, 23);
            this.bt_sair.TabIndex = 1;
            this.bt_sair.Text = "Sair";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // tb_usuário
            // 
            this.tb_usuário.Location = new System.Drawing.Point(33, 38);
            this.tb_usuário.Name = "tb_usuário";
            this.tb_usuário.Size = new System.Drawing.Size(100, 20);
            this.tb_usuário.TabIndex = 4;
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(33, 102);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(100, 20);
            this.tb_senha.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Vendas_2C.Properties.Resources.LOGO_ABC;
            this.pictureBox1.Location = new System.Drawing.Point(178, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // fm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 215);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_usuário);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_prosseguir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fm_login";
            this.Text = "ACB Sistemas";
            this.Load += new System.EventHandler(this.fm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_prosseguir;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_usuário;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

