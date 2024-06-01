﻿namespace WindowsFormsApp1.UserControls
{
	partial class UC_Produtos
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Produtos));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.produtosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.sistemaFaturaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sistemaFaturaDataSet = new WindowsFormsApp1.SistemaFaturaDataSet();
			this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.produtosTableAdapter = new WindowsFormsApp1.SistemaFaturaDataSetTableAdapters.ProdutosTableAdapter();
			this.addNovoPro = new System.Windows.Forms.Button();
			this.sistemaFaturaDataSet1 = new WindowsFormsApp1.SistemaFaturaDataSet1();
			this.sistemaFaturaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.produtosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.sistemaFaturaDataSet2 = new WindowsFormsApp1.SistemaFaturaDataSet2();
			this.vwProdutosDetalhadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.vw_ProdutosDetalhadosTableAdapter = new WindowsFormsApp1.SistemaFaturaDataSet2TableAdapters.vw_ProdutosDetalhadosTableAdapter();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.nomeProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descricaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantidadePorUnidadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
			this.nomeProdutoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantidadePorUnidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeFornecedorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iVADataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomeCategoriaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSetBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vwProdutosDetalhadosBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(928, 61);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(83)))));
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(33, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Produtos";
			// 
			// produtosBindingSource1
			// 
			this.produtosBindingSource1.DataMember = "Produtos";
			this.produtosBindingSource1.DataSource = this.sistemaFaturaDataSetBindingSource;
			// 
			// sistemaFaturaDataSetBindingSource
			// 
			this.sistemaFaturaDataSetBindingSource.DataSource = this.sistemaFaturaDataSet;
			this.sistemaFaturaDataSetBindingSource.Position = 0;
			// 
			// sistemaFaturaDataSet
			// 
			this.sistemaFaturaDataSet.DataSetName = "SistemaFaturaDataSet";
			this.sistemaFaturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// produtosBindingSource
			// 
			this.produtosBindingSource.DataMember = "Produtos";
			this.produtosBindingSource.DataSource = this.sistemaFaturaDataSet;
			// 
			// produtosTableAdapter
			// 
			this.produtosTableAdapter.ClearBeforeFill = true;
			// 
			// addNovoPro
			// 
			this.addNovoPro.BackColor = System.Drawing.Color.SteelBlue;
			this.addNovoPro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNovoPro.Image = ((System.Drawing.Image)(resources.GetObject("addNovoPro.Image")));
			this.addNovoPro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addNovoPro.Location = new System.Drawing.Point(26, 388);
			this.addNovoPro.Name = "addNovoPro";
			this.addNovoPro.Size = new System.Drawing.Size(241, 68);
			this.addNovoPro.TabIndex = 3;
			this.addNovoPro.Text = "Adicionar novo produto";
			this.addNovoPro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.addNovoPro.UseVisualStyleBackColor = false;
			this.addNovoPro.Click += new System.EventHandler(this.addNovoPro_Click);
			// 
			// sistemaFaturaDataSet1
			// 
			this.sistemaFaturaDataSet1.DataSetName = "SistemaFaturaDataSet1";
			this.sistemaFaturaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sistemaFaturaDataSet1BindingSource
			// 
			this.sistemaFaturaDataSet1BindingSource.DataSource = this.sistemaFaturaDataSet1;
			this.sistemaFaturaDataSet1BindingSource.Position = 0;
			// 
			// produtosBindingSource2
			// 
			this.produtosBindingSource2.DataMember = "Produtos";
			this.produtosBindingSource2.DataSource = this.sistemaFaturaDataSetBindingSource;
			// 
			// sistemaFaturaDataSet2
			// 
			this.sistemaFaturaDataSet2.DataSetName = "SistemaFaturaDataSet2";
			this.sistemaFaturaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// vwProdutosDetalhadosBindingSource
			// 
			this.vwProdutosDetalhadosBindingSource.DataMember = "vw_ProdutosDetalhados";
			this.vwProdutosDetalhadosBindingSource.DataSource = this.sistemaFaturaDataSet2;
			// 
			// vw_ProdutosDetalhadosTableAdapter
			// 
			this.vw_ProdutosDetalhadosTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProdutoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn1,
            this.precoDataGridViewTextBoxColumn1,
            this.quantidadePorUnidadeDataGridViewTextBoxColumn1,
            this.nomeFornecedorDataGridViewTextBoxColumn,
            this.iVADataGridViewTextBoxColumn,
            this.nomeCategoriaDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.vwProdutosDetalhadosBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(26, 107);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(744, 217);
			this.dataGridView2.TabIndex = 4;
			// 
			// nomeProdutoDataGridViewTextBoxColumn
			// 
			this.nomeProdutoDataGridViewTextBoxColumn.DataPropertyName = "NomeProduto";
			this.nomeProdutoDataGridViewTextBoxColumn.HeaderText = "NomeProduto";
			this.nomeProdutoDataGridViewTextBoxColumn.Name = "nomeProdutoDataGridViewTextBoxColumn";
			// 
			// descricaoDataGridViewTextBoxColumn1
			// 
			this.descricaoDataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
			this.descricaoDataGridViewTextBoxColumn1.HeaderText = "Descricao";
			this.descricaoDataGridViewTextBoxColumn1.Name = "descricaoDataGridViewTextBoxColumn1";
			// 
			// precoDataGridViewTextBoxColumn1
			// 
			this.precoDataGridViewTextBoxColumn1.DataPropertyName = "Preco";
			this.precoDataGridViewTextBoxColumn1.HeaderText = "Preco";
			this.precoDataGridViewTextBoxColumn1.Name = "precoDataGridViewTextBoxColumn1";
			// 
			// quantidadePorUnidadeDataGridViewTextBoxColumn1
			// 
			this.quantidadePorUnidadeDataGridViewTextBoxColumn1.DataPropertyName = "QuantidadePorUnidade";
			this.quantidadePorUnidadeDataGridViewTextBoxColumn1.HeaderText = "QuantidadePorUnidade";
			this.quantidadePorUnidadeDataGridViewTextBoxColumn1.Name = "quantidadePorUnidadeDataGridViewTextBoxColumn1";
			// 
			// nomeFornecedorDataGridViewTextBoxColumn
			// 
			this.nomeFornecedorDataGridViewTextBoxColumn.DataPropertyName = "NomeFornecedor";
			this.nomeFornecedorDataGridViewTextBoxColumn.HeaderText = "NomeFornecedor";
			this.nomeFornecedorDataGridViewTextBoxColumn.Name = "nomeFornecedorDataGridViewTextBoxColumn";
			// 
			// iVADataGridViewTextBoxColumn
			// 
			this.iVADataGridViewTextBoxColumn.DataPropertyName = "IVA";
			this.iVADataGridViewTextBoxColumn.HeaderText = "IVA";
			this.iVADataGridViewTextBoxColumn.Name = "iVADataGridViewTextBoxColumn";
			// 
			// nomeCategoriaDataGridViewTextBoxColumn
			// 
			this.nomeCategoriaDataGridViewTextBoxColumn.DataPropertyName = "NomeCategoria";
			this.nomeCategoriaDataGridViewTextBoxColumn.HeaderText = "NomeCategoria";
			this.nomeCategoriaDataGridViewTextBoxColumn.Name = "nomeCategoriaDataGridViewTextBoxColumn";
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoGenerateColumns = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeight = 15;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeProdutoDataGridViewTextBoxColumn1,
            this.descricaoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.quantidadePorUnidadeDataGridViewTextBoxColumn,
            this.nomeFornecedorDataGridViewTextBoxColumn1,
            this.iVADataGridViewTextBoxColumn1,
            this.nomeCategoriaDataGridViewTextBoxColumn1});
			this.dataGridView1.DataSource = this.vwProdutosDetalhadosBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridView1.Location = new System.Drawing.Point(307, 330);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.Size = new System.Drawing.Size(585, 150);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dataGridView1.ThemeStyle.HeaderStyle.Height = 15;
			this.dataGridView1.ThemeStyle.ReadOnly = false;
			this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
			this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// nomeProdutoDataGridViewTextBoxColumn1
			// 
			this.nomeProdutoDataGridViewTextBoxColumn1.DataPropertyName = "NomeProduto";
			this.nomeProdutoDataGridViewTextBoxColumn1.HeaderText = "NomeProduto";
			this.nomeProdutoDataGridViewTextBoxColumn1.Name = "nomeProdutoDataGridViewTextBoxColumn1";
			// 
			// descricaoDataGridViewTextBoxColumn
			// 
			this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
			this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
			// 
			// precoDataGridViewTextBoxColumn
			// 
			this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
			this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
			this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
			// 
			// quantidadePorUnidadeDataGridViewTextBoxColumn
			// 
			this.quantidadePorUnidadeDataGridViewTextBoxColumn.DataPropertyName = "QuantidadePorUnidade";
			this.quantidadePorUnidadeDataGridViewTextBoxColumn.HeaderText = "QuantidadePorUnidade";
			this.quantidadePorUnidadeDataGridViewTextBoxColumn.Name = "quantidadePorUnidadeDataGridViewTextBoxColumn";
			// 
			// nomeFornecedorDataGridViewTextBoxColumn1
			// 
			this.nomeFornecedorDataGridViewTextBoxColumn1.DataPropertyName = "NomeFornecedor";
			this.nomeFornecedorDataGridViewTextBoxColumn1.HeaderText = "NomeFornecedor";
			this.nomeFornecedorDataGridViewTextBoxColumn1.Name = "nomeFornecedorDataGridViewTextBoxColumn1";
			// 
			// iVADataGridViewTextBoxColumn1
			// 
			this.iVADataGridViewTextBoxColumn1.DataPropertyName = "IVA";
			this.iVADataGridViewTextBoxColumn1.HeaderText = "IVA";
			this.iVADataGridViewTextBoxColumn1.Name = "iVADataGridViewTextBoxColumn1";
			// 
			// nomeCategoriaDataGridViewTextBoxColumn1
			// 
			this.nomeCategoriaDataGridViewTextBoxColumn1.DataPropertyName = "NomeCategoria";
			this.nomeCategoriaDataGridViewTextBoxColumn1.HeaderText = "NomeCategoria";
			this.nomeCategoriaDataGridViewTextBoxColumn1.Name = "nomeCategoriaDataGridViewTextBoxColumn1";
			// 
			// UC_Produtos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.addNovoPro);
			this.Controls.Add(this.panel1);
			this.Name = "UC_Produtos";
			this.Size = new System.Drawing.Size(928, 516);
			this.Load += new System.EventHandler(this.UC_Produtos_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSetBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sistemaFaturaDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vwProdutosDetalhadosBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource produtosBindingSource;
		private SistemaFaturaDataSet sistemaFaturaDataSet;
		private SistemaFaturaDataSetTableAdapters.ProdutosTableAdapter produtosTableAdapter;
		private System.Windows.Forms.Button addNovoPro;
		private System.Windows.Forms.BindingSource produtosBindingSource1;
		private System.Windows.Forms.BindingSource sistemaFaturaDataSetBindingSource;
		private System.Windows.Forms.BindingSource produtosBindingSource2;
		private SistemaFaturaDataSet1 sistemaFaturaDataSet1;
		private System.Windows.Forms.BindingSource sistemaFaturaDataSet1BindingSource;
		private System.Windows.Forms.BindingSource vwProdutosDetalhadosBindingSource;
		private SistemaFaturaDataSet2 sistemaFaturaDataSet2;
		private SistemaFaturaDataSet2TableAdapters.vw_ProdutosDetalhadosTableAdapter vw_ProdutosDetalhadosTableAdapter;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantidadePorUnidadeDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeFornecedorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iVADataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeCategoriaDataGridViewTextBoxColumn;
		private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeProdutoDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantidadePorUnidadeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeFornecedorDataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iVADataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomeCategoriaDataGridViewTextBoxColumn1;
	}
}
