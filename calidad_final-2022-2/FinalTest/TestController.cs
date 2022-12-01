using Calidad20222.web.Models;
using Calidad20222.web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest

{
    public class TestController { 
    
         PokerService pokerService;
    
         [Test]
         public void CartaMayorTest()
         {
            List<Carta> list= new List<Carta>()
            {
            new Carta { Numero = 5, Palo = "ESPADA"},
            new Carta { Numero = 6, Palo = "COCO"},
            new Carta { Numero = 2, Palo = "TREBOL"},
            new Carta { Numero = 9 , Palo = "COCO"},
            new Carta { Numero = 1, Palo = "ESPADA"}
            };
            
            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("CARTA MAYOR", resultado);  
         }
           
        [Test]
        public void CartaDobleTest()
        {
                List<Carta> list = new List<Carta>()
                {
                new Carta { Numero = 11, Palo = "ESPADA"},
                new Carta { Numero = 7, Palo = "COCO"},
                new Carta { Numero = 11, Palo = "TREBOL"},
                new Carta { Numero = 9 , Palo = "TREBOL"},
                new Carta { Numero = 2, Palo = "COCO"}
                };

                pokerService = new PokerService();
                var resultado = pokerService.GetJugada(list);
                Assert.AreEqual("DOBLE", resultado);
        }

        [Test]
        public void CartaDparejaTest()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 11, Palo = "ESPADA"},
            new Carta { Numero = 6, Palo = "COCO"},
            new Carta { Numero = 11, Palo = "TREBOL"},
            new Carta { Numero = 9 , Palo = "COCO"},
            new Carta { Numero = 9, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("DOBLE PAREJA", resultado);
        }

        [Test]
        public void CartaTrioTest()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 7, Palo = "ESPADA"},
            new Carta { Numero = 7, Palo = "COCO"},
            new Carta { Numero = 7, Palo = "TREBOL"},
            new Carta { Numero = 9 , Palo = "COCO"},
            new Carta { Numero = 1, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("TRIO", resultado);
        }
        [Test]
        public void CartaEscaleraTest()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 6, Palo = "ESPADA"},
            new Carta { Numero = 7, Palo = "COCO"},
            new Carta { Numero = 4, Palo = "TREBOL"},
            new Carta { Numero = 5 , Palo = "COCO"},
            new Carta { Numero = 3, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("ESCALERA", resultado);
        }

        [Test]
        public void CartaColorTest()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 5, Palo = "ESPADA"},
            new Carta { Numero = 6, Palo = "ESPADA"},
            new Carta { Numero = 2, Palo = "ESPADA"},
            new Carta { Numero = 9, Palo = "ESPADA"},
            new Carta { Numero = 1, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("COLOR", resultado);
        }
        
        [Test]
        public void CartaFullTest()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 4, Palo = "ESPADA"},
            new Carta { Numero = 4, Palo = "COCO"},
            new Carta { Numero = 4, Palo = "CORAZON"},
            new Carta { Numero = 8 , Palo = "COCO"},
            new Carta { Numero = 8, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("FULL", resultado);
        }
        
        [Test]
        public void CartaPockerTest()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 4, Palo = "ESPADA"},
            new Carta { Numero = 4, Palo = "COCO"},
            new Carta { Numero = 4, Palo = "TREBOL"},
            new Carta { Numero = 4 , Palo = "CORAZON"},
            new Carta { Numero = 1, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("POKER", resultado);
        }
        
        [Test]
        public void CartaEscaleraRealTest()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 1, Palo = "ESPADA"},
            new Carta { Numero = 13, Palo = "ESPADA"},
            new Carta { Numero = 12, Palo = "ESPADA"},
            new Carta { Numero = 11 , Palo = "ESPADA"},
            new Carta { Numero = 10, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("ESCALERA REAL", resultado);
        }
       
        [Test]
        public void CartaEscaleraColorRealTest()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 6, Palo = "COCO"},
            new Carta { Numero = 5, Palo = "COCO"},
            new Carta { Numero = 4, Palo = "COCO"},
            new Carta { Numero = 3 , Palo = "COCO"},
            new Carta { Numero = 2, Palo = "COCO"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("ESCALERA COLOR", resultado);
        }
        [Test]
        public void CartaMayorTest02()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 5, Palo = "ESPADA"},
            new Carta { Numero = 1, Palo = "COCO"},
            new Carta { Numero = 2, Palo = "TREBOL"},
            new Carta { Numero = 4 , Palo = "COCO"},
            new Carta { Numero = 13, Palo = "CORAZON"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("CARTA MAYOR", resultado);
        }

        [Test]
        public void CartaDobleTest02()
        {
            List<Carta> list = new List<Carta>()
                {
                new Carta { Numero = 1, Palo = "ESPADA"},
                new Carta { Numero = 3, Palo = "COCO"},
                new Carta { Numero = 6, Palo = "TREBOL"},
                new Carta { Numero = 4 , Palo = "TREBOL"},
                new Carta { Numero = 1, Palo = "COCO"}
                };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("DOBLE", resultado);
        }
        [Test]
        public void CartaDparejaTest02()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 4, Palo = "ESPADA"},
            new Carta { Numero = 8, Palo = "COCO"},
            new Carta { Numero = 4, Palo = "TREBOL"},
            new Carta { Numero = 2 , Palo = "COCO"},
            new Carta { Numero = 2, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("DOBLE PAREJA", resultado);
        }
        [Test]
        public void CartaTrioTest02()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 11, Palo = "ESPADA"},
            new Carta { Numero = 3, Palo = "COCO"},
            new Carta { Numero = 7, Palo = "TREBOL"},
            new Carta { Numero = 3, Palo = "COCO"},
            new Carta { Numero = 3, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("TRIO", resultado);
        }
        [Test]
        public void CartaEscaleraTest02()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 8, Palo = "ESPADA"},
            new Carta { Numero = 7, Palo = "COCO"},
            new Carta { Numero = 6, Palo = "TREBOL"},
            new Carta { Numero = 4, Palo = "COCO"},
            new Carta { Numero = 5, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("ESCALERA", resultado);
        }
        [Test]
        public void CartaColorTest02()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 5, Palo = "TREBOL"},
            new Carta { Numero = 6, Palo = "TREBOL"},
            new Carta { Numero = 2, Palo = "TREBOL"},
            new Carta { Numero = 9, Palo = "TREBOL"},
            new Carta { Numero = 1, Palo = "TREBOL"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("COLOR", resultado);
        }

        [Test]
        public void CartaFullTest02()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 3, Palo = "ESPADA"},
            new Carta { Numero = 3, Palo = "COCO"},
            new Carta { Numero = 3, Palo = "CORAZON"},
            new Carta { Numero = 5 , Palo = "CORAZON"},
            new Carta { Numero = 5, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("FULL", resultado);
        }

        [Test]
        public void CartaPockerTest02()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 5, Palo = "ESPADA"},
            new Carta { Numero = 5, Palo = "COCO"},
            new Carta { Numero = 5, Palo = "TREBOL"},
            new Carta { Numero = 11 , Palo = "CORAZON"},
            new Carta { Numero = 5, Palo = "ESPADA"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("POKER", resultado);
        }

        [Test]
        public void CartaEscaleraRealTest02()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 1, Palo = "CORAZON"},
            new Carta { Numero = 13, Palo = "CORAZON"},
            new Carta { Numero = 12, Palo = "CORAZON"},
            new Carta { Numero = 11 , Palo = "CORAZON"},
            new Carta { Numero = 10, Palo = "CORAZON"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("ESCALERA REAL", resultado);
        }

        [Test]
        public void CartaEscaleraColorRealTest02()
        {
            List<Carta> list = new List<Carta>()
            {
            new Carta { Numero = 6, Palo = "TREBOL"},
            new Carta { Numero = 5, Palo = "TREBOL"},
            new Carta { Numero = 4, Palo = "TREBOL"},
            new Carta { Numero = 3 , Palo = "TREBOL"},
            new Carta { Numero = 2, Palo = "TREBOL"}
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(list);
            Assert.AreEqual("ESCALERA COLOR", resultado);
        }
    }
}
