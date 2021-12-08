
namespace Controle_de_Estoque_RN
{
    partial class Entradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entradas));
            this.lblInputEst = new System.Windows.Forms.Label();
            this.btnEntEstAdcProd = new System.Windows.Forms.Button();
            this.cbCadProdFor = new System.Windows.Forms.ComboBox();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet1 = new Controle_de_Estoque_RN.mydbDataSet1();
            this.txtEntEstQtd = new System.Windows.Forms.TextBox();
            this.btnEntEstExc = new System.Windows.Forms.Button();
            this.lblEntEstProd = new System.Windows.Forms.Label();
            this.lblEntEstQtd = new System.Windows.Forms.Label();
            this.txtEntEstPreco = new System.Windows.Forms.TextBox();
            this.lblEntEstPrec = new System.Windows.Forms.Label();
            this.dgvEntEst = new System.Windows.Forms.DataGridView();
            this.idEntradasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet2 = new Controle_de_Estoque_RN.mydbDataSet2();
            this.entradasTableAdapter = new Controle_de_Estoque_RN.mydbDataSet2TableAdapters.entradasTableAdapter();
            this.produtosTableAdapter = new Controle_de_Estoque_RN.mydbDataSet1TableAdapters.produtosTableAdapter();
            this.txtEntEstDet = new System.Windows.Forms.TextBox();
            this.lblEntEstDet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntEst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInputEst
            // 
            this.lblInputEst.AutoSize = true;
            this.lblInputEst.Font = new System.Drawing.Font("Poor Richard", 20F, System.Drawing.FontStyle.Bold);
            this.lblInputEst.Location = new System.Drawing.Point(461, 9);
            this.lblInputEst.Name = "lblInputEst";
            this.lblInputEst.Size = new System.Drawing.Size(234, 31);
            this.lblInputEst.TabIndex = 0;
            this.lblInputEst.Text = "Entradas no Estoque";
            // 
            // btnEntEstAdcProd
            // 
            this.btnEntEstAdcProd.BackColor = System.Drawing.Color.Lime;
            this.btnEntEstAdcProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEntEstAdcProd.Location = new System.Drawing.Point(12, 511);
            this.btnEntEstAdcProd.Name = "btnEntEstAdcProd";
            this.btnEntEstAdcProd.Size = new System.Drawing.Size(73, 38);
            this.btnEntEstAdcProd.TabIndex = 4;
            this.btnEntEstAdcProd.Text = "Adicionar Entrada";
            this.btnEntEstAdcProd.UseVisualStyleBackColor = false;
            this.btnEntEstAdcProd.Click += new System.EventHandler(this.btnEntEstAdcProd_Click);
            // 
            // cbCadProdFor
            // 
            this.cbCadProdFor.DataSource = this.produtosBindingSource;
            this.cbCadProdFor.DisplayMember = "idProdutos";
            this.cbCadProdFor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbCadProdFor.FormattingEnabled = true;
            this.cbCadProdFor.Location = new System.Drawing.Point(136, 453);
            this.cbCadProdFor.Name = "cbCadProdFor";
            this.cbCadProdFor.Size = new System.Drawing.Size(435, 23);
            this.cbCadProdFor.TabIndex = 0;
            this.cbCadProdFor.ValueMember = "idProdutos";
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
            // txtEntEstQtd
            // 
            this.txtEntEstQtd.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtEntEstQtd.Location = new System.Drawing.Point(614, 453);
            this.txtEntEstQtd.MaxLength = 4;
            this.txtEntEstQtd.Name = "txtEntEstQtd";
            this.txtEntEstQtd.Size = new System.Drawing.Size(61, 36);
            this.txtEntEstQtd.TabIndex = 1;
            // 
            // btnEntEstExc
            // 
            this.btnEntEstExc.BackColor = System.Drawing.Color.Red;
            this.btnEntEstExc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEntEstExc.Location = new System.Drawing.Point(1099, 511);
            this.btnEntEstExc.Name = "btnEntEstExc";
            this.btnEntEstExc.Size = new System.Drawing.Size(73, 38);
            this.btnEntEstExc.TabIndex = 6;
            this.btnEntEstExc.Text = "Excluir Entrada";
            this.btnEntEstExc.UseVisualStyleBackColor = false;
            this.btnEntEstExc.Click += new System.EventHandler(this.btnEntEstExc_Click);
            // 
            // lblEntEstProd
            // 
            this.lblEntEstProd.AutoSize = true;
            this.lblEntEstProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEntEstProd.Location = new System.Drawing.Point(136, 429);
            this.lblEntEstProd.Name = "lblEntEstProd";
            this.lblEntEstProd.Size = new System.Drawing.Size(72, 21);
            this.lblEntEstProd.TabIndex = 10;
            this.lblEntEstProd.Text = "Produto";
            // 
            // lblEntEstQtd
            // 
            this.lblEntEstQtd.AutoSize = true;
            this.lblEntEstQtd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEntEstQtd.Location = new System.Drawing.Point(610, 429);
            this.lblEntEstQtd.Name = "lblEntEstQtd";
            this.lblEntEstQtd.Size = new System.Drawing.Size(38, 21);
            this.lblEntEstQtd.TabIndex = 11;
            this.lblEntEstQtd.Text = "Qtd";
            // 
            // txtEntEstPreco
            // 
            this.txtEntEstPreco.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtEntEstPreco.Location = new System.Drawing.Point(723, 453);
            this.txtEntEstPreco.MaxLength = 10;
            this.txtEntEstPreco.Name = "txtEntEstPreco";
            this.txtEntEstPreco.Size = new System.Drawing.Size(82, 36);
            this.txtEntEstPreco.TabIndex = 2;
            // 
            // lblEntEstPrec
            // 
            this.lblEntEstPrec.AutoSize = true;
            this.lblEntEstPrec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEntEstPrec.Location = new System.Drawing.Point(699, 429);
            this.lblEntEstPrec.Name = "lblEntEstPrec";
            this.lblEntEstPrec.Size = new System.Drawing.Size(137, 21);
            this.lblEntEstPrec.TabIndex = 13;
            this.lblEntEstPrec.Text = "Valor da Compra";
            // 
            // dgvEntEst
            // 
            this.dgvEntEst.AllowUserToAddRows = false;
            this.dgvEntEst.AllowUserToDeleteRows = false;
            this.dgvEntEst.AutoGenerateColumns = false;
            this.dgvEntEst.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvEntEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntEst.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEntradasDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.quantidadeDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.dataEntradaDataGridViewTextBoxColumn});
            this.dgvEntEst.DataSource = this.entradasBindingSource;
            this.dgvEntEst.Location = new System.Drawing.Point(90, 52);
            this.dgvEntEst.Name = "dgvEntEst";
            this.dgvEntEst.ReadOnly = true;
            this.dgvEntEst.RowHeadersWidth = 20;
            this.dgvEntEst.Size = new System.Drawing.Size(993, 365);
            this.dgvEntEst.TabIndex = 5;
            // 
            // idEntradasDataGridViewTextBoxColumn
            // 
            this.idEntradasDataGridViewTextBoxColumn.DataPropertyName = "idEntradas";
            this.idEntradasDataGridViewTextBoxColumn.HeaderText = "ID_Entrada";
            this.idEntradasDataGridViewTextBoxColumn.Name = "idEntradasDataGridViewTextBoxColumn";
            this.idEntradasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idProdutos";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Produto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEntradaDataGridViewTextBoxColumn
            // 
            this.dataEntradaDataGridViewTextBoxColumn.DataPropertyName = "dataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.HeaderText = "Data de Entrada";
            this.dataEntradaDataGridViewTextBoxColumn.Name = "dataEntradaDataGridViewTextBoxColumn";
            this.dataEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataEntradaDataGridViewTextBoxColumn.Width = 150;
            // 
            // entradasBindingSource
            // 
            this.entradasBindingSource.DataMember = "entradas";
            this.entradasBindingSource.DataSource = this.mydbDataSet2BindingSource;
            // 
            // mydbDataSet2BindingSource
            // 
            this.mydbDataSet2BindingSource.DataSource = this.mydbDataSet2;
            this.mydbDataSet2BindingSource.Position = 0;
            // 
            // mydbDataSet2
            // 
            this.mydbDataSet2.DataSetName = "mydbDataSet2";
            this.mydbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // entradasTableAdapter
            // 
            this.entradasTableAdapter.ClearBeforeFill = true;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // txtEntEstDet
            // 
            this.txtEntEstDet.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.txtEntEstDet.Location = new System.Drawing.Point(136, 513);
            this.txtEntEstDet.MaxLength = 100;
            this.txtEntEstDet.Name = "txtEntEstDet";
            this.txtEntEstDet.Size = new System.Drawing.Size(947, 36);
            this.txtEntEstDet.TabIndex = 3;
            this.txtEntEstDet.TextChanged += new System.EventHandler(this.txtEntEstDet_TextChanged);
            // 
            // lblEntEstDet
            // 
            this.lblEntEstDet.AutoSize = true;
            this.lblEntEstDet.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEntEstDet.Location = new System.Drawing.Point(136, 489);
            this.lblEntEstDet.Name = "lblEntEstDet";
            this.lblEntEstDet.Size = new System.Drawing.Size(170, 21);
            this.lblEntEstDet.TabIndex = 15;
            this.lblEntEstDet.Text = "Observações do Item";
            this.lblEntEstDet.Click += new System.EventHandler(this.lblEntEstDet_Click);
            // 
            // Entradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblEntEstDet);
            this.Controls.Add(this.txtEntEstDet);
            this.Controls.Add(this.dgvEntEst);
            this.Controls.Add(this.lblEntEstPrec);
            this.Controls.Add(this.txtEntEstPreco);
            this.Controls.Add(this.lblEntEstQtd);
            this.Controls.Add(this.lblEntEstProd);
            this.Controls.Add(this.btnEntEstExc);
            this.Controls.Add(this.txtEntEstQtd);
            this.Controls.Add(this.cbCadProdFor);
            this.Controls.Add(this.btnEntEstAdcProd);
            this.Controls.Add(this.lblInputEst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Entradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entradas do Estoque";
            this.Load += new System.EventHandler(this.Entradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntEst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputEst;
        private System.Windows.Forms.Button btnEntEstAdcProd;
        private System.Windows.Forms.ComboBox cbCadProdFor;
        private System.Windows.Forms.TextBox txtEntEstQtd;
        private System.Windows.Forms.Button btnEntEstExc;
        private System.Windows.Forms.Label lblEntEstProd;
        private System.Windows.Forms.Label lblEntEstQtd;
        private System.Windows.Forms.TextBox txtEntEstPreco;
        private System.Windows.Forms.Label lblEntEstPrec;
        private System.Windows.Forms.DataGridView dgvEntEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mydbDataSet2BindingSource;
        private mydbDataSet2 mydbDataSet2;
        private System.Windows.Forms.BindingSource entradasBindingSource;
        private mydbDataSet2TableAdapters.entradasTableAdapter entradasTableAdapter;
        private mydbDataSet1 mydbDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private mydbDataSet1TableAdapters.produtosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.TextBox txtEntEstDet;
        private System.Windows.Forms.Label lblEntEstDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEntradasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaDataGridViewTextBoxColumn;
    }
}