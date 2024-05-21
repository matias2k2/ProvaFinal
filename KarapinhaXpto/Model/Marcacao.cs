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
        [Key]
        public int Marcacoesid { get; set; }
        public DateTime DataTime { get; set; }
        public TimeSpan Hora { get; set; }
        public int ProfissionalId { get; set; }
        public int ServicoId { get; set; }
        public int CategoriaId { get; set; }

        public int UsuarioId { get; set; }

        public virtual Profissional Profissional { get; set; }
       
        [ForeignKey("ServicoId")]
        public virtual Servico Servicos { get; set; }

        [ForeignKey("CategoriaId")]
        public virtual Categoria Categorias { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario Usuarios { get; set; }
    }
}
