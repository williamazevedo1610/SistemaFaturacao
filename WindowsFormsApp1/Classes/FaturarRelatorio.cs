﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace WindowsFormsApp1.Classes
{
	internal class FaturarRelatorio
	{
		String connectionStringSQL = "Data Source=WA_16;Initial Catalog=SistemaFatura;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

		public void gerarFaturaRelatorioPDF(List<Produto> produtos, string nomeFunci, string nomeClient, string nifCliente, decimal totalVenda, decimal desconto)
		{
			try
			{
				
				string directoryPath = @"C:\Users\Admin\Documents\ISPTEC - Universidade\ISPTEC- 3º ano - 2023-2024\2º Semestre\Engenharia de Software 2\SistemaDeFatura - estável\Faturas";

				
				if (!Directory.Exists(directoryPath))
				{
					Directory.CreateDirectory(directoryPath);
				}

				
				string fileName = $"Fatura_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";
				string filePath = Path.Combine(directoryPath, fileName);

				
				Document document = new Document();
				PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

				
				document.Open();

				
				var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
				var bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

				document.Add(new Paragraph("Fatura de Venda", titleFont));
				document.Add(new Paragraph(" "));

				// Adicionar tabela para dados da empresa e do cliente/fatura
				PdfPTable mainTable = new PdfPTable(2);
				mainTable.WidthPercentage = 100;
				mainTable.SetWidths(new float[] { 60, 40 }); // Definir largura relativa das colunas

				// Célula para dados da fatura/cliente
				PdfPCell faturaCell = new PdfPCell();
				faturaCell.Border = PdfPCell.NO_BORDER;
				faturaCell.AddElement(new Paragraph($"Data: {DateTime.Now}", bodyFont));
				faturaCell.AddElement(new Paragraph(" "));
				faturaCell.AddElement(new Paragraph($"Funcionário: {nomeFunci}", bodyFont));
				faturaCell.AddElement(new Paragraph($"Nome do Cliente: {nomeClient}", bodyFont));
				faturaCell.AddElement(new Paragraph($"NIF do Cliente: {nifCliente}", bodyFont));
				faturaCell.AddElement(new Paragraph(" "));

				// Célula para dados da empresa
				PdfPCell companyCell = new PdfPCell();
				companyCell.Border = PdfPCell.NO_BORDER;
				companyCell.HorizontalAlignment = Element.ALIGN_RIGHT;
				companyCell.AddElement(new Paragraph("ISPTEC Peças-Auto", bodyFont));
				companyCell.AddElement(new Paragraph("Talatona - Municipio de Belas", bodyFont));
				companyCell.AddElement(new Paragraph("Telefone: (+244) 949-276-083", bodyFont));
				companyCell.AddElement(new Paragraph("Email: isptecauto@isptec.com", bodyFont));

				mainTable.AddCell(faturaCell);
				mainTable.AddCell(companyCell);

				document.Add(mainTable);

				// Adicionar detalhes dos produtos
				document.Add(new Paragraph("Detalhes dos Produtos:", bodyFont));
				document.Add(new Paragraph(" "));
				PdfPTable table = new PdfPTable(5);
				table.AddCell("ID Produto");
				table.AddCell("Nome Produto");
				table.AddCell("Quantidade");
				table.AddCell("Preço Unitário");
				table.AddCell("IVA");

				foreach (Produto produto in produtos)
				{
					table.AddCell(produto.idProduto.ToString());
					table.AddCell(produto.nomProduto);
					table.AddCell(produto.qtdProduto.ToString());
					table.AddCell(produto.precoProd.ToString("0.00 Kz"));
					table.AddCell(produto.ivaProduto.ToString() + "%");
				}

				document.Add(table);

				document.Add(new Paragraph(" "));
				document.Add(new Paragraph($"Total da Venda: {totalVenda.ToString("0.00 Kz")}", bodyFont));
				document.Add(new Paragraph($"Desconto: {desconto.ToString("0.00 Kz")}", bodyFont));

				document.Close();
				registarVendaNaBD(nomeFunci, nomeClient, nifCliente, DateTime.Now, totalVenda);

				MessageBox.Show($"Fatura gerada com sucesso em: {filePath}");
				AtualizarQuantidadeProdutos(produtos);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao gerar fatura: " + ex.Message);
			}
		}

		private void registarVendaNaBD(string nomeFunc, string nomeClient, string nifClient, DateTime dataVenda, decimal totalVenda)
		{
			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();
					int funcionarioID = 0;
					string buscarFuncionarioQuery = "SELECT ID FROM FuncionarioCaixa WHERE LOWER(Nome) = LOWER(@nomeFunc)";
					using (SqlCommand buscarFuncionarioCmd = new SqlCommand(buscarFuncionarioQuery, conn))
					{
						buscarFuncionarioCmd.Parameters.AddWithValue("@nomeFunc", nomeFunc);
						object result = buscarFuncionarioCmd.ExecuteScalar();
						if (result != null)
						{
							funcionarioID = Convert.ToInt32(result);
						}
						else
						{
							MessageBox.Show($"Funcionário '{nomeFunc}' não encontrado.");
							return;
						}
					}

					string inserirVendaQuery = "INSERT INTO Vendas(FuncionarioID, NomeCliente, ClienteNIF, DataVenda, ValorTotal) " +
											   "VALUES (@funcionarioID, @nomeClient, @nifClient, @dataVenda, @totalVenda);";

					using (SqlCommand inserirVendaCmd = new SqlCommand(inserirVendaQuery, conn))
					{
						inserirVendaCmd.Parameters.AddWithValue("@funcionarioID", funcionarioID);
						inserirVendaCmd.Parameters.AddWithValue("@nomeClient", nomeClient);
						inserirVendaCmd.Parameters.AddWithValue("@nifClient", nifClient);
						inserirVendaCmd.Parameters.AddWithValue("@dataVenda", dataVenda);
						inserirVendaCmd.Parameters.AddWithValue("@totalVenda", totalVenda);

						inserirVendaCmd.ExecuteNonQuery();
					}

					string atualizarVendasQuery = "UPDATE FuncionarioCaixa SET NumeroVendas = NumeroVendas + 1 WHERE ID = @funcionarioID";
					using (SqlCommand atualizarVendasCmd = new SqlCommand(atualizarVendasQuery, conn))
					{
						atualizarVendasCmd.Parameters.AddWithValue("@funcionarioID", funcionarioID);
						atualizarVendasCmd.ExecuteNonQuery();
					}

					MessageBox.Show("Venda registrada com sucesso.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao registrar venda: " + ex.Message);
				}
			}
		}

		public void gerarFaturaProforma(List<Produto> produtos, string nomeClient, string nifCliente, decimal totalVenda, decimal desconto)
		{
			try
			{

				string directoryPath = @"C:\Users\Admin\Documents\ISPTEC - Universidade\ISPTEC- 3º ano - 2023-2024\2º Semestre\Engenharia de Software 2\SistemaDeFatura - estável\FaturasProforma";


				if (!Directory.Exists(directoryPath))
				{
					Directory.CreateDirectory(directoryPath);
				}


				string fileName = $"Fatura_{DateTime.Now.ToString("Proforma_" + "yyyyMMdd_HHmmss")}.pdf";
				string filePath = Path.Combine(directoryPath, fileName);


				Document document = new Document();
				PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));


				document.Open();

				var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
				var bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

				document.Add(new Paragraph("Fatura de Venda", titleFont));
				document.Add(new Paragraph(" "));

				// Tabela para dados da empresa e do cliente/fatura
				PdfPTable mainTable = new PdfPTable(2);
				mainTable.WidthPercentage = 100;
				mainTable.SetWidths(new float[] { 60, 40 }); // Definir largura relativa das colunas

				// Célula para dados da fatura/cliente
				PdfPCell faturaCell = new PdfPCell();
				faturaCell.Border = PdfPCell.NO_BORDER;
				faturaCell.AddElement(new Paragraph($"Data: {DateTime.Now}", bodyFont));
				faturaCell.AddElement(new Paragraph(" "));
				faturaCell.AddElement(new Paragraph($"Nome do Cliente: {nomeClient}", bodyFont));
				faturaCell.AddElement(new Paragraph($"NIF do Cliente: {nifCliente}", bodyFont));
				faturaCell.AddElement(new Paragraph(" "));

				// Célula para dados da empresa
				PdfPCell companyCell = new PdfPCell();
				companyCell.Border = PdfPCell.NO_BORDER;
				companyCell.HorizontalAlignment = Element.ALIGN_RIGHT;
				companyCell.AddElement(new Paragraph("ISPTEC Peças-Auto", bodyFont));
				companyCell.AddElement(new Paragraph("Talatona - Municipio de Belas", bodyFont));
				companyCell.AddElement(new Paragraph("Telefone: (+244) 949-276-083", bodyFont));
				companyCell.AddElement(new Paragraph("Email: isptecauto@isptec.com", bodyFont));

				mainTable.AddCell(faturaCell);
				mainTable.AddCell(companyCell);

				document.Add(mainTable);

				// Adicionar detalhes dos produtos
				document.Add(new Paragraph("Detalhes dos Produtos:", bodyFont));
				PdfPTable table = new PdfPTable(5);
				table.AddCell("ID Produto");
				table.AddCell("Nome Produto");
				table.AddCell("Quantidade");
				table.AddCell("Preço Unitário");
				table.AddCell("IVA");

				foreach (Produto produto in produtos)
				{
					table.AddCell(produto.idProduto.ToString());
					table.AddCell(produto.nomProduto);
					table.AddCell(produto.qtdProduto.ToString());
					table.AddCell(produto.precoProd.ToString("0.00 Kz"));
					table.AddCell(produto.ivaProduto.ToString() + "%");
				}

				document.Add(table);

				document.Add(new Paragraph(" "));
				document.Add(new Paragraph($"Total da Venda: {totalVenda.ToString("0.00 Kz")}", bodyFont));
				document.Add(new Paragraph($"Desconto: {desconto.ToString("0.00 Kz")}", bodyFont));

				document.Close();

				MessageBox.Show($"Proforma gerada com sucesso em: {filePath}");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao gerar Proforma: " + ex.Message);
			}
		}

		public void gerarFaturaPreview(List<Produto> produtos, string nomeFunci, string nomeClient, string nifCliente, decimal totalVenda, decimal desconto)
		{
			try
			{
				string directoryPath = Path.GetTempPath();

				string fileName = $"FaturaPreview_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.pdf";
				string filePath = Path.Combine(directoryPath, fileName);

				Document document = new Document();
				PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
				var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
				var bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

				document.Open();

				document.Add(new Paragraph("Pré-visualização da Fatura de Venda", titleFont));
				document.Add(new Paragraph(" "));

				// Tabela para dados da empresa e do cliente/fatura
				PdfPTable mainTable = new PdfPTable(2);
				mainTable.WidthPercentage = 100;
				mainTable.SetWidths(new float[] { 60, 40 }); // Definir largura relativa das colunas

				// Célula para dados da fatura/cliente
				PdfPCell faturaCell = new PdfPCell();
				faturaCell.Border = PdfPCell.NO_BORDER;
				faturaCell.AddElement(new Paragraph($"Data: {DateTime.Now}", bodyFont));
				faturaCell.AddElement(new Paragraph(" "));
				faturaCell.AddElement(new Paragraph($"Nome do Cliente: {nomeClient}", bodyFont));
				faturaCell.AddElement(new Paragraph($"NIF do Cliente: {nifCliente}", bodyFont));
				faturaCell.AddElement(new Paragraph(" "));

				// Célula para dados da empresa
				PdfPCell companyCell = new PdfPCell();
				companyCell.Border = PdfPCell.NO_BORDER;
				companyCell.HorizontalAlignment = Element.ALIGN_RIGHT;
				companyCell.AddElement(new Paragraph("ISPTEC Peças-Auto", bodyFont));
				companyCell.AddElement(new Paragraph("Talatona - Municipio de Belas", bodyFont));
				companyCell.AddElement(new Paragraph("Telefone: (+244) 949-276-083", bodyFont));
				companyCell.AddElement(new Paragraph("Email: isptecauto@isptec.com", bodyFont));

				mainTable.AddCell(faturaCell);
				mainTable.AddCell(companyCell);

				document.Add(mainTable);

				document.Add(new Paragraph("Detalhes dos Produtos:", bodyFont));
				document.Add(new Paragraph(" "));
				PdfPTable table = new PdfPTable(5);
				table.AddCell("ID Produto");
				table.AddCell("Nome Produto");
				table.AddCell("Quantidade");
				table.AddCell("Preço Unitário");
				table.AddCell("IVA");

				foreach (Produto produto in produtos)
				{
					table.AddCell(produto.idProduto.ToString());
					table.AddCell(produto.nomProduto);
					table.AddCell(produto.qtdProduto.ToString());
					table.AddCell(produto.precoProd.ToString("0.00 Kz"));
					table.AddCell(produto.ivaProduto.ToString() + "%");
				}

				document.Add(table);

				document.Add(new Paragraph(" "));
				document.Add(new Paragraph($"Total da Venda: {totalVenda.ToString("0.00 Kz")}", bodyFont));
				document.Add(new Paragraph($"Desconto: {desconto.ToString("0.00 Kz")}", bodyFont));

				document.Close();

				System.Diagnostics.Process.Start(filePath); 
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro ao gerar pré-visualização da fatura: " + ex.Message);
			}
		}

		private void AtualizarQuantidadeProdutos(List<Produto> produtosVendidos)
		{
			using (SqlConnection conn = new SqlConnection(connectionStringSQL))
			{
				try
				{
					conn.Open();

					foreach (Produto produto in produtosVendidos)
					{
						using (SqlCommand cmd = new SqlCommand("AtualizarQuantidadeProduto", conn))
						{
							cmd.CommandType = System.Data.CommandType.StoredProcedure;
							cmd.Parameters.AddWithValue("@quantidadeVendida", produto.qtdProduto);
							cmd.Parameters.AddWithValue("@produtoId", produto.idProduto);

							cmd.ExecuteNonQuery();
						}
					}

					MessageBox.Show("Quantidade dos produtos atualizada com sucesso.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro ao atualizar quantidade dos produtos: " + ex.Message);
				}
			}
		}

	}

}

