using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFilm.Entities
{
    public class BDDContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        public DbSet<Actor> Actors { get; set; }
    }
}
