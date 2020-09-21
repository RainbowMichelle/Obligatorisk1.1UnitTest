using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorisk1._1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk1._1.Tests
{
    [TestClass()]
    public class BikeTests
    {

        private Bike bikeOne;
        private Bike bikeTwo;
        private Bike bikeThree;
        private Bike bikeFour;
        private Bike bikeFive;

        [TestInitialize]

        public void Initialize()
        {
            bikeOne = new Bike(1, "red", 50, 20);
            bikeTwo = new Bike(2, "blue", 70, 30);
            bikeThree = new Bike(3, "Baby-pink", 150, 3);
            bikeFour = new Bike(4, "Hot-pink", 200, 10);
            bikeFive = new Bike(5, "Rainbow", 1000, 32);
        }

        [TestMethod()]
        public void ColorTest()
        {
            Assert.AreEqual("red", bikeOne.Color);
            Assert.AreEqual("Hot-pink", bikeFour.Color);
            bikeTwo.Color = "Y";
            Assert.AreEqual("Y", bikeTwo.Color);
            Assert.ThrowsException<Exception>(() => bikeTwo.Color = "");
            bikeTwo.Color = "A Very Vey Very Very Very Looooooooooooooooooong Color Name";
            Assert.AreEqual("A Very Vey Very Very Very Looooooooooooooooooong Color Name", bikeTwo.Color);
        }

        [TestMethod()]
        public void PriceTest()
        {
            Assert.AreEqual(1000, bikeFive.Price);
            bikeFive.Price = 500000000;
            Assert.AreEqual(500000000, bikeFive.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => bikeFive.Price = -5000);
        }

        [TestMethod()]
        public void GearTest()
        {
            Assert.AreEqual(20, bikeOne.Gear);
            bikeFive.Gear = 32;
            Assert.AreEqual(32, bikeFive.Gear);
            bikeFive.Gear = 3;
            Assert.AreEqual(3, bikeFive.Gear);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => bikeThree.Gear = 2);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => bikeThree.Gear = 33);
        }
    }
}