using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_projeto_astrocal.Models
{
    [Table("Eventos")]
    public class Evento
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string NomeEvento { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public int Ano { get; set; }
    }
}
