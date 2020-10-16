using FormFilm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormFilm.DataAcces
{
    public class ActorDAO
    {
        public static List<Actor> FindAll()
        {
            using (BDDContext context = new BDDContext())
            {
                return context.Actors.ToList();
            }
        }

        public static void Insert(Actor actor)
        {
            using (BDDContext context = new BDDContext())
            {
                context.Actors.Add(actor);
                context.SaveChanges();
            }
        }

        public static Actor FindById(int Id)
        {
            using (BDDContext context = new BDDContext())
            {
                return context.Actors.FirstOrDefault(a => a.ActorId == Id);
            }
        }

        public static Actor FindBuyId(int Id)
        {
            using (BDDContext context = new BDDContext())
            {
                return context.Actors.FirstOrDefault(a => a.ActorId == Id);
            }
        }
    }
}
