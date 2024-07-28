using System.ComponentModel.DataAnnotations;

namespace SistemaVendas.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime UltimaCompra { get; set; }
        public float Estoque { get; set; }
    }
}
