using System;
using AgeCalculator;
using NUnit.Framework;

namespace TestAgeCalculator
{
    [TestFixture]
    public class TestAge
    {

        [Test]
        public void CalculateAge_GivenItsTheDayIWasBorn_ShouldReturn0()
        {
            //Arrange

            var itsTheDayIWasBorn = new DateTime(1990, 09, 12);
            var dob = new DateTime(1990,09,12);

            //Act

            var age = GetAge(dob, itsTheDayIWasBorn);

            //Assert

            Assert.AreEqual(age, 0);

        }

        [Test]
        public void CalculateAge_GivenItsTheDayBeforeMyFirstBirthday_ShouldReturn0()
        {
            //Arrange

            var itsTheDayBeforeMyFirstBirthday = new DateTime(1991, 09, 11);
            var dob = new DateTime(1990, 09, 12);

            //Act

            var age = GetAge(dob, itsTheDayBeforeMyFirstBirthday);

            //Assert

            Assert.AreEqual(age, 0);

        }


        [Test]
        public void CalculateAge_GivenItsMyFirstBirthday_ShouldReturn1()
        {
            //Arrange

            var itsMyFirstBirthday = new DateTime(1991, 09, 12);
            var dob = new DateTime(1990, 09, 12);

            //Act

            var age = GetAge(dob, itsMyFirstBirthday);

            //Assert

            Assert.AreEqual(age, 1);
        }




        [Test]
        public void CalculateAge_GivenItsMyThirdBirthday_ShouldReturn3()
        {
            //Arrange

            var itsMyThirdBirthday = new DateTime(1993, 09, 12);
            var dob = new DateTime(1990, 09, 12);

            //Act

            var age = Age.CalculateAge(dob, itsMyThirdBirthday);

            //Assert

            Assert.AreEqual(age, 3);
        }

        [Test]
        public void CalculateAge_GivenItsTheDayBeforeMyThirdBirthday_ShouldReturn2()
        {
            //Arrange

            var itsTheDayBeforeMyThirdBirthday = new DateTime(1993, 09, 11);
            var dob = new DateTime(1990, 09, 12);

            //Act

            var age = GetAge(dob, itsTheDayBeforeMyThirdBirthday);

            //Assert

            Assert.AreEqual(age, 2);
        }

        [Test]
        public void CalculateAge_GivenItsTheMonthBeforeMyThirdBirthday_ShouldReturn2()
        {
            //Arrange

            var itsTheMonthBeforeMyThirdBirthday = new DateTime(1993, 08, 12);
            var dob = new DateTime(1990, 09, 12);

            //Act

            var age = GetAge(dob, itsTheMonthBeforeMyThirdBirthday);

            //Assert

            Assert.AreEqual(age, 2);

        }

        [Test]
        public void CalculateAge_GivenItsTheDayAfterMyThirdBirthday_ShouldReturn3()
        {
            //Arrange

            var itsTheDayAfterMyThirdBirthday = new DateTime(1993, 09, 13);
            var dob = new DateTime(1990, 09, 12);

            //Act

            var age = GetAge(dob, itsTheDayAfterMyThirdBirthday);

            //Assert

            Assert.AreEqual(age, 3);
        }

        [Test]
        public void CalculateAge_GivenItsTheMonthAfterMyThirdBirthday_ShouldReturn3()
        {
            //Arrange

            var itsTheDayAfterMyThirdBirthday = new DateTime(1993, 10, 13);
            var dob = new DateTime(1990, 09, 12);

            //Act

            var age = GetAge(dob, itsTheDayAfterMyThirdBirthday);

            //Assert

            Assert.AreEqual(age, 3);
        }

        [Test]
        public void CalculateAge_GivenItsTheDayAfterMonthBeforeMyThirdBirthday_ShouldReturn2()
        {
            //Arrange

            var itsTheDayAfterMyThirdBirthday = new DateTime(1993, 08, 11);
            var dob = new DateTime(1990, 09, 12);

            //Act

            var age = GetAge(dob, itsTheDayAfterMyThirdBirthday);

            //Assert

            Assert.AreEqual(age, 2);
        }

        //-----------------------------------Leap Year-------------------------------------------

        [Test]
        public void CalculateAge_GivenItsDayBeforeMyFirstBirthdayInNoneLeapYear_ShouldReturn0()
        {
            //Arrange

            var itsDayBeforeMyFirstBirthdayInNoneLeapYear = new DateTime(1993, 02, 28);
            var dob = new DateTime(1992, 02, 29);

            //Act

            var age = GetAge(dob, itsDayBeforeMyFirstBirthdayInNoneLeapYear);

            //Assert

            Assert.AreEqual(age, 0);
        }

        [Test]
        public void CalculateAge_GivenItsMyFirstBirthdayInNoneLeapYear_ShouldReturn1()
        {
            //Arrange

            var itsMyFirstBirthdayInNoneLeapYear = new DateTime(1993, 03, 01);
            var dob = new DateTime(1992, 02, 29);

            //Act

            var age = GetAge(dob, itsMyFirstBirthdayInNoneLeapYear);

            //Assert

            Assert.AreEqual(age, 1);
        }

        [Test]
        public void CalculateAge_GivenItsMySecondBirthdayInNoneLeapYear_ShouldReturn2()
        {
            //Arrange

            var itsMySecondBirthdayInNoneLeapYear = new DateTime(1994, 03, 01);
            var dob = new DateTime(1992, 02, 29);

            //Act

            var age = GetAge(dob, itsMySecondBirthdayInNoneLeapYear);

            //Assert

            Assert.AreEqual(age, 2);
        }

        [Test]
        public void CalculateAge_GivenItsADayAfterMySecondBirthdayInNoneLeapYear_ShouldReturn2()
        {
            //Arrange

            var itsADayAfterMySecondBirthdayInNoneLeapYear = new DateTime(1994, 03, 02);
            var dob = new DateTime(1992, 02, 29);

            //Act

            var age = GetAge(dob, itsADayAfterMySecondBirthdayInNoneLeapYear);

            //Assert

            Assert.AreEqual(age, 2);
        }

        [Test]
        public void CalculateAge_GivenItsOneMonthBeforeMyThirdBirthdayInNoneLeapYear_ShouldReturn2()
        {
            //Arrange

            var itsOneMonthBeforeMyThirdBirthdayInNoneLeapYear = new DateTime(1995, 01, 26);
            var dob = new DateTime(1992, 02, 29);

            //Act

            var age = GetAge(dob, itsOneMonthBeforeMyThirdBirthdayInNoneLeapYear);

            //Assert

            Assert.AreEqual(age, 2);
        }

        [Test]
        public void CalculateAge_GivenItsMyThirdBirthdayInNoneLeapYear_ShouldReturn3()
        {
            //Arrange

            var itsMyThirdBirthdayInNoneLeapYear = new DateTime(1995, 03, 02);
            var dob = new DateTime(1992, 02, 29);

            //Act

            var age = GetAge(dob, itsMyThirdBirthdayInNoneLeapYear);

            //Assert

            Assert.AreEqual(age, 3);
        }

        [Test]
        public void CalculateAge_GivenItsOneMonthAfterMyThirdBirthdayInNoneLeapYear_ShouldReturn3()
        {
            //Arrange

            var itsOneMonthAfterMyThirdBirthdayInNoneLeapYear = new DateTime(1995, 04, 21);
            var dob = new DateTime(1992, 02, 29);

            //Act

            var age = GetAge(dob, itsOneMonthAfterMyThirdBirthdayInNoneLeapYear);

            //Assert

            Assert.AreEqual(age, 3);
        }

        [Test]
        public void CalculateAge_GivenItsMyFourthBirthdayInLeapYear_ShouldReturn4()
        {
            //Arrange

            var itsMyFourthBirthdayInLeapYear = new DateTime(1996, 03, 01);
            var dob = new DateTime(1992, 02, 29);

            //Act

            var age = GetAge(dob, itsMyFourthBirthdayInLeapYear);

            //Assert

            Assert.AreEqual(age, 4);
        }


        private static int GetAge(DateTime dob, DateTime currentDateTime)
        {
            var age = Age.CalculateAge(dob, currentDateTime);
            return age;
        }
    }
}
