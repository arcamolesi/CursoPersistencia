using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace AulaPersistencia.Model
{
    [Table("Clientes")]
    public class Cliente
    {
        public Cliente()
        {
            this.vendas = new HashSet<Venda>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [StringLength(35)]
        [Required]
        public string nome { get; set; }

        public DateTime aniversario { get; set; }

        [StringLength(14)]
        public string telefone { get; set; }

        public virtual ICollection<Venda> vendas { get; set; }
    }
}
