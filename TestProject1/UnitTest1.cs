using Calculator_Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection.Emit;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TEST_Add_SUCCESS()
        {
            Calculator c = new Calculator();
            c.Add(2);
            Assert.AreEqual(4, c.Equals(2));
        }

        [TestMethod]
        public void TEST_Subtract_SUCCESS()
        {
            Calculator c = new Calculator();
            c.Subtract(4);
            Assert.AreEqual(2, c.Equals(2));
        }

        [TestMethod]
        public void TEST_Multiply_SUCCESS()
        {
            Calculator c = new Calculator();
            c.Multiply(2);
            Assert.AreEqual(8, c.Equals(4));
        }

        [TestMethod]
        public void TEST_Divide_SUCCESS()
        {
            Calculator c = new Calculator();
            c.Divide(20);
            Assert.AreEqual(10, c.Equals(2));
        }

        [TestMethod]
        public void TEST_Equals_SUCCESS()
        {
            Calculator c = new Calculator();
            Assert.AreEqual(0, c.Equals());
        }

        [TestMethod]
        public void TEST_Equals2_SUCCESS()
        {
            Calculator c = new Calculator();
            c.Add(8);
            Assert.AreEqual(10, c.Equals(2));
        }

        [TestMethod]
        public void TEST_Clear_SUCCESS()
        {
            Calculator c = new Calculator();
            c.Op = Calculator.operator_enumeration.Add;
            c.Clear();
            Assert.AreEqual(Calculator.operator_enumeration.None, c.Op);
        }

        [TestMethod]
        public void TEST_Back_SUCCESS()
        {
            Calculator c = new Calculator();
            string returns = "222";
            Assert.AreEqual("22", c.Back(returns));
        }

        [TestMethod]
        public void TEST_Back_EMPTY()
        {
            Calculator c = new Calculator();
            string returns = "";
            Assert.AreEqual("", c.Back(returns));
        }

        [TestMethod]
        public void TEST_performOperation_SUCCESS()
        {
            Calculator c = new Calculator();
            c.Add(2);
            Assert.AreEqual(2, c.performOperation());
        }

        [TestMethod]
        public void TEST_currentValue_SUCCESS()
        {
            Calculator c = new Calculator();
            c.CurrentValue = 2;
            Assert.AreEqual(2, c.CurrentValue);
        }
    }
}