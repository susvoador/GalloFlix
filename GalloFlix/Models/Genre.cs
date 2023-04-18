using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;

[Table("genre")]
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
    
        [Display(Name = "Nome" )]
        [Required(ErrorMessage = "O Nome é obrigatório")]
        [StringLength(30, ErrorMessage = " O Campo deve ter no máximo 30 caractéres", MinimumLength = 5)]
        public string Name { get; set; }
    }
