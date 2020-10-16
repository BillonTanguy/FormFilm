using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFilm.Entities
{
    public class Actor : Personne
    {
        public int ActorId { get; set; }
        public List<Film> Films { get; set; }
    }
}
