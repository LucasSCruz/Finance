using System.ComponentModel.DataAnnotations;

namespace WebFinance.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        [Required]
        public string Nome { get; set; }

    }
}
