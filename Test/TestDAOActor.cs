using System;
using System.Collections.Generic;
using FormFilm.DataAcces;
using FormFilm.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TestDAOActor
    {
            [TestMethod]
            public void InsertActorTest()
            {
                Actor Actor = new Actor()
                {
                    Name = "Name"
                };

                Assert.AreEqual(0, Actor.ActorId);

                ActorDAO.Insert(Actor);
                Assert.AreNotEqual(0, Actor.ActorId);

            }

            [TestMethod]
            public void FindAllActorTest()
            {
                List<Actor> listActor = null;

                listActor = ActorDAO.FindAll();

                Assert.IsNotNull(listActor);
            }

            [TestMethod]
            public void FindBuyIdActorTest()
            {
                Actor Actor = ActorDAO.FindBuyId(1);

                Assert.AreEqual(1, Actor.ActorId);

                Actor Actor2 = ActorDAO.FindBuyId(9999999);

                Assert.IsNull(Actor2);

            }
    }
}
