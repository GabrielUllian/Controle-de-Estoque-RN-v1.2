
namespace Controle_de_Estoque_RN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTrocaUsuario = new System.Windows.Forms.Button();
            this.btnCadFornece = new System.Windows.Forms.Button();
            this.btnCadprod = new System.Windows.Forms.Button();
            this.btnImputEst = new System.Windows.Forms.Button();
            this.btnOutputEst = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrocaUsuario
            // 
            this.btnTrocaUsuario.BackColor = System.Drawing.Color.Turquoise;
            this.btnTrocaUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTrocaUsuario.Location = new System.Drawing.Point(50, 288);
            this.btnTrocaUsuario.Name = "btnTrocaUsuario";
            this.btnTrocaUsuario.Size = new System.Drawing.Size(135, 112);
            this.btnTrocaUsuario.TabIndex = 0;
            this.btnTrocaUsuario.Text = "Trocar de Usuário - Log Out";
            this.btnTrocaUsuario.UseVisualStyleBackColor = false;
            this.btnTrocaUsuario.Click += new System.EventHandler(this.btnTrocaUsuario_Click);
            // 
            // btnCadFornece
            // 
            this.btnCadFornece.BackColor = System.Drawing.Color.Turquoise;
            this.btnCadFornece.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadFornece.Location = new System.Drawing.Point(191, 288);
            this.btnCadFornece.Name = "btnCadFornece";
            this.btnCadFornece.Size = new System.Drawing.Size(135, 112);
            this.btnCadFornece.TabIndex = 1;
            this.btnCadFornece.Text = "Cadastrar Fornecedores";
            this.btnCadFornece.UseVisualStyleBackColor = false;
            this.btnCadFornece.Click += new System.EventHandler(this.btnCadFornece_Click);
            // 
            // btnCadprod
            // 
            this.btnCadprod.BackColor = System.Drawing.Color.Turquoise;
            this.btnCadprod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCadprod.Location = new System.Drawing.Point(332, 288);
            this.btnCadprod.Name = "btnCadprod";
            this.btnCadprod.Size = new System.Drawing.Size(135, 112);
            this.btnCadprod.TabIndex = 2;
            this.btnCadprod.Text = "Cadastrar Produtos";
            this.btnCadprod.UseVisualStyleBackColor = false;
            this.btnCadprod.Click += new System.EventHandler(this.btnCadprod_Click);
            // 
            // btnImputEst
            // 
            this.btnImputEst.BackColor = System.Drawing.Color.Turquoise;
            this.btnImputEst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnImputEst.Location = new System.Drawing.Point(473, 288);
            this.btnImputEst.Name = "btnImputEst";
            this.btnImputEst.Size = new System.Drawing.Size(135, 112);
            this.btnImputEst.TabIndex = 3;
            this.btnImputEst.Text = "Entradas no Estoque";
            this.btnImputEst.UseVisualStyleBackColor = false;
            this.btnImputEst.Click += new System.EventHandler(this.btnImputEst_Click);
            // 
            // btnOutputEst
            // 
            this.btnOutputEst.BackColor = System.Drawing.Color.Turquoise;
            this.btnOutputEst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOutputEst.Location = new System.Drawing.Point(614, 288);
            this.btnOutputEst.Name = "btnOutputEst";
            this.btnOutputEst.Size = new System.Drawing.Size(135, 112);
            this.btnOutputEst.TabIndex = 4;
            this.btnOutputEst.Text = "Saídas no Estoque";
            this.btnOutputEst.UseVisualStyleBackColor = false;
            this.btnOutputEst.Click += new System.EventHandler(this.btnOutputEst_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 256);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOutputEst);
            this.Controls.Add(this.btnImputEst);
            this.Controls.Add(this.btnCadprod);
            this.Controls.Add(this.btnCadFornece);
            this.Controls.Add(this.btnTrocaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque Nações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Exit_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTrocaUsuario;
        private System.Windows.Forms.Button btnCadFornece;
        private System.Windows.Forms.Button btnCadprod;
        private System.Windows.Forms.Button btnImputEst;
        private System.Windows.Forms.Button btnOutputEst;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

