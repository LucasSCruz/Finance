using System.ComponentModel.DataAnnotations;

namespace WebFinance.Models
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }
        [Required(ErrorMessage = "Necessário inserir o nome")]
        public string Nome { get; set; }

    }
}
