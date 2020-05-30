using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AulaPersistencia.Model; 

namespace AulaPersistencia
{
    public partial class frmAulaLINQ : Form
    {
        public frmAulaLINQ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Contexto contexto = new Model.Contexto();
            // dgvDados.DataSource = contexto.Produtos.ToList(); 

            // dgvDados.DataSource = contexto.Produtos.OrderByDescending(p => p.quantidade).ToList();

           // dgvDados.DataSource = contexto.Produtos.OrderBy(p => p.grupo).ThenByDescending(q => q.valor).ToList();
            
            List<Produto> lstProdutos = contexto.Produtos.OrderBy(p => p.grupo).ThenByDescending(q => q.valor).ToList();

            dgvDados.DataSource = lstProdutos; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            int idVenda = Convert.ToInt32(txtVendaID.Text);

            //List<Venda> lstVendas = contexto.Vendas.Where(v => v.id == idVenda).ToList();
            //dgvDados.DataSource = lstVendas;
            //dgvDados2.DataSource = contexto.ItensVendas.Where(i => i.vendaID == idVenda).ToList();

            //Venda venda = contexto.Vendas.Find(idVenda);
            //List<Venda> lstVendas = new List<Venda>();
            //lstVendas.Add(venda);
            //dgvDados.DataSource = lstVendas;

            //dgvDados2.DataSource = venda.itensVendas.ToList(); 


            var lstVendas = from venda in contexto.Vendas.ToList()
                            where venda.id == idVenda
                            orderby venda.data
                            select new
                            {
                                id = venda.id,
                                cliente = venda.cliente.nome,
                                data = venda.data
                            };
            dgvDados.DataSource = lstVendas.ToList();

            var lstItens = from item in contexto.ItensVendas.ToList()
                          where item.vendaID == idVenda
                          orderby item.produto.descricao
                          select new
                          {
                              id = item.id,
                              produto = item.produto.descricao,
                              quantidade = item.quantidade,
                              valor = item.valor,
                              total = item.quantidade * item.valor
                          };
            dgvDados2.DataSource = lstItens.ToList();

            label1.Text = lstItens.Sum(x => x.total).ToString(); 

        }
    }
}
