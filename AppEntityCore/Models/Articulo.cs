using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
#nullable disable
    public class Articulo
    {
        [Key]
        public int IdArticulo { get; set; }  
        public string TituloArticulo { get; set; }
            
        public string Descripcion { get; set; }

        public DateTime fecha { get; set; }

        [ForeignKey("Catergoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        public ICollection<ArticuloEtiqueta> ArticuloEtiquetas { get; set; } // relacion muchos a muchos 
    }
}
