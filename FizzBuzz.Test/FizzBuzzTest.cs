using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using NUnit.Framework;

namespace FizzBuzz.Test
{
    [TestFixture()]
    class FizzBuzzTest
    {
        FizzBuzz fb = new FizzBuzz(1,15);
        [Test()]
        public void TestDivisibilityByThree()
        {
            Assert.AreEqual("Fizz",fb.DivisibilityByThree(6));
        }
        [Test()]
        public void TestNonDivisibilityByThree()
        {
            Assert.AreEqual("NotFizz", fb.DivisibilityByThree(7));
        }
        [Test()]
        public void TestDivisibilityByThreeNegativeNumber()
        {
            Assert.AreEqual("Fizz", fb.DivisibilityByThree(-6));
        }
        [Test()]
        public void TestNonDivisibilityByThreeNegativeNumber()
        {
            Assert.AreEqual("NotFizz", fb.DivisibilityByThree(-5));
        }
        [Test()]
        public void TestDivisibilityByFive()
        {
            Assert.AreEqual("Buzz", fb.DivisibilityByFive(10));
        }
        [Test()]
        public void TestNonDivisibilityByFive()
        {
            Assert.AreEqual("NotBuzz", fb.DivisibilityByFive(8));
        }
        [Test()]
        public void TestDivisibilityByFiveNegativeNumber()
        {
            Assert.AreEqual("Buzz", fb.DivisibilityByFive(-10));
        }
        [Test()]
        public void TestNonDivisibilityByFiveNegativeNumber()
        {
            Assert.AreEqual("NotBuzz", fb.DivisibilityByFive(-9));
        }
        [Test()]
        public void TestDivisibilityByThreeAndFive()
        {
            Assert.AreEqual("FizzBuzz", fb.DivisibilityByThreeAndFive(15));
        }
        [Test()]
        public void TestNonDivisibilityByThreeAndFive()
        {
            Assert.AreEqual("NotFizzBuzz", fb.DivisibilityByThreeAndFive(16));
        }
        [Test()]
        public void TestDivisibilityByThreeAndFiveNegativeNumber()
        {
            Assert.AreEqual("FizzBuzz", fb.DivisibilityByThreeAndFive(-15));
        }
        [Test()]
        public void TestNonDivisibilityByThreeAndFiveNegativeNumber()
        {
            Assert.AreEqual("NotFizzBuzz", fb.DivisibilityByThreeAndFive(-14));
        }
    }
}
