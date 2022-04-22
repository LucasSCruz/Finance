using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebFinance.Models
{
    public class Financa
    {
        [Key]
        public int Id { get; set; } 
        [Required(ErrorMessage = "Necessário inserir o tipo de conta")]
        [ForeignKey("Conta")]
        public Conta? IdConta { get; set; }
        public string? TipoMovimentacao { get; set; }
        [Required(ErrorMessage = "Necessário inserir o valor da transação")]
        public int Valor { get; set; }
        public DateTime DataCompra { get; set; }
        [Required(ErrorMessage = "Necessário especificar a pessoa da transação")]
        [ForeignKey("Pessoa")]
        public Pessoa? idPessoa { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
