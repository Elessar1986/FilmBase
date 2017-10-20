using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBase
{
    class FilmsViewData
    {
         public long FilmId { set; get; }
        public string FilmName { set; get; }
        public long PhotoId { set; get; }
        public long FilmYear { set; get; }
        public string Director { set; get; }
        public string Genre { set; get; }
        public decimal Rating { set; get; }
        public string Description { set; get; } 

        public FilmsViewData() { }

        public FilmsViewData(long filmId,
                    string filmName,
                    long photoId,
                    long filmYear,
                    string director,
                    string genre,
                    decimal rating,
                    string description)
        {
            FilmId = filmId;
            FilmName = filmName;
            PhotoId = photoId;
            FilmYear = filmYear;
            Director = director;
            Genre = genre;
            Rating = rating;
            Description = description;
        }
    }
}
