using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPersistencia.Model
{
    [Table("Vendas")]
    public class Venda
    {
        public Venda()
        {
            this.itensVendas = new HashSet<ItemVenda>(); 
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int clienteID { get; set; }
        public virtual Cliente cliente { get; set; }

        public DateTime data { get; set; }

        public ICollection<ItemVenda> itensVendas { get; set; }
    }
}
