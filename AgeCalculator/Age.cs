using System;

namespace AgeCalculator
{
    public class Age
    {
        public static int CalculateAge(DateTime dob, DateTime currentDate)

        {
            var age = 0;

            var dobYear = dob.Year;
            var dobMonth = dob.Month;
            var dobDay = dob.Day;

            var currentDateYear = currentDate.Year;
            var currentDateMonth = currentDate.Month;
            var currentDateDay = currentDate.Day;

            for (int i = dobYear; i < currentDateYear; i++)
            {
                if (dobYear < currentDateYear)
                {
                    age++;
                }
            }

            if (dobMonth < currentDateMonth)
            {
                age = age - 1;
            }

            if (dobMonth == currentDateMonth)
            {
                if (dobDay < currentDateDay)
                {
                    age = age - 1;
                }
            }

            return age;
        }
    }
}
