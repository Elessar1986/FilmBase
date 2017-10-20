using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBase
{
    public class Director
    {
        public long DirectorId { get; set; }
        public string DirectorName { get; set; }

        public Director(long directorId, string directorName)
        {
            DirectorId = directorId;
            DirectorName = directorName;
        }

        public override string ToString()
        {
            return DirectorName;
        }
    }
}
