using System.ComponentModel.DataAnnotations;

namespace AppEntityCore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Nombre { get; set; }
        public ICollection <Producto>? productos { get; set; }

    }
}
