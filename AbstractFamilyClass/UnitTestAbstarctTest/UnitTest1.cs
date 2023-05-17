using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AbstractFactoryPattren;
using static AbstractFactoryPattren.Program;

namespace UnitTestAbstarctTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCOW()
        {
            AnimalFactory factory = new AnimalFactory();
            Animal cow = factory.CreateAnimal("cow");
            string actual = cow.Speak().ToString();
            string expected = "moo!";
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDOG()
        {
            AnimalFactory factory = new AnimalFactory();
            Animal dog = factory.CreateAnimal("dog");
            string actual=dog.Speak().ToString();
            string expected = "barking!";
            Assert.AreEqual(expected, actual);  
        }
        [TestMethod]
        public void TestCAT()
        {
            AnimalFactory factory = new AnimalFactory();
            Animal cat = factory.CreateAnimal("cat");
            string actual = cat.Speak().ToString();
            string expected = "Meow!";
            Assert.AreEqual(expected, actual);
        }

    }
}
