using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPersistencia.Model
{
    public class Contexto : DbContext
    {
        public Contexto() : base("Curso2020") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ItemVenda> ItensVendas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Venda>()
                .HasRequired<Cliente>(c => c.cliente)
                .WithMany(c => c.vendas)
                .HasForeignKey(c => c.clienteID);

            modelBuilder.Entity<ItemVenda>()
                .HasRequired<Produto>(p => p.produto)
                .WithMany(p => p.itensVendas)
                .HasForeignKey(p => p.produtoID);

            modelBuilder.Entity<ItemVenda>()
                .HasRequired<Venda>(v => v.venda)
                .WithMany(v => v.itensVendas)
                .HasForeignKey(v => v.vendaID); 
        }

    }
}
