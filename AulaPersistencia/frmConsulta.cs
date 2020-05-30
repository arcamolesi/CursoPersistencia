using AulaPersistencia.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaPersistencia
{
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void btnGrupoAno_Click(object sender, EventArgs e)
        {
            Model.Contexto contexto = new Model.Contexto();
            var consulta = from venda in contexto.Vendas.ToList()
                           group venda by new { venda.data.Year, venda.data.Month } into g
                           orderby g.Key.Year, g.Key.Month
                           select new
                           {
                               ano = g.Key.Year,
                               mes = g.Key.Month,
                               qtdVendas = g.Count()
                           };
            dgvConsulta.DataSource = consulta.ToList();
        }

        public class Example
        {
            public int ano { get; set; }
            public int jan { get; set; }
            public int fev { get; set; }
            public int mar { get; set; }
            public int abr { get; set; }
            public int mai { get; set; }
            public int jun { get; set; }
            public int jul { get; set; }
            public int ago { get; set; }
            public int set { get; set; }
            public int oct { get; set; }
            public int nov { get; set; }
            public int dez { get; set; }
        }

        private void btnPivot_Click(object sender, EventArgs e)
        {
            Model.Contexto contexto = new Model.Contexto();
            var consulta = from venda in contexto.Vendas.ToList()
                           group venda by new { venda.data.Year, venda.data.Month } into g
                           orderby g.Key.Year, g.Key.Month
                           select new
                           {
                               ano = g.Key.Year,
                               mes = g.Key.Month,
                               qtdVendas = g.Count()
                           };



            var pivotTable = consulta.ToList().ToPivotTable(
                item => item.mes,  //coluna do pivot
                item => item.ano, //linha do pivot
                items => items.Any() ? items.Sum(x => x.qtdVendas) : 0); //valor do pivot

            dgvConsulta.DataSource = pivotTable;
        }


        private void frmConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnPivotArray_Click(object sender, EventArgs e)
        {

            Model.Contexto contexto = new Model.Contexto();
            var consulta = from venda in contexto.Vendas.ToList()
                           group venda by new { venda.data.Year, venda.data.Month } into g
                           orderby g.Key.Year, g.Key.Month
                           select new
                           {
                               ano = g.Key.Year,
                               mes = g.Key.Month,
                               qtdVendas = g.Count()
                           };

            string[] vMes = new string[13] { "", "jan", "fev", "mar", "abr", "mai", "jun", "jul", "ago", "set", "oct", "nov", "dez" };

            string folder = @"c:\Relatorios";
            string arquivo = @"C:\Relatorios\" + "pivot.xlsx";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (File.Exists(arquivo))
            {
                File.Delete(arquivo);
            }

            FileInfo caminhoNomeArquivo = new FileInfo(arquivo);
            ExcelPackage arquivoExcel = new ExcelPackage(caminhoNomeArquivo);
            ExcelWorksheet planilha = arquivoExcel.Workbook.Worksheets.Add("Plan1");
            int col = 1;
            int lin = 1;

         
            planilha.Cells[lin, col].Value = "ANO";
            for (int i = 1; i <= 12; i++)
            {
                planilha.Cells[lin, ++col].Value = vMes[i];
            }

            for (int ano = 2010; ano <= 2020; ano++)
            {
                             
                planilha.Cells[++lin, col=1].Value = ano;
                for (int mes = 1; mes <= 12; mes++)
                {
                    var dados = consulta.Where(c => c.ano == ano && c.mes == mes).ToList();
                    planilha.Cells[lin, ++col].Value = (dados.Count()==0)?0 : dados[0].qtdVendas;
                }

            }
            arquivoExcel.Save();
            arquivoExcel.Dispose();

            System.Diagnostics.Process.Start(arquivo);
        }

        private void btnHtml_Click(object sender, EventArgs e)
        {
            Model.Contexto contexto = new Model.Contexto();
            var consulta = from itens in contexto.ItensVendas.ToList()
                           group itens by new { itens.venda.data.Year, itens.produto.grupo } into g
                           orderby g.Key.Year, g.Key.grupo
                           select new
                           {
                               ano = g.Key.Year,
                               grupo = g.Key.grupo,
                               qtdVendas = g.Count(),
                               qtdProdutos = g.Sum(t => t.quantidade),
                               total = g.Sum(x => x.total)
                           };

            string folder = @"c:\Relatorios";
            string arquivo = @"C:\Relatorios\" + "Grupo.HTML";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if (File.Exists(arquivo))
            {
                File.Delete(arquivo);
            }

            StreamWriter sw = new StreamWriter(arquivo);

            using (sw)
            {
                sw.WriteLine("<html>");
                sw.WriteLine("<head>");
                sw.WriteLine("<meta http-equiv='Content-Type' " +
                             "content='text/html; charset=utf-8'/>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");

                sw.WriteLine("</head>");
                sw.WriteLine("<body>");
                sw.WriteLine("<h1>Relatório de Grupo de Produtos</h1>");
                sw.WriteLine("<hr align='left' border:'5px' />");
                sw.WriteLine("<table class='table table-hover'> ");
                sw.WriteLine("<tr class='thead-dark'>");
                sw.WriteLine("<th align='right' width='30px'>ID</th>");
                sw.WriteLine("<th align='left'  width='30px'>GRUPO</th>");
                sw.WriteLine("<th align='left' width='90px'>QTD VENDAS</th>");
                sw.WriteLine("<th align='left' width='90px'>QTD PRODUTOS</th>");
                sw.WriteLine("<th align='left' width='100px'>Total</th>");
                sw.WriteLine("</tr>");

                int cont = 0;
                float somaGeral = 0;
                float somaGrupo = 0;
                int anoAnt = 0;
                foreach (var item in consulta.ToList())
                {
                    if (cont == 0)
                        anoAnt = item.ano;
                    else
                    {
                        if (anoAnt != item.ano)
                        {
                            sw.WriteLine("<tr class='table-danger'>");
                            sw.WriteLine("<td align='right' width='200px'>Total do ano  " + anoAnt.ToString() + ": " + string.Format("{0:C2}", somaGrupo) + "</td>");
                            sw.WriteLine("</tr>");
                            anoAnt = item.ano;
                            somaGrupo = 0; 
                        }
                    }
                    if (cont % 2 == 0)
                        sw.WriteLine("<tr class='table-primary'>");
                    else sw.WriteLine("<tr class='table-info'>");
                    sw.WriteLine("<td align='right' width='30px'>" + item.ano + "</td>");
                    sw.WriteLine("<td align='left' width='30px'>" + item.grupo + "</td>");
                    sw.WriteLine("<td align='left' width='90px'>" + string.Format("{0:#.#,0}", item.qtdVendas) + "</td>");
                    sw.WriteLine("<td align='left' width='90px'>" + string.Format("{0:#.#,0}", item.qtdProdutos) + "</td>");
                    sw.WriteLine("<td align='left' width='100px'>" + string.Format("{0:C2}", item.total) + "</td>");
                    somaGrupo = somaGrupo + item.total; 
                    somaGeral = somaGeral + item.total;

                    sw.WriteLine("</tr>");
                    cont++;
                }
                sw.WriteLine("<tr class='table-danger'>");
                sw.WriteLine("<td align='right' width='200px'>Total do ano  " + anoAnt.ToString() + ": " + string.Format("{0:C2}", somaGrupo) + "</td>");
                sw.WriteLine("</tr>");
                sw.WriteLine("</table>");
                
                sw.WriteLine("<hr align='left' border:'5px' />");
     
                sw.WriteLine("<BR/><h2 width='440px'>Total Geral: " + string.Format("{0:C2}", somaGeral) + "</h2>");
                sw.WriteLine("<BR/><h2>Total de Registros impressos: " + cont + "</h2>");
                sw.WriteLine("</body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }

        private void btnFiltraGrupo_Click(object sender, EventArgs e)
        {
            Func<ItemVenda, bool> predicado = x => x.produto.grupo.Contains(txtGrupo.Text.Trim());
            Relatorios.RelITens(predicado);
        }

        private void btnFiltraProduto_Click(object sender, EventArgs e)
        {
            Func<ItemVenda, bool> predicado = x => x.produtoID == Convert.ToInt32(txtProdutoID.Text);
            Relatorios.RelITens(predicado);
        }

        private void btnFiltraPeriodo_Click(object sender, EventArgs e)
        {
            Func<ItemVenda, bool> predicado = x => x.venda.data>=dtpInicio.Value && x.venda.data<=dtpFim.Value;
            Relatorios.RelITens(predicado);
        }

        private void txtGrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Func<ItemVenda, bool> predicado = x => x.produto.descricao.Contains(txtDescricao.Text);
            Relatorios.RelITens(predicado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            dgvConsulta.DataSource = contexto.ItensVendas.Where(i => i.venda.data.Year == 2016 && i.produto.grupo.Contains("VAN")).ToList(); 
        }
    }
}
