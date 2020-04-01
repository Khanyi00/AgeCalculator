using System;
using AgeCalculator;
using NUnit.Framework;

namespace TestAgeCalculator
{
    [TestFixture]
    public class TestAge
    {

        [TestCase(29, "1990-02-01")]
        [TestCase(29, "1990-03-09")]
        [TestCase(30, "1990-04-01")]
        [TestCase(30, "1990-10-26")]

        [TestCase(28, "1991-02-12")]
        [TestCase(28, "1991-03-08")]
        [TestCase(29, "1991-04-01")]
        [TestCase(29, "1991-11-11")]

        [TestCase(33, "1986-01-03")]
        [TestCase(33, "1986-02-03")]
        [TestCase(34, "1986-04-01")]
        [TestCase(34, "1986-12-03")]


        public void CountAge(int age, DateTime dob)
        {
            var currentDate = DateTime.Now;

            Assert.AreEqual(age, Age.CalculateAge(dob, currentDate));
        }
    }
}
