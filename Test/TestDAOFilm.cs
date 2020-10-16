using System;
using System.Collections.Generic;
using System.Linq;
using FormFilm.DataAcces;
using FormFilm.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TestDAOFilm
    {
        [TestMethod]
        public void InsertFilmTest()
        {
            Film film = new Film()
            {
                Title = "Titre"
            };

            Assert.AreEqual(0, film.FilmId);

            FilmDAO.Insert(film);
            Assert.AreNotEqual(0, film.FilmId);
            
        }

        [TestMethod]
        public void FindAllFilmTest()
        {
            List<Film> listFilm = null;

            listFilm = FilmDAO.FindAll();

            Assert.IsNotNull(listFilm);
        }

        [TestMethod]
        public void FindBuyIdFilmTest()
        {
            Film film = FilmDAO.FindBuyId(1);

            Assert.AreEqual(1, film.FilmId);

            Film film2 = FilmDAO.FindBuyId(9999999);

            Assert.IsNull(film2);
                
        }
    }
}
