using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AstroCal.Models
{
    [Table("Cards")]
    public class Cards
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o Nome da Ocorrência Astronômica!")]
        public String Nome { get; set; }
        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Obrigatório informar a Descrição da Ocorrência Astronômica!")]
        public String Descricao { get; set; }
        [Required(ErrorMessage = "Obrigatório informar a Data da Ocorrência Astronômica!")]
        public DateTime Data { get; set; }
        [Display(Name = "Localização")]
        [Required(ErrorMessage = "Obrigatório informar a Localização da Ocorrência Astronômica!")]
        public String Localizacao { get; set; }
        [Display(Name = "Palavras-Chave")]
        public String PalavrasChave { get; set; }
        [Display(Name = "Mais Informações")]
        public String MaisInformacoes { get; set; }
    }
}
