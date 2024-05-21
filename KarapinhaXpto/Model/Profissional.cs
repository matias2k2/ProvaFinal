using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Profissional")]
    public class Profissional
    {

        [Key]
        public int proficionaisId { get; set; }
        [Required]
        [StringLength(80)]
        public String nomeProficional { get; set; }
        [Required]
        [StringLength(80)]
        public String especialidade { get; set; }
        public virtual ICollection<Marcacao> Marcacoes { get; set; }
    }
}
