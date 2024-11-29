using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace proje.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Film Adı")]
        public string? Ad { get; set; }

        [DisplayName("Film Açıklaması")]
        public string? Aciklama { get; set; }

        [DisplayName("Film Poster URL'si")]
        public string? PosterUrl { get; set; }

        [DisplayName("Film Kategorisi")]
        [Required]
        public string? Kategori { get; set; }
    }
}

