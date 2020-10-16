using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFilm.Entities
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public string Year { get; set; }
        public string Studio { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
