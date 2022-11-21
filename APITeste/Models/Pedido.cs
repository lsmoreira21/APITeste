using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APITeste.Models
{
    public class Pedido
    {
        [Key()]
        public int ID { get; set; }
        public int NumeroPedido { get; set; }
        public DateTime DataPedido { get; set; }

        [ForeignKey("Cliente")]
        public int CLienteID { get; set; }
    }
}
