
namespace Controle_de_Estoque_RN
{
    partial class Saidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saidas));
            this.lblInputEst = new System.Windows.Forms.Label();
            this.cbSaiEstProd = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet11 = new Controle_de_Estoque_RN.mydbDataSet1();
            this.txtSaiEstPrecVen = new System.Windows.Forms.TextBox();
            this.btnSaiEstRegSai = new System.Windows.Forms.Button();
            this.btnSaiEstExcSai = new System.Windows.Forms.Button();
            this.lblSaiEstProd = new System.Windows.Forms.Label();
            this.lblSaiEstQtd = new System.Windows.Forms.Label();
            this.lblSaiEstPrecVen = new System.Windows.Forms.Label();
            this.dgvSaiEst = new System.Windows.Forms.DataGridView();
            this.txtSaiEstQtd = new System.Windows.Forms.TextBox();
            this.lblSaiEstDet = new System.Windows.Forms.Label();
            this.txtSaiEstDet = new System.Windows.Forms.TextBox();
            this.saidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet31 = new Controle_de_Estoque_RN.mydbDataSet3();
            this.saidasTableAdapter = new Controle_de_Estoque_RN.mydbDataSet3TableAdapters.saidasTableAdapter();
            this.produtosTableAdapter2 = new Controle_de_Estoque_RN.mydbDataSet1TableAdapters.produtosTableAdapter();
            this.saidasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idSaidasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProdutosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaiEst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInputEst
            // 
            this.lblInputEst.AutoSize = true;
            this.lblInputEst.Font = new System.Drawing.Font("Poor Richard", 20F, System.Drawing.FontStyle.Bold);
            this.lblInputEst.Location = new System.Drawing.Point(497, 9);
            this.lblInputEst.Name = "lblInputEst";
            this.lblInputEst.Size = new System.Drawing.Size(208, 31);
            this.lblInputEst.TabIndex = 1;
            this.lblInputEst.Text = "Saídas no Estoque";
            // 
            // cbSaiEstProd
            // 
            this.cbSaiEstProd.DataSource = this.produtosBindingSource;
            this.cbSaiEstProd.DisplayMember = "idProdutos";
            this.cbSaiEstProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSaiEstProd.FormattingEnabled = true;
            this.cbSaiEstProd.Location = new System.Drawing.Point(136, 453);
            this.cbSaiEstProd.Name = "cbSaiEstProd";
            this.cbSaiEstProd.Size = new System.Drawing.Size(435, 23);
            this.cbSaiEstProd.TabIndex = 0;
            this.cbSaiEstProd.ValueMember = "idProdutos";
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "produtos";
            this.produtosBindingSource.DataSource = this.mydbDataSet11;
            // 
            // mydbDataSet11
            // 
            this.mydbDataSet11.DataSetName = "mydbDataSet1";
            this.mydbDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSaiEstPrecVen
            // 
            this.txtSaiEstPrecVen.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtSaiEstPrecVen.Location = new System.Drawing.Point(723, 453);
            this.txtSaiEstPrecVen.MaxLength = 10;
            this.txtSaiEstPrecVen.Name = "txtSaiEstPrecVen";
            this.txtSaiEstPrecVen.Size = new System.Drawing.Size(83, 36);
            this.txtSaiEstPrecVen.TabIndex = 2;
            // 
            // btnSaiEstRegSai
            // 
            this.btnSaiEstRegSai.BackColor = System.Drawing.Color.Lime;
            this.btnSaiEstRegSai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaiEstRegSai.Location = new System.Drawing.Point(12, 511);
            this.btnSaiEstRegSai.Name = "btnSaiEstRegSai";
            this.btnSaiEstRegSai.Size = new System.Drawing.Size(73, 38);
            this.btnSaiEstRegSai.TabIndex = 4;
            this.btnSaiEstRegSai.Text = "Registrar Saída";
            this.btnSaiEstRegSai.UseVisualStyleBackColor = false;
            this.btnSaiEstRegSai.Click += new System.EventHandler(this.btnSaiEstRegSai_Click);
            // 
            // btnSaiEstExcSai
            // 
            this.btnSaiEstExcSai.BackColor = System.Drawing.Color.Red;
            this.btnSaiEstExcSai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaiEstExcSai.Location = new System.Drawing.Point(1099, 511);
            this.btnSaiEstExcSai.Name = "btnSaiEstExcSai";
            this.btnSaiEstExcSai.Size = new System.Drawing.Size(73, 38);
            this.btnSaiEstExcSai.TabIndex = 6;
            this.btnSaiEstExcSai.Text = "Excluir Saída";
            this.btnSaiEstExcSai.UseVisualStyleBackColor = false;
            this.btnSaiEstExcSai.Click += new System.EventHandler(this.btnSaiEstExcSai_Click);
            // 
            // lblSaiEstProd
            // 
            this.lblSaiEstProd.AutoSize = true;
            this.lblSaiEstProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSaiEstProd.Location = new System.Drawing.Point(132, 429);
            this.lblSaiEstProd.Name = "lblSaiEstProd";
            this.lblSaiEstProd.Size = new System.Drawing.Size(72, 21);
            this.lblSaiEstProd.TabIndex = 13;
            this.lblSaiEstProd.Text = "Produto";
            // 
            // lblSaiEstQtd
            // 
            this.lblSaiEstQtd.AutoSize = true;
            this.lblSaiEstQtd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSaiEstQtd.Location = new System.Drawing.Point(610, 429);
            this.lblSaiEstQtd.Name = "lblSaiEstQtd";
            this.lblSaiEstQtd.Size = new System.Drawing.Size(38, 21);
            this.lblSaiEstQtd.TabIndex = 14;
            this.lblSaiEstQtd.Text = "Qtd";
            // 
            // lblSaiEstPrecVen
            // 
            this.lblSaiEstPrecVen.AutoSize = true;
            this.lblSaiEstPrecVen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSaiEstPrecVen.Location = new System.Drawing.Point(703, 429);
            this.lblSaiEstPrecVen.Name = "lblSaiEstPrecVen";
            this.lblSaiEstPrecVen.Size = new System.Drawing.Size(128, 21);
            this.lblSaiEstPrecVen.TabIndex = 15;
            this.lblSaiEstPrecVen.Text = "Preço da Venda";
            // 
            // dgvSaiEst
            // 
            this.dgvSaiEst.AllowUserToAddRows = false;
            this.dgvSaiEst.AllowUserToDeleteRows = false;
            this.dgvSaiEst.AutoGenerateColumns = false;
            this.dgvSaiEst.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSaiEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaiEst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSaidasDataGridViewTextBoxColumn,
            this.idProdutosDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.dataSaidaDataGridViewTextBoxColumn});
            this.dgvSaiEst.DataSource = this.saidasBindingSource1;
            this.dgvSaiEst.Location = new System.Drawing.Point(90, 52);
            this.dgvSaiEst.Name = "dgvSaiEst";
            this.dgvSaiEst.ReadOnly = true;
            this.dgvSaiEst.RowHeadersWidth = 20;
            this.dgvSaiEst.Size = new System.Drawing.Size(993, 365);
            this.dgvSaiEst.TabIndex = 5;
            // 
            // txtSaiEstQtd
            // 
            this.txtSaiEstQtd.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtSaiEstQtd.Location = new System.Drawing.Point(614, 453);
            this.txtSaiEstQtd.MaxLength = 4;
            this.txtSaiEstQtd.Name = "txtSaiEstQtd";
            this.txtSaiEstQtd.Size = new System.Drawing.Size(58, 36);
            this.txtSaiEstQtd.TabIndex = 1;
            this.txtSaiEstQtd.TextChanged += new System.EventHandler(this.txtSaiEstQtd_TextChanged);
            // 
            // lblSaiEstDet
            // 
            this.lblSaiEstDet.AutoSize = true;
            this.lblSaiEstDet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSaiEstDet.Location = new System.Drawing.Point(132, 486);
            this.lblSaiEstDet.Name = "lblSaiEstDet";
            this.lblSaiEstDet.Size = new System.Drawing.Size(170, 21);
            this.lblSaiEstDet.TabIndex = 19;
            this.lblSaiEstDet.Text = "Observações do Item";
            // 
            // txtSaiEstDet
            // 
            this.txtSaiEstDet.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtSaiEstDet.Location = new System.Drawing.Point(136, 513);
            this.txtSaiEstDet.MaxLength = 100;
            this.txtSaiEstDet.Name = "txtSaiEstDet";
            this.txtSaiEstDet.Size = new System.Drawing.Size(947, 36);
            this.txtSaiEstDet.TabIndex = 3;
            // 
            // saidasBindingSource
            // 
            this.saidasBindingSource.DataMember = "saidas";
            this.saidasBindingSource.DataSource = this.mydbDataSet31;
            // 
            // mydbDataSet31
            // 
            this.mydbDataSet31.DataSetName = "mydbDataSet3";
            this.mydbDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saidasTableAdapter
            // 
            this.saidasTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter2
            // 
            this.produtosTableAdapter2.ClearBeforeFill = true;
            // 
            // saidasBindingSource1
            // 
            this.saidasBindingSource1.DataMember = "saidas";
            this.saidasBindingSource1.DataSource = this.mydbDataSet31;
            // 
            // idSaidasDataGridViewTextBoxColumn
            // 
            this.idSaidasDataGridViewTextBoxColumn.DataPropertyName = "idSaidas";
            this.idSaidasDataGridViewTextBoxColumn.HeaderText = "idSaidas";
            this.idSaidasDataGridViewTextBoxColumn.Name = "idSaidasDataGridViewTextBoxColumn";
            this.idSaidasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idProdutosDataGridViewTextBoxColumn
            // 
            this.idProdutosDataGridViewTextBoxColumn.DataPropertyName = "idProdutos";
            this.idProdutosDataGridViewTextBoxColumn.HeaderText = "idProdutos";
            this.idProdutosDataGridViewTextBoxColumn.Name = "idProdutosDataGridViewTextBoxColumn";
            this.idProdutosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSaidaDataGridViewTextBoxColumn
            // 
            this.dataSaidaDataGridViewTextBoxColumn.DataPropertyName = "dataSaida";
            this.dataSaidaDataGridViewTextBoxColumn.HeaderText = "dataSaida";
            this.dataSaidaDataGridViewTextBoxColumn.Name = "dataSaidaDataGridViewTextBoxColumn";
            this.dataSaidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Saidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblSaiEstDet);
            this.Controls.Add(this.txtSaiEstDet);
            this.Controls.Add(this.txtSaiEstQtd);
            this.Controls.Add(this.dgvSaiEst);
            this.Controls.Add(this.lblSaiEstPrecVen);
            this.Controls.Add(this.lblSaiEstQtd);
            this.Controls.Add(this.lblSaiEstProd);
            this.Controls.Add(this.btnSaiEstExcSai);
            this.Controls.Add(this.btnSaiEstRegSai);
            this.Controls.Add(this.txtSaiEstPrecVen);
            this.Controls.Add(this.cbSaiEstProd);
            this.Controls.Add(this.lblInputEst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Saidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saidas do Estoque";
            this.Load += new System.EventHandler(this.Saidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaiEst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputEst;
        private System.Windows.Forms.ComboBox cbSaiEstProd;
        private System.Windows.Forms.TextBox txtSaiEstPrecVen;
        private System.Windows.Forms.Button btnSaiEstRegSai;
        private System.Windows.Forms.Button btnSaiEstExcSai;
        private System.Windows.Forms.Label lblSaiEstProd;
        private System.Windows.Forms.Label lblSaiEstQtd;
        private System.Windows.Forms.Label lblSaiEstPrecVen;
        private System.Windows.Forms.DataGridView dgvSaiEst;
        private System.Windows.Forms.TextBox txtSaiEstQtd;
        private mydbDataSet3 mydbDataSet3;
        private mydbDataSet1TableAdapters.produtosTableAdapter produtosTableAdapter;
        private mydbDataSet1 mydbDataSet1;
        private mydbDataSet1TableAdapters.produtosTableAdapter produtosTableAdapter1;
        private System.Windows.Forms.Label lblSaiEstDet;
        private System.Windows.Forms.TextBox txtSaiEstDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private mydbDataSet3 mydbDataSet31;
        private System.Windows.Forms.BindingSource saidasBindingSource;
        private mydbDataSet3TableAdapters.saidasTableAdapter saidasTableAdapter;
        private mydbDataSet1 mydbDataSet11;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private mydbDataSet1TableAdapters.produtosTableAdapter produtosTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSaidasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource saidasBindingSource1;
    }
}