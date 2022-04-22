using System.ComponentModel.DataAnnotations;

namespace WebFinance.Models
{
    public class Conta
    {
        [Key]
        public int IdConta { get; set; }
        [Required(ErrorMessage = "Necessário inserir um nome a conta")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Necessário inserir um tipo a conta")]
        public int Tipo { get; set; }
    }
}
