
namespace Controle_de_Estoque_RN
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblLogin_log = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtBLogin = new System.Windows.Forms.TextBox();
            this.txtBSenha = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Poor Richard", 36F, System.Drawing.FontStyle.Bold);
            this.lblLogin.Location = new System.Drawing.Point(339, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(133, 55);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin_log
            // 
            this.lblLogin_log.AutoSize = true;
            this.lblLogin_log.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLogin_log.Location = new System.Drawing.Point(208, 204);
            this.lblLogin_log.Name = "lblLogin_log";
            this.lblLogin_log.Size = new System.Drawing.Size(63, 25);
            this.lblLogin_log.TabIndex = 1;
            this.lblLogin_log.Text = "Login";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSenha.Location = new System.Drawing.Point(208, 246);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(66, 25);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // txtBLogin
            // 
            this.txtBLogin.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtBLogin.Location = new System.Drawing.Point(296, 204);
            this.txtBLogin.Name = "txtBLogin";
            this.txtBLogin.Size = new System.Drawing.Size(209, 36);
            this.txtBLogin.TabIndex = 0;
            // 
            // txtBSenha
            // 
            this.txtBSenha.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtBSenha.Location = new System.Drawing.Point(296, 246);
            this.txtBSenha.Name = "txtBSenha";
            this.txtBSenha.PasswordChar = '*';
            this.txtBSenha.Size = new System.Drawing.Size(209, 36);
            this.txtBSenha.TabIndex = 1;
            // 
            // btnLogar
            // 
            this.btnLogar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLogar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnLogar.Location = new System.Drawing.Point(511, 204);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(96, 78);
            this.btnLogar.TabIndex = 3;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = false;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.txtBSenha);
            this.Controls.Add(this.txtBLogin);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblLogin_log);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblLogin_log;
        private System.Windows.Forms.Label lblSenha;
        public System.Windows.Forms.TextBox txtBLogin;
        public System.Windows.Forms.TextBox txtBSenha;
        public System.Windows.Forms.Button btnLogar;
    }
}