using System.ComponentModel.DataAnnotations;

namespace WebFinance.Models
{
    public class Conta
    {
        [Key]
        public int IdConta { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Tipo { get; set; }
    }
}
