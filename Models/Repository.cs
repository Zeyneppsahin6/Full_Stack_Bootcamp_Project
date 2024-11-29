using proje.Models;
using System.Collections.Generic;
using System.Linq;

namespace proje
{
    public static class Repository
    {
        private static List<Film> _filmler = new List<Film>
        {
            new Film { Id = 1, Ad = "Toy Story", Aciklama = "Bir oyuncak hikayesi.", PosterUrl = "/img/oyuncakHikayesi.jpg", Kategori = "Animasyon" },
            new Film { Id = 2, Ad = "Frozen", Aciklama = "Karlar Ülkesi.", PosterUrl = "/img/karlarUlkesi.jpg", Kategori = "Animasyon" },
            new Film { Id = 3, Ad = "Coco", Aciklama = "Müzik ve aile.", PosterUrl = "/img/coco.jpeg", Kategori = "Animasyon" },

            new Film { Id = 4, Ad = "Inception", Aciklama = "Rüya içinde rüya.", PosterUrl = "/img/inception.jpg", Kategori = "Bilim Kurgu" },
            new Film { Id = 5, Ad = "The Matrix", Aciklama = "Gerçek nedir?", PosterUrl = "/img/theMatrix.jpg", Kategori = "Bilim Kurgu" },
            new Film { Id = 6, Ad = "Interstellar", Aciklama = "Uzay macerası.", PosterUrl = "/img/interstellar.jpg", Kategori = "Bilim Kurgu" },

            new Film { Id = 7, Ad = "The Shawshank Redemption", Aciklama = "Umudun gücü.", PosterUrl = "/img/theShawshankRedemption.jpg", Kategori = "Dram" },
            new Film { Id = 8, Ad = "Forrest Gump", Aciklama = "Hayat bir kutu çikolata gibidir.", PosterUrl = "/img/forrestGump.jpg", Kategori = "Dram" },
            new Film { Id = 9, Ad = "The Godfather", Aciklama = "Mafya dünyası.", PosterUrl = "/img/theGodfather.jpg", Kategori = "Dram" },

            new Film { Id = 10, Ad = "Hababam Sınıfı", Aciklama = "Lise komedisi.", PosterUrl = "/img/hababamSinifi.jpg", Kategori = "Komedi" },
            new Film { Id = 11, Ad = "G.O.R.A", Aciklama = "Bilim kurgu komedisi.", PosterUrl = "/img/gora.jpg", Kategori = "Komedi" },
            new Film { Id = 12, Ad = "Step Brothers", Aciklama = "Üvey kardeşler.", PosterUrl = "/img/stepBrothers.jpg", Kategori = "Komedi" },

            new Film { Id = 13, Ad = "Indiana Jones", Aciklama = "Antik maceralar.", PosterUrl = "/img/indianaJones.jpg", Kategori = "Macera" },
            new Film { Id = 14, Ad = "The Lord of the Rings", Aciklama = "Yüzüklerin Efendisi.", PosterUrl = "/img/theLordOfTheRings.jpg", Kategori = "Macera" },
            new Film { Id = 15, Ad = "Pirates of the Caribbean", Aciklama = "Korsanların maceraları.", PosterUrl = "/img/piratesOfTheCaribbean.jpg", Kategori = "Macera" }
        };

        public static List<Film> Filmler => _filmler;

        public static List<Film> GetByCategory(string kategori) =>
            _filmler.Where(f => f.Kategori == kategori).ToList();
    }
}
