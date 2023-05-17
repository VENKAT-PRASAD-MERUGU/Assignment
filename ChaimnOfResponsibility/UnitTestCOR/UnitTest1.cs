using ChaimnOfResponsibility.Concreteimplementer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace UnitTestCOR
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TESTceo()
        {
            Ceo ceo = new Ceo();
            var item = "lappy";
            var money = 50000;
            var expectedOutput = "Approved by Ceo for Expense of " + item + "with cost :" + money.ToString();
            var writer = new StringWriter();
            Console.SetOut(writer);
            ceo.CanApproveExpenseManger(item, money);
            var actualOutput = writer.ToString().Trim();
            Assert.AreEqual(expectedOutput, actualOutput);              
            
        }
        [TestMethod]
        public void TESTvp()
        {
            VicePresident vp = new VicePresident();
            var item = "stationary";
            var money = 11000;
            var expectedOutput = "Approved by Vice President for Expense of " + item + "with cost :" + money.ToString();
            var writer = new StringWriter();
            Console.SetOut(writer);
            vp.CanApproveExpenseManger(item, money);
            var actualOutput = writer.ToString().Trim();
            Assert.AreEqual(expectedOutput, actualOutput);

        }
        [TestMethod]
        public void TESTseniorManager()
        {
            SeniorManager sm = new SeniorManager();
            var item = "Registar Book";
            var money = 50;
            var expectedOutput = "Approved by Senior Manager for Expense of " + item + " with cost :" + money.ToString();
            var writer = new StringWriter();
            Console.SetOut(writer);
            sm.CanApproveExpenseManger(item, money);
            var actualOutput = writer.ToString().Trim();
            Assert.AreEqual(expectedOutput, actualOutput);

        }
        
    }
}
