using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using static AbstractFactoryVehicle.Program;

namespace UnitTestVehicle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TESTregularBike()
        {
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();
            IBike regularBike = regularVehicleFactory.CreateBike();
            var writer = new StringWriter();
            Console.SetOut(writer);
            regularBike.GetDetails();
            var actualOutput = writer.ToString().Trim();
            var expected = "Fetching RegularBike Details..";
            Assert.AreEqual(expected, actualOutput);
        }
        [TestMethod]
        public void TESTregularCarr()
        {
            IVehicleFactory regularVehicleFactory = new RegularVehicleFactory();
            ICar regularCar = regularVehicleFactory.CreateCar();            
            var writer = new StringWriter();
            Console.SetOut(writer);
            regularCar.GetDetails();
            var actualOutput = writer.ToString().Trim();
            var expected = "Fetching RegularCar Details..";
            Assert.AreEqual(expected, actualOutput);
        }


        [TestMethod]
        public void TESTSportsBike()
        {
            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
            IBike sportsBike = sportsVehicleFactory.CreateBike();
            var writer = new StringWriter();
            Console.SetOut(writer);
            sportsBike.GetDetails();
            var actualOutput = writer.ToString().Trim();
            var expected = "Fetching SportsBike Details..";
            Assert.AreEqual(expected, actualOutput);
        }


        [TestMethod]
        public void TESTSportsCar()
        {
            IVehicleFactory sportsVehicleFactory = new SportsVehicleFactory();
            ICar sportsCar = sportsVehicleFactory.CreateCar();
            var writer = new StringWriter();
            Console.SetOut(writer);
            sportsCar.GetDetails();
            var actualOutput = writer.ToString().Trim();
            var expected = "Fetching SportsCar Details..";
            Assert.AreEqual(expected, actualOutput);

        }
    }
}
