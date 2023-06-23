using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    public class ArticuloEtiqueta
    {
        [ForeignKey("Articulos")]
        public int ArticuloId { get; set; }

        [ForeignKey("Etiqueta")]
        public int EtiquetaId { get;}

        public Articulo? Articulo { get; set; }

        public Etiqueta? Etiqueta { get; set; }
    }
}
