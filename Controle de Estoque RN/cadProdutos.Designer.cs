
namespace Controle_de_Estoque_RN
{
    partial class cadProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadProdutos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCadProdDesc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCadProdPrec = new System.Windows.Forms.TextBox();
            this.txtCadProdUni = new System.Windows.Forms.TextBox();
            this.cbCadProdFor = new System.Windows.Forms.ComboBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new Controle_de_Estoque_RN.mydbDataSet();
            this.btnCadProdExc = new System.Windows.Forms.Button();
            this.lblStaticProdDesc = new System.Windows.Forms.Label();
            this.lblStaticProdPrec = new System.Windows.Forms.Label();
            this.lblStaticProdUni = new System.Windows.Forms.Label();
            this.lblStaticProdForn = new System.Windows.Forms.Label();
            this.dgvCadProd = new System.Windows.Forms.DataGridView();
            this.txtCadProdQtd = new System.Windows.Forms.TextBox();
            this.lblStaticProdQtd = new System.Windows.Forms.Label();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet1 = new Controle_de_Estoque_RN.mydbDataSet1();
            this.fornecedoresTableAdapter = new Controle_de_Estoque_RN.mydbDataSetTableAdapters.fornecedoresTableAdapter();
            this.produtosTableAdapter = new Controle_de_Estoque_RN.mydbDataSet1TableAdapters.produtosTableAdapter();
            this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idProdutosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(463, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // txtCadProdDesc
            // 
            this.txtCadProdDesc.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtCadProdDesc.Location = new System.Drawing.Point(102, 513);
            this.txtCadProdDesc.MaxLength = 45;
            this.txtCadProdDesc.Name = "txtCadProdDesc";
            this.txtCadProdDesc.Size = new System.Drawing.Size(435, 36);
            this.txtCadProdDesc.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.Location = new System.Drawing.Point(12, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cadastrar Produto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCadProdPrec
            // 
            this.txtCadProdPrec.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtCadProdPrec.Location = new System.Drawing.Point(561, 513);
            this.txtCadProdPrec.MaxLength = 10;
            this.txtCadProdPrec.Name = "txtCadProdPrec";
            this.txtCadProdPrec.Size = new System.Drawing.Size(77, 36);
            this.txtCadProdPrec.TabIndex = 1;
            // 
            // txtCadProdUni
            // 
            this.txtCadProdUni.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtCadProdUni.Location = new System.Drawing.Point(748, 513);
            this.txtCadProdUni.MaxLength = 4;
            this.txtCadProdUni.Name = "txtCadProdUni";
            this.txtCadProdUni.Size = new System.Drawing.Size(52, 36);
            this.txtCadProdUni.TabIndex = 3;
            // 
            // cbCadProdFor
            // 
            this.cbCadProdFor.DataSource = this.fornecedoresBindingSource;
            this.cbCadProdFor.DisplayMember = "idFornecedores";
            this.cbCadProdFor.FormattingEnabled = true;
            this.cbCadProdFor.Location = new System.Drawing.Point(853, 513);
            this.cbCadProdFor.Name = "cbCadProdFor";
            this.cbCadProdFor.Size = new System.Drawing.Size(121, 21);
            this.cbCadProdFor.TabIndex = 4;
            this.cbCadProdFor.ValueMember = "idFornecedores";
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
            // btnCadProdExc
            // 
            this.btnCadProdExc.BackColor = System.Drawing.Color.Red;
            this.btnCadProdExc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCadProdExc.Location = new System.Drawing.Point(1099, 511);
            this.btnCadProdExc.Name = "btnCadProdExc";
            this.btnCadProdExc.Size = new System.Drawing.Size(73, 38);
            this.btnCadProdExc.TabIndex = 7;
            this.btnCadProdExc.Text = "Excluir Produto";
            this.btnCadProdExc.UseVisualStyleBackColor = false;
            this.btnCadProdExc.Click += new System.EventHandler(this.btnCadProdExc_Click);
            // 
            // lblStaticProdDesc
            // 
            this.lblStaticProdDesc.AutoSize = true;
            this.lblStaticProdDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaticProdDesc.Location = new System.Drawing.Point(102, 489);
            this.lblStaticProdDesc.Name = "lblStaticProdDesc";
            this.lblStaticProdDesc.Size = new System.Drawing.Size(84, 21);
            this.lblStaticProdDesc.TabIndex = 8;
            this.lblStaticProdDesc.Text = "Descrição";
            // 
            // lblStaticProdPrec
            // 
            this.lblStaticProdPrec.AutoSize = true;
            this.lblStaticProdPrec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaticProdPrec.Location = new System.Drawing.Point(557, 489);
            this.lblStaticProdPrec.Name = "lblStaticProdPrec";
            this.lblStaticProdPrec.Size = new System.Drawing.Size(53, 21);
            this.lblStaticProdPrec.TabIndex = 9;
            this.lblStaticProdPrec.Text = "Preço";
            // 
            // lblStaticProdUni
            // 
            this.lblStaticProdUni.AutoSize = true;
            this.lblStaticProdUni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaticProdUni.Location = new System.Drawing.Point(735, 489);
            this.lblStaticProdUni.Name = "lblStaticProdUni";
            this.lblStaticProdUni.Size = new System.Drawing.Size(75, 21);
            this.lblStaticProdUni.TabIndex = 10;
            this.lblStaticProdUni.Text = "Unidade";
            // 
            // lblStaticProdForn
            // 
            this.lblStaticProdForn.AutoSize = true;
            this.lblStaticProdForn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaticProdForn.Location = new System.Drawing.Point(849, 489);
            this.lblStaticProdForn.Name = "lblStaticProdForn";
            this.lblStaticProdForn.Size = new System.Drawing.Size(96, 21);
            this.lblStaticProdForn.TabIndex = 11;
            this.lblStaticProdForn.Text = "Fornecedor";
            // 
            // dgvCadProd
            // 
            this.dgvCadProd.AllowUserToAddRows = false;
            this.dgvCadProd.AllowUserToDeleteRows = false;
            this.dgvCadProd.AutoGenerateColumns = false;
            this.dgvCadProd.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCadProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCadProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProdutosDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.idFornecedorDataGridViewTextBoxColumn});
            this.dgvCadProd.DataSource = this.produtosBindingSource1;
            this.dgvCadProd.Location = new System.Drawing.Point(90, 52);
            this.dgvCadProd.Name = "dgvCadProd";
            this.dgvCadProd.ReadOnly = true;
            this.dgvCadProd.RowHeadersWidth = 20;
            this.dgvCadProd.Size = new System.Drawing.Size(993, 365);
            this.dgvCadProd.TabIndex = 6;
            // 
            // txtCadProdQtd
            // 
            this.txtCadProdQtd.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtCadProdQtd.Location = new System.Drawing.Point(657, 513);
            this.txtCadProdQtd.MaxLength = 4;
            this.txtCadProdQtd.Name = "txtCadProdQtd";
            this.txtCadProdQtd.Size = new System.Drawing.Size(60, 36);
            this.txtCadProdQtd.TabIndex = 2;
            // 
            // lblStaticProdQtd
            // 
            this.lblStaticProdQtd.AutoSize = true;
            this.lblStaticProdQtd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStaticProdQtd.Location = new System.Drawing.Point(670, 489);
            this.lblStaticProdQtd.Name = "lblStaticProdQtd";
            this.lblStaticProdQtd.Size = new System.Drawing.Size(38, 21);
            this.lblStaticProdQtd.TabIndex = 14;
            this.lblStaticProdQtd.Text = "Qtd";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.mydbDataSet1;
            // 
            // mydbDataSet1
            // 
            this.mydbDataSet1.DataSetName = "mydbDataSet1";
            this.mydbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // produtosBindingSource1
            // 
            this.produtosBindingSource1.DataMember = "produtos";
            this.produtosBindingSource1.DataSource = this.mydbDataSet1;
            // 
            // idProdutosDataGridViewTextBoxColumn
            // 
            this.idProdutosDataGridViewTextBoxColumn.DataPropertyName = "idProdutos";
            this.idProdutosDataGridViewTextBoxColumn.HeaderText = "idProdutos";
            this.idProdutosDataGridViewTextBoxColumn.Name = "idProdutosDataGridViewTextBoxColumn";
            this.idProdutosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idFornecedorDataGridViewTextBoxColumn
            // 
            this.idFornecedorDataGridViewTextBoxColumn.DataPropertyName = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.HeaderText = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.Name = "idFornecedorDataGridViewTextBoxColumn";
            this.idFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblStaticProdQtd);
            this.Controls.Add(this.txtCadProdQtd);
            this.Controls.Add(this.dgvCadProd);
            this.Controls.Add(this.lblStaticProdForn);
            this.Controls.Add(this.lblStaticProdUni);
            this.Controls.Add(this.lblStaticProdPrec);
            this.Controls.Add(this.lblStaticProdDesc);
            this.Controls.Add(this.btnCadProdExc);
            this.Controls.Add(this.cbCadProdFor);
            this.Controls.Add(this.txtCadProdUni);
            this.Controls.Add(this.txtCadProdPrec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCadProdDesc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "cadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.cadProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCadProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCadProdDesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCadProdPrec;
        private System.Windows.Forms.TextBox txtCadProdUni;
        private System.Windows.Forms.ComboBox cbCadProdFor;
        private System.Windows.Forms.Button btnCadProdExc;
        private System.Windows.Forms.Label lblStaticProdDesc;
        private System.Windows.Forms.Label lblStaticProdPrec;
        private System.Windows.Forms.Label lblStaticProdUni;
        private System.Windows.Forms.Label lblStaticProdForn;
        private System.Windows.Forms.DataGridView dgvCadProd;
        private System.Windows.Forms.TextBox txtCadProdQtd;
        private System.Windows.Forms.Label lblStaticProdQtd;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private mydbDataSetTableAdapters.fornecedoresTableAdapter fornecedoresTableAdapter;
        private mydbDataSet1 mydbDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private mydbDataSet1TableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource produtosBindingSource1;
    }
}