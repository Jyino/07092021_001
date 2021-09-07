using Microsoft.VisualStudio.TestTools.UnitTesting;
using _07092021_001.Modeles;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07092021_001.Modeles.Tests
{
    [TestClass()]
    public class StationTests
    {
        [TestMethod()]
        public void getIdTest()
        {
            //Jeu d'essai
            Station S1 = new Station(1, "emplacement");
            //methode
            int resultat = S1.getId();
            //Assert
            Assert.AreEqual(1, resultat);
        }

        [TestMethod()]
        public void getLibelleEmplacementTest()
        {
            //Jeu d'essai
            Station S1 = new Station(1, "emplacement");
            //methode
            string resultat = S1.getLibelleEmplacementTest();
            //Assert
            Assert.AreEqual("emplacement", 1);
        }
    }
}