using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? Name { get; set; }

        [NotMapped]
        public int Edad { get; set; }

        public string? Email { get; set; }

        [ForeignKey("DetalleUsuario")]
        public int DetalleUsuarioId { get; set; }

        public DetalleUsuario? DetalleUsuario { get; set; }
    }
}
