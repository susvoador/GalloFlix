using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;

    [Table("Movie")]
    public class movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "O Título é Obrigatório")]
        [StringLength(100, ErrorMessage = "O Título deve possuir no máximo 100 caractéres"), ]
        public String Title { get; set; }

        [Display(Name = "Título Original")]
        [Required(ErrorMessage = "O Título Original é Obrigatório")]
        [StringLength(100, ErrorMessage = "O Título Original deve possuir no máximo 100 caractéres"), ]
        public String TitleOriginal { get; set; }

        [Display(Name = "Sinopse")]
        [Required(ErrorMessage = "A Sinopse é Obrigatório")]
        [StringLength(8000, ErrorMessage = "A sinopse deve possuir no máximo 8000 caractéres"), ]
        public String Sinopse { get; set; }

        [Column(TypeName = "Year")]
        [Display(Name = "Ano de Estreia")]
        [Required(ErrorMessage ="O Ano de Estreia é Obrigatório")]
        public Int16 MovieYear {get; set; }

        [Display(Name = "Duração (em minutos)")]
        [Required(ErrorMessage = "A Duração é obrigatória")]
        public Int16 Duration { get; set; }

        [Display(Name = "classificação Etária")]
        [Required(ErrorMessage = "A Classificação Etária é obrigatória")]
        public byte Agerating { get; set; }

        [StringLength(200)]
        [Display(Name = "Foto")]

        public string Image { get; set;} 

        [NotMapped]
        [Display(Name = "Duração")]
        public string HourDuration { get {
             return TimeSpan.FromMinutes(Duration)
                 .ToString(@"%h'h 'mm'min'");

    }}}
