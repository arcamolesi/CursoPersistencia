using AulaPersistencia.Model;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaPersistencia
{
    public partial class frmPreencherTabelas : Form
    {
        public frmPreencherTabelas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            string[] vNomeMas = { "Miguel", "Arthur", "Bernardo", "Heitor", "Davi", "Lorenzo", "Théo", "Pedro", "Gabriel", "Enzo", "Matheus", "Lucas", "Benjamin", "Nicolas", "Guilherme", "Rafael", "Joaquim", "Samuel", "Enzo Gabriel", "João Miguel", "Henrique", "Gustavo", "Murilo", "Pedro Henrique", "Pietro", "Lucca", "Felipe", "João Pedro", "Isaac", "Benício", "Daniel", "Anthony", "Leonardo", "Davi Lucca", "Bryan", "Eduardo", "João Lucas", "Victor", "João", "Cauã", "Antônio", "Vicente", "Caleb", "Gael", "Bento", "Caio", "Emanuel", "Vinícius", "João Guilherme", "Davi Lucas", "Noah", "João Gabriel", "João Victor", "Luiz Miguel", "Francisco", "Kaique", "Otávio", "Augusto", "Levi", "Yuri", "Enrico", "Thiago", "Ian", "Victor Hugo", "Thomas", "Henry", "Luiz Felipe", "Ryan", "Arthur Miguel", "Davi Luiz", "Nathan", "Pedro Lucas", "Davi Miguel", "Raul", "Pedro Miguel", "Luiz Henrique", "Luan", "Erick", "Martin", "Bruno", "Rodrigo", "Luiz Gustavo", "Arthur Gabriel", "Breno", "Kauê", "Enzo Miguel", "Fernando", "Arthur Henrique", "Luiz Otávio", "Carlos Eduardo", "Tomás", "Lucas Gabriel", "André", "José", "Yago", "Danilo", "Anthony Gabriel", "Ruan", "Miguel Henrique", "Oliver" };
            string[] vNomeFem = { "Alice", "Sophia", "Helena", "Valentina", "Laura", "Isabella", "Manuela", "Júlia", "Heloísa", "Luiza", "Maria Luiza", "Lorena", "Lívia", "Giovanna", "Maria Eduarda", "Beatriz", "Maria Clara", "Cecília", "Eloá", "Lara", "Maria Júlia", "Isadora", "Mariana", "Emanuelly", "Ana Júlia", "Ana Luiza", "Ana Clara", "Melissa", "Yasmin", "Maria Alice", "Isabelly", "Lavínia", "Esther", "Sarah", "Elisa", "Antonella", "Rafaela", "Maria Cecília", "Liz", "Marina", "Nicole", "Maitê", "Isis", "Alícia", "Luna", "Rebeca", "Agatha", "Letícia", "Maria-", "Gabriela", "Ana Laura", "Catarina", "Clara", "Ana Beatriz", "Vitória", "Olívia", "Maria Fernanda", "Emilly", "Maria Valentina", "Milena", "Maria Helena", "Bianca", "Larissa", "Mirella", "Maria Flor", "Allana", "Ana Sophia", "Clarice", "Pietra", "Maria Vitória", "Maya", "Laís", "Ayla", "Ana Lívia", "Eduarda", "Mariah", "Stella", "Ana", "Gabrielly", "Sophie", "Carolina", "Maria Laura", "Maria Heloísa", "Maria Sophia", "Fernanda", "Malu", "Analu", "Amanda", "Aurora", "Maria Isis", "Louise", "Heloise", "Ana Vitória", "Ana Cecília", "Ana Liz", "Joana", "Luana", "Antônia", "Isabel", "Bruna" };
            Model.Contexto contexto = new Model.Contexto();

            for (int i=0; i<200; i++)
            {
                Model.Cliente cliente = new Model.Cliente();
                cliente.id = -1;
                cliente.nome = (i % 2 == 0) ? vNomeMas[i/2] : vNomeFem[i/2];
                cliente.telefone = randNum.Next().ToString();
                DateTime data = Convert.ToDateTime("01/01/1920");
                cliente.aniversario = data.AddDays(randNum.Next(1,30000));

                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();
            }
            MessageBox.Show("Clientes gerados com sucesso...");
            
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            Model.Contexto contexto = new Contexto();

            FileStream stream = File.Open("Benny.xlsx", FileMode.Open, FileAccess.Read);
            
            var reader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            pBarProdutos.Maximum = reader.RowCount; 
           
            int cont = 0;
            try
            {
                reader.Read();

                while (reader.Read())
                {
                    Model.Produto produto = new Model.Produto();
                    produto.id = -1;
                    produto.descricao = reader[0].ToString();
                    produto.quantidade = (randNum.Next()%200)+1;
                    produto.valor = Convert.ToSingle(reader[1].ToString());
                    contexto.Produtos.Add(produto);
                    cont++;
                    contexto.SaveChanges();
                    cont++;
                    //label1.Text = cont.ToString(); 
                    pBarProdutos.Value++; 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao acessar dados de planilha" +ex.Message);
            }
            finally
            {
                MessageBox.Show("Importado com Sucesso!!!"); 
            }
        }

        private void frmPreencherTabelas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            Contexto contexto = new Contexto();
            int qtItens=0;
            int idVenda; 
            for (int i=1; i <= 1000; i++)
            {
                Model.Venda venda = new Venda();
                venda.id = -1;
                venda.clienteID = (randNum.Next()%200) + 1;
                venda.data = Convert.ToDateTime("01/01/2010").AddDays(randNum.Next() % 3800);
                contexto.Vendas.Add(venda);
                contexto.SaveChanges();
                Model.Venda ven = contexto.Vendas.OrderByDescending(p=>p.id).FirstOrDefault();
                idVenda = ven.id;
                qtItens = (randNum.Next() % 10) + 1;
                for (int j=0; j<qtItens; j++)
                {

                    Model.ItemVenda item = new ItemVenda();
                    item.id = -1;
                    item.vendaID = idVenda;
                    item.produtoID = (randNum.Next() % 11951) + 1;
                    Model.Produto produto = contexto.Produtos.Find(item.produtoID);
                    item.valor = produto.valor;
                    item.quantidade = (randNum.Next() % 10) + 1;
                    contexto.ItensVendas.Add(item);
                    contexto.SaveChanges(); 
                }
            }
        }
    }
}
