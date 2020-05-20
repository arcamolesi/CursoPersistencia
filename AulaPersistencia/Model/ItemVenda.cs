using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPersistencia.Model
{
    [Table("ItensVendas")]
    public class ItemVenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int vendaID { get; set; }
        public virtual Venda venda { get; set; }

        public int produtoID { get; set; }
        public virtual Produto produto { get; set; }

        public float quantidade { get; set; }

        public float valor { get; set; }

        public virtual float total { get { return quantidade * valor; } }

    }
}
