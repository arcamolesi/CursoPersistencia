using AulaPersistencia.Model;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AulaPersistencia
{
    public static class Relatorios
    {
        public static void RelITens(Func<ItemVenda, bool> predicado)
        {
            Contexto contexto = new Contexto();
            List<ItemVenda> lista = new List<ItemVenda>();
            lista = contexto.ItensVendas.OrderBy(i=>i.venda.data).Where(predicado).ToList(); 

            string folder = @"c:\Relatorios";
            string arquivo = @"C:\Relatorios\" + "Filtro_"+  DateTime.Now.Millisecond.ToString() + ".xlsx";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            FileInfo caminhoNomeArquivo = new FileInfo(arquivo);
            ExcelPackage arquivoExcel = new ExcelPackage(caminhoNomeArquivo);
            ExcelWorksheet planilha = arquivoExcel.Workbook.Worksheets.Add("Plan1");
            int col = 1;
            int lin = 1;

            planilha.Cells["A1:F1"].Style.Font.Size = 13;
            planilha.Cells["A1:F1"].Style.Font.Name = "Calibri";
            planilha.Cells["A1:F1"].Style.Font.Bold = true;
            planilha.Cells["A1:F1"].Style.Font.Color.SetColor(Color.Blue);

            planilha.Cells[lin, col].Value = "ID ITEM";
            planilha.Cells[lin, ++col].Value = "DATA";
            planilha.Cells[lin, ++col].Value = "PRODUTO";
            planilha.Cells[lin, ++col].Value = "QUANTIDADE";
            planilha.Cells[lin, ++col].Value = "VALOR";
            planilha.Cells[lin, ++col].Value = "TOTAL";

            float soma=0;
            float total;
            foreach (var item in lista)
            {
                col = 1; 
                planilha.Cells[++lin, col].Value = item.vendaID;

                planilha.Cells[lin, ++col].Style.Numberformat.Format = "dd-mm-yyyy";
                planilha.Cells[lin, col].Value = item.venda.data;

                planilha.Cells[lin, ++col].Value = item.produto.descricao;
                planilha.Cells[lin, ++col].Value = item.quantidade;

                planilha.Cells[lin, ++col].Style.Numberformat.Format = "#,##0.00";
                planilha.Cells[lin, col].Value = item.valor;
                total = item.quantidade * item.valor;
                planilha.Cells[lin, ++col].Style.Numberformat.Format = "#,##0.00";
                planilha.Cells[lin, col].Value = total; 

                soma+=total;
            }
            planilha.Cells[++lin, 5].Value = "Geral: ";
            planilha.Cells[lin, 6].Style.Numberformat.Format = "#,##0.00";
            planilha.Cells[lin, 6].Value = soma;

            planilha.Cells[planilha.Dimension.Address].AutoFitColumns();

            planilha.Cells[++lin, 1].Value = "Gerado em " + DateTime.Now.ToString();



            arquivoExcel.Save();
            arquivoExcel.Dispose();

            System.Diagnostics.Process.Start(arquivo);

        }
    }
}
