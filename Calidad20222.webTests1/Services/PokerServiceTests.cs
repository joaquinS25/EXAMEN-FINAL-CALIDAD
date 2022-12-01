using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calidad20222.web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calidad20222.web.Models;

namespace Calidad20222.web.Services.Tests
{
    [TestClass()]
    public class PokerServiceTests
    {
        [TestMethod()]
        public void GetJugadaTest01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 7,
                       Palo = "COCOS"
                    },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 7,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 6,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("POKER", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 4,
                       Palo = "COCOS"
                    },
                   new Carta()
                   {
                        Numero = 4,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 4,
                        Palo = "TREBOL"
                   },
                   new Carta()
                   {
                        Numero = 4,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 1,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("POKER", cartaList);
        }
        [TestMethod()]
        public void GetJugadaTest03()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                   new Carta()
                   {
                       Numero = 8,
                       Palo = "COCOS"
                    },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "CORAZON"
                   },
                   new Carta()
                   {
                        Numero = 5,
                        Palo = "COCOS"
                   },
                   new Carta()
                   {
                        Numero = 8,
                        Palo = "ESPADA"
                   },
                   new Carta()
                   {
                        Numero = 11,
                        Palo = "CORAZON"
                   },

            };
            Assert.AreNotEqual("TRIO", cartaList);
        }
        }
}