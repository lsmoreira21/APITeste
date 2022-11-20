using System.ComponentModel.DataAnnotations;

namespace APITeste.Models
{
    public class Pedido
    {
        [Key]
        public int ID { get; set; }
        public int NumeroPedido { get; set; }
        public DateTime DataPedido { get; set; }    
        public List<ItemPedido> Items { get; set; }
    }
}
