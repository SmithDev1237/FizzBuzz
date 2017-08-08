using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
    [TestClass]
    public class UnitTest_FizzBuzz
    {
        [TestMethod]
        public void Can_Find_Fizz()
        {
            Assert.AreEqual("Fizz", FizzBuzz.Solve(3));
        }

        [TestMethod]
        public void Can_Find_Buzz()
        {
            Assert.AreEqual("Buzz", FizzBuzz.Solve(5));
        }

        [TestMethod]
        public void Can_Find_FizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.Solve(15));
        }

        [TestMethod]
        public void Outputs_Number_If_Not_Fizz_Or_Buzz()
        {
            Assert.AreEqual("1", FizzBuzz.Solve(1));
        }

        [TestMethod]
        public void Can_Handle_Zero_As_Input()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.Solve(0));
        }

        [TestMethod]
        public void Can_Solve_1_To_100()
        {
            var data = FizzBuzz.SolveForRange(1, 100);
            Assert.AreEqual(100, data.Count);
            Assert.AreEqual("Fizz", data[3 - 1]);
            Assert.AreEqual("Buzz", data[5 - 1]);
            Assert.AreEqual("FizzBuzz", data[15 - 1]);
            Assert.AreEqual("1", data[1 - 1]);            
        }
    }
}
