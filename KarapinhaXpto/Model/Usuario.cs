using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuariosId { get; set; }
        [Required]
        [StringLength(80)]
        public String NomeCompleto { get; set; }
        [Required]
        [StringLength(80)]
        public String Telefone { get; set; }
        [Required]
        [StringLength(80)]
        public String Imagem { get; set; }
        [Required]
        [StringLength(80)]
        public String Email { get; set; }
        [Required]
        [StringLength(80)]
        public String Bilhete { get; set; }
        [Required]
        [StringLength(80)]
        public String Username { get; set; }
        public Usuario()
        {

        }
    }
}
