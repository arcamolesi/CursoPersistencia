using AulaPersistencia.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaPersistencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Cliente cliente = new Cliente();

            //popular objeto
            cliente.id = -1;
            cliente.nome = txtNome.Text;
            cliente.aniversario = Convert.ToDateTime(txtAniversario.Text); 
            cliente.telefone = txtTelefone.Text;

            contexto.Clientes.Add(cliente);
            contexto.SaveChanges();

            dataGridView1.DataSource = "";
            dataGridView1.DataSource = contexto.Clientes.ToList(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = contexto.Clientes.ToList(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Cliente cliente = contexto.Clientes.Find(Convert.ToInt32(txtID.Text)); 

            //popular objeto
          //  cliente.id =  Convert.ToInt32(txtID.Text);
            cliente.nome = txtNome.Text;
            cliente.aniversario = Convert.ToDateTime(txtAniversario.Text);
            cliente.telefone = txtTelefone.Text;

            contexto.Entry(cliente).State = EntityState.Modified;
            contexto.SaveChanges();

            dataGridView1.DataSource = "";
            dataGridView1.DataSource = contexto.Clientes.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Cliente cliente = contexto.Clientes.Find(Convert.ToInt32(txtID.Text));

            contexto.Clientes.Remove(cliente);
            contexto.SaveChanges();

            dataGridView1.DataSource = "";
            dataGridView1.DataSource = contexto.Clientes.ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime data = Convert.ToDateTime (DateTime.Now.ToString());
            MessageBox.Show(DateTime.Now.ToString());
            DateTime dataini = Convert.ToDateTime("15-05-2020");
            MessageBox.Show(dataini.ToLongTimeString());
            long dif = data.Second - dataini.Second;
            MessageBox.Show(dif.ToString()); 
        }
    }
}
