using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AstroCal.Models
{
    [Table("Blog")]
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Título")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public String Titulo { get; set; }
        [Display(Name = "Comentário")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public String Comentario { get; set; }
    }
}
