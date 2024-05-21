using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Servicos")]
    public class Servico
    {
        [Key]
        public int servicoid { get; set; }
        [Required]
        [StringLength(80)]
        public String nomeServico { get; set; }
        [Required]
        [StringLength(80)]
        public String decricao { get; set; }
        public float valor { get; set; }

        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<Marcacao> Marcacoes { get; set; }

    }
}
