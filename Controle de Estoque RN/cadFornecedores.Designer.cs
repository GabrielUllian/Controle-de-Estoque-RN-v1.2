
namespace Controle_de_Estoque_RN
{
    partial class cadFornecedores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadFornecedores));
            this.btnCadForCodFor = new System.Windows.Forms.Button();
            this.lblStaticCadFor = new System.Windows.Forms.Label();
            this.btnCadForExcFor = new System.Windows.Forms.Button();
            this.txtCadForIden = new System.Windows.Forms.TextBox();
            this.txtCadForCNPJ = new System.Windows.Forms.TextBox();
            this.txtCadForMail = new System.Windows.Forms.TextBox();
            this.txtCadForEnd = new System.Windows.Forms.TextBox();
            this.txtCadForCep = new System.Windows.Forms.TextBox();
            this.txtCadForTel = new System.Windows.Forms.TextBox();
            this.lblStaticIden = new System.Windows.Forms.Label();
            this.lblStaticCNPJ = new System.Windows.Forms.Label();
            this.lblStaticEmail = new System.Windows.Forms.Label();
            this.lblStaticCEP = new System.Windows.Forms.Label();
            this.lblStaticEnd = new System.Windows.Forms.Label();
            this.lblStaticTel = new System.Windows.Forms.Label();
            this.dgvCadFor = new System.Windows.Forms.DataGridView();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new Controle_de_Estoque_RN.mydbDataSet();
            this.fornecedoresTableAdapter = new Controle_de_Estoque_RN.mydbDataSetTableAdapters.fornecedoresTableAdapter();
            this.fornecedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idFornecedoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadForCodFor
            // 
            this.btnCadForCodFor.BackColor = System.Drawing.Color.Lime;
            this.btnCadForCodFor.Location = new System.Drawing.Point(12, 514);
            this.btnCadForCodFor.Name = "btnCadForCodFor";
            this.btnCadForCodFor.Size = new System.Drawing.Size(80, 38);
            this.btnCadForCodFor.TabIndex = 6;
            this.btnCadForCodFor.Text = "Cadastrar Fornecedor";
            this.btnCadForCodFor.UseVisualStyleBackColor = false;
            this.btnCadForCodFor.Click += new System.EventHandler(this.btnCadForCodFor_Click);
            // 
            // lblStaticCadFor
            // 
            this.lblStaticCadFor.AutoSize = true;
            this.lblStaticCadFor.Font = new System.Drawing.Font("Poor Richard", 20F, System.Drawing.FontStyle.Bold);
            this.lblStaticCadFor.Location = new System.Drawing.Point(462, 9);
            this.lblStaticCadFor.Name = "lblStaticCadFor";
            this.lblStaticCadFor.Size = new System.Drawing.Size(295, 31);
            this.lblStaticCadFor.TabIndex = 1;
            this.lblStaticCadFor.Text = "Cadastro de Fornecedores";
            // 
            // btnCadForExcFor
            // 
            this.btnCadForExcFor.BackColor = System.Drawing.Color.Red;
            this.btnCadForExcFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadForExcFor.Location = new System.Drawing.Point(1092, 511);
            this.btnCadForExcFor.Name = "btnCadForExcFor";
            this.btnCadForExcFor.Size = new System.Drawing.Size(80, 38);
            this.btnCadForExcFor.TabIndex = 20;
            this.btnCadForExcFor.Text = "Excluir Fornecedor";
            this.btnCadForExcFor.UseVisualStyleBackColor = false;
            this.btnCadForExcFor.Click += new System.EventHandler(this.btnCadForExcFor_Click);
            // 
            // txtCadForIden
            // 
            this.txtCadForIden.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtCadForIden.Location = new System.Drawing.Point(102, 453);
            this.txtCadForIden.MaxLength = 45;
            this.txtCadForIden.Name = "txtCadForIden";
            this.txtCadForIden.Size = new System.Drawing.Size(287, 36);
            this.txtCadForIden.TabIndex = 0;
            // 
            // txtCadForCNPJ
            // 
            this.txtCadForCNPJ.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtCadForCNPJ.Location = new System.Drawing.Point(395, 453);
            this.txtCadForCNPJ.MaxLength = 18;
            this.txtCadForCNPJ.Name = "txtCadForCNPJ";
            this.txtCadForCNPJ.Size = new System.Drawing.Size(196, 36);
            this.txtCadForCNPJ.TabIndex = 1;
            // 
            // txtCadForMail
            // 
            this.txtCadForMail.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtCadForMail.Location = new System.Drawing.Point(771, 453);
            this.txtCadForMail.MaxLength = 45;
            this.txtCadForMail.Name = "txtCadForMail";
            this.txtCadForMail.Size = new System.Drawing.Size(287, 36);
            this.txtCadForMail.TabIndex = 3;
            // 
            // txtCadForEnd
            // 
            this.txtCadForEnd.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtCadForEnd.Location = new System.Drawing.Point(102, 516);
            this.txtCadForEnd.MaxLength = 90;
            this.txtCadForEnd.Name = "txtCadForEnd";
            this.txtCadForEnd.Size = new System.Drawing.Size(663, 36);
            this.txtCadForEnd.TabIndex = 4;
            // 
            // txtCadForCep
            // 
            this.txtCadForCep.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtCadForCep.Location = new System.Drawing.Point(771, 516);
            this.txtCadForCep.MaxLength = 9;
            this.txtCadForCep.Name = "txtCadForCep";
            this.txtCadForCep.Size = new System.Drawing.Size(196, 36);
            this.txtCadForCep.TabIndex = 5;
            // 
            // txtCadForTel
            // 
            this.txtCadForTel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtCadForTel.Location = new System.Drawing.Point(597, 453);
            this.txtCadForTel.MaxLength = 14;
            this.txtCadForTel.Name = "txtCadForTel";
            this.txtCadForTel.Size = new System.Drawing.Size(168, 36);
            this.txtCadForTel.TabIndex = 2;
            // 
            // lblStaticIden
            // 
            this.lblStaticIden.AutoSize = true;
            this.lblStaticIden.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaticIden.Location = new System.Drawing.Point(102, 429);
            this.lblStaticIden.Name = "lblStaticIden";
            this.lblStaticIden.Size = new System.Drawing.Size(110, 21);
            this.lblStaticIden.TabIndex = 10;
            this.lblStaticIden.Text = "Identificação";
            // 
            // lblStaticCNPJ
            // 
            this.lblStaticCNPJ.AutoSize = true;
            this.lblStaticCNPJ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaticCNPJ.Location = new System.Drawing.Point(394, 429);
            this.lblStaticCNPJ.Name = "lblStaticCNPJ";
            this.lblStaticCNPJ.Size = new System.Drawing.Size(49, 21);
            this.lblStaticCNPJ.TabIndex = 11;
            this.lblStaticCNPJ.Text = "CNPJ";
            // 
            // lblStaticEmail
            // 
            this.lblStaticEmail.AutoSize = true;
            this.lblStaticEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaticEmail.Location = new System.Drawing.Point(771, 429);
            this.lblStaticEmail.Name = "lblStaticEmail";
            this.lblStaticEmail.Size = new System.Drawing.Size(59, 21);
            this.lblStaticEmail.TabIndex = 12;
            this.lblStaticEmail.Text = "E-Mail";
            // 
            // lblStaticCEP
            // 
            this.lblStaticCEP.AutoSize = true;
            this.lblStaticCEP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaticCEP.Location = new System.Drawing.Point(771, 492);
            this.lblStaticCEP.Name = "lblStaticCEP";
            this.lblStaticCEP.Size = new System.Drawing.Size(39, 21);
            this.lblStaticCEP.TabIndex = 13;
            this.lblStaticCEP.Text = "CEP";
            // 
            // lblStaticEnd
            // 
            this.lblStaticEnd.AutoSize = true;
            this.lblStaticEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaticEnd.Location = new System.Drawing.Point(102, 492);
            this.lblStaticEnd.Name = "lblStaticEnd";
            this.lblStaticEnd.Size = new System.Drawing.Size(81, 21);
            this.lblStaticEnd.TabIndex = 14;
            this.lblStaticEnd.Text = "Endereço";
            // 
            // lblStaticTel
            // 
            this.lblStaticTel.AutoSize = true;
            this.lblStaticTel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaticTel.Location = new System.Drawing.Point(597, 429);
            this.lblStaticTel.Name = "lblStaticTel";
            this.lblStaticTel.Size = new System.Drawing.Size(76, 21);
            this.lblStaticTel.TabIndex = 15;
            this.lblStaticTel.Text = "Telefone";
            // 
            // dgvCadFor
            // 
            this.dgvCadFor.AllowUserToAddRows = false;
            this.dgvCadFor.AllowUserToDeleteRows = false;
            this.dgvCadFor.AutoGenerateColumns = false;
            this.dgvCadFor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCadFor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadFor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFornecedoresDataGridViewTextBoxColumn,
            this.identificacaoDataGridViewTextBoxColumn,
            this.cnpjDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn});
            this.dgvCadFor.DataSource = this.fornecedoresBindingSource1;
            this.dgvCadFor.Location = new System.Drawing.Point(90, 52);
            this.dgvCadFor.Name = "dgvCadFor";
            this.dgvCadFor.ReadOnly = true;
            this.dgvCadFor.RowHeadersWidth = 20;
            this.dgvCadFor.Size = new System.Drawing.Size(993, 365);
            this.dgvCadFor.TabIndex = 7;
            this.dgvCadFor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "fornecedores";
            this.fornecedoresBindingSource.DataSource = this.mydbDataSet;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedoresBindingSource1
            // 
            this.fornecedoresBindingSource1.DataMember = "fornecedores";
            this.fornecedoresBindingSource1.DataSource = this.mydbDataSet;
            // 
            // idFornecedoresDataGridViewTextBoxColumn
            // 
            this.idFornecedoresDataGridViewTextBoxColumn.DataPropertyName = "idFornecedores";
            this.idFornecedoresDataGridViewTextBoxColumn.HeaderText = "idFornecedores";
            this.idFornecedoresDataGridViewTextBoxColumn.Name = "idFornecedoresDataGridViewTextBoxColumn";
            this.idFornecedoresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // identificacaoDataGridViewTextBoxColumn
            // 
            this.identificacaoDataGridViewTextBoxColumn.DataPropertyName = "identificacao";
            this.identificacaoDataGridViewTextBoxColumn.HeaderText = "identificacao";
            this.identificacaoDataGridViewTextBoxColumn.Name = "identificacaoDataGridViewTextBoxColumn";
            this.identificacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnpjDataGridViewTextBoxColumn
            // 
            this.cnpjDataGridViewTextBoxColumn.DataPropertyName = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.HeaderText = "cnpj";
            this.cnpjDataGridViewTextBoxColumn.Name = "cnpjDataGridViewTextBoxColumn";
            this.cnpjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.dgvCadFor);
            this.Controls.Add(this.lblStaticTel);
            this.Controls.Add(this.lblStaticEnd);
            this.Controls.Add(this.lblStaticCEP);
            this.Controls.Add(this.lblStaticEmail);
            this.Controls.Add(this.lblStaticCNPJ);
            this.Controls.Add(this.lblStaticIden);
            this.Controls.Add(this.txtCadForTel);
            this.Controls.Add(this.txtCadForCep);
            this.Controls.Add(this.txtCadForEnd);
            this.Controls.Add(this.txtCadForMail);
            this.Controls.Add(this.txtCadForCNPJ);
            this.Controls.Add(this.txtCadForIden);
            this.Controls.Add(this.btnCadForExcFor);
            this.Controls.Add(this.lblStaticCadFor);
            this.Controls.Add(this.btnCadForCodFor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedores";
            this.Load += new System.EventHandler(this.cadFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadForCodFor;
        private System.Windows.Forms.Label lblStaticCadFor;
        private System.Windows.Forms.Button btnCadForExcFor;
        private System.Windows.Forms.TextBox txtCadForIden;
        private System.Windows.Forms.TextBox txtCadForCNPJ;
        private System.Windows.Forms.TextBox txtCadForMail;
        private System.Windows.Forms.TextBox txtCadForEnd;
        private System.Windows.Forms.TextBox txtCadForCep;
        private System.Windows.Forms.TextBox txtCadForTel;
        private System.Windows.Forms.Label lblStaticIden;
        private System.Windows.Forms.Label lblStaticCNPJ;
        private System.Windows.Forms.Label lblStaticEmail;
        private System.Windows.Forms.Label lblStaticCEP;
        private System.Windows.Forms.Label lblStaticEnd;
        private System.Windows.Forms.Label lblStaticTel;
        private System.Windows.Forms.DataGridView dgvCadFor;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private mydbDataSetTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource1;
    }
}