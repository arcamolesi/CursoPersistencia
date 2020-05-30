using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaPersistencia.Model
{
    [Table("Produtos")]
    public class Produto
    {
        public Produto()
        {
            this.itensVendas = new HashSet<ItemVenda>(); 
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(50)]
        [Required]
        public string descricao { get; set; }
        
        public float quantidade { get; set; }
        public float valor { get; set; }
        [StringLength(3)]
        public string grupo { get; set; }

        public virtual float total { get { return quantidade * valor; } }

        public virtual ICollection<ItemVenda> itensVendas { get; set; }

    }
}
