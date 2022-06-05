using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AstroCal.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [Required(ErrorMessage = "Obrigatório Informar o Usuário!")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o Email!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar a Senha!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório Informar o CEP!")]
        public int CEP { get; set; }
        public Perfil Perfil { get; set; }

    }

    public enum Perfil
    {
        Admin,
        User
    }
}
