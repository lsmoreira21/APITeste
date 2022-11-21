using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APITeste.Models
{
    public class ItemPedido
    {
        [Key()]        
        public int Id { get; set; }
        public string Nome { get; set; }

        [ForeignKey("Pedido")]
        public int PedidoID { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

    }
}
