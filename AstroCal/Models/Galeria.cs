using System;
using System.ComponentModel.DataAnnotations;

namespace AstroCal.Models
{
    public class Galeria
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public String Titulo { get; set; }
        public String Foto { get; set; }
    }
}
