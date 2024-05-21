using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Marcacao")]
    public class Marcacao
    {
    
        public int Marcacoesid { get; set; }
        public DateTime DataTime { get; set; }
        public TimeSpan Hora { get; set; }


        //[ForeignKey("ProfissionalId")]
        //public virtual Profissional Profissional { get; set; }
    }
}
