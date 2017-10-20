using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBase
{
    public class Film
    {
        public long FilmId { set; get; }
        public string FilmName { set; get; }
        public long PhotoId { set; get; }
        public long FilmYear { set; get; }
        public long DirectorId { set; get; }
        public long GenreId { set; get; }
        public decimal Rating { set; get; }
        public string Description { set; get; } 

        public Film() { }

        public Film(long filmId,
                    string filmName,
                    long photoId,
                    long filmYear,
                    long directorId,
                    long genreId,
                    decimal rating,
                    string description)
        {
            FilmId = filmId;
            FilmName = filmName;
            PhotoId = photoId;
            FilmYear = filmYear;
            DirectorId = directorId;
            GenreId = genreId;
            Rating = rating;
            Description = description;
        }

    }
}
