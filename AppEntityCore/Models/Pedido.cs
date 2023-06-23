using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppEntityCore.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "datatime")]
        public DateTime FechaPedido { get; set; }

        [Column(TypeName = "data")]
        public DateTime FechaEntrega { get; set; }

        [Column(TypeName = "time")]
        public DateTime Fecha { get; set; }


    }
}
