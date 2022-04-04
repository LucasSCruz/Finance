using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebFinance.Models
{
    public class Financa
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        [ForeignKey("Conta")]
        public Conta? IdConta { get; set; }
        public string? TipoMovimentacao { get; set; }
        [Required]
        public int Valor { get; set; }
        public DateTime DataCompra { get; set; }
        [Required]
        [ForeignKey("Pessoa")]
        public Pessoa? idPessoa { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
