using FormFilm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFilm.DataAcces
{
    public class FilmDAO
    {
        public static List<Film> FindAll()
        {
            using (BDDContext context = new BDDContext())
            {
                return context.Films.ToList();
            }
        }
       
        public static void Insert(Film Movie)
        {
            using (BDDContext context = new BDDContext())
            {
                context.Films.Add(Movie);
                context.SaveChanges();
            }
        }

        public static Film FindBuyId(int Id)
        {
            using (BDDContext context = new BDDContext())
            {
                return context.Films.FirstOrDefault(a => a.FilmId == Id);
            }
        }
        
    }
}
