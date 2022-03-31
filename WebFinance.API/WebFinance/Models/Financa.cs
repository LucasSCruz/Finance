using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebFinance.Models
{
    public class Financa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Conta { get; set; }
        [Required]
        public string TipoMovimentacao { get; set; }
        [Required]
        public int Valor { get; set; }
        [Required]
        public DateTime DataCompra { get; set; }
        [Required]
        [ForeignKey("id")]
        public int idPessoa { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
