using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBase
{
    public class Genre
    {
        public long GenreId { get; set; }
        public string GenreName { get; set; }

        public Genre (long genreId, string genreName)
        {
            GenreId = genreId;
            GenreName = genreName;
        }
        public override string ToString()
        {
            return GenreName;
        }
    }
}
