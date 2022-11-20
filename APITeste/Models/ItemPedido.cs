using System.ComponentModel.DataAnnotations;

namespace APITeste.Models
{
    public class ItemPedido
    {
        [Key]        
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
