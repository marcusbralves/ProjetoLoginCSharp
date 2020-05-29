namespace ProjetoLogin.Apresentacao
{
    partial class Cadastrar
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
            this.lblLogin2 = new System.Windows.Forms.Label();
            this.lblSenha2 = new System.Windows.Forms.Label();
            this.lblsenha3 = new System.Windows.Forms.Label();
            this.txtLogin2 = new System.Windows.Forms.TextBox();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.txtSenha3 = new System.Windows.Forms.TextBox();
            this.btnCdastrar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin2
            // 
            this.lblLogin2.AutoSize = true;
            this.lblLogin2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin2.Location = new System.Drawing.Point(37, 19);
            this.lblLogin2.Name = "lblLogin2";
            this.lblLogin2.Size = new System.Drawing.Size(36, 15);
            this.lblLogin2.TabIndex = 0;
            this.lblLogin2.Text = "Login";
            // 
            // lblSenha2
            // 
            this.lblSenha2.AutoSize = true;
            this.lblSenha2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha2.Location = new System.Drawing.Point(37, 72);
            this.lblSenha2.Name = "lblSenha2";
            this.lblSenha2.Size = new System.Drawing.Size(40, 15);
            this.lblSenha2.TabIndex = 1;
            this.lblSenha2.Text = "Senha";
            // 
            // lblsenha3
            // 
            this.lblsenha3.AutoSize = true;
            this.lblsenha3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsenha3.Location = new System.Drawing.Point(37, 130);
            this.lblsenha3.Name = "lblsenha3";
            this.lblsenha3.Size = new System.Drawing.Size(98, 15);
            this.lblsenha3.TabIndex = 2;
            this.lblsenha3.Text = "Confirmar senha";
            // 
            // txtLogin2
            // 
            this.txtLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin2.Location = new System.Drawing.Point(40, 35);
            this.txtLogin2.Name = "txtLogin2";
            this.txtLogin2.Size = new System.Drawing.Size(261, 22);
            this.txtLogin2.TabIndex = 3;
            // 
            // txtSenha2
            // 
            this.txtSenha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha2.Location = new System.Drawing.Point(40, 88);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(146, 26);
            this.txtSenha2.TabIndex = 4;
            // 
            // txtSenha3
            // 
            this.txtSenha3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha3.Location = new System.Drawing.Point(40, 146);
            this.txtSenha3.Name = "txtSenha3";
            this.txtSenha3.Size = new System.Drawing.Size(146, 26);
            this.txtSenha3.TabIndex = 5;
            // 
            // btnCdastrar2
            // 
            this.btnCdastrar2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCdastrar2.Location = new System.Drawing.Point(40, 196);
            this.btnCdastrar2.Name = "btnCdastrar2";
            this.btnCdastrar2.Size = new System.Drawing.Size(121, 37);
            this.btnCdastrar2.TabIndex = 6;
            this.btnCdastrar2.Text = "Cadastrar";
            this.btnCdastrar2.UseVisualStyleBackColor = true;
            // 
            // Cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.btnCdastrar2);
            this.Controls.Add(this.txtSenha3);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.txtLogin2);
            this.Controls.Add(this.lblsenha3);
            this.Controls.Add(this.lblSenha2);
            this.Controls.Add(this.lblLogin2);
            this.Name = "Cadastrar";
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin2;
        private System.Windows.Forms.Label lblSenha2;
        private System.Windows.Forms.Label lblsenha3;
        private System.Windows.Forms.TextBox txtLogin2;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.TextBox txtSenha3;
        private System.Windows.Forms.Button btnCdastrar2;
    }
}