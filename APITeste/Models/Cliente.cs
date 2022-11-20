using System.ComponentModel.DataAnnotations;

namespace APITeste.Models
{
    public class Cliente
    {
        [Key]        
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
